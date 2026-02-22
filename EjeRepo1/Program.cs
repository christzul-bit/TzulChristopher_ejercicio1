//programa con repo 1
Console.WriteLine("Ingrese el tipo de atención \n" +
    "1)Emergencia \n" +
    "2)Consulta \n" +
    "3) Pediatria \n" +
    "4)Traumatología_");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la edad del paciente_");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la temperatura en °C_");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la saturacion de oxigeno_");
double oxigeno = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nivel de dolor en el rango 1-10_");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la tensión sistólica_");
double tension = double.Parse(Console.ReadLine());

