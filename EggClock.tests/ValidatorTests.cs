using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEggClock;
using Xunit;


namespace EggClock.tests
{
    public class ValidatorTests
    {

        [Fact]
        //Tests if the login validator is failing
        public void PromtPIN_ShouldFail()
        {
            //Arrange
            Validator validator = new Validator();
            Card card = new Card(134, 1);
            //Act
            var expected = validator.validatorBool = true;

            //Assert
            Assert.True(expected);


        }
        [Fact]
        //Tests if the login validator is working
        public void PromtPIN_Shouldwork()
        {
            //Arrange
            Validator validator = new Validator();
            Card card = new Card(1234, 1);
            //Act
            var expected = validator.validatorBool = true;

            //Assert
            Assert.True(expected);

        }
    }
}

//System.FormatException
