using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpeechRecognitionApi.Models;

namespace SpeechRecognitionApi.Data
{
    public class SpeechRecognitionContext : DbContext
    {
        public SpeechRecognitionContext(DbContextOptions<SpeechRecognitionContext> options ) : base (options)
        {
        }

        public DbSet<SpeechRecognition> SpeechRecognitionRow { get; set; }
    }
}
