using HealthInsurance.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace HealthInsurance.Api.ActionFilters
{
    public class ValidationFilterAttribute : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var param = context.ActionArguments.FirstOrDefault();

            if (param.Value == null)
            {
                //throw new BadRequestException("Object is null");
                context.Result = new BadRequestObjectResult("Object is null");
            }
            else if (!context.ModelState.IsValid)
            {
                //throw new BadRequestException(context.ModelState.to);
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
            else
                await next();
        }
    }
}
