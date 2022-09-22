using DocsGenTestData.Models.Attributes;

namespace DocsGenTestData.Models.TestData {
    public abstract class Car {
        [Description("This shows the cars type")]
        public string Type { get; set; }
        [Description("This shows the cars hp")]
        public int Horsepower { get; set; }


        public Car(string type) {
            this.Type = type;
        }

    }

    [Description("Represents a car as tesla")]
    [CarAttribute("Model S", MostExpensiveType = "Model S")]
    public class Tesla : Car {
        public Tesla(string type) : base(type) {
        }
    }

    [Description("Represents a car as audi")]
    [CarAttribute("Audi RS e-Tron G", MostExpensiveType = "R8 Spyder")]
    public class Audi : Car {
        public Audi(string type) : base(type) {

        }
    }

}
