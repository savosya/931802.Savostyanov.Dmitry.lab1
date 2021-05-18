
namespace lab1.Data.Models
{
    public class CalcModel
    {
        public int a;
        public int b;
        public string sum;
        public string sub;
        public string mult;
        public string div;

        public CalcModel(int a, int b,string sum, string sub, string mult, string div)
        {
            this.a = a;
            this.b = b;
            this.sum = sum;
            this.sub = sub;
            this.mult = mult;
            this.div = div;
        }
    }
}
