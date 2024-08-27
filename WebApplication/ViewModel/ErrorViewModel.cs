using System;

namespace WebApplication.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorMessage { get; set; }
        public string NotifyMessage { get; set; }
        public string SuccessMessage { get; set; }
    }
}
