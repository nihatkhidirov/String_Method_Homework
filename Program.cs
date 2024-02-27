namespace Hometask_String_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods_Task1
            //Console.WriteLine("Birinci Ededinizi Daxil Edin: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ikinci Ededinizi Daxil Edin: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Operatoru Daxil Edin: ");
            //char c = Convert.ToChar(Console.ReadLine());
            //Calculation(number1,number2,c);
            //Verilmis iki eded uzerinde verilmis operator simvoluna esasen riyazi emeliyyat aparib neticesini consolde.da
            //gosteren metod
            #endregion
            #region ForMethods_Task2
            //Console.WriteLine("Stringinizi Daxil Edin: ");
            //string input = Console.ReadLine();
            //CountsOfSymbols(input);
            #endregion
            #region ForMethods_Task4
            //Console.WriteLine("Ededinizi Daxil Edin: ");
            //int input=Convert.ToInt32(Console.ReadLine());
            //SumOfInteger(input);
            #endregion
            Power(2, 4);
        }

        #region Task_1
        static void Calculation(double number1, double number2, char c)
        {
            switch (c)
            {
                case '*':
                    double hasil = number1 * number2;
                    Console.WriteLine("Daxil Etdiyiniz Ededlerin Hasili: " + (hasil));
                    break;
                case '/':
                    double division = number1 / number2;
                    if (number2 != 0)
                    {
                        Console.WriteLine("Daxil Etdiyiniz Ededlerin Bolumu: " + (division));
                    }
                    else
                    {
                        Console.WriteLine("0-a Bolme Emeliyyati Edilmir!");
                    }
                    break;
                case '+':
                    double sum = number1 + number2;
                    Console.WriteLine("Daxil Etdiyiniz Ededlerin Cemi: " + (sum));
                    break;
                case '-':
                    double substract = number1 - number2;
                    Console.WriteLine("Daxil Etdiyiniz Ededlerin Ferqi: " + (substract));
                    break;
                default:
                    Console.WriteLine("Duzgun Operator Daxil Edilmemisdir!");
                    break;

            }
        }
        #endregion
        #region Task_2
        //Verilmis yazidaki verilmis simvollarin sayini qaytaran method
        static void CountsOfSymbols(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                count++;
            }
            Console.WriteLine("Daxil Etdiyiniz Metndeki Simvollarin Sayi: " +(count));

        }
        #endregion
        #region Task_4
        //Verilmis Ededin Reqemleri Cemini qaytaran metod
        static void SumOfInteger(int input)
        {
            int count = 0;
            int qaliq;
            while (input>0)
            {
                 //100
                 qaliq=input% 10;
                input /= 10;
                count = qaliq + count;

            }

            Console.WriteLine("Daxil Etdiyiniz Ededin Reqemleri Cemi: "+(count));

        }
        #endregion
        #region Task_5
        static void Power(int eded, int quvvet)
        {
            //Verilmis ededi verilmis quvvete yukseldib neticesini qaytaran metod
            int count = quvvet;
            while (quvvet>0)
            {
                quvvet--;
                eded *= eded;
            }
            Console.WriteLine(eded);
        }
        #endregion
        //.......//
    }
}