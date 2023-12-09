using System.Collections.Generic;


namespace Lab04_2.Models
{
    internal interface ICustomerRepository
    {
        /*khai bao phuong thuc lay danh sach khach hang*/
        IList<Customer> GetCustomer();
        /*khai bao phuong thuc lay khach hang*/
        Customer GetCustomer(string customerId);
        /*khai bao phuong thuc them khach hang*/
        void AddCustomer(Customer cus);
        /*khai bao phuong thuc cap nhat khach hang*/
        void UpdateCustomer(Customer cus);
        /*khai bao phuong thuc tim kiem khach hang*/
        IList<Customer> SearchCustomer(string name);
        /*khai bao phuong thuc xoa khach hang*/
        void DeleteCustomer(string customerId);
    }
}
