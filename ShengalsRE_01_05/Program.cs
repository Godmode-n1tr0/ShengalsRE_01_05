using ShengalsRE_01_05;
using System;

//Объявление класа
TovarWithSklad tovarWithSklad = new TovarWithSklad();
YearVipuskWithTovar yearVipuskWithTovar = new YearVipuskWithTovar();


while (true)
{
    //Выбор задания
    Console.WriteLine("Программа с датой выпуска 1 без даты 2");
    int variantZad = Convert.ToInt32(Console.ReadLine());
    // Ввод данных
    Console.Write("Введите наименование товара: ");
    string NameT = Convert.ToString(Console.ReadLine());
    tovarWithSklad.Name = NameT;

    Console.Write("Введите цену товара: ");
    double PriceT = Convert.ToDouble(Console.ReadLine());
    tovarWithSklad.Price = PriceT;

    Console.Write("Введите количество товара: ");
    int CountT = Convert.ToInt32(Console.ReadLine());
    tovarWithSklad.Count = CountT;

    //Проверка на вариант задачи
    if (variantZad == 1)
    {
        Console.Write("Введите год выпуска: ");
        int YearWithVT = Convert.ToInt32(Console.ReadLine());
        yearVipuskWithTovar.Year = YearWithVT;
        //Проверка на валидность
        if (tovarWithSklad.isValid() == false)
        {
            string Errorname = tovarWithSklad.ErrorName;
            Console.WriteLine($"В поле {Errorname} ошибка, попробуйте еще раз!");
        }
        else
        {
            yearVipuskWithTovar.QulityWithVT();
            break;
        }
    }
    else
    {
        //Проверка на валидность
        if (tovarWithSklad.isValid() == false)
        {
            string Errorname = tovarWithSklad.ErrorName;
            Console.WriteLine($"В поле {Errorname} ошибка, попробуйте еще раз!");
        }
        else
        {
            //Вывод
            tovarWithSklad.QualityWithTovar();
            tovarWithSklad.EnterOtvet();
            break;
        }
    } 
    
}


