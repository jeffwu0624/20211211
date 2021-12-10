namespace WebApplication1
{
    public class UserCreator
    {
        public string GetUserName(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                return Path.GetFileName(context.User.Identity.Name);
            }

            return "";
        }
    }
}
