using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPageOverview.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string changingString { get; set; }

        public void OnGet()
        {
            changingString = "This is the changing string.";
        }

        public void OnPostView1()
        {
            changingString = "The string has changed.";
        }

        public void OnPostView2()
        {
            changingString = "Another Change!";
        }
    }

    public class CodeBehind
    {
        public string aString = "This is a code behind string.";

        public void ChangeString()
        {
            aString = "This string has changed.";
        }
    }
}
