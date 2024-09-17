int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
//Console.WriteLine($"coin: {((coin.Next(0,2) == 0  ? "heads" : "tails"))}
while(true) {Console.WriteLine(new Random().Next(0,2) < 1 ? "cara" : "cruz"); Console.ReadKey();}
