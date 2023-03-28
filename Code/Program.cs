using System;

  public class Program{
    static void Main(string[] args){
      //CelsiusToFahrenheit();
      //InputFactorial();
      //InputFibonacci();
      // PassByRef();
      //InputTextShuffle();
    }


    //CelsiusToFahrenheit----------------------------------------------
    public static void CelsiusToFahrenheit(){
      double celsius = double.Parse(Console.ReadLine());
      double Fahrenheit = Convert_CelsiusToFahrenheit(celsius);
      Console.WriteLine(Fahrenheit);
    }

    public static double Convert_CelsiusToFahrenheit(double celsius){
      return (9.0 * celsius /5.0) + 32.0;
    }
    //CelsiusToFahrenheit-END------------------------------------------

    //Factotial--------------------------------------------------------
    public static void InputFactorial(){
      int num = int.Parse(Console.ReadLine());
      Console.WriteLine(Factotial(num));
    }

    public static int Factotial(int num){
      int result = 1;
      if(num > 1){
        result = num * Factotial(num - 1);
      }
      return result;
    }
    //Factotial-END----------------------------------------------------

    //Fibonacci--------------------------------------------------------

    public static void InputFibonacci(){
      int number = int.Parse(Console.ReadLine());
      for(int i = 0; i <= number; i++){
        Console.Write("{0}, ", Fibonacci(i)); 
      }
    }
    
    public static int Fibonacci(int number){
      if(number == 0 || number == 1){
        return number;
      }
      return Fibonacci(number - 1) + Fibonacci(number - 2);
    }
    //Fibonacci-END----------------------------------------------------

    //PassByRef--------------------------------------------------------
    static void PassByRef(){
      int number = 1;
      Add(ref number);
      Console.WriteLine(number);
    }

    static void Add(ref int refArg){
      refArg = refArg + 44;
    }
    //PassByRef-END----------------------------------------------------
  
    //TextShuffle------------------------------------------------------
    static void InputTextShuffle(){
      string text1 = Console.ReadLine();
      string text2 = Console.ReadLine();
      string text3 = Console.ReadLine();
      int number = int.Parse(Console.ReadLine());

      while(number > 0){
      TextShuffle(ref text1,ref text2,ref text3,number);
      number--;
      }

      Console.WriteLine(text1);      
      Console.WriteLine(text2);
      Console.WriteLine(text3);
    }

    static void TextShuffle(ref string text1,ref string text2,ref string text3,int number){
      string top = text1;
      text1 = text2;
      text2 = text3;
      text3 = top;
    }
    //TextShuffle-END--------------------------------------------------
  }