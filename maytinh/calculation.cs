using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maytinh
{
    public class calculation
    {
        private int a;
        private int b;

        public calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int ex(string symbol)
        {
            int re = 0;

            switch (symbol)
            {
                case "+":
                    re = this.a + this.b;
                    break;
                case "-":
                    re = this.a - this.b;
                    break;
                case "*":
                    re = this.a * this.b;
                    break;
                case "/":
                    re = this.a / this.b;
                    break;
            }

            return re;
        }
    }
}
