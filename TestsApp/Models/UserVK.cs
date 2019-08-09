using System.Collections.Generic;

namespace TestsApp.Models {
    public class UserVK {
        public IEnumerable<User> Response { get; set; }
    }

    public class User {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
    }
}
