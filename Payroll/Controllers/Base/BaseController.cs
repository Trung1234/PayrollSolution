using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Payroll.Controllers.Base
{
    /// <summary>
    /// Template Method Design Pattern
    /// to create superclass of other Controllers
    /// </summary>
    public abstract class BaseController : Controller
    {
        private readonly ICompositeViewEngine _viewEngine;

        protected BaseController(ICompositeViewEngine viewEngine)
        {
            _viewEngine = viewEngine;
        }

        /// <summary>
        /// abstracting Index behavior
        /// </summary>
        /// <returns></returns>
        public abstract IActionResult Index();

        /// <summary>
        /// abstracting Create behavior
        /// </summary>
        /// <returns></returns>
        public abstract IActionResult Create();

        /// <summary>
        /// Detail Create behavior
        /// </summary>
        /// <returns></returns>
        public abstract IActionResult Detail(int id);

        /// <summary>
        /// this method helps to render a partial view into html string.
        /// </summary>
        /// <param name="viewEngine"></param>
        /// <param name="viewName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string RenderPartialViewToString(string viewName)
        {
            viewName = viewName ?? ControllerContext.ActionDescriptor.ActionName;
            using (StringWriter sw = new StringWriter())
            {
                IView view = _viewEngine.FindView(ControllerContext, viewName, false).View;
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
