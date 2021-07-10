// DaY 2 (Task 02).....
//using System;

//namespace consol1
//{
//    class Operation
//    {
//        static void Main(string[] args)
//        {
//            // int data types
//            byte centuries = 20;
//            ushort years = 2021;
//            uint days = 7030480;
//            ulong hours = 17531520;
//            Console.WriteLine((centuries + 1) + "centuries are" + years + "years are" + days + "days are" + hours + "hours are");
//            Console.WriteLine("----------------------------------");
//            ulong MaxValue = UInt64.MaxValue;
//            Console.WriteLine(MaxValue);

//            // floAT data types
//            float fpi = 3.14f;             // 7 digits after the decimal point
//            Console.WriteLine(fpi);
//            double dpi = 3.14d;           // 14 digits after the decimal point
//            Console.WriteLine(dpi);
//            double infinity = double.PositiveInfinity;
//            Console.WriteLine(infinity);
//            Console.WriteLine("----------------------------------");

//            // calculation errors
//            float fp = 3.14f;
//            Console.WriteLine(fp);
//            double dp = 3.14f;
//            Console.WriteLine(dp);
//            float ff = 1.0f / 3;
//            Console.WriteLine(ff);
//            double dd = ff;
//            Console.WriteLine(dd);
//            Console.WriteLine("----------------------------------");

//            // to precise the output value
//            Console.WriteLine(dd.ToString("{0.0000}"));

//            // decimal data types (128 values)
//            decimal m = 3.1223455678869574595729469750m;     // 128 digits
//            Console.WriteLine(m);
//            Console.WriteLine("----------------------------------");

//            // boolean dAta types
//            int a = 1;
//            int b = 5;
//            bool c = (a > b);
//            bool d = (a == 1);
//            if (c)
//            {
//                Console.WriteLine("a>b");
//            }
//            else
//            {
//                Console.WriteLine("a<b");
//            }
//            Console.WriteLine("c = " + c);
//            Console.WriteLine("d = " + d);
//            Console.WriteLine("----------------------------------");

//            // character data types
//            string ab = "a";
//            char aa = 'a';
//            Console.WriteLine(ab);
//            Console.WriteLine(aa);
//            Console.WriteLine((int)aa);
//            Console.WriteLine("----------------------------------");

//            // string data types
//            string n = "Apple is a fruit";
//            Console.WriteLine(n);
//            Console.WriteLine(n.Length);
//            Console.WriteLine(n.Substring(0, 7));
//            Console.WriteLine(n.Trim());
//            Console.WriteLine(n.Clone());
//            Console.WriteLine(n.Replace(' ', '_'));
//            Console.WriteLine(n.Split());
//        }
//    }
//}


//using System;
//public class Exercise7
//{
//    public static void Main()
//    {
//        float distance;
//        float hour, min, sec;

//        float timeSec;
//        float mps;
//        float kph, mph;

//        Console.Write("Input distance(metres): ");
//        distance = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(hour): ");
//        hour = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(minutes): ");
//        min = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(seconds): ");
//        sec = Convert.ToSingle(Console.ReadLine());

//        timeSec = (hour * 3600) + (min * 60) + sec;
//        mps = distance / timeSec;
//        kph = (distance / 1000.0f) / (timeSec / 3600.0f);
//        mph = kph / 1.609f;

//        Console.WriteLine("Your speed in metres/sec is {0}", mps);
//        Console.WriteLine("Your speed in km/h is {0}", kph);
//        Console.WriteLine("Your speed in miles/h is {0}", mph);
//    }
//}

//// Operation
//using System;
//namespace consol1
//{
//    public class Operation
//    {
//        public static void Main(String [] arg)
//        {
//            int a, b;
//            char op;
//            float result;
//            Console.Write("Enter the First Number :");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Second Number :");
//            b = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Operation :");
//            op = Convert.ToChar(Console.ReadLine());
//            if (op == '+')
//            {
//                result = a + b;
//                Console.WriteLine(" Result of a+b {0}", result);
//            }
//            else if (op == '-')
//            {
//                result = a - b;
//                Console.WriteLine("Result of  a-b {0}", result);
//            }
//            else if (op == '*')
//            {
//                result = a * b;
//                Console.WriteLine("Result of a*b {0}", result);
//            }
//            else if (op == '/')
//            {
//                result = a / b;
//                Console.WriteLine("Result of a/b {0}", result);
//            }
//            else
//            {
//                Console.WriteLine("Wrong Operation !");
//            }
//        }
//    }
//}


// check Alphabet
//using System;
//namespace consol1
//{
//    class Program
//    {
//        public static void Main(string[] arg)
//        {
//            char c;
//            Console.Write("Enter An Alphabet :");
//            c = Convert.ToChar(Console.ReadLine());
//            if (char.IsUpper(c))
//            {
//                Console.WriteLine("Capital");
//            }
//            else
//            {
//                Console.WriteLine("Samll");
//            }
//        }
//    }
//}

// Circle's perimeter and area
//using System;
//namespace consol1
//{
//    class Circle
//    {
//        public static void Main(String [] arg)
//        {
//            int r;
//            float p, a;
//            Console.Write("Enter the radious of circle :");
//            r = Convert.ToInt32(Console.ReadLine());
//            p = r * 2 * 3.14f;
//            a = r * r * 3.14f;
//            Console.WriteLine("Perimeter is :{0}", p);
//            Console.WriteLine("Perimeter is :{0}", a);
//        }
//    }
//}

// Reverse 
//using System;
//namespace consol1
//{
//    class Reverse
//    {
//        public static void Main(String [] arg)
//        {
//            char a, b, c;
//            Console.Write("enter a character :");
//            a = Convert.ToChar(Console.ReadLine());
//            Console.Write("enter second character :");
//            b = Convert.ToChar(Console.ReadLine());
//            Console.Write("enter third character :");
//            c = Convert.ToChar(Console.ReadLine());
//            Console.WriteLine("reverse {0} {1} {2}", c, b, a);
//        }
//    }
//}

// speed
//using System;
//namespace consol1
//{
//    class Sp
//    {
//        public static void Main(String [] arg)
//        {
//            float distance, hrs, sec, min,total_time;
//            float speed_kph, speed_mps, speed_mph;
//            Console.Write("enter the  distance in metres: ");
//            distance = Convert.ToSingle(Console.ReadLine());
//            Console.Write("Input time in hours: ");
//            hrs = Convert.ToSingle(Console.ReadLine());
//            Console.Write("Input time in minutes: ");
//            min = Convert.ToSingle(Console.ReadLine());
//            Console.Write("Input time in Seconds: ");
//            sec = Convert.ToSingle(Console.ReadLine());
//            total_time = (hrs * 3600) + (min * 60) + sec;
//            speed_kph = (distance / 1000.0f) / (total_time / 3600.0f);
//            speed_mps = distance / total_time;
//            speed_mph = speed_kph / 1.609f;
//            Console.WriteLine(" speed in Kilometres/hrs is {0}", speed_kph);
//            Console.WriteLine("Your speed in meter per sec is {0}", speed_mps);
//            Console.WriteLine("Your speed in miles/h is {0}", speed_mph);
//        }
//    }
//}


// Day 03 (Task 03).....

//// Compare two floating numbers...
//using System;
//namespace consol1
//{
//    class Comparison
//    {
//        static void Main()
//        {
//            float _firstName = 2.222345f;
//            float _secondName = 3.222345f;
//            if (_firstName == _secondName)
//            {
//                Console.WriteLine("Both are Equal numbers !!");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal");
//            }

//        }

//    }
//}


//// string data type....
//using System;
//namespace consol1
//{
//    class Obj
//    {
//        static void Main(String[] arg)
//        {
//            string str1 = "Hello";
//            string str2 = "World";
//            object obj = str1 + " " + str2;
//            Console.WriteLine(obj);
//            string str3 = obj.ToString();
//            Console.WriteLine(str3);
//        }
//    }
//}


//// isosceles triangle...
//using System;
//namespace consol1
//{
//    class Triangle
//    {
//        public static void Main(String[] arg)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("ISOSCELES TRIANGLE");
//            Console.WriteLine("        ©  ");
//            Console.WriteLine("      ©   ©");
//            Console.WriteLine("    ©       ©");
//            Console.WriteLine("  ©           ©");
//            Console.WriteLine(" ©©©©©©©©©©©©©©©");
//        }
//    }
//}


//// Company's Data....
//using System;
//namespace consol1
//{
//    class Data
//    {
//        static void Main(String[] arg)
//        {
//            string FirstName;
//            string lastName;
//            byte age;
//            char gender;
//            int id;
//            Console.Write("Enter the First Name :");
//            FirstName = Convert.ToString(Console.ReadLine());
//            Console.Write("Enter the Last Name :");
//            lastName = Convert.ToString(Console.ReadLine());
//            Console.Write("Enter the Age :");
//            age = (byte)Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Gender :");
//            gender = Convert.ToChar(Console.ReadLine());
//            Console.Write("Enter the Id Number :");
//            id = Convert.ToInt32(Console.ReadLine());
//        }
//    }
//}


//// Swap two numbers..
//using System;
//namespace consol1
//{
//    class Swap
//    {
//        static void Main()
//        {
//            int a = 5, b = 10, temp =0;
//            Console.WriteLine("Before Swapping the numbers are : a = " + a + " " + "b = " + b);
//            a = a + b;
//            b = a - b;
//            a = a - b;
//            Console.WriteLine("Swap two numbers without using third variable :  a = " +a+ "  " +  "b = "+b);
//            Console.WriteLine("...............................................");
//            Console.WriteLine("Before Swapping the numbers are : a = " + a + " " + "b = " + b);
//            temp = a;
//            a = b;
//            b = temp;
//            Console.WriteLine("Swap two numbers with third variable : a = " +a + " "+ "b = "+b);

//        }
//    }
//}


// DaY 04 (TASk 4).....

////Divisible by 5 and 7 both...
//using System;
//namespace consol1
//{
//    class Divide
//    {
//        static void Main()
//        {
//            int a;
//            Console.Write("Enter the number :");
//            a = Convert.ToInt32(Console.ReadLine());
//            bool result = (a % 5 == 0) && (a % 7 == 0);
//            Console.WriteLine("The Number is Divisible by 5 & 7 both :{0}", result);
//        }
//    }
//}

// Area of Trapezoid..
//using System;
//namespace consol1
//{
//    class Area
//    {
//        static void Main()
//        {
//            int a, b, h;
//            float area;
//            Console.Write("Enter the Base of Trapezoid :");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Base of Trapezoid :");
//            b = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Height of Trapezoid :");
//            h = Convert.ToInt32(Console.ReadLine());
//            area = ((a + b) / 2) * h;
//            Console.WriteLine("Area of Trapezoid is :{0}", area);
//        }
//    }
//}

//// Four Digit Number's Operation...
//using System;
//namespace consol1
//{
//    class Operation
//    {
//        static void Main()
//        {
//            int _number, rev=0, rem, sum = 0;
//            Console.Write("Enter the number :");
//            _number = Convert.ToInt32(Console.ReadLine());
//            if ((_number>999) && (_number<=9999))
//            {
//                // sum of all digits.
//                Console.WriteLine("The Input Number is a Four digits number !!");
//                rem = _number % 10;         // for the first digit
//                _number = _number / 10;
//                sum = sum + rem;
//                rem = _number % 10;        // for thr second digit
//                _number = _number / 10;
//                sum = sum + rem;
//                rem = _number % 10;       // for the third digit
//                _number = _number / 10;
//                sum = sum + rem;
//                rem = _number % 10;      // for fourth digit
//                _number = _number / 10;
//                sum = sum + rem;
//                Console.WriteLine("Sum of all digits of this number is :{0}", sum);
//                Console.WriteLine("...........................................................");
//                // reverse number.
//                rem = _number % 10;
//                _number = _number / 10;
//                rev = rev * 10 + rem;
//                rem = _number % 10;
//                _number = _number / 10;
//                rev = rev * 10 + rem;
//                rem = _number % 10;
//                _number = _number / 10;
//                rev = rev * 10 + rem;
//                rem = _number % 10;
//                _number = _number / 10;
//                rev = rev * 10 + rem;
//                Console.WriteLine("Reverse of this Number :{0}", rev);
//            }
//            else
//            {
//                Console.WriteLine("This is not a Four digit value !");
//            }
//        }
//    }

//}

// Four digit number..
//using System;
//namespace consol1
//{
//    class Operation
//    {
//        static void Main()
//        {
//            int _fNumber, _sNumber, _tNumber, _frNumber;
//            Console.Write("Enter the First Number :");
//            _fNumber = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Second Number :");
//            _sNumber = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Third Number :");
//            _tNumber = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Fourth Number :");
//            _frNumber = Convert.ToInt32(Console.ReadLine());

//        }
//    }
//}

//// Four digit..
//using System;
//namespace consol1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the number: ");
//            int number = Convert.ToInt32(Console.ReadLine());
//            if ((number>999) && (number <= 9999))
//            {
//                Console.WriteLine("The Entered Number is a four digit number ...");
//                int a = number / 1000;
//                int b = (number / 100) % 10;
//                int c = (number / 10) % 10;
//                int d = number % 10;
//                Console.WriteLine("..Sum of all digits = {0}", a + b + c + d);
//                Console.WriteLine("...Reverse disgits = {3}{2}{1}{0}", a, b, c, d);
//                Console.WriteLine("....Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
//                Console.WriteLine(".....Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);
//            }
//            else
//            {
//                Console.WriteLine("It is not Four digit number!!");
//            }
//        }
//    }
//}


//using System;
//namespace consol1
//{
//    class Program
//    {

//        static void Main(String[] arg)
//        {
//            int   a, b;
//            Console.Write("Enter the First  number :");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Second number :");
//            b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("So the First Number is a = {0:D2}", a);
//            Console.WriteLine("So the Second Number is b = {0:D2}", b);
//            Console.WriteLine("Add two Numbers a + b = {0:D2}", a+b);
//            Console.WriteLine("Multiplication of two Numbers a * b =  {0:D2}", a * b);
//        }
//    }
//}


// DaY 04 (Task 05)....

//// Quadratic Equation......
//using System;
//namespace consol1
//{
//    class Equation
//    {
//        static void Main(String[] arg)
//        {
//            double a, b, c, r1, r2, discriminant;
//            Console.Write("Enter the First Value : a =  ");
//            bool isadouble = double.TryParse(Console.ReadLine(),out a);
//            Console.Write("Enter the Second Value : b =  ");
//            bool isbdouble = double.TryParse(Console.ReadLine(),out b);
//            Console.Write("Enter the First Value : c =  ");
//            bool iscdouble = double.TryParse(Console.ReadLine(),out c);
//            if (isadouble && isbdouble && iscdouble)
//            {
//                discriminant = b * b - 4 * a * c;
//                if (discriminant < 0)
//                {
//                    Console.WriteLine("Roots are Imaginary");
//                    r1 = -b / (2 * a);
//                    r2 = Math.Sqrt(-discriminant) / (2 * a);
//                    Console.WriteLine(" First root is = {0:#.##} + i ({1:#.##})", r1, r2);
//                    Console.WriteLine(" Second root is = {0:#.##} - i ({1:#.##})", r1, r2);
//                    Console.ReadLine();
//                }
//                else if (discriminant == 0)
//                {
//                    Console.WriteLine("Roots are Equal and real\n");
//                    Console.WriteLine("So the First Root is Root1 = {0:#.##}", -b / (2 * a));
//                    Console.WriteLine("and the Seocnd Root is Root2 = {0:#.##}", -b / (2 * a));
//                    Console.ReadLine();
//                }
//                else
//                {
//                    Console.WriteLine("Roots are Unequal and real");
//                    r1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//                    r2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//                    Console.WriteLine("First root is = {0:#.##}", r1);
//                    Console.WriteLine(" Second root is = {0:#.##}", r2);
//                    Console.ReadLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Some of the variables are not in double!! so it is not Valid entry !!");
//            }

//        }
//    }
//}


//// Sorting of three numbers in descending order...
//using System;
//namespace consol1
//{
//    class sort
//    {
//        public static void Main(string[] arg)
//        {
//            double a, b, c, max = 0.0, min = 0.0, mid = 0.0;
//            Console.Write("enter the first value a = ");
//            a = double.Parse(Console.ReadLine());
//            Console.Write("enter the first value b = ");
//            b = double.Parse(Console.ReadLine());
//            Console.Write("enter the first value c = ");
//            c = double.Parse(Console.ReadLine());
//            if (a > b && a > c)
//            {
//                max = a;
//                if (b > c)
//                {
//                    min = c;
//                    mid = b;
//                }
//                else
//                {
//                    min = b;
//                    mid = c;
//                }
//            }
//            else if (b > a && b > c)
//            {
//                max = b;
//                if (a > c)
//                {
//                    min = c;
//                    mid = a;
//                }
//                else
//                {
//                    min = a;
//                    mid = c;
//                }
//            }
//            else if (c > a && c > b)
//            {
//                max = c;
//                if (b > a)
//                {
//                    min = a;
//                    mid = b;
//                }
//                else
//                {
//                    min = b;
//                    mid = a;
//                }
//            }
//            Console.WriteLine("Sorted number : {0} {1} {2}", max, mid, min);
//        }
//    }
//}

//// Fibonacci series..
//using System;
//namespace consol1
//{
//    class Series
//    {
//        static void Main(String[] arg)
//        {
//            int a = 0, b = 1,c, i;
//            Console.WriteLine("Fibonacci Series till 100 : ");
//            Console.WriteLine(a + " " + b + " ");
//            for (i=2; i<=100; i++)
//            {
//                c = a + b;
//                Console.Write(c + "\t");
//                a = b;
//                b = c;
//            }
//            Console.ReadLine();
//        }
//    }
//}

// Convert into Word...
//using System;
//namespace consol1
//{
//    class Words
//    {
//        static void Main(String[] arg)
//        {
//            int n1;
//            Console.Write(" Enter the number  n1 =  ");
//            bool Parsesuccess = int.TryParse(Console.ReadLine(), out n1);
//            while (!Parsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                Parsesuccess = int.TryParse(Console.ReadLine(), out n1);
//            }
//            if (n1>=0 && n1 <= 10)
//            {
//                switch (n1)
//                {
//                    case 0: Console.WriteLine("  0 --> ZERO ");
//                        break;
//                    case 1:
//                        Console.WriteLine("  1 --> ONE ");
//                        break;
//                    case 2:
//                        Console.WriteLine("  2 --> TWO ");
//                        break;
//                    case 3:
//                        Console.WriteLine("  3 --> THREE ");
//                        break;
//                    case 4:
//                        Console.WriteLine("  4 --> FOUR ");
//                        break;
//                    case 5:
//                        Console.WriteLine("  5 --> FIVE ");
//                        break;
//                    case 6:
//                        Console.WriteLine("  6 --> SIX ");
//                        break;
//                    case 7:
//                        Console.WriteLine("  7 --> SEVEN ");
//                        break;
//                    case 8:
//                        Console.WriteLine("  8 --> EIGHT ");
//                        break;
//                    case 9:
//                        Console.WriteLine("  9 --> NINE ");
//                        break;
//                    case 10:
//                        Console.WriteLine("  10 --> TEN ");
//                        break;
//                    default:
//                        Console.WriteLine("  Wrong !!");
//                        break;
//                }
//            }
//        }
//    }
//}


// Check Validation....
//using System;
//namespace consol1
//{
//    class Number
//    {
//        static void Main(String[] arg)
//        {
//            int n1, n2, n3, n4, n5,sum;
//            Console.Write("  n1 =  ");
//            bool Parsesuccess = int.TryParse(Console.ReadLine(), out n1);
//            while (!Parsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                Parsesuccess = int.TryParse(Console.ReadLine(), out n1);
//            }
//            Console.Write("  n2 =  ");
//            bool parsesuccess = int.TryParse(Console.ReadLine(), out n2);
//            while (!parsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                parsesuccess = int.TryParse(Console.ReadLine(), out n2);
//            }
//            Console.Write("  n3 =  ");
//            bool ifParsesuccess = int.TryParse(Console.ReadLine(), out n3);
//            while (!ifParsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                ifParsesuccess = int.TryParse(Console.ReadLine(), out n3);
//            }
//            Console.Write("  n4 =  ");
//            bool ifparsesuccess = int.TryParse(Console.ReadLine(), out n4);
//            while (!ifparsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                ifparsesuccess = int.TryParse(Console.ReadLine(), out n4);
//            }
//            Console.Write("  n5 =  ");
//            bool intParsesuccess = int.TryParse(Console.ReadLine(), out n5);
//            while (!intParsesuccess)
//            {
//                Console.WriteLine(" Please enter the Numbers Only !");
//                intParsesuccess = int.TryParse(Console.ReadLine(), out n5);
//            }
//            sum = n1 + n2 + n3 + n5 + n5;
//            Console.WriteLine("Sum = {0}", sum);
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace consol1
//{
//    public class csharpExercise
//    {
//        static void Main(string[] args)
//        {
//            int num, i;

//            /*Reading number      
//             */

//            Console.Write("Enter any number: ");
//            num = Convert.ToInt32(Console.ReadLine());
//            bool c;
//            bool f = true;
//            i = 2;
//            while (i <= num / 2)
//            {
//                if (num % i == 0)
//                {
//                     c = false;
//                    break;
//                }
//                i++;
//            }
//            if (f==true)
//            {
//                Console.WriteLine(" Prime Number ? :{0}", f);
//            }

//            else
//            {
//                Console.WriteLine(" Prime Number ? :{0}", c);
//            }
//            Console.ReadLine();
//        }
//    }
//}


// DaY 05

//// Bonus pionts with upper and lower limits ...(using switch case) 
//using System;
//namespace consol1
//{
//    class BonusPoint
//    {
//        static void Main(String[] arg)
//        {
//            int a;
//            Console.Write("  Enter the Positive Number a = ");
//            bool Parsesuccess = int.TryParse(Console.ReadLine(), out a);
//            while (!Parsesuccess)
//            {
//                Console.WriteLine("  Please enter the Numbers Only !");
//                Parsesuccess = int.TryParse(Console.ReadLine(), out a);
//            }
//            switch (a)
//            {
//                case 1:
//                case 2:
//                case 3:
//                    Console.WriteLine("  bunus points multiplied by 10 : {0}", a * 10);
//                    break;
//                case 4:
//                case 5:
//                case 6:
//                    Console.WriteLine("  bonus points multiplied by 100 : {0}", a * 100);
//                    break;
//                case 7:
//                case 8:
//                case 9:
//                    Console.WriteLine("  bonus points multiplied by 1000 : {0}", a * 1000);
//                    break;
//                default:
//                    Console.WriteLine("Wrong  Number !!");
//                    break;
//            }
//        }
//    }
//}


//// Bonus pionts without taking upper and lower limits...(using if-else statements)
//using System;
//namespace consol1
//{
//    class BonusPoint
//    {
//        static void Main(String[] arg)
//        {
//            int a;
//            Console.Write("  Enter the Positive Number a = ");
//            bool Parsesuccess = int.TryParse(Console.ReadLine(), out a);
//            while (!Parsesuccess)
//            {
//                Console.WriteLine("  Please enter the Numbers Only !");
//                Parsesuccess = int.TryParse(Console.ReadLine(), out a);
//            }
//            if (a > 1 && a < 3)     // between 1 and 3
//            {
//                Console.WriteLine("  bunus points multiplied by 10 = {0}", a * 10);
//            }
//            else if (a > 4 && a < 6)   // between 4 and 6
//            {
//                Console.WriteLine("  bonus points multiplied by 100 = {0}", a * 100);
//            }
//            else if (a > 7 && a < 9)   // between 7 and 9
//            {
//                Console.WriteLine("  bonus points multiplied by 1000 = {0}", a * 1000);
//            }
//            else
//            {
//                Console.WriteLine("  Wrong  Number !!");
//            }
//        }
//    }
//}


// not divisible by 3 and 7...
//using System;
//namespace consol1
//{
//    class Divide
//    {
//        static void Main(String[] arg)
//        {
//            Console.Write("  Enter the number from 1 to 100 :  n = ");
//            int n = Int32.Parse(Console.ReadLine());
//            if (n>=1 && n <= 100)
//            {
//                for (int i = 1; i < n; i++)
//                {
//                    if (i % (3 * 7) != 0) Console.WriteLine(i);
//                }
//            }
//            else
//            {
//                Console.WriteLine("  Wrong Number !!");
//            }
//        }
//    }
//}


//using System;
//namespace consol1
//{
//    class Power
//    {
//        static void Main(String[] arg)
//        {
//            int n, m;
//            int x = 1;
//            Console.WriteLine("Enter n:");
//            n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter m:");
//            m = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < m; i++)
//            {
//                x = x * n;
//            }
//            Console.WriteLine(x);
//        }
//    }
//}




// C# program to check Lucky Number 
//using System; 

//class GFG
//{

//    public static int counter = 2;

//    // Returns 1 if n is a lucky no. 
//    // ohterwise returns 0 
//    static bool isLucky(int n)
//    {

//        // variable next_position is  
//        // just for readability of 
//        // the program we can remove 
//        // it and use n only  
//        int next_position = n;

//        if (counter > n)
//            return true;
//        if (n % counter == 0)
//            return false;

//        // calculate next position of 
//        // input no 
//        next_position -= next_position
//                            / counter;

//        counter++;

//        return isLucky(next_position);
//    }

//    // driver program 
//    public static void Main()
//    {
//        int x = 5;

//        if (isLucky(x))
//            Console.Write(x + " is a "
//                         + "lucky no.");
//        else
//            Console.Write(x + " is not"
//                      + " a lucky no.");
//    }
//}


// DaY 07 ...

//// N!*K!/(N-K)!....
//using System;
//namespace consol1
//{
//    class Op
//    {
//        static void Main(String[] arg)
//        {
//            Console.Write("  Enter the N : ");
//            int N = int.Parse(Console.ReadLine());
//            Console.Write("  Enter the K (1<K<N) : ");
//            int K = int.Parse(Console.ReadLine());
//            int z = N - K;
//            if (K < N)
//            {
//                for (int i = N-1; i>0; i--)
//                {
//                    N = N * i;
//                }
//                for (int i = K-1; i>0; i--)
//                {
//                    K = K * i;
//                }
//                for (int i = z-1; i>0; i--)
//                {
//                    z = z * i;
//                }
//                Console.WriteLine("  N! * K!/(N! - K!) = {0}", (N * K) / z);
//            }
//            else
//            {
//                Console.WriteLine("  K must be less than N, so enter the lesser value from N !!");
//            }
//        }
//    }
//}


// GCD && LCM...
//using System;
//namespace consol
//{
//    class GcdLcm
//    {
//        static void Main(String[] arg)
//        {
//            int num1,num2,Gcd,Lcm,denominator,numerator,remainder;
//            Console.Write("  Enter the Positive Number num1 = ");
//            bool Parsesuccess = int.TryParse(Console.ReadLine(), out num1);
//            while (!Parsesuccess)
//            {
//                Console.WriteLine("  Please enter the Numbers Only !");
//                Parsesuccess = int.TryParse(Console.ReadLine(), out num1);
//            }
//            Console.Write("  Enter the Positive Number num2 = ");
//            bool parsesuccess = int.TryParse(Console.ReadLine(), out num2);
//            while (!parsesuccess)
//            {
//                Console.WriteLine("  Please enter the Numbers Only !");
//                parsesuccess = int.TryParse(Console.ReadLine(), out num2);
//            }
//            if (num1 > num2)
//            {
//                numerator = num1;
//                denominator = num2;
//            }
//            else
//            {
//                numerator = num2;
//                denominator = num1;
//            }
//            remainder = numerator % denominator;
//            while (remainder != 0)
//            {
//                numerator = denominator;
//                denominator = remainder;
//                remainder = numerator % denominator;
//            }
//            Gcd = denominator;
//            Lcm = (num1 * num2) / Gcd;
//            Console.WriteLine("  Greatest Common Divisor GCD = {0}", Gcd);
//            Console.WriteLine("  Least Common Multiple LCM = {0}", Lcm);
//        }
//    }
//}

//// Pattern printing
//using System;
//namespace consol1
//{
//    class Pattern
//    {
//        static void Main(String[] arg)
//        {
//            Console.Write("  Enter the number N :");
//            int n = int.Parse(Console.ReadLine());
//            for (int i = n; i >0; i--)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("  *");
//                }
//                Console.WriteLine();
//            }
//            for (int i = 1; i <=n; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("  *");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}


// Pattern Printing...
//using System;
//namespace consol1
//{
//    class Pattern
//    {
//        static void Main(String[] arg)
//        {
//            int i, j;
//            for (i = 1; i <= 8; i++)
//            {
//                for (j = 1; j <= 15; j++)
//                {
//                    if ((j >= 8 - (i - 1) && j <= 8 + (i - 1)))
//                    {
//                        Console.Write("*");
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine(); 
//            }
//        }
//    }
//}

// DaY 08 

//using System;
//namespace consol1
//{
//    class Array
//    {
//        static void Main(String[] arg)
//        {
//            int N;
//            int i;
//            Console.Write("Enter the lenght of array :");
//            N = int.Parse(Console.ReadLine());
//            int[] numbers = new int[N];
//            for (i = 0; i < N; i++)
//            {

//                numbers[i] = int.Parse(Console.ReadLine());
//            }
//            i = 0;
//            while (i < N / 2 && numbers[i] == numbers[N - 1 - i])
//            {
//                i++;
//            }

//            if (i == N / 2)
//            {
//                Console.WriteLine("The array is a symetrical array");
//            }
//            else
//            {
//                Console.WriteLine("The array is NOT a symetrical array");
//            }
//        }
//    }
//}


//using System;

//public class Program
//{
//	public static void Main()
//	{
//		int len, i;
//		bool symmetric = true;

//		Console.Write("Enter the length of array: ");
//		len = int.Parse(Console.ReadLine());
//		int[] arr = new int[len];
//		Console.Write("Enter elements of the array: \n");

//		for (i = 0; i < len; i++)
//		{
//			Console.Write("Enter element =  " + i);
//			arr[i] = int.Parse(Console.ReadLine());
//		}
//		i = len - 1;
//		int j = 0;
//		do
//		{
//			if (arr[i] == arr[j])
//			{
//				i--;
//				j++;
//			}
//			else
//			{
//				symmetric = false;
//				break;
//			}

//		}
//		while (i >= len / 2);
//        {



//		}

//	}
//}



// DaY 08 

//// creating Array
//using System;
//class Array
//{
//    static void Main(String[] arg)
//    {
//        int[] arr = new int[20];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = i * 5;
//            Console.Write( " {0}\t",arr[i]);
//        }
//    }
//}



// Lexicographically Array
//using System;
//namespace consol1
//{
//    class Array
//    {
//        static void Main(String[] arg)
//        {
//            bool equalArray = true;
//            char[] arr1 = new char[5] { 'a', 'b', 'd', 'e', 'f' };
//            char[] arr2 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
//            if (arr1.Length > arr2.Length)
//            {
//                Console.WriteLine(" Second Array Is Lexicographical First");
//            }
//            else if (arr1.Length < arr2.Length)
//            {
//                Console.WriteLine(" First Array Is Lexicographical First");
//            }
//            else
//            {
//                for (int i = 0; i < arr1.Length; i++)
//                {
//                    if (arr1[i] > arr2[i])
//                    {
//                        Console.WriteLine(" Second Array Is Lexicographical First");
//                        equalArray = false;
//                        break;
//                    }
//                    if (arr1[i] < arr2[i])
//                    {
//                        Console.WriteLine(" First Array Is Lexicographical First");
//                        equalArray = false;
//                        break;
//                    }
//                }
//                if (equalArray)
//                {
//                    Console.WriteLine(" Equal Arrays");
//                }
//            }

//        }
//    }
//}


// DaY 09

//using System;
//namespace consol1
//{
//    class Program
//    {
//        static void Main(String[] arg)
//        {
//            Console.Write("Please enter a number to divide 100: ");

//            try
//            {
//                int num = int.Parse(Console.ReadLine());

//                int result = 100 / num;

//                Console.WriteLine("100 / {0} = {1}", num, result);
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Cannot divide by zero. Please try again.");
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine("Invalid operation. Please try again.");
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("Not a valid format. Please try again.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error occurred! Please try again.");
//            }

//        }

//    }
//}


// Calculator......// Output...
//using System;
//namespace consol1
//{
//    class Calculataor
//    {
//        static void Main(String[] arg)
//        {
//            bool endOperation = false;
//            while (!endOperation)
//            {
//                double num1, num2, result = 0.00;
//                int op = 0;
//                Console.Write(" num1 =  ");
//                bool Parsesuccess = double.TryParse(Console.ReadLine(), out num1);
//                while (!Parsesuccess)
//                {
//                    Console.WriteLine(" Please enter the Numbers Only !");
//                    Parsesuccess = double.TryParse(Console.ReadLine(), out num1);
//                }
//                Console.Write(" num2 =  ");
//                bool parsesuccess = double.TryParse(Console.ReadLine(), out num2);
//                while (!parsesuccess)
//                {
//                    Console.WriteLine(" Please enter the Numbers Only !");
//                    parsesuccess = double.TryParse(Console.ReadLine(), out num2);
//                }
//                Console.WriteLine(" Choose an operator from the following list :");
//                Console.WriteLine("\t 1 - Add");
//                Console.WriteLine("\t 2 - Subtract");
//                Console.WriteLine("\t 3 - Multiply");
//                Console.WriteLine("\t 4 - Divide");
//                Console.WriteLine("\t 0 - Exit");
//                Console.Write(" Your option? ");
//                try
//                {
//                    op = int.Parse(Console.ReadLine());
//                    if (op != 1 && op != 2 && op != 3 && op != 4)
//                    {
//                        throw new Exception(op.ToString());
//                    }
//                    if (op == 4)
//                        if (num2 == 0)
//                            throw new DivideByZeroException(" Division by zero is not allowed !");
//                    result = Calculator(num1, num2, op);
//                }
//                catch (DivideByZeroException ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(" Operation Error: {0} is not a valid op", ex.Message);
//                }
//                Console.Write(" Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
//                if (Console.ReadLine() == "n")
//                    endOperation = true;
//                Console.WriteLine("\n");
//                Console.Read();
//                static double Calculator(double n1, double n2, int op)
//                {
//                    double result = 0.00;
//                    switch (op)
//                    {
//                        case 1:
//                            result = n1 + n2;
//                            Console.WriteLine(" Result is = {0}", result);
//                            break;
//                        case 2:
//                            result = n1 - n2;
//                            Console.WriteLine(" Result is = {0}", result);
//                            break;
//                        case 3:
//                            result = n1 * n2;
//                            Console.WriteLine(" Result is = {0}", result);
//                            break;
//                        case 4:
//                            if (n2 != 0)
//                            {
//                                result = n1 / n2;
//                                Console.WriteLine(" Result is = {0}", result);
//                            }
//                            break;
//                        default:
//                            break;
//                    }
//                    return result;
//                }
//            }
//            return;
//        }
//    }
//}


// Calculator 
//using System;

//namespace consol1
//{
//    class Calculator
//    {
//        public static double DoOperation(double num1, double num2, int op)
//        {
//            double result = double.NaN;
//            switch (op)
//            {
//                case 1:
//                    result = num1 + num2;
//                    break;
//                case 2:
//                    result = num1 - num2;
//                    break;
//                case 3:
//                    result = num1 * num2;
//                    break;
//                case 4:
//                    if (num2 != 0)
//                    {
//                        result = num1 / num2;
//                    }
//                    break;
//                default:
//                    break;
//            }
//            return result;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool endOperator = false;
//            Console.WriteLine(" Console Calculator in C#\r");
//            Console.WriteLine(" ------------------------\n");
//            while (!endOperator)
//            {
//                string numInput1 = "";
//                string numInput2 = "";
//                double result = 0;
//                Console.Write(" Enter the First number : ");
//                numInput1 = Console.ReadLine();
//                double cleanNum1 = 0;
//                while (!double.TryParse(numInput1, out cleanNum1))
//                {
//                    Console.Write(" This is not valid input. Please enter an integer value : ");
//                    numInput1 = Console.ReadLine();
//                }
//                Console.Write(" Ente rthe Second Number : ");
//                numInput2 = Console.ReadLine();
//                double cleanNum2 = 0;
//                while (!double.TryParse(numInput2, out cleanNum2))
//                {
//                    Console.Write(" This is not valid input. Please enter an integer value : ");
//                    numInput2 = Console.ReadLine();
//                }
//                Console.WriteLine(" Choose an operator from the following list :");
//                Console.WriteLine("\t 1 - Add");
//                Console.WriteLine("\t 2 - Subtract");
//                Console.WriteLine("\t 3 - Multiply");
//                Console.WriteLine("\t 4 - Divide");
//                Console.WriteLine("\t 0 - Exit");
//                Console.Write(" Your option? ");
//                int op = Convert.ToInt32(Console.ReadLine());
//                try
//                {
//                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
//                    if (double.IsNaN(result))
//                    {
//                        Console.WriteLine(" Operation error ! \n");
//                    }
//                    else Console.WriteLine(" Your result: {0:0.##}\n", result);
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(" Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
//                }
//                Console.WriteLine("------------------------\n");
//                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
//                if (Console.ReadLine() == "n")
//                    endOperator = true;
//                Console.WriteLine("\n");
//            }
//            return;
//        }
//    }
//}







//using System;

//namespace consol1
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine(" Hello World!");

//            bool endoperation = false; // Sets value of loop variable to false.
//            while (endoperation == false) // Causes the program to repeatedly run until the user chooses to stop.
//            {
//                MessageOptions(); // Calls a procedure which lists the user's options.
//                var input = Console.ReadLine();
//                int Input;

//                while ((!int.TryParse(input, out Input)) | (!(Input >= 0 && Input <= 6))) // Loop repeats while either the user's input can't be passed into an int variable or while the int is not between 0 and 6 inclusive.
//                {
//                    Console.WriteLine("ERROR: Invalid Input");
//                    MessageOptions();
//                    input = Console.ReadLine();
//                }

//                if (Input == 0) // Input of 0 exits the program
//                {
//                    Console.WriteLine(" Exit");
//                    endoperation = true;
//                    break;
//                }
//                FirstInput(Input); // Calls a procedure which gets the user's first number, the message depending on the user's previous input.
//                var strNum1 = Console.ReadLine();
//                double num1;

//                while ((!double.TryParse(strNum1, out num1))) // Loop repeats while the user's input can't be passed into a double variable.
//                {
//                    Console.WriteLine("ERROR: Invalid Input");
//                    FirstInput(Input);
//                    strNum1 = Console.ReadLine();
//                }

//                SecondInput(Input); // Calls a procedure which gets the user's first number, the message depending on the user's previous input
//                var strNum2 = Console.ReadLine();
//                double num2;

//                while ((!double.TryParse(strNum2, out num2))) // Loop repeats while the user's input can't be passed into a double variable.
//                {
//                    Console.WriteLine("ERROR: Invalid Input");
//                    SecondInput(Input);
//                    strNum2 = Console.ReadLine();
//                }

//                switch (Input) // Passes the user's two numbers into corresponding procedure for a certain mathematical operation.
//                {
//                    // inputInt corresponds to the user's respones to the operation they wish to perform.
//                    case 1:
//                        Console.WriteLine(Add(num1, num2));
//                        break;
//                    case 2:
//                        Console.WriteLine(Subtract(num1, num2));
//                        break;
//                    case 3:
//                        Console.WriteLine(Multiply(num1, num2));
//                        break;
//                    case 4:
//                        Console.WriteLine(Divide(num1, num2));
//                        break;
//                    case 5:
//                        Console.WriteLine(Powers(num1, num2));
//                        break;
//                    case 6:
//                        Console.WriteLine(Logarithm(num1, num2));
//                        break;
//                }
//            }
//        }

//        static double Powers(double number, double power) // Raises the first number to the power of the second number and returns the result.
//        {
//            return Math.Pow(number, power);
//        }

//        static double Add(double number, double number2) // Adds together both numbers and returns the result.
//        {
//            return number + number2;
//        }

//        static double Subtract(double number, double number2) // Subtracts the second number from the first number and returns the result.
//        {
//            return number - number2;
//        }

//        static double Multiply(double number, double number2) // Multiplies together both numbers and returns the result.
//        {
//            return number * number2;
//        }

//        static double Divide(double number, double number2) // Divides the first number by the second number and returns the result.
//        {
//            return number / number2;
//        }

//        static double Logarithm(double number, double number2) // Returns the logarithm of base first number and argument second number.
//        {
//            return Math.Log(number2, number);
//        }

//        static public void MessageOptions() // Displays the user's inital options.
//        {
//            Console.WriteLine();
//            Console.WriteLine("-------------------------------------");
//            Console.WriteLine("Choose one of the following options: ");
//            Console.WriteLine("1. Addition");
//            Console.WriteLine("2. Subtraction");
//            Console.WriteLine("3. Multiplication");
//            Console.WriteLine("4. Division");
//            Console.WriteLine("5. Powers");
//            Console.WriteLine("6. Logarithms");
//            Console.WriteLine("0. Exit");
//            Console.WriteLine("-------------------------------------");
//        }

//        static public void FirstInput(int input) // Displays what number should be entered dependent on the inital input.
//        {
//            switch (input)
//            {
//                case 1:
//                case 2:
//                case 3:
//                case 4:
//                    Console.WriteLine("Enter the first number: ");
//                    break;
//                case 5:
//                    Console.WriteLine("Enter the base number: ");
//                    break;
//                case 6:
//                    Console.WriteLine("Enter the logarithm's base: ");
//                    break;
//            }
//        }

//        static public void SecondInput(int input) // Displays what number should be entered dependenent on the inital input.
//        {
//            switch (input)
//            {
//                case 1:
//                case 2:
//                case 3:
//                case 4:
//                    Console.WriteLine("Enter the second number: ");
//                    break;
//                case 5:
//                    Console.WriteLine("Enter the exponent: ");
//                    break;
//                case 6:
//                    Console.WriteLine("Enter the logarithm's argument: ");
//                    break;
//            }
//        }
//    }
//}




//using System;
//namespace consol1
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine(" Simple Calculator : ");
//            bool endoperation = false;
//            while (endoperation == false)
//            {
//                Options();
//                var input = Console.ReadLine();
//                int Input;
//                while ((!int.TryParse(input, out Input)) | (!(Input >= 0 && Input <= 4)))
//                {
//                    Console.WriteLine(" ERROR: Invalid Input ! Enter Only Numbers \n");
//                    Options();
//                    input = Console.ReadLine();
//                }
//                if (Input == 0)
//                {
//                    Console.WriteLine(" Exit");
//                    endoperation = true;
//                    break;
//                }
//                FirstInput(Input);
//                var strNum1 = Console.ReadLine();
//                double num1;
//                while ((!double.TryParse(strNum1, out num1)))
//                {
//                    Console.WriteLine(" ERROR: Invalid Input ! Enter Only Number \n");
//                    FirstInput(Input);
//                    strNum1 = Console.ReadLine();
//                }
//                SecondInput(Input);
//                var strNum2 = Console.ReadLine();
//                double num2;
//                while ((!double.TryParse(strNum2, out num2)))
//                {
//                    Console.WriteLine(" ERROR: Invalid Input ! Enter Only Number \n");
//                    SecondInput(Input);
//                    strNum2 = Console.ReadLine();
//                }
//                switch (Input)
//                {
//                    case 1:
//                        Console.WriteLine(Add(num1, num2));
//                        break;
//                    case 2:
//                        Console.WriteLine(Subtract(num1, num2));
//                        break;
//                    case 3:
//                        Console.WriteLine(Multiply(num1, num2));
//                        break;
//                    case 4:
//                        Console.WriteLine(Divide(num1, num2));
//                        break;
//                }
//            }
//        }
//        static double Add(double number1, double number2)
//        {
//            return number1 + number2;
//        }
//        static double Subtract(double number1, double number2)
//        {
//            return number1 - number2;
//        }
//        static double Multiply(double number1, double number2)
//        {
//            return number1 * number2;
//        }
//        static double Divide(double number1, double number2)
//        {
//            return number1 / number2;
//        }
//        static public void Options()
//        {
//            Console.WriteLine();
//            Console.WriteLine("-------------------------------------");
//            Console.WriteLine(" Choose one of the following options: ");
//            Console.WriteLine(" 1. Addition");
//            Console.WriteLine(" 2. Subtraction");
//            Console.WriteLine(" 3. Multiplication");
//            Console.WriteLine(" 4. Division");
//            Console.WriteLine(" 0. Exit");
//            Console.WriteLine("-------------------------------------");
//        }
//        static public void FirstInput(int input)
//        {
//            switch (input)
//            {
//                case 1:
//                case 2:
//                case 3:
//                case 4:
//                    Console.Write(" Enter the first number : ");
//                    break;
//            }
//        }
//        static public void SecondInput(int input)
//        {
//            switch (input)
//            {
//                case 1:
//                case 2:
//                case 3:
//                case 4:
//                    Console.Write(" Enter the second number : ");
//                    break;
//            }
//        }
//    }
//}




// Calculator......// Output...
using System;
namespace consol1
{
    class Program
    {
        static void Main(String[] arg)
        {
            bool endOperation = false;
            while (!endOperation)
            {
                double num1, num2;
                int op = 0;
                Console.Write(" num1 =  ");
                bool Parsesuccess = double.TryParse(Console.ReadLine(), out num1);
                while (!Parsesuccess)
                {
                    Console.WriteLine(" Please enter the Numbers Only !");
                    Parsesuccess = double.TryParse(Console.ReadLine(), out num1);
                }
                Console.Write(" num2 =  ");
                bool parsesuccess = double.TryParse(Console.ReadLine(), out num2);
                while (!parsesuccess)
                {
                    Console.WriteLine(" Please enter the Numbers Only !");
                    parsesuccess = double.TryParse(Console.ReadLine(), out num2);
                }
                MessageOptions();
                try
                {
                    op = int.Parse(Console.ReadLine());
                    if (op != 1 && op != 2 && op != 3 && op != 4)
                    {
                        throw new Exception(op.ToString());
                    }
                    if (op == 4)
                        if (num2 == 0)
                            throw new DivideByZeroException(" Division by zero is not allowed !");

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Operation Error: {0} is not a valid op", ex.Message);
                }

                Console.Write(" Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                    endOperation = true;
                Console.WriteLine("\n");
                Console.Read();
                switch (op)
                {
                    case 1:
                        Console.WriteLine(Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(Subtract(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(Multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(Divide(num1, num2));
                        break;
                }

            }

        }
        static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        static public void MessageOptions()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Choose one of the following options: ");
            Console.WriteLine(" 1. Addition");
            Console.WriteLine(" 2. Subtraction");
            Console.WriteLine(" 3. Multiplication");
            Console.WriteLine(" 4. Division");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("-------------------------------------");
        }
    }
}
