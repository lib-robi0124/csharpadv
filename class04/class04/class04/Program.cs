using class04.Entities;

using class04.Helpers;

NotGenericHelpers notGenericHelper = new NotGenericHelpers();

List<string> names = new List<string>() { "Martin", "Dare", "Slave", "Marija"};
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

notGenericHelper.GetInfoForStrings(names);
notGenericHelper.GoThroughStrings(names);

notGenericHelper.GetInfoForInts(numbers);
notGenericHelper.GoThroughInts(numbers);


Console.WriteLine("== generic helper ==");


GenericListHelper<string>.GetInfoForItems(names);
GenericListHelper<int>.GetInfoForItems(numbers);

GenericListHelper<int>.GoThroughItems(numbers);
GenericListHelper<string>.GoThroughItems(names);


List<Product> products = new List<Product>()
{
    new Product() {Id = 1, Name = "Prod 1", Description = "Prod desc 1"},
    new Product() {Id = 2, Name = "Prod 2", Description = "Prod desc 2"},
};

List<Order> orders = new List<Order>
{
    new Order() {Id = 1, Receiver = "Darko", Address = "Test address1"},
    new Order() {Id = 1, Receiver = "Ana", Address = "Test address2"},
    new Order() {Id = 1, Receiver = "Marija", Address = "Test address3"},


};

GenericDb<Product> productsDb = new GenericDb<Product>();
GenericDb<Order> ordersDb = new GenericDb<Order>();


productsDb.InsertRange(products);
ordersDb.InsertRange(orders);

productsDb.PrintAll();

GenericListHelper<Product>.GoThroughItems(products);
//GenericListHelper<Order>.GoThroughItems(orders);