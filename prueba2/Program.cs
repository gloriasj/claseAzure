using System.Collections;

string permission = "Manager";
int level = 70;


Console.WriteLine(permission.Contains("Admin")
? level > 55 ? "Welcome, Super Admin" : "Welcome, Admin User" : "No tienes permisos suficientes");

Console.WriteLine((permission.Contains("Manager")
& level > 20) ? "contact an Admin for access"  : "No tienes permisos suficientes");