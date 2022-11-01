using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Context : SuperClass
    {
        public string TipoBancos { get; set; }
        public new void TesteInterface()
        {
            TipoBancos = "Couro";
            base.TesteInterface();
        }
    }

    public class SuperClass
    {
        public string CorCarro { get; set; }
        public void TesteInterface()
        {
            CorCarro = "Verde";
        }
    }
}
