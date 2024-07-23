using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using authentication_and_authorization_api.Models.Response;

namespace authentication_and_authorization_api.Filters
{
    public class ChangeResponseResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var modelState = context.ModelState;

            switch (context.Result)
            {
                case ObjectResult result:
                    {
                        var isSuccessful = (result.StatusCode ?? 500) < 300;

                        var response = new ResponseModel<object>
                        {
                            StatusCode = result.StatusCode ?? 500,
                            IsSuccessful = isSuccessful,
                            Errors = context.ModelState
                                .Select(x => new PropertyError
                                {
                                    Property = x.Key,
                                    ErrorMessages = x.Value.Errors
                                        .Select(y => y.ErrorMessage)
                                        .ToList()
                                })
                                .Where(x => x.ErrorMessages.Any())
                                .ToList(),
                            Data = isSuccessful ? result.Value : null
                        };

                        context.Result = new ObjectResult(response) { StatusCode = response.StatusCode };
                    }
                    break;
            }
        }
    }
}
