using System;
using Xunit;
using bestilvasketidCore21API;
using BestilVasketidCoreAPI.Controllers;
using BestilVasketidCoreAPI.Models;
using System.Collections.Generic;

namespace BestilVasketidTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    }

    public class UnitTest2
    {
        UserController uc = new UserController();

        [Fact]
        public void Test2()
        {
            List<DTO_User> user = uc.Get();

            Assert.True(user != null);
        }

    }
}
