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

                int[] numeri = { 2, 6, 7, 5, 3, 9 };

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

                
                StampaArray(numeri);
            

                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                //FUNZIONE QUADRATO
                //int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.
                //Console.WriteLine("Seconda funzione Quadrato");
                Console.WriteLine("Seconda funzione Quadrato");

                int numero;

                Console.WriteLine("Inserisci numero");
                numero = Convert.ToInt32(Console.ReadLine());


                int Quadrato( int numero)
                {
                    return numero * numero;
                }

                int risultatoQuadrato = Quadrato(numero);
                Console.WriteLine($"Il quadrato del numero passato è: {risultatoQuadrato}");
            

                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            
                //FUNZIONE ARRAY AL QUADRATO
                //int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi,
                //restituisca un nuovo array con tutti gli elementi elevati quadrato. 
                
                Console.WriteLine("Terza funzione Array Quadrato");

                int[] array = { 2, 6, 7, 5, 3, 9 };
                Console.Write("Array originale: ");
                StampaArray(array);

                //SPAZIO
                Console.WriteLine();

                int[] ElevaArrayAlQuadrato(int[] array)
                {
                    int[] risultato = new int[array.Length];

                    for (int i = 0;  i < array.Length;  i++)
                    {
                        risultato[i] = Quadrato(array[i]);
                    }

                    return risultato;
                }


                //array al quadrato
                int []risultatoArray = ElevaArrayAlQuadrato(array);
                Console.Write("Array al quadrato: ");
                StampaArray(risultatoArray);


                //SPAZIO
                Console.WriteLine();

                



                //SOLO PER CREARE SPAZIO(x leggibilità)
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            

                //FUNZIONE ARRAY SOMMA
                //int sommaElementiArray(int[] array)**:
                //che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

                Console.WriteLine("Quarta funzione Array Somma");

                int[] arraySomma = { 2, 6, 7, 5, 3, 9 };

                //richiamo variabile 
                int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arraySomma);

                int sommaElementiArray(int[] arrayAlQuadrato)
                {
                    int somma = 0;

                    for(int i = 0; i < arrayAlQuadrato.Length; i++)
                    {
                         somma += arrayAlQuadrato[i];
                    }

                    return somma;
                }

                int sommaOriginale = sommaElementiArray(arraySomma);
                Console.WriteLine($"Somma di tutti i numeri nell'array originale: {sommaOriginale}");
          

                int risultato = sommaElementiArray(arrayAlQuadrato);
                Console.WriteLine($"Risultato della somma dell'array modificata al quadrato: {risultato}");

                //SPAZIO
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("BONUS");


                /////////////////
                    //BONUS
                ////////////////
               

                Console.WriteLine("Quanti numeri vuoi inserire?");
                int lunghezzaArray = Convert.ToInt32(Console.ReadLine());

                //SPAZIO
                Console.WriteLine();

                int[] arrNum = new int[lunghezzaArray];

                Console.WriteLine("Inserisci i numeri:");

                for (int i = 0; i < lunghezzaArray; i++)
                {
                    Console.Write($"Numero {i + 1}: ");
                    arrNum[i] = Convert.ToInt32(Console.ReadLine());
                }

                //SPAZIO
                Console.WriteLine();
                Console.WriteLine();

                //stampa array
                Console.WriteLine("Ecco il tuo array del Bonus: ");
                StampaArray(arrNum);

                //SPAZIO
                Console.WriteLine();
                Console.WriteLine();

                //stampa array al quadrato
                int[] risultatoArrNum = ElevaArrayAlQuadrato(arrNum);
                Console.WriteLine("Array al quadrato del Bonus: ");
                StampaArray(risultatoArrNum);

                //SPAZIO
                Console.WriteLine();
                Console.WriteLine();

                int sommaOriginaleArrNum = sommaElementiArray(arrNum);
                Console.WriteLine($"Somma di tutti i numeri nell'array originale del Bonus: {sommaOriginaleArrNum}");

                int sommaArrNumQuadrato = sommaElementiArray(risultatoArrNum); 
                Console.WriteLine($"Risultato della somma dell'array modificata al quadrato: {sommaArrNumQuadrato}");

            }

        }
    }
}
