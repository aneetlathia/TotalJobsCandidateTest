using System.Web.Mvc;
using PairingTest.Web.Interfaces;
using PairingTest.Web.ServiceClients;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller, IQuestionnaireController
    {
        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //public async Task<ViewResult> Index()
        //{
        //}

        public virtual ViewResult Index()
        {
            var questionsClient = new QuestionsClient("http://localhost:50014/");

            var questionVm = questionsClient.GetQuestions();
            questionsClient.BlankAnswersList(ref questionVm);

            return View(questionVm);
        }

        public ViewResult Angular()
        {
            return View();
        }
    }
}
