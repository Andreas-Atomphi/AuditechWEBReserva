using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aprendizado.Pages.Model
{
    public class PrincipalModel  :   PageModel
    {
        private readonly    ILogger<PrincipalModel> _logger;

        public PrincipalModel(ILogger<PrincipalModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
