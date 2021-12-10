namespace WebApplication1
{
    public class HolidayJudge
    {
        public bool IsCelebrateDay()
        {
            if (GetToday() == DateTime.Parse("2021/11/11"))
            {
                return true;
            }

            return false;
        }

        public virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}
