using System.Collections.Generic;
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
                CorrectAnswer = "Уменьшают производительность отдельного запроса",
                TestNumber = 1
            });

            // Вопрос 2
            db.Questions.Add(new Question {
                Id = 2,
                Name = "В чем отличие Web API приложения от MVC?",
                CorrectAnswer = "Отсутствует представление",
                TestNumber = 1
            });

            // Вопрос 3
            db.Questions.Add(new Question {
                Id = 3,
                Name = "Какой HTTP глагол используется для получения данных с сервера?",
                CorrectAnswer = "GET",
                TestNumber = 1
            });

            // Вопрос 4
            db.Questions.Add(new Question {
                Id = 4,
                Name = "Какой HTTP глагол используется для создания нового объекта?",
                CorrectAnswer = "POST",
                TestNumber = 1
            });

            // Вопрос 5
            db.Questions.Add(new Question {
                Id = 5,
                Name = "Какой HTTP глагол используется для обновления существующего объекта?",
                CorrectAnswer = "PUT",
                TestNumber = 1
            });

            // Варианты ответов
            IEnumerable<Answer> answerOptions = new List<Answer> {
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

            ////////////////////////////////////// T-SQL
            // Вопрос 1
            db.Questions.Add(new Question
            {
                Id = 101,
                Name = "Microsoft SQL Server использует следующее процедурное расширение языка SQL ...",
                CorrectAnswer = "Transact-SQL",
                TestNumber = 2
            });

            // Вопрос 2
            db.Questions.Add(new Question
            {
                Id = 102,
                Name = "Transact-SQL расширяет язык SQL, предоставляя следующую дополнительную возможность ...",
                CorrectAnswer = "все из указанных",
                TestNumber = 2
            });

            // Вопрос 3
            db.Questions.Add(new Question
            {
                Id = 103,
                Name = "Выражения языка DDL (Data Definition Language) ...",
                CorrectAnswer = "используются для создания, изменения или удаления объектов в базе данных",
                TestNumber = 2
            });

            // Вопрос 4
            db.Questions.Add(new Question
            {
                Id = 104,
                Name = "Выражения языка DCL (Data Control Language) ...",
                CorrectAnswer = "предназначены для назначения прав на объекты базы данных",
                TestNumber = 2
            });

            // Вопрос 5
            db.Questions.Add(new Question
            {
                Id = 105,
                Name = "Выражения языка DML (Data Manipulation Language) ...",
                CorrectAnswer = "используются для запросов и изменения данных",
                TestNumber = 2
            });

            // Варианты ответов
            IEnumerable<Answer> answerOptionsSQL = new List<Answer> {
                new Answer {
                    QuestionId = 105,
                    AnswerOption = "используются для создания, изменения или удаления объектов в базе данных" },
                new Answer {
                    QuestionId = 105,
                    AnswerOption = "предназначены для назначения прав на объекты базы данных" },
                new Answer {
                    QuestionId = 105,
                    AnswerOption = "используются для запросов и изменения данных" },
                new Answer {
                    QuestionId = 105,
                    AnswerOption = "нет правильного ответа" },

                new Answer {
                    QuestionId = 104,
                    AnswerOption = "используются для создания, изменения или удаления объектов в базе данных" },
                new Answer {
                    QuestionId = 104,
                    AnswerOption = "предназначены для назначения прав на объекты базы данных" },
                new Answer {
                    QuestionId = 104,
                    AnswerOption = "используются для запросов и изменения данных" },
                new Answer {
                    QuestionId = 104,
                    AnswerOption = "нет правильного ответа" },

                new Answer {
                    QuestionId = 103,
                    AnswerOption = "используются для создания, изменения или удаления объектов в базе данных" },
                new Answer {
                    QuestionId = 103,
                    AnswerOption = "предназначены для назначения прав на объекты базы данных" },
                new Answer {
                    QuestionId = 103,
                    AnswerOption = "используются для запросов и изменения данных" },
                new Answer {
                    QuestionId = 103,
                    AnswerOption = "нет правильного ответа" },

                new Answer {
                    QuestionId = 102,
                    AnswerOption = "управляющие операторы" },
                new Answer {
                    QuestionId = 102,
                    AnswerOption = "локальные и глобальные переменные" },
                new Answer {
                    QuestionId = 102,
                    AnswerOption = "различные дополнительные функции для обработки строк, дат, математики и т.п." },
                new Answer {
                    QuestionId = 102,
                    AnswerOption = "все из указанных" },

                new Answer {
                    QuestionId = 101,
                    AnswerOption = "Transact-SQL" },
                new Answer {
                    QuestionId = 101,
                    AnswerOption = "PL/pgSQL" },
                new Answer {
                    QuestionId = 101,
                    AnswerOption = "PL/SQL" },
                new Answer {
                    QuestionId = 101,
                    AnswerOption = "SQL PL" }
            };

            ////////////////////////////////////// ASP.NET Core MVC
            // Вопрос 1
            db.Questions.Add(new Question
            {
                Id = 201,
                Name = "Соглашением по конфигурации является ...",
                CorrectAnswer = "все из указанных",
                TestNumber = 3
            });

            // Вопрос 2
            db.Questions.Add(new Question
            {
                Id = 202,
                Name = "Выражения Razor начинаются с символа ...",
                CorrectAnswer = "@",
                TestNumber = 3
            });

            // Вопрос 3
            db.Questions.Add(new Question
            {
                Id = 203,
                Name = "Какое выражение Razor можно использовать для установки значений атрибутов элементов в представлении?",
                CorrectAnswer = "@Model или @ViewBag",
                TestNumber = 3
            });

            // Вопрос 4
            db.Questions.Add(new Question
            {
                Id = 204,
                Name = "Какой префикс нужно использовать, чтобы вставить литеральный текст в блок кода Razor в представлении?",
                CorrectAnswer = "@:",
                TestNumber = 3
            });

            // Вопрос 5
            db.Questions.Add(new Question
            {
                Id = 205,
                Name = "Какой оператор C# можно применять в представлении Razor?",
                CorrectAnswer = "все из указанных",
                TestNumber = 3
            });

            // Варианты ответов
            IEnumerable<Answer> answerOptionsASPNETCoreMVC = new List<Answer> {
                new Answer {
                    QuestionId = 205,
                    AnswerOption = "@switch" },
                new Answer {
                    QuestionId = 205,
                    AnswerOption = "@if" },
                new Answer {
                    QuestionId = 205,
                    AnswerOption = "@foreach" },
                new Answer {
                    QuestionId = 205,
                    AnswerOption = "все из указанных" },

                new Answer {
                    QuestionId = 204,
                    AnswerOption = "@%" },
                new Answer {
                    QuestionId = 204,
                    AnswerOption = "@#" },
                new Answer {
                    QuestionId = 204,
                    AnswerOption = "@:" },
                new Answer {
                    QuestionId = 204,
                    AnswerOption = "@>" },

                new Answer {
                    QuestionId = 203,
                    AnswerOption = "@Model" },
                new Answer {
                    QuestionId = 203,
                    AnswerOption = "@ViewBag" },
                new Answer {
                    QuestionId = 203,
                    AnswerOption = "@Model или @ViewBag" },
                new Answer {
                    QuestionId = 203,
                    AnswerOption = "выражения Razor нельзя использовать для установки значений атрибутов" },

                new Answer {
                    QuestionId = 202,
                    AnswerOption = "#" },
                new Answer {
                    QuestionId = 202,
                    AnswerOption = "$" },
                new Answer {
                    QuestionId = 202,
                    AnswerOption = "@" },
                new Answer {
                    QuestionId = 202,
                    AnswerOption = "%" },

                new Answer {
                    QuestionId = 201,
                    AnswerOption = "контроллеры имеют имена, которые заканчиваются на Controller, и находятся в папке Controllers" },
                new Answer {
                    QuestionId = 201,
                    AnswerOption = "представления помещаются в папку /Views/ИмяКонтроллера/ИмяДействия.cshtml" },
                new Answer {
                    QuestionId = 201,
                    AnswerOption = "имена файлов макетов имеют префикс в виде символа подчеркивания и размещаются в папке /Views/Shared" },
                new Answer {
                    QuestionId = 201,
                    AnswerOption = "все из указанных" }
            };

            db.Answers.AddRange(answerOptions);
            db.Answers.AddRange(answerOptionsSQL);
            db.Answers.AddRange(answerOptionsASPNETCoreMVC);
            db.SaveChanges();
        }
    }
}
