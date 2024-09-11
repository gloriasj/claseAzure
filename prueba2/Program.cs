using System.Text;
Console.OutputEncoding= Encoding.UTF8;
/*Console.WriteLine("Hello, World!");
Console.WriteLine("Congtratulations");
Console.WriteLine("  ");
Console.WriteLine("you wrote your first lines of code");

Console.WriteLine("Es la primera linea");
Console.WriteLine("Es la segunda linea");

Console.Write('b');

Console.WriteLine("123");
Console.WriteLine(123);*/

//CREACION DE LA PRIMERA VARIABLE

string firstName;
//firstName= "";
//Console.WriteLine(firstName);
firstName="Gloria";
Console.WriteLine(firstName);
firstName="Bob";
Console.WriteLine(firstName);
firstName="Isabella";
Console.WriteLine(firstName);
firstName="Yasmin";
Console.WriteLine(firstName);

var message="hello";

//1EJERCICIO
var name="Bob";
var number=3;
var number2 =32.1;
Console.Write("Hello, mi name is " +  name  +  " i have " +  number  +  " now " +   number2);
//OTRA MANERA DE HACERLO
//string name2= "Bob";
//int num1=3;
//decimal num2= 32.4m;

//COMBINACION DE CADENAS
string secondName="Dylan";
string greeting= "Hello";
//string message = greeting + " " + firstName + "!";
string message2= $"{greeting} {secondName}!";
Console.WriteLine(message2);



//Console.Clear();
int version = 11;
string updateText = "Update to Windows";
message2=$"{greeting} {version.ToString()}!";

Console.WriteLine(message2);

Console.Clear();
string projectName = "First project";
var path = $@"C:\Output\{projectName}\Data";
Console.WriteLine(path);




