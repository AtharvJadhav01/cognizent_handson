using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Week3WebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = context.Exception.ToString();

            string folder = Path.Combine(Directory.GetCurrentDirectory(), "Logs");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string file = Path.Combine(folder, "ErrorLog.txt");

            File.AppendAllText(file,
                $"[{DateTime.Now}] {message}{Environment.NewLine}{Environment.NewLine}");

            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}