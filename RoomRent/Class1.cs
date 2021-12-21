using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRent
{
    public class Room
    {
        private string rname;
        private bool rac;
        private bool rtv;
        private int rquantity;
        private int rbed; 

        public void setrname(string rname)
        {
            this.rname = rname;
        }

        public string getrname()
        {
            return this.rname;
        }

        public void setrac(bool rac)
        {
            this.rac = rac;
        }

        public bool getrac()
        {
            return this.rac;
        }

        public void setrtv(bool rtv)
        {
            this.rtv = rtv;
        }

        public bool getrtv()
        {
            return this.rtv;
        }

        public void setrquantity(int rquantity)
        {
            this.rquantity = rquantity;
        }

        public int getrquantity()
        {
            return this.rquantity;
        }
        public void setrbed(int rbed)
        {
            this.rbed = rbed;
        }
    }
}
