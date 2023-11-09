using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Net;

namespace PetStoreProject
{
    [TestClass]
    public class PetStoreAPITestCases

    {
        [TestMethod]
        public async Task VerifyOKResponseForDetailsOfPetAsync()
        {
            try
            {
                using var client = new HttpClient();
                var result = await client.GetAsync("https://petstore.swagger.io/v2/pet/5");
                Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            }
            catch (Exception ex)
            {
                Assert.Fail("Test Case failed beacuse of" + ex.StackTrace);
            }
        }
        [TestMethod]
        public async Task VerifyNotFoundResponseForNegativeEndPointAsync()
        {
            try
            {

                using var client = new HttpClient();
                var result = await client.GetAsync("https://petstore.swagger.io/v2/pet/-5");
                Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
            }
            catch (Exception ex)
            {
                Assert.Fail("Test Case failed beacuse of" + ex.StackTrace);
            }
        }
        [TestMethod]
        public async Task VerifyNotAllowedResponseForBlankEndPointAsync()
        {
            try
            {
                using var client = new HttpClient();
                var result = await client.GetAsync("https://petstore.swagger.io/v2/pet/");
                Assert.AreEqual(HttpStatusCode.MethodNotAllowed, result.StatusCode);
            }
            catch (Exception ex)
            {
                Assert.Fail("Test Case failed beacuse of" + ex.StackTrace);
            }
        }
    }
}
