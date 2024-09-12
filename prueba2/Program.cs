//SUMAS CON CONVERSION IMPLICITA DE DATOS

using System.Data;

int firstNUmber = 12;
int secondNumber = 7;
Console.WriteLine(firstNUmber + secondNumber);

string nombre ="Bob";
int widgetsSold= 7;
Console.WriteLine (nombre + " sold " + widgetsSold + " widgets ");
///<concatena el +7, es decir, quedaria igual a 77>
Console.WriteLine(nombre + " sold " + widgetsSold + 7 + " widgets ");
/// <con el parentisis se convierte en otra operacion lo que daria 7+7+14> 
Console.WriteLine(nombre + " sold " + (widgetsSold + 7) + " widgets ");

//EJERCICIOS
//SUMA RESTA MULTIPLICACION Y DIVISION
 int num1 = 10;
 int num2 = 6;
int resto= num1 % num2;
 Console.WriteLine(num1 + num2);
 Console.WriteLine(num1 - num2);
 Console.WriteLine(num1 * num2);
 Console.WriteLine(num1 / num2);
 //division de enteros sacando el resultado de 
 Console.WriteLine((decimal)num1 / (decimal)num2);
 //resto de la division
 Console.WriteLine(resto);

///DIVISION CON DATOS DECIMALES
 
double number = 10.2;
double number2 =  2.5;
Console.WriteLine( number / number2);

/// ANAIDIR LA DIVISION UTILIZANDO DATOS DECIMALES
decimal de = (decimal) firstNUmber / (decimal) secondNumber;

///SACAR EL RESTO DE UNA DIVISION
///int dividiendo= 20;
///int divisor= 6;
//int resto = dividiendo % divisor;
///Console.WriteLine(dividiendo / divisor % resto);


