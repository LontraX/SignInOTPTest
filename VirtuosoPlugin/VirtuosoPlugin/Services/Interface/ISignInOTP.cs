using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtuosoPlugin.DTOs;

namespace VirtuosoPlugin.Services.Interface
{
    public interface ISignInOTP
    {
        public bool GetSignInOTPResponse(ResponseText responseDTO);
    }
}
