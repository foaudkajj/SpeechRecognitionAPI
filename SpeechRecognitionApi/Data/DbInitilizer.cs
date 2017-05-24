using SpeechRecognitionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeechRecognitionApi.Data
{
    public class DbInitilizer
    {
        public static void Initilize(SpeechRecognitionContext context)
        {
            context.Database.EnsureCreated();

            if(context.SpeechRecognitionRow.Any())
            {
                return;
            }

            var Speeches = new SpeechRecognition[]
            {
                new SpeechRecognition{Speech="Hello", Respone="Hello man"},
                new SpeechRecognition{Speech="What is your name ?", Respone="My name is man"},
                new SpeechRecognition{Speech="Where do you live ?", Respone="I live in Iskenderun"},
                new SpeechRecognition{Speech="How old are you ?", Respone="I am 20 years old"},
                new SpeechRecognition{Speech="Nice to meet you", Respone="me too"},
                new SpeechRecognition{Speech="Merhaba", Respone="Ooooh merhaba arkadaşım"},
                new SpeechRecognition{Speech="Nasılsın", Respone="İyiyim sen nasılsın"},
                new SpeechRecognition{Speech="Ben de iyiyim", Respone="Allah kolaylık versin"},
                new SpeechRecognition{Speech="Hayat nasıl gidiyor", Respone="İyi vallah"}
            };

            foreach(SpeechRecognition s in Speeches)
            {
                context.Add(s);
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Internal Error in Database");
            }
            
        }
    }
}
