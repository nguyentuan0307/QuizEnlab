using AutoMapper;
using QuizEnlab.Data;
using QuizEnlab.Model;

namespace QuizEnlab.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Quiz, ResultModel>().ReverseMap();
            CreateMap<Answer, AnswerModel>().ReverseMap();
            CreateMap<Answer, AnswerReviewModel>().ReverseMap();
        }
    }
}
