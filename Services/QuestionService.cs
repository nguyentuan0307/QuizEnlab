﻿using QuizEnlab.Data;
using QuizEnlab.Model;
using QuizEnlab.Repositories.IRepository;
using QuizEnlab.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace QuizEnlab.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IQuizRepository _quizRepository;
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IQuizRepository quizRepository, IUserAnswerRepository userAnswerRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _quizRepository = quizRepository;
            _userAnswerRepository = userAnswerRepository;
            _mapper = mapper;
        }
        public async Task<QuestionModel?> GetFirstQuestionAsync(int quizId)
        {
            var question = await _questionRepository.GetRandomQuestionAsync();
            if (question == null)
            {

                return null;
            }

            var quiz = await _quizRepository.GetQuizByIdAsync(quizId);
            if (quiz == null)
            {
                return null;
            }
            var questionModel = new QuestionModel
            {
                IdQuiz = quiz.Id,
                QuestionAnswer = question
            };
            return questionModel;
        }

        public async Task<NextQuestionResult?> GetNextQuestionAsync(int quizId)
        {
            NextQuestionResult nextQuestionResult = new NextQuestionResult();
            var quiz = await _quizRepository.GetQuizByIdAsync(quizId);
            if (quiz == null)
            {
                nextQuestionResult.IsQuiz = false;
                return nextQuestionResult;
            }

            var usedQuestionIds = await _userAnswerRepository.GetAllQuestionIdAsync(quiz.Id);
            var question = await _questionRepository.GetRandomQuestionExcludingAsync(usedQuestionIds);

            if (question == null)
            {
                var quizNew = new Quiz
                {
                    Id = quiz.Id,
                    EndTime = DateTime.Now,
                    StartTime = quiz.StartTime,
                    UserAnswersCount = quiz.UserAnswersCount,
                    UserAnswersCountCorrect = quiz.UserAnswersCountCorrect,
                };
                var quizResult = await _quizRepository.UpdateQuizAsync(quizId, quizNew);
                nextQuestionResult.IsQuestion = false;
                nextQuestionResult.ResultModel = _mapper.Map<ResultModel>(quizResult);
                return nextQuestionResult;
            }
            nextQuestionResult.Question = new QuestionModel
            {
                IdQuiz = quiz.Id,
                QuestionAnswer = question
            };
            return nextQuestionResult;
        }
    }
}