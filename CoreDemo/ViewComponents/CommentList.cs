using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,UserName="Serkan"
                },
                 new UserComment
                {
                    ID = 2,UserName="Erkan"
                },
                  new UserComment
                {
                    ID = 3,UserName="Can"
                }

            };
            return View(commentvalues);
        }

    }
}
