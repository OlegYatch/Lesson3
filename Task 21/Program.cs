//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A x1 ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б x2 ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты A y1 ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Б y2 ");
int y2 = int.Parse(Console.ReadLine());


Console.WriteLine("Введите координаты точки A z1 ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б z2 ");
int z2 = int.Parse(Console.ReadLine());
 double Distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
 Console.WriteLine($"Расстоягие от точки А до точки Б по заданным координатам {Distance}");
