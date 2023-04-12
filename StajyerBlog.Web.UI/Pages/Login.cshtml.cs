using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajyerBlog.Core.Data.DTO;
using StajyerBlog.Web.UI.Helpers;

namespace StajyerBlog.Web.UI.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            var obj = new AuthFilter();
            obj.Password = Password;
            obj.Email = Email;
            var rt = ApiHelper.Post<AuthDTO>("/api/Auth", obj);
        }
    }
}
