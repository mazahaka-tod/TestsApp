﻿using System.Collections.Generic;
using System.Data.Entity;

namespace TestsApp.Models {
    public class TestContext : DbContext {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public TestContext() : base("TestDb") { }

        static TestContext() {
            //Database.SetInitializer(new TestContextInitializer());
        }
    }

    public class TestContextInitializer : DropCreateDatabaseAlways<TestContext> {
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

            //// Вопрос 7
            //db.Questions.Add(new Question {
            //    Id = 7,
            //    Name = "Безопасным глаголом является ...",
            //    CorrectAnswer = "HEAD"
            //});

            //// Вопрос 8
            //db.Questions.Add(new Question {
            //    Id = 8,
            //    Name = "Идемпотентным (но небезопасным) глаголом является ...",
            //    CorrectAnswer = "PUT"
            //});

            //// Вопрос 9
            //db.Questions.Add(new Question {
            //    Id = 9,
            //    Name = "Web API контроллеры используют пространство имен ...",
            //    CorrectAnswer = "System.Web.Http"
            //});

            //// Вопрос 10
            //db.Questions.Add(new Question {
            //    Id = 10,
            //    Name = "Какой из классов не относится к Web API?",
            //    CorrectAnswer = "HttpApplication"
            //});

            //// Вопрос 11
            //db.Questions.Add(new Question {
            //    Id = 11,
            //    Name = "Пространство имен System.Net.Http содержит ...",
            //    CorrectAnswer = "типы, которые представляют HTTP-запросы и ответы"
            //});

            //// Вопрос 12
            //db.Questions.Add(new Question {
            //    Id = 12,
            //    Name = "Какое из свойств не определяет класс ApiController?",
            //    CorrectAnswer = "ViewBag"
            //});

            //// Вопрос 13
            //db.Questions.Add(new Question {
            //    Id = 13,
            //    Name = "Какое из свойств не определяет класс HttpRequestMessage?",
            //    CorrectAnswer = "HttpMethod"
            //});

            //// Вопрос 14
            //db.Questions.Add(new Question {
            //    Id = 14,
            //    Name = "Какое из свойств не определяет класс HttpRequestContext?",
            //    CorrectAnswer = "IsAuthenticated"
            //});

            //// Вопрос 15
            //db.Questions.Add(new Question {
            //    Id = 15,
            //    Name = "Какое из свойств не определяет класс HttpControllerContext?",
            //    CorrectAnswer = "HttpContext"
            //});

            //// Вопрос 16
            //db.Questions.Add(new Question {
            //    Id = 16,
            //    Name = "Конфигурация Web API выполняется в файле ...",
            //    CorrectAnswer = "App_Start/WebApiConfig.cs"
            //});

            //// Вопрос 17
            //db.Questions.Add(new Question {
            //    Id = 17,
            //    Name = "Экземпляр класса HttpConfiguration доступен через ...",
            //    CorrectAnswer = "все указанные свойства"
            //});

            //// Вопрос 18
            //db.Questions.Add(new Question {
            //    Id = 18,
            //    Name = "Какое из свойств не определяет класс HttpConfiguration?",
            //    CorrectAnswer = "Url"
            //});



            // Варианты ответов
            IEnumerable<Answer> answerOptions = new List<Answer> {
                //new Answer {
                //    QuestionId = 18,
                //    AnswerOption = "DependencyResolver" },
                //new Answer {
                //    QuestionId = 18,
                //    AnswerOption = "Filters" },
                //new Answer {
                //    QuestionId = 18,
                //    AnswerOption = "Routes" },
                //new Answer {
                //    QuestionId = 18,
                //    AnswerOption = "Url" },

                //new Answer {
                //    QuestionId = 17,
                //    AnswerOption = "статическое свойство Configuration класса GlobalConfiguration" },
                //new Answer {
                //    QuestionId = 17,
                //    AnswerOption = "свойство Configuration класса HttpControllerContext" },
                //new Answer {
                //    QuestionId = 17,
                //    AnswerOption = "свойство Configuration класса ApiController" },
                //new Answer {
                //    QuestionId = 17,
                //    AnswerOption = "все указанные свойства" },

                //new Answer {
                //    QuestionId = 16,
                //    AnswerOption = "App_Start/WebApiConfig.cs" },
                //new Answer {
                //    QuestionId = 16,
                //    AnswerOption = "App_Start/RouteConfig.cs" },
                //new Answer {
                //    QuestionId = 16,
                //    AnswerOption = "Global.asax.cs" },
                //new Answer {
                //    QuestionId = 16,
                //    AnswerOption = "Web.config" },

                //new Answer {
                //    QuestionId = 15,
                //    AnswerOption = "HttpContext" },
                //new Answer {
                //    QuestionId = 15,
                //    AnswerOption = "Configuration" },
                //new Answer {
                //    QuestionId = 15,
                //    AnswerOption = "Request" },
                //new Answer {
                //    QuestionId = 15,
                //    AnswerOption = "RequestContext" },

                //new Answer {
                //    QuestionId = 14,
                //    AnswerOption = "IsAuthenticated" },
                //new Answer {
                //    QuestionId = 14,
                //    AnswerOption = "Configuration" },
                //new Answer {
                //    QuestionId = 14,
                //    AnswerOption = "IsLocal" },
                //new Answer {
                //    QuestionId = 14,
                //    AnswerOption = "RouteData" },

                //new Answer {
                //    QuestionId = 13,
                //    AnswerOption = "HttpMethod" },
                //new Answer {
                //    QuestionId = 13,
                //    AnswerOption = "Content" },
                //new Answer {
                //    QuestionId = 13,
                //    AnswerOption = "Headers" },
                //new Answer {
                //    QuestionId = 13,
                //    AnswerOption = "Properties" },

                //new Answer {
                //    QuestionId = 12,
                //    AnswerOption = "ViewBag" },
                //new Answer {
                //    QuestionId = 12,
                //    AnswerOption = "ControllerContext" },
                //new Answer {
                //    QuestionId = 12,
                //    AnswerOption = "ModelState" },
                //new Answer {
                //    QuestionId = 12,
                //    AnswerOption = "Request" },

                //new Answer {
                //    QuestionId = 11,
                //    AnswerOption = "типы, которые представляют HTTP-запросы и ответы" },
                //new Answer {
                //    QuestionId = 11,
                //    AnswerOption = "базовый класс Web API контроллеров ApiController" },
                //new Answer {
                //    QuestionId = 11,
                //    AnswerOption = "классы, которые обеспечивают внедрение зависимостей" },
                //new Answer {
                //    QuestionId = 11,
                //    AnswerOption = "классы, которые используются для валидации данных" },

                //new Answer {
                //    QuestionId = 10,
                //    AnswerOption = "HttpApplication" },
                //new Answer {
                //    QuestionId = 10,
                //    AnswerOption = "HttpRequestContext" },
                //new Answer {
                //    QuestionId = 10,
                //    AnswerOption = "HttpResponseMessage" },
                //new Answer {
                //    QuestionId = 10,
                //    AnswerOption = "HttpConfiguration" },

                //new Answer {
                //    QuestionId = 9,
                //    AnswerOption = "System.Web" },
                //new Answer {
                //    QuestionId = 9,
                //    AnswerOption = "System.Web.MVC" },
                //new Answer {
                //    QuestionId = 9,
                //    AnswerOption = "System.Web.Http" },
                //new Answer {
                //    QuestionId = 9,
                //    AnswerOption = "Все из указанных" },

                //new Answer {
                //    QuestionId = 8,
                //    AnswerOption = "GET" },
                //new Answer {
                //    QuestionId = 8,
                //    AnswerOption = "HEAD" },
                //new Answer {
                //    QuestionId = 8,
                //    AnswerOption = "POST" },
                //new Answer {
                //    QuestionId = 8,
                //    AnswerOption = "PUT" },

                //new Answer {
                //    QuestionId = 7,
                //    AnswerOption = "HEAD" },
                //new Answer {
                //    QuestionId = 7,
                //    AnswerOption = "POST" },
                //new Answer {
                //    QuestionId = 7,
                //    AnswerOption = "PUT" },
                //new Answer {
                //    QuestionId = 7,
                //    AnswerOption = "DELETE" },

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