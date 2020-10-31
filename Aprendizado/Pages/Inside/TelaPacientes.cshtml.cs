using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aprendizado.Pages.Inside
{
    public class TelaPacientesModel  :   PageModel
    {
        private readonly    ILogger<TelaPacientesModel> _logger;

        public TelaPacientesModel(ILogger<TelaPacientesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
