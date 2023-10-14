
// Matriz Aleatoria

static void RandomArray() 
{
    Random numAleatorio = new Random();
    int[] arregloAleatorio = new int[10];
    int sumaAleatorio = 0;

    for (int i = 0; i < arregloAleatorio.Length; i++)
    {
        arregloAleatorio[i] = numAleatorio.Next(5, 26);
        sumaAleatorio += arregloAleatorio[i];
        Console.WriteLine($"Número aleatorio entre 5 y 25: {arregloAleatorio[i]}");
    }

    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"El total de la suma de los números aleatorio es: {sumaAleatorio}");
}

RandomArray();

Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------------------------------------------");

// Lanzamiento de Moneda

static string TossCoin() 
{
    // Console.WriteLine("¡Tirando una moneda!");

    Random monedaAleatorio = new Random();
    int moneda = monedaAleatorio.Next(1, 3);
    string ladoMoneda;

    if (moneda == 1) 
    {
        Console.WriteLine("¡Tirando una moneda!");
        // Console.WriteLine("Cara");
        ladoMoneda = "Cara";
    }
    else 
    {
        Console.WriteLine("¡Tirando una moneda!");
        // Console.WriteLine("Cruz");
        ladoMoneda = "Cruz";
    }

    return ladoMoneda;
}

//  TossCoin();

static void TossMultipleCoins(int num)
{
    string[] numeroLanzamiento = new string[num];
    double mediaLanzamiento;
    int cantidadLanzamientoCabeza = 0;
    
    for (int i = 0; i < numeroLanzamiento.Length; i++)
    {
        numeroLanzamiento[i] = TossCoin();
        if (numeroLanzamiento[i] == "Cara")
        {
            cantidadLanzamientoCabeza++;
        }

        Console.WriteLine(numeroLanzamiento[i]);
    }
    
    mediaLanzamiento = (double)cantidadLanzamientoCabeza / (double)numeroLanzamiento.Length;
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"La relación entre los lanzamientos de cabezas ({cantidadLanzamientoCabeza}) y el total de lanzamientos ({numeroLanzamiento.Length}) es: {mediaLanzamiento}");
}

TossMultipleCoins(10);

Console.WriteLine("---------------------------------------------");
Console.WriteLine("---------------------------------------------");

// Nombres

static void Nombres()
{
    List<string> listaNombres = new List<string>() 
    {
        "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney"
    };
    
    List<string> ordenListaNombres = new List<string>();
    Random numeroAleatorio = new Random();
    int j;
    bool conteo = false;

    foreach (string nombre in listaNombres)
    {
        Console.WriteLine($"Nombre de la lista: {nombre}");
    }

    Console.WriteLine("---------------------------------------------");

    for (int i = 0; i < listaNombres.Count; i++)
    {
        numeroAleatorio.Next(0, listaNombres.Count);
        
        if (listaNombres[i].Length > 5) 
        {
            Console.WriteLine($"Nombre con más de 5 carácteres: {listaNombres[i]}");
        } 
    }

    Console.WriteLine("---------------------------------------------");

    while (ordenListaNombres.Count < listaNombres.Count)
    {
        j = numeroAleatorio.Next(0, listaNombres.Count);

        if (ordenListaNombres.Count > 0)
        {
            for (int i = 0; i < ordenListaNombres.Count; i++)
            {
                if (ordenListaNombres[i] != listaNombres[j])
                {
                    if (conteo == false && i == (ordenListaNombres.Count - 1))
                    {
                        ordenListaNombres.Add(listaNombres[j]);
                    }
                }
                else
                {
                    conteo = true;
                }
            }

            conteo = false;
        }
        else 
        {
            ordenListaNombres.Add(listaNombres[j]);
        }
    }

    foreach (string orderNombre in ordenListaNombres)
    {
        Console.WriteLine($"Nombre ordenado al azar: {orderNombre}");
    }
}

Nombres();

Console.WriteLine("---------------------------------------------");