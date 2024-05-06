int rta; 
SuperHeroe superHeroe1 = new SuperHeroe("", "", 0, 0, 0);
SuperHeroe superHeroe2 = new SuperHeroe("", "", 0, 0, 0);

do
{
    Console.WriteLine("1. Cargar superheroe 1");
    Console.WriteLine("2. Cargar superheroe 2");
    Console.WriteLine("3. ¡PELEAR!");
    Console.WriteLine("4. Salir");
    rta = IngresarMenu("Ingrese una opción:");

    switch (rta)
    {
        case 1:
            superHeroe1 = ObtenerSuperheroe();
            Console.WriteLine($"Se creo al superheroe {superHeroe1.Nombre}");
            break;

        case 2:
            superHeroe2 = ObtenerSuperheroe();
            Console.WriteLine($"Se creo al superheroe {superHeroe2.Nombre}");
            break;

        case 3:
            double skill1 = superHeroe1.ObtenerSkill();
            double skill2 = superHeroe2.ObtenerSkill();
            Console.WriteLine(skill1 + " " + skill2);

            if (superHeroe1.Nombre == string.Empty || superHeroe2.Nombre == string.Empty)
            {
                Console.WriteLine("No se ha creado ningun superheroe.");
            }
            else
            {
                if (skill1 - skill2 > 30)
                {
                    Console.WriteLine($"Ganó {superHeroe1.Nombre} por amplia diferencia");
                } else if (skill2 - skill1 > 30)
                {
                    Console.WriteLine($"Ganó {superHeroe2.Nombre} por amplia diferencia");
                }
                else if (skill1 - skill2 > 10)
                {
                    Console.WriteLine($"Ganó {superHeroe1.Nombre}. Fue muy parejo");
                }else if (skill2 - skill1 > 10)
                {
                    Console.WriteLine($"Ganó {superHeroe2.Nombre}. Fue muy parejo");
                }
                else if (skill1 - skill2 > 0)
                {
                    Console.WriteLine($"Ganó {superHeroe1.Nombre} ¡No le sobró nada!");
                }else if (skill2 - skill1 > 0)
                {
                    Console.WriteLine($"Ganó {superHeroe2.Nombre} ¡No le sobró nada!");
                }
            }
            break;

        default:
            break;
    }

} while (rta != 4);


static int IngresarMenu (string mensaje){
    int numero;
    do
    {
        Console.WriteLine(mensaje);
        numero = int.Parse(Console.ReadLine());
    } while (numero > 4 || numero < 1);
    
    return numero;
}

static double IngresarAtributo (string mensaje){
    double num;
    do
    {
        Console.WriteLine(mensaje);
        num = double.Parse(Console.ReadLine());

    } while (num < 1 || num > 100);
    return num;
}

static double IngresarDouble (string mensaje){
    double num;
    do
    {
        Console.WriteLine(mensaje);
        num = double.Parse(Console.ReadLine());

    } while (num < 0);
    return num;
}

static string IngresarString (string mensaje){
    string msj;
    do
    {
        Console.WriteLine(mensaje);
        msj = Console.ReadLine();
    } while (msj == null);
    return msj;
}

static SuperHeroe ObtenerSuperheroe (){
    string nombre = IngresarString("ingrese el nombre:");
    string ciudad = IngresarString("Ingrese la ciudad de origen:");
    double peso = IngresarDouble("Ingrese el peso:");
    double fuerza = IngresarAtributo("Ingrese la fuerza (1-100):");
    double velocidad = IngresarAtributo("Ingrese la velocidad (1-100):");

    SuperHeroe nuevoSuperheroe = new SuperHeroe(nombre, ciudad, peso, fuerza, velocidad);
    return nuevoSuperheroe;
}
