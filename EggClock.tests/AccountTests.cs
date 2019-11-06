using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TheEggClock;
using System.Security.Authentication;
using Autofac.Extras.Moq;

namespace EggClock.tests
{
    public class AccountTests
    {

        [Theory]
        [InlineData(5401, 4999)]
        [InlineData(2000, 500)]
        [InlineData(7500, 5000)]
        [InlineData(uint.MaxValue, uint.MaxValue - 1)]
        void BalanceCheck_ValidAmount(double currentBalance, double wantedAmount)
        {
            Card card = new Card(1234, currentBalance);
            Account account = new Account();
            //currentBalance = Convert.ToDouble(card.Balance);

            //Arrange
            var expected = true;


            //Assert
            Assert.Equal(expected, account.BalanceCheck((Card)card, (double)wantedAmount));

        }
  

        [Theory]
        [InlineData(500, 2000)]

        void BalanceCheck_InsufficientFunds(double currentBalance, double wantedAmount)
        {
            //arrange
            Account account = new Account();
            Card card = new Card(1234, currentBalance);

            //System.FormatException

            //act
            var result = account.BalanceCheck(1);
            //assert
            //The below statement is not working as expected.
            Assert.Throws<System.FormatException>(wantedAmount, () => account.BalanceCheck(card, wantedAmount));


            AccountMessages accountMessages = new AccountMessages();
            //currentBalance = Convert.ToDouble(card.Balance);

            //Arrange
            //var expected = false;

            //Assert
            //Assert.Equal(expected, account.BalanceCheck((Card)card, (double)wantedAmount));
            var expected = false;
            Assert.Equal(expected, account.BalanceCheck((Card)card, (double)wantedAmount));

            //Exception exception = accountMessages.AccountInsuffiant;
            //Exception actual = Assert.Throws<Exception>(() => account.BalanceCheck((Card)card, (double)wantedAmount));
            //Assert.Equal(actual, expected);

        }
        //[Fact]
        //public void BalanceCheck_InsufficientFunds()
        //{
        //    double test = 3;
        //    //arrange
        //    ATM atm = new ATM();
        //    Account account = new Account();
        //    Card card = new Card(1234, 123);
        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        mock.Mock<Account>()
        //           .Setup(x => x.BalanceCheck((Card)card, (double)test));
        //        //var cls = mock.cre
        //        //var expected = atm.FrontScreen((Card)card);
        //    }
        //        //act
        //        //var actual = account.BalanceCheck((Card)card, 2000);
        //        //assert
        //        //The below statement is not working as expected.
        //        //Assert.Throws<ArgumentException>(() => result);
        //    //    var expected = false;
        //    //Assert.Equal(expected, account.BalanceCheck((Card)card, (double)3000));


        //    //AccountMessages accountMessages = new AccountMessages();
        //    //currentBalance = Convert.ToDouble(card.Balance);


        //}




    }
}
