///INCREMENTO Y DECREMENTO


//int value = 0;    //value is now 0
//value = value + 5; //value is now 5
//value +=5;          //value is now 10


//int value = 0;    //value is now 0
//value = value + 1; //value is now 1
//value ++;          //value is now 2

/// -----------------------------------------------------------///


///AUMENTAR Y DISMINUIR UN VALOR
 int value = 1;
 value = value + 1;
 Console.WriteLine("Primer incremento: " + value);
value += 1;
 Console.WriteLine("Primer incremento: " + value);
value++;
 Console.WriteLine("Primer incremento: " + value);
 value = -1;
 Console.WriteLine("Primer incremento: " + value);
 value -=1;
 Console.WriteLine("Primer incremento: " + value);
value--;
 Console.WriteLine("Primer incremento: " + value);

/// -----------------------------------------------------------///

//CALCULO GRADOS FAHRENHEIT A CELSIUS
var FAHRENHEIT = 94;
var CELSIUS = (FAHRENHEIT - 32m) * (5m / 9m);
Console.WriteLine("La temperatura es " + Math.Round(CELSIUS,1) + "CELSIUS");
Console.WriteLine("La temperatura es " + CELSIUS.ToString ("##.#") + "CELSIUS");
Console.WriteLine("La temperatura es " + decimal.Round(CELSIUS,1) + "CELSIUS");