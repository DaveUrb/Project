using System;

namespace project
{
    class Program
    {
        public struct Product
        {
            public string Name;
            public double Pr1pc;
            public double Pr1kg;
        }
       
        private static void Main(string[] args)
        {
            Console.Clear();
            //Deklaracja produktów i specyfikacji
            Product prod1 = new();
            Product prod2 = new();
            Product prod3 = new();
            Product prod4 = new();
            Product prod5 = new();
            //Prod1
            prod1.Name = "Chlyb";
            prod1.Pr1pc = 6.30;
            prod1.Pr1kg = 8.00;
            //Prod2
            prod2.Name = "Ciostko";
            prod2.Pr1pc = 1.20;
            prod2.Pr1kg = 48.70;
            //Prod3
            prod3.Name = "Sernik";
            prod3.Pr1pc = 12.30;
            prod3.Pr1kg = 47.10;
            //Prod4
            prod4.Name = "Szynka";
            prod4.Pr1pc = 7.50;
            prod4.Pr1kg = 28.20;
            //Prod5
            prod5.Name = "Kremowka";
            prod5.Pr1pc = 13.37;
            prod5.Pr1kg = 21.37;

            string ShowProducts()
            {
                Console.WriteLine($"\n");
                Console.WriteLine($"[1] {prod1.Name} {prod1.Pr1pc}zł/szt, {prod1.Pr1kg}zł/kg");
                Console.WriteLine($"[2] {prod2.Name} {prod2.Pr1pc}zł/szt, {prod2.Pr1kg}zł/kg");
                Console.WriteLine($"[3] {prod3.Name} {prod3.Pr1pc}zł/szt, {prod3.Pr1kg}zł/kg");
                Console.WriteLine($"[4] {prod4.Name} {prod4.Pr1pc}zł/szt, {prod4.Pr1kg}zł/kg");
                Console.WriteLine($"[5] {prod5.Name} {prod5.Pr1pc}zł/szt, {prod5.Pr1kg}zł/kg");
                return "";
            }
            string Seller()
            {
                ShowProducts();
                string ChosenProduct;
                int ChosenUnit;
                Console.Write("Wskaż wybrany produkt:");
                int Choice = Convert.ToInt32(Console.ReadKey());
                switch(Choice)
                {
                    case 1:
                        ChosenProduct = prod1.Name;
                        break;
                    case 2:
                        ChosenProduct = prod2.Name;
                        break;
                    case 3:
                        ChosenProduct = prod3.Name;
                        break;
                    case 4:
                        ChosenProduct = prod4.Name;
                        break;
                    case 5:
                        ChosenProduct = prod5.Name;
                        break;
                }
                Console.WriteLine("Podaj jednostkę.");
                Console.WriteLine("[1] Sztuka");
                Console.WriteLine("[2] Kilogram");
                ChosenUnit = Convert.ToInt32(Console.ReadKey());
                
                return "";

            }
            ShowProducts();
            Console.ReadKey();
            Main(args);
            
        }
        
    }
}
