using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Study2gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study2gether.Atributtes
{
    public class ViewBagActionFilter : ActionFilterAttribute
    {
        private readonly ApplicationDbContext _context;

        public ViewBagActionFilter(ApplicationDbContext context)
        {
            _context = context;
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Controller is Controller)
            {
                var controller = context.Controller as Controller;
                controller.ViewData.Add("Axis", _context.Axis.OrderBy(x => x.name).ToList());
                controller.ViewData.Add("Micros", _context.Microfoundation.OrderBy(x => x.name).ToList());
                controller.ViewData.Add("Category", _context.Category.OrderBy(x => x.name).ToList());
            }

            base.OnResultExecuting(context);
        }
    }
}
