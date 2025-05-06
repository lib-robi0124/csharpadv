using ExtensionMethod.Entities;

namespace ExtensionMethod.PiggybackingHelpers
{
    public static class PiggybackingProductHelpers
    {
        public static void PrintProductId(this Product product)
        {
            Console.WriteLine(product.Id);
        }
        
    }
}
