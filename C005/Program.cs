// Задать рандомное вещественное чисело
double test = new Random().NextDouble();
System.Console.WriteLine(test);
test*=100;
System.Console.WriteLine(Math.Round(test,3));
// 5 строка округление до 3 знаков после запятой