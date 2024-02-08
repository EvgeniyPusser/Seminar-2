//Первое задание на делимость числа на 7 и 23 одновременно

// System.Console.Write("Введите число");
//  int number1 = Convert.ToInt32(Console.ReadLine());

//  if(number1 % 7 ==0  && number1 % 23 == 0)
//  {
//    System.Console.WriteLine("ДА");
//  }
//  else
//  {
//    System.Console.WriteLine("НЕТ");
//  }


//Второе задание на определение координатной четверти по координатам числа

// System.Console.Write("Введите координату x числа");
//  int x = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату y числа");
//  int y = Convert.ToInt32(Console.ReadLine());

//  if(x > 0)
//  {
//    if(y > 0)
//    {
//     System.Console.WriteLine("Первая координатная четверть");
//    }
//    else
//    {
//     System.Console.WriteLine("Четёртая координатная четверть");
//    }
//  }
//  else
//  {
//    if(y > 0){
//      System.Console.WriteLine("Вторая координатная четверть");
//    }
//    else
//    {
//      System.Console.WriteLine("Третья координатная четверть");
//    }
//  }

//Третье задание на определение наибольшей цифры в числе из отрезка

// System.Console.Write("Введите число из отрезка [10, 99]");
//  int numberFromSegment = Convert.ToInt32(Console.ReadLine());

//  if(numberFromSegment >= 10 && numberFromSegment <= 99)
//  {
//    if(numberFromSegment / 10 > numberFromSegment % 10)
//    {
//     System.Console.WriteLine(numberFromSegment / 10);}
//     else
//     {
//       System.Console.WriteLine(numberFromSegment % 10);
//     }
//    }
 

 //Четвёртое задание на последовательность цифр натурального числа
 System.Console.Write("Введите число   ");
 int number = Convert.ToInt32(Console.ReadLine());
 int numberOld = number;//наше первоначальное число, цифры которого мы хотим записать
 
 int figure = 0;
 System.Console.WriteLine("Справа налево" + "  ");
 while(number > 0)
 {
  figure = number % 10;
  System.Console.Write(figure + "," );
  number = number / 10; 
 }

// System.Console.Write("Слева направо" + "  ");    
// int degree = 0;
// while(number > 10)
// {
//     number = number/ 10;
//     degree++; //это порядок нашего числа
// }
   
//    for(; degree >= 0; degree--)
// {
//   int degreeVariable= Convert.ToInt32(Math.Pow(10, degree));//здесь пришлось попотеть, потому что возведение в степеь подразумевает double, а не int, а double, в свою очередь не дает целочисленного деления
//   int res = numberOld / degreeVariable;
//   numberOld = numberOld - res * degreeVariable;
//   System.Console.Write(res + "," );
// }
