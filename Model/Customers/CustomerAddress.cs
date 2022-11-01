using Model.Common;
using Model.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model.Customers
{
    public class CustomerAddress : BaseModel
    {
        public int CustomerAddressId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string PostalCode { get; set; }
        public string AddressStreet { get; set; }
        public string Neighborhood { get; set; }
        public string AddressNumber { get; set; }
        public string AddressComplement { get; set; }
        public string Observation { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
      

    }
}
