using FluentAssertions;

namespace Test
{
    public class Test1
    {
        [Fact]
        public void Sum()
        {
            ClassLibrary1.Lib lib=new ClassLibrary1.Lib(65.11m);
            var sum = lib.Mult(100);
            sum.Should().Be(6511).And.BeOfType(typeof(decimal));
        }
        [Theory]
        [InlineData(100)]
        //[InlineData("abc")] //False
        public void Valid(object money)
        {
            ClassLibrary1.Lib lib = new ClassLibrary1.Lib(65.11m);
            var val = lib.Valid(money);
            val.Should().BeTrue();
        }
        [Theory]
        [InlineData(10,600,92,3000)]
        public void Diff (decimal money8, decimal moneyProc, decimal result, decimal result2)
        {

            ClassLibrary1.Lib lib = new ClassLibrary1.Lib(10m);
            var com1 = lib.Diff8(money8);
            com1.Should().NotBe(0);
            var com2 = lib.DiffProc(moneyProc,50);
            com2.Should().NotBe(0);

            com1.Should().Be(result);
            com2.Should().Be(result2);

        }
    }
}