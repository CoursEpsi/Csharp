﻿public class Worker
{
    private List<string> _chaines { get; set; }

    public Worker()
    {
        _chaines = new List<string>();
        for(int i = 1; i <= 10; i++)
        {
            this._chaines.Add($"element n°{i} de la liste");
        }
    }

    public string GetElement(int index)
    {
//        if (index > 9)
//        {
//            throw new Exception.GrosDoigtsException("L'index doit être inférieur à 9!");
//        }
        return _chaines[index];
    }
}
