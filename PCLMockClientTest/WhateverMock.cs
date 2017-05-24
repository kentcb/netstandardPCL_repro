using PCLMock;
using PCLMockClientTest;

namespace QUT.UnitTests
{
    public class AuthenticationProviderMock : MockBase<IWhatever>, IWhatever
    {
        public string What() =>
            this.Apply(x => x.What());
    }
}
