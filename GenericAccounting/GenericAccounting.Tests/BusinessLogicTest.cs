using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using BOL;
using System.Web.Helpers;

namespace GenericAccounting.Tests
{
    [TestClass]
    public class BusinessLogicTest
    {
        [TestMethod]
        public void TestPassword()
        {
            SecurityLogic createUser = new SecurityLogic();
            user aUser = new user();
            aUser.username = "pyviet";
            aUser.password = "extremelylongpassword";
            createUser.addUser(aUser);
            Assert.IsNotNull(createUser.getUser("pyviet"));
            Assert.AreEqual(Crypto.SHA256(createUser.getUser("pyviet").salt + "extremelylongpassword"), createUser.getUser("pyviet").password);
        }

        [TestMethod]
        public void TestMembershipProvider()
        {
            SimpleMembershipProvider smp = new SimpleMembershipProvider();
            Assert.AreEqual(true, smp.ValidateUser("pyviet", "extremelylongpassword"));
            SecurityLogic deleteUser = new SecurityLogic();
            deleteUser.deleteUser("pyviet");
            Assert.IsNull(deleteUser.getUser("pyviet"));
        }
    }
}
