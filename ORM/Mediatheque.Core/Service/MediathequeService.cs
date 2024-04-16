using Mediatheque.Core.DAL;
using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;
        private ApplicationDbContext _db;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }
        public MediathequeService(INotationService notationService, ApplicationDbContext applicationDbContext)
        {
            _notationService = notationService;
            _db = applicationDbContext;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }
        
        public List<string> PresentationCD()
        {
            List<string> listeCD = new List<string>();

            if (_fondDeCommerce.Count == 0)
            {
                listeCD.Add("Pas de CD");
                return listeCD;
            }

            foreach (CD objet in _fondDeCommerce)
            {
                string description = $"{objet.TitreDeLObjet} par {objet.Groupe}, noté {objet.Note}";
                listeCD.Add(description);
            }

            return listeCD;
        }

        public List<CD> GetCDs()
        {
            return this._db.CDs.ToList();
        }

        public CD AddCd(CD cd)
        {
            this._db.CDs.Add(cd);
            this._db.SaveChanges();
            return cd;
        }

        public CD GetCdById(int cdId)
        {
            return this._db.CDs.Find(cdId);
        }

        public List<CD> GetCdsByGroupe(string groupe)
        {
            return this._db.CDs.Where(cd => cd.Groupe == groupe).ToList();
        }

        public void DeleteCd(int cdId)
        {
            var cd = this._db.CDs.Find(cdId);
            this._db.CDs.Remove(cd);
            this._db.SaveChanges();
        }

        public void EditCd(int cdId, string albumModified)
        {
            var cd = this._db.CDs.Find(cdId);
            cd.TitreDeLObjet = albumModified;
            this._db.SaveChanges();
        }
    }
}
