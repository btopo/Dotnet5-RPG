using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet5_RPG.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; } // data we want to return 
        public bool Success { get; set; } = true; // states if the call was successful
        public string Message { get; set; } = null; // displays message on frontend
    }
}