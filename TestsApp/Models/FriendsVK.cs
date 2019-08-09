using System.Collections.Generic;

namespace TestsApp.Models {
    public class FriendsVK {
        public Friends Response { get; set; }
    }

    public class Friends {
        public int Count { get; set; }
        public IEnumerable<Items> Items { get; set; }
    }

    public class Items {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
    }
}
