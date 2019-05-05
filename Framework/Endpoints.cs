using Framework;

namespace TechnicalTest
{
    public  class Endpoint
    {
        public static string Albums { get { return AppSettings.Albums; } }
        public static string Comments { get { return AppSettings.Comments; } }
        public static string Photos { get { return AppSettings.Photos; } }
        public static string Todos { get { return AppSettings.Todos; } }
        public static string Users { get { return AppSettings.Users; } }
        public static string Posts { get { return AppSettings.Posts; } }
    }

}