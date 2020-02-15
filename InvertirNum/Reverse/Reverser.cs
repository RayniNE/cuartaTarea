using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvertirNum.Reverse
{
    public class Reverser
    {
        //Esta funcion permite recibir un numero como parametro, y hace todo el proceso de invertirlo.
        public static int invertirNum(int num)
        {
            string numString = "";
            if(num > 10)
            {
                //Si el numero es mayor de 10, se invierte.
                numString += num.ToString()[1];
                numString += num.ToString()[0];
            }
            else
            {
                //Si es menor que 10, se invierte y el se añade un 0 al final.
                numString += num.ToString()[0] + "0";
            }
            return Convert.ToInt32(numString);
        }
    }
}
