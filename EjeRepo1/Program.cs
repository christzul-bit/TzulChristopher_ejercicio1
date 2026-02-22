//programa con repo 1
int prioridad = 0;
string sugerencia = "";
Console.WriteLine("Ingrese el tipo de atención \n" +
    "1)Emergencia \n" +
    "2)Consulta \n" +
    "3)Pediatria \n" +
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
if (edad >= 0 && edad <= 100 && temperatura > -100 && temperatura < 100 && oxigeno > 0 && dolor >= 1 && dolor <= 10 && tension > 0) { 
    switch(opcion)
    {
        case 1:
            //se sumara en 1 la prioridad por cada caso que se presente, al ser una emergencia la prioridad empieza con 3
            prioridad += 3;
            if(oxigeno < 90){prioridad += 1;}
            if(edad > 60) { prioridad += 1;}
            if(temperatura > 37) { prioridad += 1;}
            if(tension >= 140) { prioridad += 1;}
            if(dolor >= 5) {  prioridad += 1;}
            break;
        case 2:
            if (oxigeno < 90) { prioridad += 1; }
            if (edad > 60) { prioridad += 1; }
            if (temperatura > 37) { prioridad += 1; }
            if (tension >= 140) { prioridad += 1; }
            if (dolor >= 5) { prioridad += 1; }
            break;
        case 3:
            if(edad < 18)
            {
                prioridad += 1;
                if (oxigeno < 90) { prioridad += 1; }
                if (edad < 6) { prioridad += 1; }
                if (temperatura > 37) { prioridad += 1; }
                if (tension >= 140) { prioridad += 1; }
                if (dolor >= 5) { prioridad += 1; }
            }
            else
            {
                Console.WriteLine("El pasiente no es un niño");
                prioridad -= 1;
            }
            break;
        case 4:
            prioridad += 2;
            if (oxigeno < 90) { prioridad += 1; }
            if (edad > 60) { prioridad += 1; }
            if (temperatura > 37) { prioridad += 1; }
            if (tension >= 140) { prioridad += 1; }
            if (dolor >= 5) { prioridad += 1; }
            break;
        default: { Console.WriteLine("Opcion invalida"); break;}
    }
    if(prioridad < 0)
    {
        sugerencia = "No se tiene sugerencia";
    }else if(prioridad < 4)
    {
        sugerencia = "Consulta normal";
    }else if(prioridad < 6)
    {
        sugerencia = "Ateción necesaria";
    }else { sugerencia = "Emergencia total"; }
    Console.WriteLine($"El nivel de prioridad es {prioridad} \n" +
        $"se recomienda: {sugerencia}");
}else
{
    Console.WriteLine("Una o varios valores son invalidos, verifique bien sus respuestas");
}
