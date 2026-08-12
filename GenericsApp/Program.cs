using System.Reflection;

namespace GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Cyrus";

            if (myName.GetType() == typeof(string))
            {
                // Hey this is a string
            }
        }
    }

    internal class ConfigurationManager<T>
    { 
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        { 
            // Logic
        }
    }
}