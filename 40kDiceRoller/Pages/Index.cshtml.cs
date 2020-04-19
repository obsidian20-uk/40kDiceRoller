using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _40kDiceRoller.Pages
{
    public class IndexModel : PageModel
    {
        public bool AdvancedWoundMode { get; set; }
        public int NumHitDice { get; set; }

        public int HitScore { get; set; }

        public int WoundScore { get; set; }

        public int SaveScore { get; set; }

        public int TotalHits { get; set; }

        public Dictionary<int, int> Results { get; set; } = new Dictionary<int, int>();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Results.Add(1, 2);
            Results.Add(2, 3);
            Results.Add(3, 3);
            Results.Add(4, 2);
        }

        public void OnGet()
        {

        }
    }
}
