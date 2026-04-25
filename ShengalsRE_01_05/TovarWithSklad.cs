using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShengalsRE_01_05
{
    public class TovarWithSklad
    {
        // Поле с именем товара
        public string Name { get; set; }
        // Поле с ценой товара
        public double Price { get; set; }
        // Поле с количеством
        public int Count { get; set; }
        // Поле с качеством товара
        public double Quality { get; set; }
        // Поле с наименование ошибки при вводе
        public string ErrorName { get; set; }

        // Формула высчитывание качества товара
        public double QualityWithTovar()
        {
            Quality = Price / Count;

            return Quality;
        }

        // вывод ответов
        public void EnterOtvet()
        {
            Console.WriteLine($"Качества товара: {Quality}");
        }

        // проверка на ввод данных
        public bool isValid()
        {
            //Проверка на пустоту в поле Name
            if (string.IsNullOrEmpty(Name))
            {
                ErrorName = "Name";
                return false;
            }
            //Проверка на пустоту в поле Price
            if (string.IsNullOrEmpty(Convert.ToString( Price)))
            {
                ErrorName = "Price";
                return false;
            }
            //Проверка на пустоту в поле Count
            if (string.IsNullOrEmpty(Convert.ToString(Count)))
            {
                ErrorName = "Count";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
