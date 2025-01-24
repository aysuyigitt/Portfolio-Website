using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _ExpierenceComponentPartial : ViewComponent
    {
        private readonly MyPortfolyoContext _context;

        public _ExpierenceComponentPartial(MyPortfolyoContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList(); 
            return View(values);
        }
    }
}

