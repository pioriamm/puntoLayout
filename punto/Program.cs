using System;
using System.Globalization;
using punto;

internal class Program
{
    private static void Main(string[] args)
    {
        String currentFilePath;
        String lerOutroArquvio = "s";


        while (lerOutroArquvio == "s" || lerOutroArquvio == "S") {
         
            Console.WriteLine("Informe o caminho do arquivo:");
            currentFilePath = Console.ReadLine();

            ReadFile readFile = new ReadFile(currentFilePath);
            readFile.showFormatedFile();
            Console.WriteLine(" ");
            Console.WriteLine("Deseja ler outro arquivo?  s ou n");
            lerOutroArquvio = Console.ReadLine();
        }

    } 
}