using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtuosoPlugin.DTOs;
using VirtuosoPlugin.Services.Interface;

namespace VirtuosoPlugin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignInOTPController : ControllerBase
    {
        //private readonly ISignInOTP _signInOTP;
        public static string checker;
        public SignInOTPController()
        {
            //_signInOTP = signInOTP;
        }
        [HttpPost("get-otp")]
        
        public IActionResult GetSignInOTP(dynamic ResponseText)
        {
            string response = ResponseText.ToString();
            //
            //response = response.Replace('\'', "\"");
            var answer = JsonSerializer.Deserialize<ResponseText>(response);
            
            //var result = _signInOTP.GetSignInOTPResponse();
            return Ok();
        }
    }
}
