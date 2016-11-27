using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using PairingTest.Web.Models;
using PairingTest.Web.ServiceClients;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionsClientTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "My expected quesitons";
            var questionsClient = new Mock<QuestionsClient>("");
            questionsClient.Setup(x => x.GetQuestions()).Returns(new QuestionnaireViewModel()
            {
                QuestionnaireTitle = expectedTitle
            });

            //Act
            var result = questionsClient.Object.GetQuestions();

            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void NumberOfBlankListOfAnswerShouldMatchNumberOfQuestions()
        {
            //Arrange
            var questionsText = new List<string>() { "Question 1", "Question 2", "Question 3" };
            var result = new QuestionnaireViewModel()
            {
                QuestionsText = questionsText
            };
            var questionClient = new QuestionsClient("");

            //Act
            questionClient.BlankAnswersList(ref result);

            //Assert
            Assert.That(result.AnswersText.Count, Is.EqualTo(3));
            Assert.That(result.AnswersText[0], Is.Empty);
            Assert.That(result.AnswersText[1], Is.Empty);
            Assert.That(result.AnswersText[2], Is.Empty);
        }
    }
}
