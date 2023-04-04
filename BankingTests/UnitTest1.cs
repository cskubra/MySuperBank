using MySuperBank;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var account = new BankAccount("Kendra", 10000);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000, DateTime.Now, "Atempt to overdraw")

                );


        }
        [Fact]
        public void Test2()
        {

            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("Invalid", -55)

                );

        }
    }
}