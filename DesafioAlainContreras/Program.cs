// See https://aka.ms/new-console-template for more information
string nombreAlumno = "Alain Dzaul";
string apellidoAlumno = "Contreras Olea";
long DNI = 12345678910;
int edadAlumno = 25;
double alturaAlumno = 1.75;
string alturaAlumnos = alturaAlumno + " m";

Console.WriteLine("Nombre del alumno: " + nombreAlumno);
Console.WriteLine("Apellido del alumno: " + apellidoAlumno);
Console.WriteLine("DNI del alumno: " + DNI);
Console.WriteLine("Edad del alumno: " + edadAlumno);
Console.WriteLine("Altura del alumno: "+alturaAlumnos);
Console.WriteLine("Write any value:");
string askedValue = Console.ReadLine();
Console.WriteLine("You typed: "+"'"+askedValue+"'");

Console.WriteLine("Type first number to add: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Second number to add: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
int sum = firstValue + secondValue;
Console.WriteLine("The sum of both numbers is: " + sum);

