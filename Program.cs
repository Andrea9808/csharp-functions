using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {   
                //FUNZIONE STAMPA ARRAY
                //void StampaArray(int[] array) * *: che preso un array di numeri interi,
                //stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
                Console.WriteLine("Prima funzione StampaArray");
                void StampaArray(int[] array)
                {
                    Console.Write("[");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"elemento {array[i]} ");
                        if (i < array.Length - 1)
                            Console.Write(", ");
                    }
                    Console.Write("]");
                }

                int[] numeri = { 2, 6, 7, 5, 3, 9 };
                StampaArray(numeri);
            }

                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            {
                //FUNZIONE QUADRATO
                //int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.
                Console.WriteLine("Seconda funzione Quadrato");

                int numero;

                Console.WriteLine("Inserisci numero");
                numero = Convert.ToInt32(Console.ReadLine());


                int Quadrato( int numero)
                {
                    return numero * numero;
                }

                int risultato = Quadrato(numero);
                Console.WriteLine($"Il quadrato del numero passato è: {risultato}");
            }

                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            {
                //FUNZIONE ARRAY AL QUADRATO
                //int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi,
                //restituisca un nuovo array con tutti gli elementi elevati quadrato. 
                
                Console.WriteLine("Terza funzione Array Quadrato");

                int[] array = { 2, 6, 7, 5, 3, 9 };

                int[] ElevaArrayAlQuadrato(int[] array)
                {
                    int[] risultato = new int[array.Length];

                    for (int i = 0;  i < array.Length;  i++)
                    {
                        risultato[i] = array[i] * array[i];
                    }

                    return risultato;
                }

                int []risultatoArray = ElevaArrayAlQuadrato(array);

                
                Console.Write("Array al quadrato: ");
                for (int i = 0; i < risultatoArray.Length; i++)
                {
                    Console.Write(risultatoArray[i] + " ");
                }

            }

                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            {

                //FUNZIONE ARRAY SOMMA
                //int sommaElementiArray(int[] array)**:
                //che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

                Console.WriteLine("Quarta funzione Array Somma");

                int[] array = { 2, 6, 7, 5, 3, 9 };
                

                int sommaElementiArray(int[] array)
                {
                    int somma = 0;

                    for(int i = 0; i < array.Length; i++)
                    {
                         somma += array[i];
                    }

                    return somma;
                }

                int risultato = sommaElementiArray(array);
                Console.WriteLine(risultato);
            }

        }
    }
}
