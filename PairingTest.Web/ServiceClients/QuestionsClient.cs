using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using PairingTest.Web.Models;

namespace PairingTest.Web.ServiceClients
{
    public class QuestionsClient
    {
        private readonly string _baseAddress;

        public QuestionsClient(string baseAddress)
        {
            _baseAddress = baseAddress;
        }

        public virtual QuestionnaireViewModel GetQuestions()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = client.GetAsync("api/questions").Result;
                if (response.IsSuccessStatusCode)
                {
                    return (response.Content.ReadAsAsync<QuestionnaireViewModel>().Result);
                }

                throw new HttpResponseException(response.StatusCode);
            }
        }

        public void BlankAnswersList(ref QuestionnaireViewModel questionnaireVm)
        {
            if (questionnaireVm != null)
            {
                questionnaireVm.AnswersText = new List<string>();

                for (var indx = 0; indx < questionnaireVm.QuestionsText.Count; indx++)
                {
                    questionnaireVm.AnswersText.Add("");
                }
            }
        }
    }
}