namespace MenuDriven
{
    internal class Program
    {

        static double SquareArea(double side)
        {
            return side * side;
        }

        static double SquarePerimeter(double side)
        {
            return 4 * side;
        }

        static double CircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }

        static double CirclePerimeter(double radius)
        {
            return 2 * 3.14 * radius;
        }

        static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        static double RectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }




        static void Main(string[] args)
        {
            int shapeChoice = 0;
            int operationChoice = 0;
            double perimeter = 0;
            double area = 0;

            do
            {

                Console.WriteLine("Select Shape:");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice (1-3): ");
                shapeChoice = int.Parse(Console.ReadLine());

                switch(shapeChoice)
                {
                    case 1:
                        {
                            do
                            {
                                Console.WriteLine("\nSelect Operation:");
                                Console.WriteLine("1. Calculate Area");
                                Console.WriteLine("2. Calculate Perimeter");
                                Console.WriteLine("3. Calculate Both");
                                Console.WriteLine("0. Exit");
                                Console.Write("Enter your choice (1-3): ");

                                operationChoice = int.Parse(Console.ReadLine());

                                switch(operationChoice)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter side of square: ");
                                            double side = double.Parse(Console.ReadLine());
                                            area = SquareArea(side);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Square Area: " + area);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Enter side of square: ");
                                            double side = double.Parse(Console.ReadLine());
                                            perimeter = SquarePerimeter(side);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Square Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter side of square: ");
                                            double side = double.Parse(Console.ReadLine());
                                            area = SquareArea(side);
                                            perimeter = SquarePerimeter(side);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Square Area: " + area);
                                            Console.WriteLine("Square Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.WriteLine("square Operation Completed...");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid operationChoice choice!");
                                            break;
                                        }
                                }
                            } while (operationChoice != 0);

                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("\nSelect Operation:");
                                Console.WriteLine("1. Calculate Area");
                                Console.WriteLine("2. Calculate Perimeter");
                                Console.WriteLine("3. Calculate Both");
                                Console.WriteLine("0. Exit");
                                Console.Write("Enter your choice (1-3): ");

                                operationChoice = int.Parse(Console.ReadLine());

                                switch (operationChoice)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter radius of circle: ");
                                            double radius = double.Parse(Console.ReadLine());
                                            area = CircleArea(radius);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Circle Area: " + area);
                                            Console.WriteLine("-------------------------------------------------");
                                            
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Enter radius of circle: ");
                                            double radius = double.Parse(Console.ReadLine());
                                            perimeter = CirclePerimeter(radius);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Circle Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter radius of circle: ");
                                            double radius = double.Parse(Console.ReadLine());
                                            area = CircleArea(radius);
                                            perimeter = CirclePerimeter(radius);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Circle Area: " + area);
                                            Console.WriteLine("Circle Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.WriteLine("circle Operation Completed...");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid operationChoice choice!");
                                            break;
                                        }
                                }
                            } while (operationChoice != 0);

                            break;
                        }
                    case 3:
                        {
                            do
                            {
                                Console.WriteLine("\nSelect Operation:");
                                Console.WriteLine("1. Calculate Area");
                                Console.WriteLine("2. Calculate Perimeter");
                                Console.WriteLine("3. Calculate Both");
                                Console.WriteLine("0. Exit");
                                Console.Write("Enter your choice (1-3): ");

                                operationChoice = int.Parse(Console.ReadLine());

                                switch (operationChoice)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter length of rectangle: ");
                                            double length = double.Parse(Console.ReadLine());
                                            Console.Write("Enter width of rectangle: ");
                                            double width = double.Parse(Console.ReadLine());
                                            area = RectangleArea(length, width);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Rectangle Area: " + area);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Enter length of rectangle: ");
                                            double length = double.Parse(Console.ReadLine());
                                            Console.Write("Enter width of rectangle: ");
                                            double width = double.Parse(Console.ReadLine());
                                            perimeter = RectanglePerimeter(length, width);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Rectangle Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter length of rectangle: ");
                                            double length = double.Parse(Console.ReadLine());
                                            Console.Write("Enter width of rectangle: ");
                                            double width = double.Parse(Console.ReadLine());
                                            area = RectangleArea(length, width);
                                            perimeter = RectanglePerimeter(length, width);
                                            Console.WriteLine("\n------------------- Result --------------------");
                                            Console.WriteLine("Rectangle Area: " + area);
                                            Console.WriteLine("Rectangle Perimeter: " + perimeter);
                                            Console.WriteLine("-------------------------------------------------");
                                            break;
                                        }
                                    case 0:
                                        {
                                            Console.WriteLine("rectangle Operation Completed...");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid operationChoice choice!");
                                            break;
                                        }
                                }
                            } while (operationChoice != 0);

                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Shape Operation Completed...");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid shape choice!");
                            break;
                        }


                }

            } while (shapeChoice != 0);


        }
    }
}
