using System;

namespace Curso_Introducao_Asp.Net_Core_SignalR_C.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
