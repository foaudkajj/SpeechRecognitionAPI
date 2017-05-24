using SpeechRecognitionApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeechRecognitionApi.Models
{
    public class SpeechRecognitionRepository : ISpeechRecognitionRepository
    {
        public readonly SpeechRecognitionContext _context;
        public SpeechRecognitionRepository(SpeechRecognitionContext context)
        {
            _context = context;
        }

        public string Get(string speech)
        {
            //Func<string,string> fetchResponse = s => s.First()
            SpeechRecognition result = _context.SpeechRecognitionRow.First(s => s.Speech == speech ? true : false);
            return result.Respone;
        }
    }
}
