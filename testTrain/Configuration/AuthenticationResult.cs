using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testTrain.Configuration
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }

    }
}
