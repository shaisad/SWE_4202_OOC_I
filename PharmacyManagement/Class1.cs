using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    public class Medicine
    {
        private string medname;
        private string medid;
        private int medquantity;
        private int medprice;
        
        public void setmedname(string setmedname)
        {
            this.medname = setmedname;
        }
        public string getmedname()
        { 
            return this.medname; 
        }
        public void setmedid(string setmedid)
        {
            this.medid = setmedid;
        }
        public string getmedid()
        {
            return this.medid;
        }
        public void setmedquantity(int setmedquantity)
        {
            this.medquantity = setmedquantity;
        }
        public int getmedquantity()
        {
            return this.medquantity;
        }
        public void setmedprice(int setmedprice)
        {
            this.medprice = setmedprice;
        }
        public int getmedprice()
        {
            return this.medprice;
        }

    }
}
