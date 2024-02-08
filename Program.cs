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


System.Console.Write("Введите координату x числа");
 int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату y числа");
 int y = Convert.ToInt32(Console.ReadLine());

 if(x > 0)
 {
   if(y > 0)
   {
    System.Console.WriteLine("Первая координатная четверть");
   }
   else
   {
    System.Console.WriteLine("Четёртая координатная четверть");
   }
 }
 else
 {
   if(y > 0){
     System.Console.WriteLine("Вторая координатная четверть");
   }
   else
   {
     System.Console.WriteLine("Третья координатная четверть");
   }
 }

