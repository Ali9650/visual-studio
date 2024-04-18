using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region
//console.writeline("bir eded daxil edin");
//int number = convert.toint32(console.readline());
//if (number > 0)
//{
//    console.writeline("daxil edilen eded musbetdir");
//}
//else
//{
//    console.writeline("daxil edilen eded menfidir");
//}
#endregion
#region
//Console.WriteLine("1-ci ededini daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci ededini daxil et"); 
//int number2=Convert.ToInt32((Console.ReadLine()));
//Console.WriteLine("3-cu ededini daxil et");
//int number3=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("4-cu ededini daxil et");
//int number4=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("5-ci ededini daxil et");
//int number5 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number1+number2+number3+number4+number5);
#endregion
#region
//Console.WriteLine("1 eded daxil edin");
//    int number=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Pow(number,2));
#endregion
#region
//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci ededi daxil et");
//int number2 =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3-cu ededi daxil et");
//int number3 = Convert.ToInt32(Console.ReadLine());
//if (number1>number2 && number1>number3)
//{
//    Console.WriteLine("1ci daxil edilen en boyuk ededdir");
//}
//else if (number2>number1 && number2>number3)
//{
//    Console.WriteLine("2ci daxil edilen en boyuk ededdir");
//}
//else if (number3>number1 && number3>number2)
//{
//    Console.WriteLine("3cu daxil edilen en boyuk ededdir");
//}
#endregion
#region
//Console.WriteLine("1-ci ededi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci ededi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (Math.Pow(number1, 3) > number2)
//{
//    Console.WriteLine("1-ci daxil edilen ededin kubu 2-ci daxil edilen ededden boyukdur");
//}
//else
//{
//    Console.WriteLine("1-ci daxil edilen ededin kubu 2-ci daxil edilen ededden kicikdir");
//}
#endregion
#region
//Console.WriteLine("Eded daxil et");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number%5==0 && number%3==0) {
//    Console.WriteLine("Eded hem 3-e hemde 5-e bolunur");
//}
//else
//{
//    Console.WriteLine("Eded hem 3-e hemde 5-e bolunmur");
//}
#endregion
#region
//Console.WriteLine("Kartdaki meblegi daxil et");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Mehsulun meblegi daxil et");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1>number2)
//{
//    Console.WriteLine("Kartdaki pulun meblegi mehsulu almaga kifayet edir");
//}
//else
//{
//    Console.WriteLine("Kartdaki pulun meblegi mehsulu almaga kifayet etmir");
//}
#endregion
#region
//Console.WriteLine("1-ci fennin balini daxil edin");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2-ci fennin balini daxil edin");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3-cu fennin balini daxil edin");
//int number3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("4-cu fennin balini daxil edin");
//int number4 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("5-ci fennin balini daxil edin");
//int number5 = Convert.ToInt32(Console.ReadLine());
//int ortalama = (number1 + number2 + number3 + number4 + number5) / 5;
//if (ortalama >= 65 && ortalama =< 100)
//{
//    Console.WriteLine("telebe smestri kecib");
//}
//else
//    Console.WriteLine("telebe smestri kecmeyib");
#endregion

#region
//Console.Writeline("1-ci ededi  daxil edin");
//int number1 = Convert.ToInt32(console.readline());
//Console.Writeline("2-ci ededi  daxil edin");
//int number2 = Convert.ToInt32(console.readline());
//if (number1 > 0 && number2 > 0)
//{
//    if (number1 > number2)
//    {
//        console.writeline("1-ci eded 2-ciden boyukdur");
//    }
//    else
//    {
//        Console.Writeline("2-ci eded 1-ciden boyukdur");
//    }
//}
//else
//{
//    Console.Writeline("1-i ve ya her ikisi natural eded deyil");
//}
#endregion
#region
//Console.WriteLine("suyun temperaturunu daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine("suyun donma temperaturundan yuxaridir");
//}
//else
//{
//    Console.WriteLine("suyun donma temperaturundan asagidir");
//}
#endregion
#region
//for (int i = 0; i <= 50; i++)
//{
//    Console.WriteLine(i);
//}
#endregion
#region
//int count = 0;
//for (int i=0; i<=40; i++)
//{
//  if (i%3==0)
//    { count++; }
//}
//Console.WriteLine(count);
#endregion
#region
//for (int i = 0; i <= 100; i++)
//{
//    if (i % 7 == 0 && i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    }
#endregion
#region
//Console.WriteLine("eded daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());
//int digit_count = 0;
//int TempNum = num;
//if (num == 0)
//{
//    digit_count = 1;
//}
//else
//{
//    while (TempNum != 0)
//    {
//        TempNum /= 10;
//        digit_count++;
//    }
//}
//Console.WriteLine(digit_count);
#endregion
#region
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//int temp = 0;
//while (number>0)
//{
//    temp = (temp * 10) + (number % 10);
//        number = number / 10;

//}
//Console.WriteLine(temp);
#endregion
#region
/*Console.WriteLine("eded daxil edin");
int number = Convert.ToInt32(Console.ReadLine());
int fakt = 1;
for (int i = 1; i <= number; i++)
{
    fakt = fakt * i;
}
Console.WriteLine(fakt);*/
#endregion

#region
//Console.Writeline("eded daxil edin");
//int number = Convert.ToInt32(Console.Readline());
//int fakt = 1;
//int i = 1;
//while (number >= i)
//{
//    fakt = fakt * i;
//    i++;
//}
//Console.Writeline(fakt);
#endregion


#region
//int n=Convert.ToInt32(Console.ReadLine());
//int squareroot=Convert.ToInt32(Console.ReadLine());
//bool isprimitive = true;
//for (int i=2; i<=squareroot; i++)
//{
//    if (n % i == 0)
//    {

//        isprimitive = false;
//        break;

//    }
//}
//if (isprimitive)
//{
//    Console.WriteLine("sade");
//}
//else
//{
//    Console.WriteLine("murekkeb");
//}
#endregion

#region
//Console.WriteLine ("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//int i = 0;
//int rem = 1;
//while (number > 0)
//{
//    rem = number % 10;
//    i = i + rem;
//    number=number / 10;
//}
//Console.WriteLine(i);
#endregion

#region
//Console.WriteLine("eded daxil edin");
//int number = Convert.ToInt32(Console.ReadLine());
//int rem = 1;
//int max = 0;
//while (number > 0)
//{
//    rem = number % 10;
//    if (rem > max)
//    {
//        max = rem;
//    }
//    number = number / 10;
//}
//Console.WriteLine(max);
#endregion
#region
//for (int i = 70; i >= 0; i = i - 2)
//{
//    Console.WriteLine(i);
//}
#endregion

#region
//Console.WriteLine("reqem olaraq ayi daxil edin");
//int say=Convert.ToInt32(Console.ReadLine());

//switch (say)
//{
//    case 1:
//        Console.WriteLine("Yanvar, Qis feslidi");
//        break;
//    case 2:
//        Console.WriteLine("Fevral, Qis feslidi");
//        break;
//    case 3:
//        Console.WriteLine("Mart, Yaz feslidir");
//        break;
//    case 4:
//        Console.WriteLine("Aprel, Yaz feslidir");
//        break;
//    case 5:
//        Console.WriteLine("May, Yaz feslidir");
//        break;
//    case 6:
//        Console.WriteLine("Iyun, Yay feslidir");
//        break;
//    case 7:
//        Console.WriteLine("Iyul, Yay feslidir");
//        break;
//    case 8:
//        Console.WriteLine("Avqust, Yay feslidir");
//        break;
//    case 9:
//        Console.WriteLine("Sentyabr, Payiz feslidir");
//        break;
//    case 10:
//        Console.WriteLine("Oktyabr, Payiz feslidir");
//        break;
//    case 11:
//        Console.WriteLine("Noyabr, Payiz feslidir");
//        break;
//    case 12:
//        Console.WriteLine("Dekabr, Qis feslidir");
//        break;
//    default:
//        Console.WriteLine("Daxil etdiyiniz ay yoxdu");
//        break;
//}
#endregion

#region
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(" ");
//}
#endregion

#region
//for (int i = 1; i <= 9; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine("");
//}
#endregion

#region
//for (int i = 9; i >= 0; i--)
//{
//    for (int j = i; j >= 0; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine (" ");
//}
#endregion