using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsGenTestData.Models.Attributes {
    [AttributeUsage(AttributeTargets.All)]
    public class Description : Attribute {
        public readonly string Content;
        public Description(string description) {
            this.Content = description;
        }
    }
}
