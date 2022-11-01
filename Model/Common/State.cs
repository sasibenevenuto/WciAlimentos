using Model.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class State : BaseModel
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public string FederativeUnit { get; set; }
        public string ExternalCode { get; set; }
    }
}
