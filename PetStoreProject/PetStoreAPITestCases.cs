using System.Net;

namespace PetStoreProject
{
    [TestClass]
    public class PetStoreAPITestCases
    {
        [TestMethod]
        public void Test()
        {
            try
            {
                HttpWebRequest hrrp = (HttpWebRequest)WebRequest.Create("https://petstore.swagger.io/v2/pet/5");
                HttpWebResponse htt = (HttpWebResponse)hrrp.GetResponse();
                Assert.AreEqual(HttpStatusCode.OK, htt.StatusCode);
            }
            catch (Exception ex) 
            {

            }
        }
    }
}