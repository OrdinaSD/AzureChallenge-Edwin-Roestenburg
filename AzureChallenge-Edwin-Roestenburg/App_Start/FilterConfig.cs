using System.Web;
using System.Web.Mvc;

namespace AzureChallenge_Edwin_Roestenburg
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
