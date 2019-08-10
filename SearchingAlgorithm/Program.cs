using System;

namespace SearchingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, N = 0, i = 0;
            int[] v; //Array with the data

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Select a choice: ");
                Console.WriteLine("1) Sequential with iterative centinela searching."); //After that you have to introduce the data by hand or randomly. Both cases you will have to order after searching.
                Console.WriteLine("2) Sequential with recursive centinela searching.");
                Console.WriteLine("3) Iterative binary searching.");
                Console.WriteLine("4) Recursive binary searching.");
                Console.WriteLine("5) Exit.");

                op = Int16.Parse(Console.ReadLine());
                Console.Clear();

                switch (op) //MAIN SWITCH 
                {

                    case 1: //SEQUENTIAL WITH ITERATIVE CENTINELA
                        do
                        {
                            op = optionMenu();
                            Console.Clear();

                            switch (op)
                            {
                                case 1: //MANUAL CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int16.Parse(Console.ReadLine()); //Write the elements number.
                                    v = new int[N + 1]; //Assign values space.        

                                    while (i < N)
                                    {
                                        Console.Write("Number" + (i + 1) + ":");
                                        v[i] = Int16.Parse(Console.ReadLine()); //Assigns each array position to each data value.
                                        i++;
                                    }

                                    IterativeSecuentialSearch(v, N); ; //Search the number in the string.

                                    Console.Write("Press to continue.");
                                    Console.ReadLine();
                                    break;

                                case 2: //RANDOM CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int32.Parse(Console.ReadLine()); //Write the elements number.
                                    v = new int[N + 1]; //Assign values space.     

                                    while (i < N)
                                    {
                                        v[i] = i;
                                        i++;
                                    }

                                    IterativeSecuentialSearch(v, N); //Search the number in the string.

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    op = 1;
                                    break;
                            }

                        } while (op < 1 || op > 2);

                        break;

                    case 2: //SEQUENTIAL WITH RECURSIVE CENTINELA
                        do
                        {
                            op = optionMenu();
                            Console.Clear();

                            switch (op)
                            {
                                case 1: //MANUAL CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int16.Parse(Console.ReadLine()); //Write the elements number.
                                    v = new int[N + 1]; //Assign values space.                 

                                    while (i < N)
                                    {
                                        Console.Write("Number" + (i + 1) + ":");
                                        v[i] = Int16.Parse(Console.ReadLine()); //Assigns each array position to each data value.
                                        i++;
                                    }

                                    RecursiveSecuentialSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 2: //RANDOM CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int32.Parse(Console.ReadLine()); //Write the elements number.
                                    v = new int[N + 1]; //Assign values space.    

                                    while (i < N)
                                    {
                                        v[i] = i;
                                        i++;
                                    }

                                    RecursiveSecuentialSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    op = 1;
                                    break;
                            }

                        } while (op < 1 || op > 2);
                        break;

                    //ALL PROCESS IS THE SAME FOR THE BINARY SEARCHING SO I WILL OMIT BASIC COMMENTS
                    case 3: //ITERATIVE BINARY
                        do
                        {
                            op = optionMenu();
                            Console.Clear();

                            switch (op)
                            {
                                case 1: //MANUAL CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int16.Parse(Console.ReadLine());
                                    v = new int[N + 1];

                                    while (i < N)
                                    {
                                        Console.Write("Number" + (i + 1) + ":");
                                        v[i] = Int16.Parse(Console.ReadLine());
                                        i++;
                                    }

                                    BinaryIterativeSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 2: //RANDOM CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int32.Parse(Console.ReadLine());
                                    v = new int[N + 1];

                                    while (i < N)
                                    {
                                        v[i] = i;
                                        i++;
                                    }

                                    BinaryIterativeSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    op = 1;
                                    break;
                            }

                        } while (op < 1 || op > 2);
                        break;

                    case 4: //RECURSIVE BINARY
                        do
                        {
                            op = optionMenu();
                            Console.Clear();

                            switch (op)
                            {
                                case 1: //MANUAL CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int16.Parse(Console.ReadLine());
                                    v = new int[N + 1];

                                    while (i < N)
                                    {
                                        Console.Write("Number" + (i + 1) + ":");
                                        v[i] = Int16.Parse(Console.ReadLine());
                                        i++;
                                    }

                                    BinaryRecursiveSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 2: //RADOM CASE
                                    Console.Write("Introduce the number of elements to use: ");
                                    N = Int32.Parse(Console.ReadLine());
                                    v = new int[N + 1];

                                    while (i < N)
                                    {
                                        v[i] = i;
                                        i++;
                                    }

                                    BinaryRecursiveSearch(v, N);

                                    Console.Write("\nPress to continue....");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    op = 1;
                                    break;
                            }

                        } while (op < 1 || op > 2);
                        break;
                }

            } while (op != 5);
        }

        //Option Menu repeated in each searching type option
        private static int optionMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Introduce data by hand.");
            Console.WriteLine("2) Introduce data randomly.");
            Console.WriteLine("3) Back to main menu.");

            return (Int16.Parse(Console.ReadLine()));
        }

        private static void IterativeSecuentialSearch(int[] v, int N)
        {
            Console.Write("Introduce element to search: ");
            int elem = Int32.Parse(Console.ReadLine()); //Stablish the element to search
            int pos = Working.SecuentialIterative_Search(elem, v); //Secuential iterative search

            if (pos == N)
                Console.WriteLine("\nThe element is not in the string.");

            else
                Console.WriteLine("\nThe element position is " + (pos + 1));

        }


        private static void RecursiveSecuentialSearch(int[] v, int N)
        {
            Console.Write("Introduce element to search: ");
            int elem = Int32.Parse(Console.ReadLine());
            int pos = Working.SecuentialRecursive_Search(elem, v, 0);

            if (pos == N)
                Console.WriteLine("\nThe element is not in the string.");

            else
                Console.WriteLine("\nThe element position is " + (pos + 1));

        }

        private static void BinaryIterativeSearch(int[] v, int N)
        {
            Console.Write("Introduce element to search: ");
            int elem = Int32.Parse(Console.ReadLine());

            int pos = Working.BinaryIterative_Search(elem, v);

            if (pos == -1)
                Console.WriteLine("\nThe element is not in the string.");

            else
                Console.WriteLine("\nThe element position is " + (pos + 1));

        }

        private static void BinaryRecursiveSearch(int[] v, int N)
        {

            Console.Write("Introduce element to search: ");
            int elem = Int32.Parse(Console.ReadLine());

            int pos = Working.BinaryRecursive_Search(elem, v, 0, N);

            if (pos == -1)
                Console.WriteLine("\nThe element is not in the string.");

            else
                Console.WriteLine("\nThe element position is " + (pos + 1));

        }
    
    }
}
