using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeechRecognitionApi.Models
{
    public interface ISpeechRecognitionRepository
    {
        string Get(string request);
    }
}
