using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.DAL.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _WorkComponentPartial : ViewComponent
    {
        private readonly MyPortfolyoContext _context;

        public _WorkComponentPartial(MyPortfolyoContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}