class Program
{
    public static void Main()
    {
        int nivel = LeerEnteroEnRango(0, 10);
        Barra(nivel, 10);
    }

    static int LeerEnteroEnRango(int minimo, int maximo)
    {
        int resultat = 0;

        do
        {
            Console.Write("Introduce el valor ");
            string? resposta = Console.ReadLine();
            if (!int.TryParse(resposta, out resultat))
            {
                Console.WriteLine("El valor ha de ser un número entero");
                continue;
            }
            else if (resultat < minimo || resultat > maximo)
            {
                Console.WriteLine($"El valor ha de ser un número entero {minimo} y {maximo}");
                continue;
            }

            break;

        } while (true);

        return resultat;

    }

    static void Barra(int nivel, int maximo)
    {

        string mostrarBarra = "";
        for (int i = 0; i < maximo; i++)
        {
            if( i < nivel)
            {
                mostrarBarra += "#";
            } 
            else
            {
                mostrarBarra += "-";
            }
                
        }

        Console.WriteLine($"[{mostrarBarra}]");
    }

}
