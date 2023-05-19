using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using TestApi.DTOs;
using Microsoft.AspNetCore.Http;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class MetaController : ControllerBase
    {

        [HttpGet]
        [Route("log")]
        public string Get()
        {
            string _ruta = Environment.GetEnvironmentVariable("LOG_FILE_PATH");
            String line;
            var sb = new System.Text.StringBuilder();
            try
            {
                StreamReader sr = new StreamReader(_ruta);
                line = sr.ReadLine();

                while (line != null)
                {
                    line = sr.ReadLine();

                    if (line != null)
                        sb.AppendLine(line.ToString());

                }

                sr.Close();
            }
            catch (Exception e)
            {
                return "Exception : " + e.Message.ToString();
            }

            return sb.ToString();
        }

        [HttpGet]
        [Route("log/truncate")]
        public LogDto Truncate()
        {
            string _ruta = Environment.GetEnvironmentVariable("LOG_FILE_PATH");
  
            try
            {
                StreamWriter sr = new StreamWriter(_ruta, false);
                sr.Close();
            }
            catch (Exception e)
            {
                return new LogDto()
                {
                    code = StatusCodes.Status500InternalServerError.ToString(),
                    message = "Exception : " + e.Message.ToString()
                };
            }

            var _BaseResponse = new LogDto()
            {
                code = StatusCodes.Status200OK.ToString(),
                message = "log truncado"
            };

            return _BaseResponse;
        }
    }
}
