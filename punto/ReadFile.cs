using System;
using System.IO;
using System.Net.NetworkInformation;

namespace punto
{
    public class ReadFile
    {
        List<String> rowFile = new List<String>();
        List<String> formatedFile = new List<String>();

        LayoutPunto layoutPunto = new LayoutPunto();


        public ReadFile(string path)
        {
            checkingFilePath(path.Replace("\\", "\\\\"));

        }

        void checkingFilePath(String pathFile)
        {

            if (!String.IsNullOrWhiteSpace(pathFile))
            {

                try
                {

                    using (StreamReader sr = new StreamReader(pathFile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string? valueString = sr.ReadLine();
                            rowFile.Add(valueString ?? "oi");
                            formatingByLayout(valueString ?? "oi");
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
                }
                Console.WriteLine(" ");
                Console.WriteLine("O arquivo lido.");
                Console.WriteLine("______________________________________________________________________________________________________________________________");
                Console.WriteLine(" ");

            }
            
        }

        void formatingByLayout(String valueString) {

            String first = valueString.Substring(0,2).Trim();

            switch (first)
            {
                case "A0":
                    formatedFile.Add(layoutPunto.A0(valueString));
                    break;
                case "L0":
                    formatedFile.Add(layoutPunto.L0(valueString));
                    break;
                case "CV":
                    formatedFile.Add(layoutPunto.CV(valueString));
                    break;
                case "AJ":
                    formatedFile.Add(layoutPunto.AJ(valueString));
                    break;
                case "CC":
                    formatedFile.Add(layoutPunto.CC(valueString));
                    break;
                case "L9":
                    formatedFile.Add(layoutPunto.L9(valueString));
                    break;
                case "A9":
                    formatedFile.Add(layoutPunto.A9(valueString));
                    break;
            }

        }

        public void showFormatedFile()
        {
            
            foreach (String line in formatedFile){
                Console.WriteLine(line);
            }
        }
    }
}