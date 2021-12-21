using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRent
{
    public class SingleRoom:Room
    {
        private bool sgamingsetup;
       

        public void setsgamingsetup(bool sgamingsetup)
        {
            this.sgamingsetup = sgamingsetup;
        }

        public bool getsgamingsetup()
        {
            return this.sgamingsetup;
        }



        public int calculatecost()
        {
            if (this.getrac() == true && this.getsgamingsetup() == false)
            {
                return 2000 + 500;
            }
            else if (this.getrac() == false && this.getsgamingsetup() == true)
            {
                return 2000 + 1000;
            }
            else if (this.getrac() == true && this.getsgamingsetup() == true)
            {
                return 2000 + 1000 + 500;

            }
            else
            {
                return 2000;
            }
        }
    }
}
