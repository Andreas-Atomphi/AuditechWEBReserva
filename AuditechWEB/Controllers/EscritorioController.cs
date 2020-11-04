using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuditechWEB.Models;

namespace AuditechWEB.Controllers
{
    [Route("/Escritorio")]
    public class EscritorioController   :   Controller
    {
        private readonly ILogger<EscritorioController> _logger;

        public EscritorioController(ILogger<EscritorioController> logger)
        {
            _logger = logger;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
