using Microsoft.AspNetCore.Mvc;

namespace MVCround2.Controllers
{
    // /about
    //[Route("[controller]/[action]")]
    public class AboutController
    {
        public string Index()
        {
            return "What's good sugar plum? I'm the about controller";
        }

        public string Message()
        {
            return "Hah! You want a message? Fuck you";
        }

        public string Potato()
        {
            return "Agria, tom toms, can't remember any other potato breeds...";
        }
    }
}
