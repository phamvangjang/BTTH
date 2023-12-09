namespace Lab04_1.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }

        /*
        public Customer(string customerId, string name, string address, string phone, string email, int balance)
        {
            CustomerID = customerId;
            FullName = name;
            Address = address;
            Phone = phone;
            Email = email;
            Balance = balance;
        }

        public Customer()
        {
        }
        */
    }
}