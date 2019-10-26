namespace Service
{
    public class TestService : ITestService
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public string Concatenate(string a, string b) => a + b;
    }
}