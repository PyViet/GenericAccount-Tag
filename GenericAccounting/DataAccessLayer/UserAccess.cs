using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DataAccessLayer
{
    public class UserAccess
    {
        private GenericAccountingDataEntities dataEntities;
        public UserAccess()
        {
            dataEntities = new GenericAccountingDataEntities();
        }

        public user getUser(string username)
        {
            return dataEntities.users.Find(username);
        }

        public void insertUser(user auser)
        {
            try
            {
                dataEntities.users.Add(auser);
                dataEntities.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void deleteUser(user auser)
        {
            user toremove = dataEntities.users.Find(auser.username);
            dataEntities.users.Remove(toremove);
            dataEntities.SaveChanges();
        }

        public void deleteAll()
        {
            dataEntities.users.RemoveRange(dataEntities.users);
            dataEntities.SaveChanges();
        }
    }
}
