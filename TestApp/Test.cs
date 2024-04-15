using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Test
    {
        public string Task { get; set; }
        public List<string> Answers { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public Image? Image { get; set; }
        public bool IsMultiple { get; set; }
        public decimal Point { get; set; }
    }
}
