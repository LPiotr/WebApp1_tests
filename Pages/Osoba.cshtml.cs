using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1;
using System.Collections.Generic;

namespace WebApp1.Pages
{
    public class OsobaModel : PageModel
    {
        public List<Osoba> Osoby { get; set; }

        public void OnGet()
        {
            var service = new OsobaService();
            Osoby = service.GetOsoby();
        }
    }
}