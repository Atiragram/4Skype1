using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;

namespace WindowsFormsApplication3
{
    public class User
    {
        private string UserName;
        private List<string> friends = new List<string>();
        private List<string> OnlineFriends = new List<string>();

        public User(Skype skype)
        {
            SetUser(skype.CurrentUserProfile.FullName);
        }

        private void SetUser(string name)
        {
            this.UserName = name;
        }

        public string GetUser()
        {
            return this.UserName;
        }

        public List<string> GetAllFriends(Skype skype)
        {
            if (skype.Friends.Count > 0)
            {
                for (int i = 1; i < skype.Friends.Count; i++)
                {
                    friends.Add(skype.Friends[i].Handle);
                }
            }
            return friends;
        }

        public List<string> GetOnlineFriends(Skype skype)
        {
            if (skype.Friends.Count > 0)
            {
                for (int i = 1; i < skype.Friends.Count; i++)
                {
                    if (skype.Friends[i].OnlineStatus != TOnlineStatus.olsOffline)
                    {
                        OnlineFriends.Add(skype.Friends[i].Handle);
                    }
                }
            }
            return OnlineFriends;
        }

    }
}
