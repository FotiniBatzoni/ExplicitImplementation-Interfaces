using System;

namespace CatalogSaver
{
    public interface ISaveable
    {
        void Save();
    }

    public class Catalog : ISaveable
    {
        //when we use explicit implementation 
        //we are not allowed to put access modifiers on the members
        void ISaveable.Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
