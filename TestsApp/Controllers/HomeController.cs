using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestsApp.Models;

namespace TestsApp.Controllers {
    public class HomeController : Controller {

        static HttpClient client = new HttpClient();

        public async Task<ActionResult> Index() {
            HttpCookie token = HttpContext.Request.Cookies["token"];
            //Если пользователь не авторизован
            if (token == null) {
                // Отображаю кнопку "Авторизоваться"
                return View("Index", new IndexViewModel { View = "noauth" });
            }
            else {
                // Получаю информацию о пользователе
                IndexViewModel model = await GetUserVKAndFriendsVK(token.Value);
                return View("Index", model);
            }
        }

        public ActionResult Login() {
            // Если пользователь нажал кнопку "Авторизоваться" 
            string URL = "https://oauth.vk.com/authorize?" +
                "client_id=111" +                                                     // исправить
                "&display=page" +
                "&redirect_uri=http://localhost:3000/Home/OAuth" +                             // исправить
                "&scope=friends" +
                "&response_type=code" +
                "&v=5.101";
            return Redirect(URL);
        }

        public ActionResult Logout() {
            // Удаляю куку
            HttpContext.Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);
            return View("Index", new IndexViewModel { View = "noauth" });
        }

        public async Task<ActionResult> OAuth() {
            string code = Request.QueryString["code"];
            string URL = "https://oauth.vk.com/access_token?" +
                    "client_id=111" +                                                 // исправить
                    "&client_secret=111" +                                            // исправить
                    "&redirect_uri=http://localhost:3000/Home/OAuth" +                         // исправить
                    "&code=" + code;
            HttpResponseMessage response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode) {
                // Получаю токен
                TokenVK token = await response.Content.ReadAsAsync<TokenVK>();
                // Добавляю куку в ответ
                AddCookie(token);
                // Получаю информацию о пользователе
                IndexViewModel model = await GetUserVKAndFriendsVK(token.Access_token);
                return View("Index", model);
            }
            return View("Error");
        }

        private void AddCookie(TokenVK token) {
            HttpCookie myCookie = new HttpCookie("token", token.Access_token) {
                Expires = DateTime.Now.AddSeconds(token.Expires_in),
                Domain = Request.Url.Host,
                Path = "/"
            };
            HttpContext.Response.Cookies.Add(myCookie);
        }

        private async Task<IndexViewModel> GetUserVKAndFriendsVK(string token) {
            UserVK userVK = await GetUserVK(token);
            FriendsVK friendsVK = await GetFriendsVK(token);
            return new IndexViewModel { UserVK = userVK, FriendsVK = friendsVK, View = "start" };
        }

        private async Task<UserVK> GetUserVK(string token) {
            // Получаю имя и фамилию пользователя
            string URL = "https://api.vk.com/method/users.get?" +
                "&v=5.101" +
                "&access_token=" + token;
            HttpResponseMessage response = await client.GetAsync(URL);
            UserVK userVK = await response.Content.ReadAsAsync<UserVK>();
            return userVK;
        }

        private async Task<FriendsVK> GetFriendsVK(string token) {
            // Получаю список друзей пользователя
            string URL = "https://api.vk.com/method/friends.get?" +
                "&count=5" +
                "&fields=first_name,last_name" +
                "&v=5.101" +
                "&access_token=" + token;
            HttpResponseMessage response = await client.GetAsync(URL);
            FriendsVK friendsVK = await response.Content.ReadAsAsync<FriendsVK>();
            return friendsVK;
        }
    }
}
