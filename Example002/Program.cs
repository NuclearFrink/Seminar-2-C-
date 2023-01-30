// найти координаты x y
int numX = 0;
int numY = 0;

Console.WriteLine("Задайте X,  ");
numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте Y,  ");
numY = Convert.ToInt32(Console.ReadLine());


if ((numX > 0) && (numY > 0)) Console.WriteLine("Точка в плоскости I ");
if ((numX < 0) && (numY > 0)) Console.WriteLine("Точка в плоскости II ");
if ((numX < 0) && (numY < 0)) Console.WriteLine("Точка в плоскости III ");
if ((numX > 0) && (numY < 0)) Console.WriteLine("Точка в плоскости IV ");