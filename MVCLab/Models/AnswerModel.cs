using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab.Models
{
    public class AnswerModel
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public double GetQuotient { get { return Number1 / Number2; } }

        public double GetRemainder { get { return Number1 % Number2; } }
        
       
    }

}
