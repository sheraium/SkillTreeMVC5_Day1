using System.Web;
using System.Web.Mvc;

namespace SkillTreeMVC5_Day1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
