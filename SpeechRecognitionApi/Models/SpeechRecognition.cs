using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpeechRecognitionApi.Models
{
    public class SpeechRecognition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Speech { get; set; }
        public string Respone { get; set; }
    }
}
