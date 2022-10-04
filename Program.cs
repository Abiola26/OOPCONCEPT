// See https://aka.ms/new-console-template for more information
using OOPCONCEPT;

Console.WriteLine("Hello, World!");

Module1 M1 = new Module1();
Module2 M2 = new Module2();
Module3 M3 = new Module3();

double g = M1.Product(3, 2);
Console.WriteLine(g);

double J = M2.Division(3, 2);
Console.WriteLine(J);

double f = M3.Sum(3, 2, 2, 4, 6);
Console.WriteLine(f);
