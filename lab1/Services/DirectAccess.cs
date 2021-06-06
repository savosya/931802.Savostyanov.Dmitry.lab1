using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Services
{
    public class DirectAccess
    {
        public int a { get; set; }
        public int b { get; set; }
        public string sum { get; set; }
        public string sub { get; set; }
        public string mult { get; set; }
        public string div { get; set; }

        public DirectAccess()
        {
            Random rand = new();
            a = rand.Next(0, 11);
            b = rand.Next(0, 11);
            sum = $"{a} + {b} = {a + b}";
            sub = $"{a} - {b} = {a - b}";
            mult = $"{a} * {b} = {a * b}";
            div = b == 0 ? "Can't devide by 0" : $"{a} / {b} = {a / b}";
        }
    }
}
