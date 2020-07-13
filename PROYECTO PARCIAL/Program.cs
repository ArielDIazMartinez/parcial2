using System;

namespace Sistema_de_votaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear una aplicación para un sistema de votaciones. 
      Caracteristicas:
          -Cantidad de candidatos 4
         - Cantidad de votos 1,000, estos seran de forma aleatoria.
         - Los resultados se mostraran(Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
         - El sistema es tipo consola en C#.
         -Datos candidato: Partido, Nombre completo, poscición a la que aspira(presidente).
         -Partidos: Fecha de fundacion(ficticia), Nombre completo y siglas */


            Random numeroaleatorio = new Random();

            int Numero1 = 1001;             
            int[] DatosAlready = new int[4];
            for (int i = 0; i != DatosAlready.Length; i++)
            {
                DatosAlready[i] = numeroaleatorio.Next(0, Numero1); ;
                Numero1 = Numero1 - DatosAlready[i];
            }
            double[] PORCENTAJE = new double[4];
            for (int i = 0; i != PORCENTAJE.Length; i++)
            {
                PORCENTAJE[i] = Convert.ToDouble(DatosAlready[i]);
                PORCENTAJE[i] = (PORCENTAJE[i] * 100) / 1000;
            }
            ReverseIntegerArray(DatosAlready);
            ReverseDoubleArray(PORCENTAJE);

            

            Console.WriteLine("(1)Danilo Medina {Aspira Presidente} ");
            Console.WriteLine($"(Partido de las gallinas  hogareñas) PGH (03-01-2001)  voto: {DatosAlready[0]}  porcentaje: {PORCENTAJE[0]}%");
            Console.WriteLine();

            Console.WriteLine("(2)Gonzalo el penco {Aspira Presidente}");
            Console.WriteLine($"(Partido de los Pollito Pio) PPP  (29-06-1998)  voto: {DatosAlready[1]}  porcentaje: {PORCENTAJE[1]}%");
            Console.WriteLine();

            Console.WriteLine("(3)Chusflay nothing {Aspira Presidente} ");
            Console.WriteLine($"(Partido de las Cantinas de  arroz) PCA  (02-03-1926)  voto: {DatosAlready[2]}  porcentaje: {PORCENTAJE[2]}%");
            Console.WriteLine();

            Console.WriteLine("(4)Ariel diaz Martinez {Aspira Presidente}");
            Console.WriteLine($"(Partido de los Pencos del Esprimidor) PPE  (21-02-2005)  voto: {DatosAlready[3]}  porcentaje: {PORCENTAJE[3]}%");
            Console.WriteLine();


             void NombreCandidato(string PARTIDO, string NOMBRE)
            {
                Console.WriteLine($"({PARTIDO}) {NOMBRE} aspira a: (* President * )");
            }           
            {
                Console.WriteLine("");
            }
            void ReverseIntegerArray(int[] num)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Array.Sort(num);
                    Array.Reverse(num);
                }
            }
            void ReverseDoubleArray(double[] num)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Array.Sort(num);
                    Array.Reverse(num);
                }
            }
            Console.ReadKey();
        }
        

        
        
    }
    
}