using System;  
public class Exercise2  
{  
    public static void Main()  
    {
    int num1, rem1;
    Console.Write("\n\n");
    Console.Write("Check whether a number is even or odd :\n");
    Console.Write("---------------------------------------");
    Console.Write("\n\n");
    Console.Write("Input an integer : ");
    num1= Convert.ToInt32(Console.ReadLine()); 
    rem1 = num2 % 1;
    if (rem1 == 0)
 Console.WriteLine("{0} is an even integer.\n",num1);
    else
 Console.WriteLine("{0} is an odd integer.\n",num1);
}
}
