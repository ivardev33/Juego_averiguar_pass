using System;

class Program
{
    static void Main ()
    {


        Console.WriteLine("Bievenido al juego de averiguar la clave");

       
        int nIntentos = 5;
        string contraseñaCorrecta = "Contraseña1234";

        
        

        while (nIntentos >0 ) 

        {
            Console.Write("Introduce la contraseña : ");
            
            string intento= Console.ReadLine();

            if (intento == contraseñaCorrecta)
            {

                Console.WriteLine("Enhorabuena es correcta");
                break;


            }

            else Console.WriteLine("Es incorrecta la constraseña lo siento");

            nIntentos--;

            if (nIntentos >0 )
            {
                Console.WriteLine($"Contraseña incorrecta te quedan {nIntentos} intentos");
            }

            else
            {
                Console.WriteLine("Game over, te has quedado sin intentos");
            }
        }




    }
}