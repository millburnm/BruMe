
namespace BruMeServices
{
    public class UntappdMethodName
    {
        public string Name { get; set; }
        private UntappdMethodName(string name) { Name = name; }

        public static UntappdMethodName UserInfo { get { return new UntappdMethodName("user/info/{0}"); } }
    }
}
