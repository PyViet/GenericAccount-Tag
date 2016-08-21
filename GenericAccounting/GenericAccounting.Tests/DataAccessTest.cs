using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using BOL;

namespace GenericAccounting.Tests
{
    [TestClass]
    public class DataAccessTest
    {
        private UserAccess useraccess = new UserAccess();
        private user auser = new user();

        [TestMethod]
        public void TestUsers()
        {
            //test inserting user
            useraccess.deleteAll();         
            auser.username = "pyviet";
            auser.password = "extremelylongpassword";
            useraccess.insertUser(auser);

            //retrieving user using username
            Assert.AreEqual(auser.username, useraccess.getUser("pyviet").username);
            useraccess.deleteUser(auser);
            Assert.IsNull(useraccess.getUser("pyviet"));
        }
    }
}
