using System;
using Microsoft.AspNetCore.Mvc;

namespace Aprendizado.Pages.Controller
{
    [Route("/Escritorio")]
    public class EscritorioController   :   ControllerBase
    {
        [HttpGet("/{page:id}")]
        public  void   escritorio(int   page)
        {
            
        }
    }
}
