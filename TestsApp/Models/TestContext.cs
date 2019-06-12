using System.Collections.Generic;
using System.Data.Entity;

namespace TestsApp.Models {
    public class TestContext : DbContext {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public TestContext() : base("TestDb") { }

        static TestContext() {
            Database.SetInitializer(new TestContextInitializer());
        }
    }

    public class TestContextInitializer : DropCreateDatabaseIfModelChanges<TestContext> {
        protected override void Seed(TestContext db) {
            // Вопрос 1
            db.Questions.Add(new Question {
                Id = 1,
                Name = "Асинхронные методы ...",
                CorrectAnswer = "Уменьшают производительность отдельного запроса"
            });

            // Вопрос 2
            db.Questions.Add(new Question {
                Id = 2,
                Name = "В чем отличие Web API приложения от MVC?",
                CorrectAnswer = "Отсутствует представление"
            });

            // Вопрос 3
            db.Questions.Add(new Question {
                Id = 3,
                Name = "Какой HTTP глагол используется для получения данных с сервера?",
                CorrectAnswer = "GET"
            });

            // Вопрос 4
            db.Questions.Add(new Question {
                Id = 4,
                Name = "Какой HTTP глагол используется для создания нового объекта?",
                CorrectAnswer = "POST"
            });

            // Вопрос 5
            db.Questions.Add(new Question {
                Id = 5,
                Name = "Какой HTTP глагол используется для обновления существующего объекта?",
                CorrectAnswer = "PUT"
            });

            // Вопрос 6
            db.Questions.Add(new Question {
                Id = 6,
                Name = "Какой HTTP глагол используется для удаления объекта?",
                CorrectAnswer = "DELETE"
            });

            // Вопрос 7
            db.Questions.Add(new Question {
                Id = 7,
                Name = "Безопасным глаголом является ...",
                CorrectAnswer = "HEAD"
            });

            // Вопрос 8
            db.Questions.Add(new Question {
                Id = 8,
                Name = "Идемпотентным (но небезопасным) глаголом является ...",
                CorrectAnswer = "PUT"
            });

            // Вопрос 9
            db.Questions.Add(new Question {
                Id = 9,
                Name = "Web API контроллеры используют пространство имен ...",
                CorrectAnswer = "System.Web.Http"
            });



            // Варианты ответов
            IEnumerable<Answer> answerOptions = new List<Answer> {
                new Answer {
                    QuestionId = 9,
                    AnswerOption = "System.Web" },
                new Answer {
                    QuestionId = 9,
                    AnswerOption = "System.Web.MVC" },
                new Answer {
                    QuestionId = 9,
                    AnswerOption = "System.Web.Http" },
                new Answer {
                    QuestionId = 9,
                    AnswerOption = "Все из указанных" },

                new Answer {
                    QuestionId = 8,
                    AnswerOption = "GET" },
                new Answer {
                    QuestionId = 8,
                    AnswerOption = "HEAD" },
                new Answer {
                    QuestionId = 8,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 8,
                    AnswerOption = "PUT" },

                new Answer {
                    QuestionId = 7,
                    AnswerOption = "HEAD" },
                new Answer {
                    QuestionId = 7,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 7,
                    AnswerOption = "PUT" },
                new Answer {
                    QuestionId = 7,
                    AnswerOption = "DELETE" },

                new Answer {
                    QuestionId = 6,
                    AnswerOption = "GET" },
                new Answer {
                    QuestionId = 6,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 6,
                    AnswerOption = "PUT" },
                new Answer {
                    QuestionId = 6,
                    AnswerOption = "DELETE" },

                new Answer {
                    QuestionId = 5,
                    AnswerOption = "GET" },
                new Answer {
                    QuestionId = 5,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 5,
                    AnswerOption = "PUT" },
                new Answer {
                    QuestionId = 5,
                    AnswerOption = "DELETE" },

                new Answer {
                    QuestionId = 4,
                    AnswerOption = "GET" },
                new Answer {
                    QuestionId = 4,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 4,
                    AnswerOption = "PUT" },
                new Answer {
                    QuestionId = 4,
                    AnswerOption = "DELETE" },

                new Answer {
                    QuestionId = 3,
                    AnswerOption = "GET" },
                new Answer {
                    QuestionId = 3,
                    AnswerOption = "POST" },
                new Answer {
                    QuestionId = 3,
                    AnswerOption = "PUT" },
                new Answer {
                    QuestionId = 3,
                    AnswerOption = "DELETE" },

                new Answer {
                    QuestionId = 2,
                    AnswerOption = "Отсутствует представление" },
                new Answer {
                    QuestionId = 2,
                    AnswerOption = "Отсутствует контроллер" },
                new Answer {
                    QuestionId = 2,
                    AnswerOption = "Отсутствует модель" },
                new Answer {
                    QuestionId = 2,
                    AnswerOption = "Нет отличий" },

                new Answer {
                    QuestionId = 1,
                    AnswerOption = "Уменьшают производительность отдельного запроса" },
                new Answer {
                    QuestionId = 1,
                    AnswerOption = "Увеличивают производительность отдельного запроса" },
                new Answer {
                    QuestionId = 1,
                    AnswerOption = "Не влияют на производительность отдельного запроса" },
                new Answer {
                    QuestionId = 1,
                    AnswerOption = "Уменьшают общую производительность приложения" }
            };

            db.Answers.AddRange(answerOptions);
            db.SaveChanges();
        }
    }
}
