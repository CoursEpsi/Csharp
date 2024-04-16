namespace Mediatheque.Core.Model
{

    public class CD : ObjetDePret
    {
        public string Groupe { get; set; }
        public int? Note { get; set; }

        public CD(string titreDeLObjet, string groupe) : base(titreDeLObjet)
        {
            this.Groupe = groupe;
        }

        public override string ToString()
        {
            return "CD: " + this.TitreDeLObjet + " par " + this.Groupe;
        }
    }
}
