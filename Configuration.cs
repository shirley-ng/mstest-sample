using System.Configuration;

namespace mstest_sample
{
    public class Configuration
    {
        private static Configuration _current;

        public static Configuration Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new Configuration();
                }
                return _current;
            }
        }

        public string Url
        {
            get
            {
                return ConfigurationManager.AppSettings["Url"];
            }
        }

        public string Username
        {
            get
            {
                return ConfigurationManager.AppSettings["Username"];
            }
        }

        public string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["Password"];
            }
        }

        public string Browser
        {
            get
            {
                return ConfigurationManager.AppSettings["Browser"];
            }
        }
    }
}