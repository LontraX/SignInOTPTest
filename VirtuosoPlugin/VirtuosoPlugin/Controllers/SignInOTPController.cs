using System;
using System.Collections.Generic;
using System.IO;
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
            // converts the json from the backend to string

            string response = ResponseText.ToString();

            // writes the string into a text file.

            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                writetext.WriteLine(response);
            }
            return Ok();
        }
    }
}
