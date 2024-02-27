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
            CountOfWords("Bugun hava istidir");
            #region ForMethods_Task4
            //Console.WriteLine("Ededinizi Daxil Edin: ");
            //int input=Convert.ToInt32(Console.ReadLine());
            //SumOfInteger(input);
            #endregion
            #region ForMethod_Task5
            Power(3, 5);
            #endregion
            #region ForMethod_Task6
            NegativToPositiv(1, 2, -4, -5, 1);
            #endregion
            #region ForMethod_Task7
            Reverse("salam");
            #endregion
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
        //Verilmis yazidaki sozlerin sayini qaytaran metod(soz dedikde bosluqlarla ayrilmis butun yazilar nezerde tutulur)
        static void CountOfWords(string input) //Code Academyde bir nece tedris sahesi var
        {
            int count = 0;
            char c = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == c)
                {
                    count++;

                }
            }
            count = count + 1;
            Console.WriteLine(count);
        }

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
            int newnum = eded;
            //Verilmis ededi verilmis quvvete yukseldib neticesini qaytaran metod
            for (int i = 1; i < quvvet; i++)
            {
                eded=newnum*eded;


            }
            Console.WriteLine(eded);
        }
        #endregion
        #region Task_6
        //Verilmis ededler siyahisinin butun elementlerini musbet sekilde qaytaran metod. 
        static void NegativToPositiv(params int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < 0)
                {
                    arr2[i] = -arr2[i];
                }
                Console.WriteLine(arr2[i]);
            }

        }
        #endregion
        #region Task_7
        //Verilmis yazini ters formada qaytaran metod 
        static void Reverse(string input)
        {
            string empty = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                empty += input[i];
            }
            Console.WriteLine(empty);
        }
        #endregion
    }
}