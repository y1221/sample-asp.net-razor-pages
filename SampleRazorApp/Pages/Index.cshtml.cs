using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "sample message";

        [BindProperty]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        public void OnGet()
        {
            Message = "何か書いて下さい。";
        }

        public void OnPost(string name)
        {

        }
    }
}
