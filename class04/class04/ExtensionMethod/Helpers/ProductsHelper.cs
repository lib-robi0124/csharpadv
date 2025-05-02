using ExtensionMethod.Entities;


namespace ExtensionMethod.Helpers
{
    public static class ProductsHelper
    {
        public static void PrintProductId(this Product product)
        {
            Console.WriteLine(product.Id);
        }
    }
}
