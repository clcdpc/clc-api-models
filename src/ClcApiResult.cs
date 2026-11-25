using Microsoft.AspNetCore.Mvc;

namespace Clc.Api.Models
{
    public class ClcApiResult
    {
        public int ErrorCode { get; set; } = 0;
        public string ErrorMessage { get; set; } = string.Empty;

        public ClcApiResult()
        {
            
        }

        public ClcApiResult(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public static NotFoundObjectResult PatronIdNotFound(string barcode) => new(new ClcApiResult(-3000, $"No patron found for barcode {barcode}"));

        public override string ToString() => $"{ErrorCode} - {ErrorMessage}";
    }
}
