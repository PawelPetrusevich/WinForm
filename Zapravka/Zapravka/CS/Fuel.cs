using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapravka.CS
{
    class Fuel
    {
        #region Field
        string name;
        decimal price;
        #endregion
        #region property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

    }
}
