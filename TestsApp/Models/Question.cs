using System.Collections.Generic;

namespace TestsApp.Models {
    public class Question {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CorrectAnswer { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public Question() {
            Answers = new List<Answer>();
        }
    }
}
