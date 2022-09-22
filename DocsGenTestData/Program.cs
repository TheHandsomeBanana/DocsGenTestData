

using DocsGenTestData.Models.Attributes;
using DocsGenTestData.Models.TestData;

namespace DocsGenTestData {
    class Program {
        static void Main(string[] args) {
            Audi audi = new Audi("A4") {
                Horsepower = 230
            };

            Tesla tesla = new Tesla("Model 3") {
                Horsepower = 325
            };

            IEnumerable<Attribute> audiAttributes = audi.GetType().GetCustomAttributes(true).Cast<Attribute>();

            string audiDescription = null;
            string audiFastest = null;
            string audiMostExpensive = null;

            foreach (var audiAttribute in audiAttributes) {
                if (audiAttribute is Description description)
                    audiDescription = description.Content;
                else if(audiAttribute is CarAttribute carAttribute) {
                    audiFastest = carAttribute.FastestType;
                    audiMostExpensive = carAttribute.MostExpensiveType;
                }
            }

            IEnumerable<Attribute> teslaAttributes = tesla.GetType().GetCustomAttributes(true).Cast<Attribute>();
            string teslaDescription = null;
            string teslaFastest = null;
            string teslaMostExpensive = null;

            foreach (var teslaAttribute in teslaAttributes) {
                if (teslaAttribute is Description description)
                    teslaDescription = description.Content;
                else if (teslaAttribute is CarAttribute carAttribute) {
                    teslaFastest = carAttribute.FastestType;
                    teslaMostExpensive = carAttribute.MostExpensiveType;
                }
            }

            Console.WriteLine($"Audi {audi.Type}: {audiDescription}\nFastest: {audiFastest}\nMost Expensive: {audiMostExpensive}\n");
            Console.WriteLine($"Tesla {tesla.Type}: {teslaDescription}\nFastest: {teslaFastest}\nMost Expensive: {teslaMostExpensive}\n");

            Console.ReadLine();
        }
    }
}