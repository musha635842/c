using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetcoreap.Pages
{
    public class hireModel : PageModel
    {
        private readonly ILogger<hireModel> _logger;

        public hireModel(ILogger<hireModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
