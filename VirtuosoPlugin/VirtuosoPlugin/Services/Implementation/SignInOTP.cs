using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VirtuosoPlugin.DTOs;
using VirtuosoPlugin.Services.Interface;

namespace VirtuosoPlugin.Services.Implementation
{
    public class SignInOTP : ISignInOTP
    {
        public bool GetSignInOTPResponse(ResponseText responseDTO)
        {
            //using (var httpClient = new HttpClient())
            //{
            //    StringContent content = new StringContent(Encoding.UTF8, "application/json");
            //    using (var response = await httpClient.GetAsync())
            //    {
            //        //string DataSetResponse = await response.Content.ReadAsStringAsync();

            //        //data = JsonConvert.DeserializeObject<BaseResponse<WidgetDataSet>>(DataSetResponse);
            //    }
            //}
            if (responseDTO.Response == "success")
            {
                return true;
            }
            return false;

        }
    }
}
