namespace CatalogSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            //catalog.Save();   //compiler error

            ISaveable saveable = new Catalog();
            saveable.Save();

            ((ISaveable)catalog).Save();

            var varCatalog = new Catalog();
            // varCatalog.Save();   //compiler error


        }
    }
}
