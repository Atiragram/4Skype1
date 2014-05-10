using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;

namespace WindowsFormsApplication3
{
    class FriendInfo
    {
        private string FriendName;

        public FriendInfo()
        {
           // this.FriendName = friend;
        }

        public string GetFullName(string friend, Skype skype)
        {
            string FullName = skype.get_User(friend).FullName;
            return FullName;
        }

        public string GetBirthday(string friend, Skype skype)
        {
            string birhtday= skype.get_User(friend).Birthday.Date.ToString();
            return birhtday;
        }

        public string GetCountry(string friend, Skype skype)
        {
            string Country = skype.get_User(friend).Country;
            return Country;
        }

        public string GetCity (string friend, Skype skype)
        {
            string City = skype.get_User(friend).City;
            return City;
        }

         public string GetDispname (string friend, Skype skype)
        {
            string Disp_name = skype.get_User(friend).DisplayName;
            return Disp_name;
        }

        public string GetLastVisit (string friend, Skype skype)
        {
            string LastVisit = skype.get_User(friend).LastOnline.ToString();
            return LastVisit;
        }
        


        

    }
}
