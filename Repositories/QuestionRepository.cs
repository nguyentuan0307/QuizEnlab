﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizEnlab.Data;
using QuizEnlab.Model;
using QuizEnlab.Repositories.IRepository;

namespace QuizEnlab.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _dataContext;

        public QuestionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Question?> GetRandomQuestionAsync()
        {
            var question = await _dataContext.Questions.Include(q => q.Answers)
                .OrderBy(q => Guid.NewGuid())
                .FirstOrDefaultAsync();
            if (question == null)
            {
                return null;
            }
            return question;
        }

        public async Task<Question?> GetRandomQuestionExcludingAsync(HashSet<int> usedQuestionIds)
        {
            var question = await _dataContext.Questions
                .Include(q => q.Answers)
                .Where(q => !usedQuestionIds.Contains(q.Id))
                .OrderBy(q => Guid.NewGuid())
                .FirstOrDefaultAsync();

            if (question == null)
            {
                return null;
            }

            return question;
        }

        public async Task<int?> GetIdQuestionByIdAnswerAsync(int answerId)
        {
            var questionId = await _dataContext.Answers
                .Where(a => a.Id == answerId)
                .Select(a => a.QuestionId)
                .FirstOrDefaultAsync();
            return questionId;
        }
        public async Task<List<Question>?> GetQuestionsByQuizAsync(int quizId)
        {
            var quiz = await _dataContext.Quizzes.FindAsync(quizId);
            if (quiz == null)
            {
                return null;
            }

            var questionIds = await _dataContext.UserAnswers
                .Where(a => a.QuizId == quizId)
                .Select(a => a.Answer.QuestionId)
                .Distinct()
                .ToListAsync();
            var questions = await _dataContext.Questions
                .Include(q => q.Answers)
                .Where(q => questionIds.Contains(q.Id))
                .ToListAsync();

            return questions;
        }

        public async Task<Question?> GetQuestionById(int id)
        {
            return await _dataContext.Questions.FindAsync(id);
        }

        public async Task<List<Question>?> GetQuestionsAsync()
        {
            return await _dataContext.Questions.ToListAsync();
        }
    }
}
