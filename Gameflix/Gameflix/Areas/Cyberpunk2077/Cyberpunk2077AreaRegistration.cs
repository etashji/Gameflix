using System.Web.Mvc;

namespace Gameflix.Areas.Cyberpunk2077
{
    public class Cyberpunk2077AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cyberpunk2077";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Cyberpunk2077_default",
                "Cyberpunk2077/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}