using System.Net;

Random random = new Random();

var discountPercentage = 0;
for (int i = 0; i == 1; i ++);
while(true){
var daysUntilExpiration = random.Next(12);

Console.Clear();
Console.WriteLine("Numero de dias que expire: " + daysUntilExpiration);
if (daysUntilExpiration > 5){
    Console.WriteLine("Tu suscripcion esta a punto de expirar")
}
else if(daysUntilExpiration <= 5 && daysUntilExpiration > 1){
    Console.WriteLine("Your subscription will in " + daysUntilExpiration + " days. Renew now and save 10%");
}
else if (daysUntilExpiration == 1 ){
    Console.WriteLine("Tu suscripcion expira hoy. Renueva y ahorrate un" + discountPercentage + "%");

}
else{
Console.WriteLine("Tu suscripcion ha expirado");
}

}
var tecla = Console.ReadKey();
if(tecla.KeyChar == 'x');
