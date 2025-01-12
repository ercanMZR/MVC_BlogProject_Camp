using Microsoft.AspNetCore.Mvc;
using MVC_ProjectCamp.Models;

namespace MVC_ProjectCamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalue = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    username="Efrun"
                },
                new UserComment
                {
                    ID=2,
                    username="selin"
                },
                new UserComment
                {
                    ID=3,
                    username="ömür"
                }
            };
            return View(commentvalue);
        }
    }
}
