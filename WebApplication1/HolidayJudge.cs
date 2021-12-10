namespace WebApplication1
{
    public class HolidayJudge
    {
        public bool IsCelebrateDay()
        {
            if (DateTime.Today == DateTime.Parse("2021/11/11"))
            {
                return true;
            }

            return false;
        }
    }
}
