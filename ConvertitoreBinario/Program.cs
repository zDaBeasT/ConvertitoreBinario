using System;

namespace ConvertitoreBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, divisore;
            Console.Write("Inserisci il numero decimale:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il valore con cui vuoi dividere:");
            divisore = Convert.ToInt32(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                resto = num % divisore;
                num /= divisore;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"Il numero binario corrisponde a: {binario}");
            Console.ReadLine();
        }
    }
}
