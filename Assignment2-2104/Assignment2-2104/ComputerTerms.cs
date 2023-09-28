using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2104
{
    public class ComputerTerm
    {
        public string AcronymName { get; set; }
        public string FullDefinition { get; set; }

        public ComputerTerm(string acronymName, string fullDefinition)
        {
            AcronymName = acronymName;
            FullDefinition = fullDefinition;
        }
    }
}