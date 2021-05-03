using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Payroll.Controllers.Base
{
    public class BaseController : Controller
    {
        /// <summary>
        /// this method helps to render a partial view into html string.
        /// </summary>
        /// <param name="viewEngine"></param>
        /// <param name="viewName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string RenderPartialViewToString(ICompositeViewEngine viewEngine, string viewName)
        {
            viewName = viewName ?? ControllerContext.ActionDescriptor.ActionName;
            using (StringWriter sw = new StringWriter())
            {
                IView view = viewEngine.FindView(ControllerContext, viewName, false).View;
                ViewContext viewContext = new ViewContext(ControllerContext, view, ViewData, TempData, sw, new HtmlHelperOptions());
                view.RenderAsync(viewContext).Wait();
                return sw.GetStringBuilder().ToString();
            }
        }
        /// <summary>
        /// This method helps to get the error information from the MVC "ModelState".
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetErrorsFromModelState()
        {
            var errors = new Dictionary<string, object>();
            foreach (var key in ModelState.Keys)
            {
                // Only send the errors to the client.
                if (ModelState[key].Errors.Count > 0)
                {
                    errors[key] = ModelState[key].Errors;
                }
            }
            return errors;
        }
    }
}
