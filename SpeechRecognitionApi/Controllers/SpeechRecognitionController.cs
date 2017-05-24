using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpeechRecognitionApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpeechRecognitionApi.Controllers
{
    [Route("api/getAnswer")]
    public class SpeechRecognitionController : Controller
    {
        private readonly ISpeechRecognitionRepository _SRRepository;

        public SpeechRecognitionController(ISpeechRecognitionRepository SRRepository)
        {
            _SRRepository = SRRepository;
        }



        
        [HttpGet("{speech}")]
        public ActionResult Get(string speech)
        {
            if(speech == null)
            {
                return BadRequest();
            }
            return Ok(_SRRepository.Get(speech).ToString());
        }
    }
}
