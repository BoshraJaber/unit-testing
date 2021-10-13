using System;
using Xunit;
using ATM;

namespace ATM_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnCorrectBalance()
        {
            Assert.Equal(0, Program.ViewBalance());
        }


        [Fact]
        public void ReturnCorrectDeposit()
        {
            ;
            Assert.Equal("Task completed successfully", Program.Deposit(1200));
        }

        [Fact]
        public void ReturnIncorrectDeposit()
        {


            Assert.Equal("Invalid Number, please enter a valid number", Program.Deposit(-10));
        }
        [Fact]
        public void ReturnInCorrectWithdrawForLargerThanBalance()
        {


            Assert.Equal($"{1200} is greater than what you have, your balance {Program.ViewBalance()}", Program.Withdraw(1200));
        }
        [Fact]
        public void ReturnIncorrectWithdraw()
        {


            Assert.Equal("Invalid Number, Please enter a number above 0", Program.Withdraw(-1200));
        }

        [Fact]
        public void ReturncorrectWithdraw()
        {

            Program.Deposit(1000);
            Assert.Equal("Task Completed Successfully", Program.Withdraw(200));
        }
    }
}

