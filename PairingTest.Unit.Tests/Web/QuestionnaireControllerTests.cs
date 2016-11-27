using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using PairingTest.Web.Interfaces;
using PairingTest.Web.Models;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected quesitons";
            var questionnaireVm = new QuestionnaireViewModel()
            {
                QuestionnaireTitle = expectedTitle
            };
            var viewData = new ViewDataDictionary()
            {
                Model = questionnaireVm
            };
            var questionnaireController = new Mock<IQuestionnaireController>();
            questionnaireController.Setup(x => x.Index()).Returns(new ViewResult()
            {
                ViewData = viewData
            });

            //Act
            var result = (QuestionnaireViewModel)questionnaireController.Object.Index().ViewData.Model;
            
            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}