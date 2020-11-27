using System.Collections.Generic;

namespace AbstractFactoryTest.Models
{
    public class DiningSet
    {
        public Table Table { get; set; }
        public List<Chair> Chairs { get; set; }
    }
}
