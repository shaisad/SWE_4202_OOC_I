using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_Dependencies
{
    public class User
    {
        private string userid;
        private string username;
        private string useraddress;
        private string userdestination;
        private string rentedcarname;

        public void setuserid(string userid)
        { this.userid = userid; }
        public string getuserid()
        { return this.userid; }
        public void setusername(string username)
        { this.username = username; }
        public string getusername()
        { return this.username; }
        public void setuseraddress(string useraddress)
        { this.useraddress = useraddress; }
        public string getuseraddress()
        { return this.useraddress; }
        public void setuserdestination(string userdestination)
        { this.userdestination = userdestination; }
        public string getuserdestination()
        { return this.userdestination; }
        public void setrentedcarname(string rentedcarname)
        { this.rentedcarname = rentedcarname; }
        public string getrentedcarname()
        { return this.rentedcarname; }



    }
}
