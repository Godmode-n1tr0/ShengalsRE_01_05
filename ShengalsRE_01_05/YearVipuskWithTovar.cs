using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShengalsRE_01_05
{
    public class YearVipuskWithTovar
    {
        // Поле с датой выпуска
        public int Year { get; set; }

        // Качество с учетом даты выпуска
        public double QulityP { get; set; }

        //Формула для расчеты качества с учетом даты выпуска
        public void QulityWithVT()
        {
            // переменная с текущей датой;
            int t = DateTime.Now.Year;
            TovarWithSklad tovarWithSklad1 = new TovarWithSklad();
            t -= Year;
            if (t < 3)
            {
                QulityP =  tovarWithSklad1.Quality + 0.5 * (t - Year);
            }
            else
            {
                QulityP = tovarWithSklad1.Quality + 1.3 * (t - Year);
            }
            Console.WriteLine($"Качество товара с учетом года выпуска: {QulityP}");
        }


    }
}
