using System;
using Xunit;
using FrontEnd;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEndTests
{
    public class UnitTest1
    {
        [Fact]
        public async void HttpGetExceptionTest()
        {
            Func<Task> Action = async () => await ClsHttp.GetUrl("http://127.0.0.1:65000/api/test-connection-error");

            var Ex = await Assert.ThrowsAsync<HttpRequestException>(Action);
            
            // Ex.message should be "No connection could be made because the target machine actively refused it. (127.0.0.1:65000)"
            Assert.Contains("refused", Ex.Message);
        }
    }
}
