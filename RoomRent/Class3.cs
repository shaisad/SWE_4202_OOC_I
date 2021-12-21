using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRent
{
    public class DoubleRoom:Room
    {
        private bool dtv;
        private bool dcbreakfast;

        public void setdtv(bool dtv)
        {
            this.dtv = dtv;
        }

        public bool getdtv()
        {
            return this.dtv;
        }

        public void setdcbreakfast(bool dcbreakfast)
        {
            this.dcbreakfast = dcbreakfast;
        }

        public bool getdcbreakfast()
        {
            return this.dcbreakfast;
        }


        public int calculatecost()
        {
            if (this.getrac() == true && this.getdtv() == false && this.getdcbreakfast() == false)
            {
                return 3500 + 500;
            }
            else if (this.getrac() == true && this.getdtv() == true && this.getdcbreakfast() == false)
            {
                return 3500 + 500 + 1000;
            }
            else if (this.getrac() == true && this.getdtv() == true && this.getdcbreakfast() == true)
            {
                return 3500 + 1000 + 500 + 500;

            }
            else if (this.getrac() == false && this.getdtv() == true && this.getdcbreakfast() == false)
            {
                return 3500 + 1000;
            }
            else if (this.getrac() == false && this.getdtv() == true && this.getdcbreakfast() == true)
            {
                return 3500 + 1000 + 500;
            }
            else if (this.getrac() == false && this.getdtv() == false && this.getdcbreakfast() == false)
            {
                return 3500 + 500;
            }
            else if (this.getrac() == true && this.getdtv() == false && this.getdcbreakfast() == true)
            {
                return 3500 + 500 + 500;
            }
            else
            {
                return 3500;
            }
        }

    }
}
