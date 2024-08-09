using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class OtherModel : PageModel
    {
        public string Message { get; set; }

        public void OnPost(string name, string password, string mail, string tel)
        {
            Message = "Name : " + name + ", Password : " + password + ", Mail : " + mail + ", Tel : " + tel;
        }
    }
}
