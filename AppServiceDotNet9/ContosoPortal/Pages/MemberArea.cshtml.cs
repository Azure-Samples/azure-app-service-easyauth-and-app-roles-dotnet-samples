using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoPortal.Pages
{
    [Authorize(Roles = "Member")]
    public class MemberAreaModel : PageModel
    {
        private readonly ILogger<MemberAreaModel> _logger;

        public MemberAreaModel(ILogger<MemberAreaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
