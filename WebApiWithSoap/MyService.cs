namespace WebApiWithSoap
{
    public class MyService : IMyService
    {
        public string MySoapMethod(string input)
        {
            return $"Hello, {input}";
        }
    }
}
