using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AuditechWEB.Models
{
    public class PacientesModel  :   PageModel
    {
        private readonly    ILogger<PacientesModel> _logger;

        public PacientesModel(ILogger<PacientesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
