using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clc.Api.Models
{
    public static class ErrorMessages
    {
        public static readonly Dictionary<int, string> ErrorCodesDictionary = new()
        {
            [-1] = "General failure",
            [-3001] = "No patron found for barcode {0}",
        };

        public static string GetErrorMessage(int errorCode, params object[] args)
        {            
            // Format the error message dynamically
            return string.Format(ErrorCodesDictionary.TryGetValue(errorCode, out var message)
                ? message
                : "Unknown error.", args);
        }
    }
}
