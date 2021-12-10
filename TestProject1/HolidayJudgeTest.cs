using System;
using NUnit.Framework;
using WebApplication1;

namespace TestProject1
{
    public class HolidayJudgeTest
    {
        [TestCase("2021/11/11")]
        public void IsCelebrateDay_shouldReturnTrue(string value)
        {
            var holidayJudge = new FakeHolidayJudge()
            {
                Today = DateTime.Parse(value)
            };

            var isCelebrateDay = holidayJudge.IsCelebrateDay();

            Assert.AreEqual(true, isCelebrateDay);
        }
    }

    public class FakeHolidayJudge : HolidayJudge
    {
        public DateTime Today { get; set; }

        public override DateTime GetToday()
        {
            return Today;
        }
    }
}
