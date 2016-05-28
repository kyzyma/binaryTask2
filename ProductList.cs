using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class ProductList : AbstractProdactList
    {
        public delegate void DelegEventUser( string m);

        // create events
        public event DelegEventUser UserAdded = null;
        public event DelegEventUser UserRemoved = null;

        public void OnUserAddedEvent( string message)
        {
            if (UserAdded != null)
                UserAdded(message);
        }

        public void OnUserRemovedEvent(string message)
        {
            if (UserRemoved != null)
                UserRemoved(message);
        }

       
        public List<User> userList = new List<User>();

        public override void AddUser(AbstractProdactLogger log)
        {
            User u = new User();    //create user

            u.InputUser();    // input user data

            userList.Add(u);

            UserAdded += log.Info;
            UserAdded += log.Debug;
            OnUserAddedEvent("Added user in list");
            UserAdded -= log.Debug;
            UserAdded -= log.Info;
        }

        public override void RemoveUser(int index, AbstractProdactLogger log)
        {
            userList.RemoveAt(index);  // remove user by index

            UserRemoved += log.Info;
            UserRemoved += log.Debug;
            OnUserRemovedEvent("Removed user with list");  //call event file
            UserRemoved -= log.Info;
            UserRemoved -= log.Debug;
        }

        
    }
}
