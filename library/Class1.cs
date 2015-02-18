using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Class1
    {
        public double Hesapla(double a,double b,char c)
        {
            double sonuc=0;
            switch (c)
            { 
                case '+':
                    sonuc = a + b;
                    break;

                case '-':
                    sonuc = a - b;
                    break;

                case '*':
                    sonuc = a * b;
                    break;

                case '/':
                    sonuc = a / b;
                    break;
       
            }

            return sonuc;
        }



    }
}
