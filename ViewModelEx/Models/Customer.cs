using System;
using System.Reflection.Metadata.Ecma335;

namespace ViewModelEx.Models
{
    public class Customer
    {
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }

        public Customer()
        {
            this.CustomerID = 121;
            this.CustomerName = "Sunil";
            this.Address = "Nigid Pune";
            this.EmailID = "sunil@gmail.com";
            this.MobileNo = "797979897";
        }
    }
}
