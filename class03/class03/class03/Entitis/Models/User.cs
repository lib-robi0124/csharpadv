namespace staticclasses.Entitis.Models
{
    public class User : BaseEntity
    {
        //public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> orders { get; set; } = new List<Order>();

        public User(int Id, string username, string address) : base(id)
        {
           
            Username = username;
            Address = address;
        }

        public void PrintOrders()
        {
            for (int i = 0; i < orders.Count; i++) 
            {
                Console.WriteLine($"{i+1}) {orders[i].GetOrderInfo()}");
        }

    }
}
