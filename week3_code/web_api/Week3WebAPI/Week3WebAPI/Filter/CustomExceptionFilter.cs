using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Week3WebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Get exception details
            string message = context.Exception.ToString();

            // Create Logs folder if it doesn't exist
            string logFolder = Path.Combine(Directory.GetCurrentDirectory(), "Logs");

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            // Write exception to a file
            string logFile = Path.Combine(logFolder, "ErrorLog.txt");

            File.AppendAllText(
                logFile,
                $"[{DateTime.Now}] {message}{Environment.NewLine}{Environment.NewLine}"
            );

            // Return 500 Internal Server Error
            context.Result = new ObjectResult("An internal server error occurred.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}