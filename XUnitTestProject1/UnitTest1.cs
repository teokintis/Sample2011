using System;
using UnitTesting;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Account account = new Account(100);

            Assert.Equal(110, account.Deposit(10));

        }
    }
}
