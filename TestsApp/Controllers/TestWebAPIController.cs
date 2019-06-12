using System.Linq;
using System.Web.Http;
using TestsApp.Models;

namespace TestsApp.Controllers {
    public class TestWebAPIController : ApiController {
        private TestContext db = new TestContext();
        private static int numberOfCorrectAnswers;

        public QuestionViewModel GetQuestion(int id) {
            // Получаем вопрос из базы
            Question question = db.Questions.Find(id);
            // Исключаем свойство с правильным ответом CorrectAnswer и преобразуем массив ответов
            QuestionViewModel questionViewModel = new QuestionViewModel {
                Number = question.Id,
                Question = question.Name,
                Answers = question.Answers.Select(a => a.AnswerOption).ToArray()
            };
            // В начале теста
            if (id == 1) {
                // Отправляем клиенту общее количество вопросов в базе
                questionViewModel.TotalQuestions = db.Questions.Count();
                // Сбрасываем счетчик правильных ответов
                numberOfCorrectAnswers = 0;
            }
            return questionViewModel;
        }

        public void PostAnswer(AnswerViewModel answer) {
            Question question = db.Questions.Find(answer.Number);
            // Проверяем ответ пользователя
            if (answer.Answer == question.CorrectAnswer) {
                numberOfCorrectAnswers++;
            }
        }

        public int GetResult() {
            // Возвращаем количесто правильных ответов
            return numberOfCorrectAnswers;
        }
    }
}
