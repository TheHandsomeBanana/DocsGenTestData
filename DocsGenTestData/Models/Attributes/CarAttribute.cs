using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsGenTestData.Models.Attributes {
    [AttributeUsage(AttributeTargets.Class)]
    public class CarAttribute : Attribute {
        public readonly string FastestType;
        public string MostExpensiveType { get; set; }

        public CarAttribute(string fastestType) {
            this.FastestType = fastestType;
        }
    }
}
