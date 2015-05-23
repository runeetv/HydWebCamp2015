using System.Web;
using System.Web.Mvc;

namespace GeekQuiz
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyActionFilterAttribute());
        }
    }

    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
            context.RequestContext.HttpContext.Response.Write("<h1>Hello From Hyd Web Camps !</h1>");
        }
    }
}
