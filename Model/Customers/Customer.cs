using Model.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Customers
{
    public class Customer : BaseModel
    {
        public int CustomerId { get; set; }        
        public string TradingName { get; set; }
        public string FantasyName { get; set; }
        public string CPFCNPJ { get; set; }
        public string StateRegistration { get; set; }
        public string MunicipalityRegistration { get; set; }
        public string CellPhone { get; set; }
        public string PhoneNumbers { get; set; }
        public List<CustomerAddress> CustomerAddress { get; set; }
    }
}
