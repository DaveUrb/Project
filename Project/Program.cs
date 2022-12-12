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
            Console.WriteLine("Kasjerkomat 1.0");
            Console.WriteLine("Rozpocznij od pierwszego klienta.");
            string ChosenProduct="";
            double ChosenProductPr1pc = 0;
            double ChosenProductPr1kg = 0;
            int ChosenUnit;
            double amountKg = 0;
            int amountPc=0;
            double price=0;
            double amount = 0;
            string row;
            double rowSum = 0;
            var cart = new List<string>();
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
                //Wyświetl wszystkie produkty
                Console.WriteLine($"\n");
                Console.WriteLine($"[1] {prod1.Name} {prod1.Pr1pc}zł/szt, {prod1.Pr1kg}zł/kg");
                Console.WriteLine($"[2] {prod2.Name} {prod2.Pr1pc}zł/szt, {prod2.Pr1kg}zł/kg");
                Console.WriteLine($"[3] {prod3.Name} {prod3.Pr1pc}zł/szt, {prod3.Pr1kg}zł/kg");
                Console.WriteLine($"[4] {prod4.Name} {prod4.Pr1pc}zł/szt, {prod4.Pr1kg}zł/kg");
                Console.WriteLine($"[5] {prod5.Name} {prod5.Pr1pc}zł/szt, {prod5.Pr1kg}zł/kg");
                return "";
            }
            string PrintReceipt()
            {
                Console.Clear();
                Console.WriteLine("Twój paragon:");
                cart.ForEach(x => {Console.WriteLine(x); });
                Console.WriteLine("RAZEM DO ZAPŁATY: "+ rowSum + "\n\n\n");
                Console.WriteLine("Czy chcesz zakończyć?");
                Console.WriteLine("[1]Następny klient");
                Console.WriteLine("[2]Zakończ");
                int Choice3 = Convert.ToInt32(Console.ReadLine());
                switch (Choice3)
                {
                    case 1:
                        Seller();
                        break;
                    case 2:
                        return "";
                    default:
                        return "";
                }
                return "";
            }
            string Seller()
            {
                Console.Clear();
                ShowProducts();
                //Wybierz produkt
                Console.Write("Wskaż wybrany produkt:");
                int Choice1 = Convert.ToInt32(Console.ReadLine());
                switch(Choice1)
                {
                    case 1:
                        ChosenProduct = prod1.Name;
                        ChosenProductPr1kg = prod1.Pr1kg;
                        ChosenProductPr1pc = prod1.Pr1pc;
                        break;
                    case 2:
                        ChosenProduct = prod2.Name;
                        ChosenProductPr1kg = prod2.Pr1kg;
                        ChosenProductPr1pc = prod2.Pr1pc;
                        break;
                    case 3:
                        ChosenProduct = prod3.Name;
                        ChosenProductPr1kg = prod3.Pr1kg;
                        ChosenProductPr1pc = prod3.Pr1pc;
                        break;
                    case 4:
                        ChosenProduct = prod4.Name;
                        ChosenProductPr1kg = prod4.Pr1kg;
                        ChosenProductPr1pc = prod4.Pr1pc;
                        break;
                    case 5:
                        ChosenProduct = prod5.Name;
                        ChosenProductPr1kg = prod5.Pr1kg;
                        ChosenProductPr1pc = prod5.Pr1pc;
                        break;
                    default:
                        Seller();
                        break;
                }
                Console.WriteLine("Podaj jednostkę.");
                Console.WriteLine("[1] Sztuka");
                Console.WriteLine("[2] Kilogram");
                ChosenUnit = Convert.ToInt32(Console.ReadLine());
                switch (ChosenUnit)
                {
                    case 1:
                        Console.WriteLine("Podaj ilość w sztukach:");
                        amountPc = Convert.ToInt32(Console.ReadLine());
                        amount = amountPc;
                        price = amountPc * ChosenProductPr1pc;
                        break; 
                    case 2:
                        Console.Write("Podaj ilość w kg:");
                        amountKg = Convert.ToDouble(Console.ReadLine());
                        amount = amountKg;
                        price = amountKg * ChosenProductPr1kg;
                        break;
                    default:
                        Seller();
                        break;
                }
                row = ChosenProduct + " | " + amount + " | " + price;
                Console.WriteLine(row);
                cart.Add(row);
                rowSum += price;
                Console.WriteLine("Pomyślnie dodano produkt.");
                Console.WriteLine("[1]Dodaj kolejny produkt.");
                Console.WriteLine("[2]Zakończ paragon.");
                int Choice2 = Convert.ToInt32(Console.ReadLine());
                switch (Choice2)
                {
                    case 1:
                        Seller();
                        break;
                    case 2:
                        PrintReceipt();
                        break;
                    default:
                        PrintReceipt();
                        break;
                }
                return "";
            }
            Seller();
            Console.ReadKey();
            Main(args);
            
        }
        
    }
}
