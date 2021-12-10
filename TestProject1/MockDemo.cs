using FluentAssertions;
using Moq;
using NSubstitute;
using NUnit.Framework;

namespace TestProject1
{
    public class MockDemo
    {
        [Test]
        public void MoqDemo()
        {
            var creator = new Mock<INumberCreator>();

            creator.Setup(x => x.CreateInt()).Returns(6);

            var calculator = new NumberCalculator(creator.Object);

            Assert.AreEqual(12, calculator.MultiInt(2));

            // FluentAssertions
            calculator.MultiInt(2).Should().Be(12);
        }

        [Test]
        public void NSubDemo()
        {
            var creator = Substitute.For<INumberCreator>();

            creator.CreateInt().Returns(6);

            var calculator = new NumberCalculator(creator);

            Assert.AreEqual(12, calculator.MultiInt(2));

            // FluentAssertions
            calculator.MultiInt(2).Should().Be(12);
        }

        [Test]
        public void ArrayCountDemo()
        {
            var datas = new []
            {
                1,2, 3, 4
            };

            datas.Should().OnlyContain(x => x > 0);
            datas.Should().HaveCount(4, "應該要有4個數字");
            
            Assert.That(datas, Has.Length.EqualTo(4));
        }
    }

    public interface INumberCreator
    {
        int CreateInt();
    }

    public class NumberCalculator
    {
        private readonly INumberCreator _creator;

        public NumberCalculator(INumberCreator creator)
        {
            _creator = creator;
        }

        public int MultiInt(int multiple)
        {
            return _creator.CreateInt() * multiple;
        }
    }
}
