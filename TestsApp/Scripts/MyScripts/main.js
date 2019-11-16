var model = {
    view: ko.observable("start"),               // отображаемое представление
    test: {
        number: ko.observable(0),               // номер вопроса
        question: ko.observable(""),            // сам вопрос
        answers: ko.observableArray([])         // варианты ответов
    },
    totalQuestions: ko.observable(0),           // всего вопросов в тесте
    numberOfCorrectAnswers: ko.observable(0)    // количество правильных ответов
};

var showQuestion = function () {
    $.ajax("/api/TestWebAPI", {
        type: "GET",
        data: { id: model.test.number() + 1 },
        success: function (data) {
            // Считываем общее количество вопросов в модель
            if (model.test.number() === 0) {
                model.totalQuestions(data.TotalQuestions);
            }
            // Считываем номер вопроса в модель
            model.test.number(data.Number);
            // Считываем сам вопрос в модель
            model.test.question(data.Question);
            // Перемешиваем варианты ответов
            shuffle(data.Answers);
            // Очищаем массив ответов в модели
            model.test.answers([]);
            // Считываем перемешанные варианты ответов в модель
            data.Answers.forEach(function (item) {
                model.test.answers.push(item);
            });
            // Отображаем представление с вопросом
            model.view("form");
            // Выбираем первый вариант по умолчанию
            $('#answer_1').prop('checked', true);
        },
        beforeSend: function () {
            $('#wait').text('Загрузка теста. Подождите... ');
        }
    });
};

// Функция для перемешивания массива ответов
var shuffle = function (answers) {
    for (var i = 3; i >= 1; i--) {
        var j = Math.round(Math.random() * (i + 1) - 0.5);    // случ. целое число [0;i]
        var tmp = answers[j];
        answers[j] = answers[i];
        answers[i] = tmp;
    }
};

var sendAnswer = function () {
    $.ajax("/api/TestWebAPI", {
        type: "POST",
        data: {
            number: model.test.number(),
            answer: $(':radio:checked').val()
        },
        success: function () {
            // Если последний вопрос
            if (model.test.number() === model.totalQuestions())
                // то отображаем результат теста
                getResult();
            else // отображаем следующий вопрос
                showQuestion();
        }
    });
};

var getResult = function () {
    $.ajax("/api/TestWebAPI", {
        type: "GET",
        success: function (data) {
            // Считываем количество правильных ответов
            model.numberOfCorrectAnswers(data);
            // Отображаем представление с результатом
            model.view("result");
        }
    });
};

$(document).ready(function () {
    ko.applyBindings();
    //$.ajax("/api/TestWebAPI", {
    //    type: "HEAD"
    //});
});

// test
