using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_3
{
    public class Caller
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime CallTime { get; set; }
        public Caller (string name, string number, DateTime callTime)
        {  
            Name = name;
            Number = number; 
            CallTime = callTime; 
        }
        public override string ToString()
        {
            return $"Caller: {Name}, Number:{Number}, Queue Entry Time: {CallTime}";
        }
    }
}
