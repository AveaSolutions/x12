
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12
{
    class ToXml
    {
        public void ConvertStdIn()
        {
            var parser = new OopFactory.X12.Parsing.X12Parser();

            var parseResult = parser.ParseMultiple(Console.OpenStandardInput());

            var firstResult = parseResult.First();

            firstResult.Serialize(Console.OpenStandardOutput());
        }
    }
}
