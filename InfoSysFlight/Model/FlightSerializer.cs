using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InfoSysFlight.Model
{
    internal static class FlightSerializer
    {
        public static void SaveToFile(List<Flight> flights, string filename)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект,
                    //который хотим сериализовать
                    serializer.Serialize(writer, flights);
                }
        }

        public static List<Flight> LoadFromFile(string filename)
        {
            List<Flight> fligths = null;

            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                 fligths = serializer.Deserialize<List<Flight>>(reader);
            }

            return fligths;
        }
    }
}
