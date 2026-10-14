using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata.Ecma335;

namespace ViewModelEx.ViewModels
{
    public class ProdCustBookVM
    {
        public string ProductName { get; set; }
        public string   MfgName { get; set; }
        public decimal Price { get; set; }

        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public decimal BookPrice { get; set; }

        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
    }
}
