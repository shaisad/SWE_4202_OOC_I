using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_Dependencies
{
    public class Car
    {
        private string carname;
        private string carmodel;
        private int carquantity;

        public void setcarname(string carname)
        { this.carname = carname; }
        public string getcarname()
        { return this.carname; }
        public void setcarmodel(string carmodel)
        { this.carmodel = carmodel; }
        public string getcarmodel()
        { return this.carmodel; }
        public void setcarquantity(int carquantity)
        { this.carquantity = carquantity; }
        public int getcarquantity()
        { return this.carquantity; }

    }
}
