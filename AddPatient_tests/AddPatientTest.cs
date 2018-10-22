using NUnit.Framework;
using RestSharp;
using System.Net;
using System;

namespace AddPatient_tests
{
    /// <summary>
    /// Summary description for AddPatientTest
    /// </summary>
    [TestFixture]
    public class AddPatientTest
    {
        private readonly RestClient _client = new RestClient("http://r78-rc.zdrav.netrika.ru/EMK/PixService.svc");
        private Envelope e = new Envelope()
        {
            Body = new EnvelopeBody
            {
                AddPatient = new AddPatient
                {
                    guid = new Guid("F887330A79FC-4D40-AE9A-E92EB4F58968").ToString(),
                    idLPU = new Guid("3b4b37cd-ef0f-40179eb4-2fe49142f682").ToString(),
                    patient = new AddPatientPatient
                    {
                        BirthDate = "1980-01-21T00:00:00",
                        FamilyName = "Шариков",
                        GivenName = "Полиграф",
                        IdPatientMIS = "PatientMIS03.03.2016 15:22:3859",
                        Sex = 1,

                        Documents = new Documents
                        {
                            DocumentDto = new DocumentsDocumentDto
                            {
                                IdDocumentType = 14,
                                DocS = 2111,
                                DocN = 636538,
                                ProviderName = "УФМС"
                            }
                        },

                        Addresses = new Addresses
                        {
                            AddressDto = new AddressesAddressDto
                            {
                                IdAddressType = 123,
                                StringAddress = "Пречистенка, 13"
                            }
                        },

                        BirthPlace = new BirthPlace
                        {
                            Country = "Российская Федерация",
                            Region = "Московская область",
                            City = "Москва"
                        },

                        Contacts = new Contacts
                        {
                            ContactDto = new ContactsContactDto
                            {

                                IdContactType = 1234,
                                ContactValue = "+7 953 444 55 66 абырвалг"
                            },
                        }
                    }
                }
            }
        };

        [Test]
        public void StraightThrough()
        {
            // Arrange
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public void BirthDate_InvalidOffset()
        {
            // Arrange
            e.Body.AddPatient.patient.BirthDate = "07/10/1990";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void BirthDate_Empty()
        {
            // Arrange
            e.Body.AddPatient.patient.BirthDate = " ";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void BirthDate_InvalidDataType()
        {
            // Arrange
            e.Body.AddPatient.patient.BirthDate = "первое января тысяча девятьсот восьмидесятого года";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }
        
        [Test]
        public void FamilyName_symbols()
        {
            // Arrange
            e.Body.AddPatient.patient.FamilyName = "'Фамилия'";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void FamilyName_Empty()
        {
            // Arrange
            e.Body.AddPatient.patient.FamilyName = " ";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void GivenName_symbols()
        {
            // Arrange
            e.Body.AddPatient.patient.GivenName = "'Имя?'";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void GivenName_Empty()
        {
            // Arrange
            e.Body.AddPatient.patient.GivenName = " ";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void IdPatientMIS_symbols()
        {
            // Arrange
            e.Body.AddPatient.patient.IdPatientMIS = "'Id&?'";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void IdPatientMIS_empty()
        {
            // Arrange
            e.Body.AddPatient.patient.IdPatientMIS = " ";
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Test]
        public void Sex_Female()
        {
            // Arrange
            e.Body.AddPatient.patient.Sex = 2;
            var request = new RestRequest();
            request.AddXmlBody(e);

            // Act
            var response = _client.Execute(request);


            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
