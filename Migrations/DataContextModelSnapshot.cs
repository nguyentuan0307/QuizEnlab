﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizEnlab.Data;

#nullable disable

namespace QuizEnlab.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizEnlab.Data.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCorrect = true,
                            QuestionId = 1,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 2,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 3,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 4,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 5,
                            IsCorrect = true,
                            QuestionId = 2,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 6,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 7,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 8,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 9,
                            IsCorrect = true,
                            QuestionId = 3,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 10,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 11,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 12,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 13,
                            IsCorrect = true,
                            QuestionId = 4,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 14,
                            IsCorrect = false,
                            QuestionId = 4,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 15,
                            IsCorrect = false,
                            QuestionId = 4,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 16,
                            IsCorrect = false,
                            QuestionId = 4,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 17,
                            IsCorrect = true,
                            QuestionId = 5,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 18,
                            IsCorrect = false,
                            QuestionId = 5,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 19,
                            IsCorrect = false,
                            QuestionId = 5,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 20,
                            IsCorrect = false,
                            QuestionId = 5,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 21,
                            IsCorrect = true,
                            QuestionId = 6,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 22,
                            IsCorrect = false,
                            QuestionId = 6,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 23,
                            IsCorrect = false,
                            QuestionId = 6,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 24,
                            IsCorrect = false,
                            QuestionId = 6,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 25,
                            IsCorrect = true,
                            QuestionId = 7,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 26,
                            IsCorrect = false,
                            QuestionId = 7,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 27,
                            IsCorrect = false,
                            QuestionId = 7,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 28,
                            IsCorrect = false,
                            QuestionId = 7,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 29,
                            IsCorrect = true,
                            QuestionId = 8,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 30,
                            IsCorrect = false,
                            QuestionId = 8,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 31,
                            IsCorrect = false,
                            QuestionId = 8,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 32,
                            IsCorrect = false,
                            QuestionId = 8,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 33,
                            IsCorrect = true,
                            QuestionId = 9,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 34,
                            IsCorrect = false,
                            QuestionId = 9,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 35,
                            IsCorrect = false,
                            QuestionId = 9,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 36,
                            IsCorrect = false,
                            QuestionId = 9,
                            Text = "Đáp án 4"
                        },
                        new
                        {
                            Id = 37,
                            IsCorrect = true,
                            QuestionId = 10,
                            Text = "Đáp án 1"
                        },
                        new
                        {
                            Id = 38,
                            IsCorrect = false,
                            QuestionId = 10,
                            Text = "Đáp án 2"
                        },
                        new
                        {
                            Id = 39,
                            IsCorrect = false,
                            QuestionId = 10,
                            Text = "Đáp án 3"
                        },
                        new
                        {
                            Id = 40,
                            IsCorrect = false,
                            QuestionId = 10,
                            Text = "Đáp án 4"
                        });
                });

            modelBuilder.Entity("QuizEnlab.Data.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Question", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Câu hỏi 1"
                        },
                        new
                        {
                            Id = 2,
                            Text = "Câu hỏi 2"
                        },
                        new
                        {
                            Id = 3,
                            Text = "Câu hỏi 3"
                        },
                        new
                        {
                            Id = 4,
                            Text = "Câu hỏi 4"
                        },
                        new
                        {
                            Id = 5,
                            Text = "Câu hỏi 5"
                        },
                        new
                        {
                            Id = 6,
                            Text = "Câu hỏi 6"
                        },
                        new
                        {
                            Id = 7,
                            Text = "Câu hỏi 7"
                        },
                        new
                        {
                            Id = 8,
                            Text = "Câu hỏi 8"
                        },
                        new
                        {
                            Id = 9,
                            Text = "Câu hỏi 9"
                        },
                        new
                        {
                            Id = 10,
                            Text = "Câu hỏi 10"
                        });
                });

            modelBuilder.Entity("QuizEnlab.Data.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserAnswersCount")
                        .HasColumnType("int");

                    b.Property<int>("UserAnswersCountCorrect")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("QuizEnlab.Data.UserAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnswerIdSelected")
                        .HasColumnType("int");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerIdSelected");

                    b.HasIndex("QuizId");

                    b.ToTable("UserAnswer", (string)null);
                });

            modelBuilder.Entity("QuizEnlab.Data.Answer", b =>
                {
                    b.HasOne("QuizEnlab.Data.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizEnlab.Data.UserAnswer", b =>
                {
                    b.HasOne("QuizEnlab.Data.Answer", "Answer")
                        .WithMany("UserAnswers")
                        .HasForeignKey("AnswerIdSelected")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuizEnlab.Data.Quiz", "Quiz")
                        .WithMany("UserAnswers")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("QuizEnlab.Data.Answer", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("QuizEnlab.Data.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuizEnlab.Data.Quiz", b =>
                {
                    b.Navigation("UserAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
