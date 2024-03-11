using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MVCProject
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly IModelMetadataProvider modelMetadataProvider;

        public ExceptionFilter()
        {
            //this.modelMetadataProvider = ModelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
           //throw new NotImplementedException();
           //TODO for handling exception occured

            var exception = context.Exception;
            var result = new ViewResult
            {
                ViewName="Error",
                StatusCode= context.HttpContext.Response.StatusCode
            };
            result.ViewData = new ViewDataDictionary(modelMetadataProvider, context.ModelState);
            result.ViewData.Add("errMsg",exception.Message);
            context.ExceptionHandled=true; //imp so that exception will not propagate further
            context.Result = result;


        }
    }

    public class MyActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           // throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
