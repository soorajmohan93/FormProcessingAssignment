using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FormsProcessingAssignment.Models;

namespace FormsProcessingAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [FromForm]
        public DateAndTime DateToChange { get; set; }

        public DateTime Result;
        public bool DisplayResult = false;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }

        public void OnGet()
        {
            DateToChange.DateTimeInput = DateTime.Now;
        }

        public void OnPost()
        {
            Result = DateToChange.DateTimeInput.AddDays(DateToChange.NumberInput);
            DisplayResult = true;
        }
    }
}
