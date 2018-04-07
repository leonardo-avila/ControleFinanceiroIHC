using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroIHC
{
    class Renda : Financa
    {      

        public Renda(string description, double value)
        {
            this.type = "Renda";
            this.description = description;
            this.value = value;
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2}", this.type, this.description, this.value);
        }
    }
}
