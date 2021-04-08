using EFDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WorkerContext _db;

        public EFDataAccessLibrary.Models.Worker Workers { get; set; }

        public IndexModel(ILogger<IndexModel> logger, WorkerContext db)
        {
            _logger = logger;
            _db = db;
          
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        { 
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/Index");
        }

    }
}
