using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SpeechRecognitionApi.Data;

namespace SpeechRecognitionApi.Migrations
{
    [DbContext(typeof(SpeechRecognitionContext))]
    [Migration("20170521052443_DBname")]
    partial class DBname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpeechRecognitionApi.Models.SpeechRecognition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Respone");

                    b.Property<string>("Speech");

                    b.HasKey("ID");

                    b.ToTable("SpeechRecognitionRow");
                });
        }
    }
}
