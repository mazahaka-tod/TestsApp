using System.Linq;
using System.Web;
using System.Web.Http;
using TestsApp.Models;

namespace TestsApp.Controllers {
    public class TestWebAPIController : ApiController {

        private static TestContext db = new TestContext();

        static TestWebAPIController() {
            db.Answers.FirstOrDefault();
        }

        public QuestionViewModel GetQuestion(int id, int testnumber) {
            // Получаем вопрос из базы
            Question question = db.Questions.FirstOrDefault(q => q.QuestionNumber == id);
            // Исключаем свойство с правильным ответом CorrectAnswer и преобразуем массив ответов
            QuestionViewModel questionViewModel = new QuestionViewModel {
                Number = question.QuestionNumber % 100,
                Question = question.Name,
                Answers = question.Answers.Select(a => a.AnswerOption).ToArray()
            };
            // В начале теста
            if (id % 100 == 1) {
                // Отправляем клиенту общее количество вопросов в базе
                questionViewModel.TotalQuestions = db.Questions.Where(q => q.TestNumber == testnumber).Count();
                // Сбрасываем счетчик правильных ответов
                HttpContext.Current.Session["numberOfCorrectAnswers"] = 0;
            }
            return questionViewModel;
        }

        public void PostAnswer(AnswerViewModel answer) {
            Question question = db.Questions.FirstOrDefault(q => q.QuestionNumber == answer.Number);
            // Если ответ пользователя правильный
            if (answer.Answer == question.CorrectAnswer) {
                int numberOfCorrectAnswers = (int)HttpContext.Current.Session["numberOfCorrectAnswers"];
                HttpContext.Current.Session["numberOfCorrectAnswers"] = numberOfCorrectAnswers + 1;
            }
        }

        public int GetResult() {
            // Возвращаем количесто правильных ответов
            return (int)HttpContext.Current.Session["numberOfCorrectAnswers"];
        }

        public void Head() {
            if (HttpContext.Current.Session["numberOfCorrectAnswers"] == null)
                db.Answers.FirstOrDefault();
        }
    }
}
