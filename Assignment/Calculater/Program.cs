namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch=0;

            do {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.substract");
                Console.WriteLine("3.Multipaction");
                Console.WriteLine("4.Divide");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Choose What you Want");
                
                ch= int.Parse(Console.ReadLine());

                Console.WriteLine("Enter two Numbers");
                Console.Write("Num1 => ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Num2 => ");
                int num2 = int.Parse(Console.ReadLine());

                switch (ch)
                {

                    case 1:
                        { 
                            int sum=num1+ num2;
                            Console.WriteLine($"Addition of tow Numbers is {sum}");
                            break;
                        
                        }
                    case 2:
                        {
                            int sub = num1 - num2;
                            Console.WriteLine($"Substraction of tow Numbers is {sub}");
                            break;

                        }
                    case 3:
                        {
                            int mul = num1 * num2;
                            Console.WriteLine($"Multiplaction of tow Numbers is {mul}");
                            break;

                        }
                    case 4:
                        {
                            int div = num1 / num2;
                            Console.WriteLine($"Divedition of tow Numbers is {div}");
                            break;

                        }
                    case 0:
                        {
                            Console.WriteLine("Thank You   Vist Again");  
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Plese enter Valid number...");
                            break;

                        }
                }    

            }while(ch!=0);
                
        }
    }
}
