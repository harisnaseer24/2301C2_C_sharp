﻿
//Console.WriteLine("Hello, Haris!");

//DATATYPES
/*
 
int age = 18;
long daysLived = 14636213256L;
float percentage = 78.99F;
double speedOflight = 3.8374847374894767;
decimal points = 4.993M;



//char favCharacter = '\n';
//string name = "Haris Nasser";
// bool istrue= true;

//Console.WriteLine("Enter Your Name?");
//string UserName= Console.ReadLine();

//Console.WriteLine("Welcome, " + UserName);

//Operators
int a = 30, b = 10;
//Arithmetical Operators
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

// assignment operators
a += 23;// a = a + 23
Console.WriteLine(a);
a -= 23;// a = a - 23
Console.WriteLine(a);
a *= 3;// a = a * 3
Console.WriteLine(a);
a /= 3;// a = a / 3
Console.WriteLine(a);


// Comparison operaators
Console.WriteLine(a == b);//False
//Console.WriteLine(a != b);//True
//Console.WriteLine(a < b);//False
//Console.WriteLine(a > b);//True
Console.WriteLine(a <= b);//False
Console.WriteLine(a >= b);//True

// Logical Operators
//And

Console.WriteLine(a <= b && a != b);

//Or
Console.WriteLine(a <= b || a != b);

//Not
Console.WriteLine(!(a <= b) && a != b);

// Conditional Statements


Console.WriteLine("Please Enter Your Age : ");

int age = Int32.Parse(Console.ReadLine());

//if else ladder
if (age >18 )
{
    Console.WriteLine("You are Eligible to vote.");
}
else if (age == 18)
{
    //Nested if else ladder

    Console.WriteLine("Do you have NIC..? Press 'Y' for yes and 'N' for no");

    char status = char.Parse(Console.ReadLine());
    if(status =='Y' || status == 'y')
    {
        Console.WriteLine("You can Vote.");
    }
    else if (status == 'N' || status == 'n')
    {
        Console.WriteLine("Sorry, You can't Vote.");
    }
   else 
    {
        Console.WriteLine("Press Y or N only.");
    }
}
else
{
    Console.WriteLine("Sorry, You are not Eligible to vote.");
}
// Switch
Console.WriteLine("Please enter number for days from 1 to 7");
int day = Int32.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Today is Monday..");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday..");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday..");
        break;
    case 4:
        Console.WriteLine("Today is Thursday..");
        break;
    case 5:
        Console.WriteLine("Today is Friday..");
        break;
    case 6:
        Console.WriteLine("Today is Saturday..");
        break;
    case 7:
        Console.WriteLine("Today is Sunday..");
        break;
    default:
        Console.WriteLine("Invalid Number");
        break;

}

//Loops


//For
for (int i=1; i <= 100; i++)
{
    Console.WriteLine(i);
}
//reverse counting
for (int i = 100; i <=1; i--)
{
    Console.WriteLine(i);
}

//even
for (int i = 2; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
//odd
for (int i = 1; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
//5 table
for (int i = 5; i <= 50; i += 5)
{
    Console.WriteLine(i);
}

//While

int j = 0;
while ( j <= 10)
{
    Console.WriteLine(j);
    j++;
}


//Do While

int k = 0;
do
{
    Console.WriteLine(k);
    k++;

}
while (k > 10);


char choice;//global scope

do
{
    Console.WriteLine("Please enter number for days from 1 to 7");
    int day = Convert.ToInt32(Console.ReadLine());

    switch (day)
    {
        case 1:
            Console.WriteLine("Today is Monday..");
            break;
        case 2:
            Console.WriteLine("Today is Tuesday..");
            break;
        case 3:
            Console.WriteLine("Today is Wednesday..");
            break;
        case 4:
            Console.WriteLine("Today is Thursday..");
            break;
        case 5:
            Console.WriteLine("Today is Friday..");
            break;
        case 6:
            Console.WriteLine("Today is Saturday..");
            break;
        case 7:
            Console.WriteLine("Today is Sunday..");
            break;
        default:
            Console.WriteLine("Invalid Number");
            break;

    }

    Console.WriteLine("Pleas press Y to continue or any key to exit..!");
    choice = Convert.ToChar(Console.ReadLine());

}
while (choice == 'Y' || choice == 'y');


//Arrays
int[] evenNumbers = { 2,6,4,8,22 };//indexes 0-4 length 5
Console.WriteLine(evenNumbers[3]);

int[] evenNumbers = new int[6];//indexes 0-5 length 6 {0,0,54,0,0,0}
//evenNumbers[2] = 54; 
//Console.WriteLine(evenNumbers[3]);


//           i < 6

for( int i=0; i < evenNumbers.Length; i++)
{
    Console.WriteLine($"Please { i+1 } value for even numbers array");//String Interpolation
    evenNumbers[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Your entered array is :");
for (int j=0; j < evenNumbers.Length; j++)
{
    Console.WriteLine(evenNumbers[j]);


}
//Validation  for even numbers  63 -> 64

*/
//int[] evenNumbers = { 2, 14, 22, 8, 2 };
//{2, 8 ,22, 14, 2 }
/*Array.Sort(evenNumbers);//ascending order

Array.Reverse(evenNumbers);// descending order
for (int j = 0; j < evenNumbers.Length; j++)
{
    Console.WriteLine(evenNumbers[j]);


}

int index = Array.BinarySearch(evenNumbers, 22);
Console.WriteLine($"The desired number : 22 is at {index}");
int index = Array.IndexOf(evenNumbers, 2);
Console.WriteLine($"The desired number : 2 is at {index}");

int Lastindex = Array.LastIndexOf(evenNumbers, 2);
Console.WriteLine($"  2 's last occurence  is at {Lastindex}");


//Printing an array using foreach loop

string[] products = { "watch", "airbuds", "uv glass", "back cover", "wrap"};//5 0-4
// var : select datatype automatically.

foreach (var product in products)
{
	Console.Write(product+ " ");// writes in same line
}

//Multidimensional Array( Arrays inside an array ) but fixed size 
//2d array inside an array

int[,] marks =
{
    {20,40 },
    {40,60 }
};
//3d array inside an array inside an array 2X2X2
int[,,] data =
{
	{
        { 20,40} ,{10,20}
    },
	{
        { 60,50},{ 30,70}
    }
};

string[,] groups =
{
    {
        "Fazal",//[0,0]
        "Afzal"//[0,1]
    },
    {
        "Yahya", 
        "umer" 
    },
    {
        "Waleed",
        "Zeeshan" //[2,1]
    }
};
 3 X 2
//Console.WriteLine(groups[2,1]);
//nested loop

for (int i = 0; i < groups.GetLength(0); i++)// outer loop
{
	Console.WriteLine($"Group{i + 1}");

	for (int j = 0; j < groups.GetLength(1); j++)// inner loop
	{
		
		Console.WriteLine(groups[i, j]);
	}
	Console.WriteLine();
}

//placeholder
string fname = Console.ReadLine();
string mname = Console.ReadLine();
string lname = Console.ReadLine();

Console.WriteLine("Hello {1} {2} {0}",fname,mname,lname);

//Jagged Array

string[][] skillset =
{
     new string[2]{"PHP", "MySql"},
     new string[4]{"PHP", "MySql", "NextJs", "Python"},
     new string[1]{"Batain Banana"},
     new string[3]{"C#", "SQL SERVER", "Typescript"},

};



foreach (var item in skillset)
{
    foreach (var item1 in item)
    {
        Console.WriteLine(item1);
        
    }
    Console.WriteLine();
}
;



//Functions
//Pre defined 
//Math.Cos(90);
//Math.Sqrt(49);//7

//User defined

void sqWithSqrt()
{
    int number = 49;
    int square = number * number;
    Console.WriteLine($"Square of {number} is : {square}");
    Console.WriteLine($"Square Root of {number} is : {Math.Sqrt(number)}");
}

sqWithSqrt();

//1. No  Return with no Parameters
//Function Definition
void Greet()
{
    Console.WriteLine("Salam, Jumma Mubarak");
}
//Calling a function
Greet();

//2.  Return with no Parameters
string Greet()
{
   return ("Salam, Jumma Mubarak");
}
//Calling a function

string msg = Greet();
Console.WriteLine(msg);


Console.WriteLine(Greet());

//3. No  Return with Parameters
void Greet(string name)//parameter
{
    Console.WriteLine($"Salam {name}, Jumma Mubarak");
}
//Calling a function
Greet("Haris");// argument

//4. Return with Parameters
string Greet(string name,int age)
{
    return ($"Hi {name}, your age is {age}.We Warmly welcome you.");
}
//Calling a function

string msg = Greet("Haris",45);
Console.WriteLine(msg);

//Percentage Calculator

// (obt/total)*100

//Exception Handling 
//try | catch

try
{
    int age = Convert.ToInt32(Console.ReadLine());
    if(age >= 60)
    {
        Console.WriteLine("You should Rest now");
    }
    else
    {
        Console.WriteLine("Keep doing hard work.");
    }

}
catch (FormatException)
{
    Console.WriteLine("Please enter numeric value for age");
}



//Collections

//Generics -- (Dynamic Size) List + Additional Methods
//Non Generics -- (Fixed Size) Arrays



//List
//Generic Collection
List<string> Mobiles = new List<string>();

Mobiles.Add("Samsung S24");
Mobiles.Add("Oppo F11");
Mobiles.Add("Redmi Note 14");
Mobiles.Add("Apple Iphone 15 pro");
Mobiles.Add("Nokia 3310");
Mobiles.Add("Google Pixel 8pro");
Console.WriteLine(Mobiles[4]);
Mobiles.Remove("Nokia 3310");

Console.WriteLine("Displaying Cellphones");
Mobiles.Insert(4, "Realme Gt");


foreach (var item in Mobiles)
{
    Console.WriteLine(item);
}

Console.WriteLine(Mobiles.Count());
Console.WriteLine(Mobiles.Contains("Nokia 3310"));//true /false

Mobiles.Clear(); //Empty list


//Create a List. Get input for list items from user. If user types "no",
//you have to print all items in the list.

*/
// 

//Generic Collection (Datatype is defined)
//Queue
//fifo -- First in first out


//Queue<string> names = new Queue<string>();
//names.Enqueue("Haris");
//names.Enqueue("Jameel");
//names.Enqueue("Shariq");
//names.Enqueue("Qasim");
//names.Enqueue("Waleed");
//names.Enqueue("Owais");

//names.Dequeue();
//names.Dequeue();
//names.Dequeue();

//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}


//Stack
//lifo -- Last in first out

//Stack<string> names = new Stack<string>();
//names.Push("Haris");
//names.Push("Jameel");
//names.Push("Shariq");
//names.Push("Qasim");
//names.Push("Waleed");
//names.Push("Owais");

//names.Pop();
//names.Pop();
//names.Pop();
//names.Pop();


//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}


//Non - generic (Any type can become an element. As a object)
//ArrayList
//using System.Collections;
//ArrayList address = new ArrayList();
//address.Add("Gulistan e johar");
//address.Add("Block 16");
//address.Add("Street 2");
//address.Add("R 834");


//ArrayList person = new ArrayList();
//person.Add("Mr. Zeldon");
//person.Add(28);
//person.Add(3124545457845);
//person.Add("CEO");
//person.Add("BSCS");
//person.Add("Karachi");
//person.Remove(28);
//person.RemoveAt(0);
//person.RemoveRange(0,2);

//person.AddRange(address);
//bool isMSCS= person.Contains("MSCS");
//person.Clear();
//Console.WriteLine(person[2]);
//foreach (var property in person)
//{
//    Console.WriteLine(property);
//}
//Console.WriteLine(isMSCS);

//Create an Array List for Mobile specifications. Take input from user and save the features in your arraylist.
//As User types ok in input you have to display a thanks msg with all specifications.


//Dictionary (Generics) (key : value)

//using System.Collections;

//Dictionary<string, string> Accesories = new Dictionary<string, string>();

//Accesories.Add("product 1","Fast Charging Cable");
//Accesories.Add("product 2","Fast Charger");
//Accesories.Add("product 3","Handsfree");
//Accesories.Add("product 4","AirPods");
//Accesories.Add("product 5","AirDots");
//Accesories.Add("product 6","Smart Watch");
////Accesories.Add();
//Accesories.Remove("product 5");


//Console.WriteLine(Accesories.ContainsValue("Smart Watch"));

//for (int i = 1; i <=6; i++)
//{
//    Console.WriteLine(Accesories["product "+i]);
//}

//foreach (var item in Accesories)
//{

//   string[] test= (item.ToString()).Split(",");// returns an array\
//    string key = test[0].Trim('[');// product 1
//    string value = test[1].Trim(']'); 

//    Console.WriteLine("This is key : {0} and this is value : {1}",key, value);


//}

//Hashtable (Non-Generics) (key : value)// Searching()

//Hashtable Singers = new Hashtable();// Calling constructor of Hashtable class for creating its object
//Singers.Add("top 1","Arijit");
//Singers.Add(2,"Atif");
//Singers.Add(3.0,"Rahat fateh");
//Singers.Add(false,123);

//Console.WriteLine(Singers[3.0]);

//foreach (DictionaryEntry item in Singers)
//{
//    Console.WriteLine(item.Key+":"+ item.Value);
//}

//Console.WriteLine(Singers.GetHashCode());


//String Methods
//string test = "we-aRE-Learn-i-ng-C#";
//Console.WriteLine(test.Replace("Learning", "Mastering"));
//Console.WriteLine(test.ToLower());
//Console.WriteLine(test.ToUpper());

//string[] abc = test.Split("-");
//foreach (string item in abc)
//{
//    Console.WriteLine(item);


//}
//Console.WriteLine(test.Trim('-'));

//Classes & Objects

//Person abc = new Person();
//Console.WriteLine(abc.PName);

//abc.PName = "Farooq";
//abc.CellNo = "+92 315655656";
//abc.Address = "h no 123, block a, stree 1, karachi.";
//abc.age = 24;
//Console.WriteLine(abc.PName);
//Console.WriteLine(abc.CellNo);
//Console.WriteLine(abc.Address);
//Console.WriteLine(abc.age);


//Person haris = new Person("Haris","+92 3172021951","hfkjdshf sjdkfk",45);
//Console.WriteLine(haris.PName);
//Console.WriteLine(haris.CellNo);
//Console.WriteLine(haris.Address);
//Console.WriteLine(haris.age);

//class Person
//{
//    public string PName, CellNo, Address;
//    public int age;

//    //constructor
//    public Person()
//    {
//        this.PName = "Anonymous"; 
//        this.CellNo = "Anonymous"; 
//        this.Address = "Unknown"; 
//        this.age = 100;
//    }

//    //constructor method(overloading)
//    public Person(string name, string no, string add, int age)
//    {
//        this.PName = name;
//        this.CellNo = no;
//        this.Address = add;
//        this.age = age;
//    }

//}


// Coding Best Practices:

//Indentation (Readable by using new lines and spaces)
//less Repeatation
//Comments
//Meaningful Variable Names
//No errors


//OOP (Objected Oriented Programming) approach || tariqa
//it is used to make code readable & reusable


// Main pillars of OOP

//1. Inheritance

//2. Polymorphism

// Method Overloading add(0,2), add(1,2,3), add(4,5,6,7,8,9,10) 
// Method Overriding 

//3. Abstraction
//4. Encapsulation

//1. Inheritance
//access modifiers


//Single inheritance Vehicle -> Car
//Multilevel Inheritance Vehicle -> Car -> ECar
//Heirarchical inheritance Vehicle - >Car , Vehicle -> Bike , Vehicle ->truck
//Multiple inheritance   
//Hybrid inheritance  Vehicle - >Car , Car -> Ecar ,  Vehicle -> Car -> ECar( more than one type of inheritance)


//Vehicle accord = new Vehicle();
//accord.run();


//Car camry = new Car("Toyota Camry","2024 LE","v8","320 kph");
//camry.run();
//camry.stop();

//ECar tesla = new ECar("Tesla ", "2024 LE", "v6", "220 kph","800 KMS");
//tesla.run();
//tesla.stop();

//Vehicle abc = new Vehicle();// Abstract class
//Math abc = new Math();
//abc.Sqrt(49);

//Static 
//Math.Sqrt(5);
//Vehicle.raceStart();
//Console.WriteLine(Vehicle.NoofLaps);



//Parent Class (Base class)(Super Class)
//abstract public class Vehicle
//{
//    public string speed;
//    static public int NoofLaps=4;

//    public void run()
//    {
//        Console.WriteLine("the Vehicle started running.");
//    }
//    static public void raceStart()
//    {
//        Console.WriteLine("the Race has just begin . May the best be winner");
//    } 
//    public void run(string name)
//    {
//        Console.WriteLine($"the {name} started running.");
//    } 
//    public void stop()
//    {
//        Console.WriteLine("the Vehicle is stopped.");
//    }
//}

////Child Class (sub class)(Derived Class)
////class Car extends Vehicle
//class Car: Vehicle
//{
//   public string name;
//   public string model;
//   public string power;

//    public Car(string name, string model, string power, string speed)
//    {
//        this.name = name;
//        this.model = model;
//        this.power = power;
//        this.speed = speed;
//    }

//    //Overriding run() and stop() methods here
//    public void run()
//    {   
//        //run funtion now prints the name and speed of car too.
//        Console.WriteLine($"{this.name} is running at {this.speed}");
//    }
//    public void stop()
//    {   
//        //stop funtion now prints the name and dift of car too when stopping.
//        Console.WriteLine($"the {this.name} is stopped with drift.");
//    }

//}

//// inheriting Cars class
//class ECar : Car
//{
//    public string OneChargeDistance;


//    public ECar(string name, string model, string power, string speed, string OneChargeDistance):base(name, model, power, speed)
//    {
//        this.OneChargeDistance = OneChargeDistance;

//    }

//    //Overriding run() and stop() methods here
//    public void run()
//    {
//        //run funtion now prints the name and speed of car too.
//        Console.WriteLine($"{this.name} is running at {this.speed} and it gives {this.OneChargeDistance} in one Charge.");
//    }


//}

//InterFaces ()

//FrontEndDevloper haris = new FrontEndDevloper();
//haris.complexDesign();
//haris.basicDesign();

//BackEndDevloper Ebad = new BackEndDevloper();
//Ebad.basicCrud();
//Ebad.complexAPIs("Ebad");

//FullStackDeveloper haris = new FullStackDeveloper();
//haris.LearningSession();
//haris.basicDesign();
//haris.complexAPIs("Haris Naseer");


//interface FrontEndDevlopment
//{
//   void basicDesign();
//   void complexDesign();
//}


//interface BackEndDevelopment
//{
//    void basicCrud();
//    void complexAPIs(string devName);
//}

//public class FrontEndDevloper: FrontEndDevlopment
//{
//   public void basicDesign()
//    {
//        Console.WriteLine("WE will provide you a basicc design using html, Css and Bootstrap.");
//    }
//    public void complexDesign()
//    {
//        Console.WriteLine("WE will provide you a Complex design using React or Vue or NextJS .");
//    }
//}


//public class BackEndDevloper: BackEndDevelopment
//{
//   public void basicCrud()
//    {
//        Console.WriteLine("WE will provide you basic CRUD Operations.");
//    }
//    public void complexAPIs(string devName)
//    {
//        Console.WriteLine($"{devName} will provide you  Complex APIs with authentication .");
//    }
//}


////Multiple Inheritance
//public class FullStackDeveloper : FrontEndDevlopment, BackEndDevelopment
//{
//    public void basicDesign()
//    {
//        Console.WriteLine("WE will provide you a basic design using html, Css and Bootstrap.");
//    }
//    public void complexDesign()
//    {
//        Console.WriteLine("WE will provide you a Complex design using React or Vue or NextJS .");
//    }

//    public void basicCrud()
//    {
//        Console.WriteLine("WE will provide you basic CRUD Operations.");
//    }
//    public void complexAPIs(string devName)
//    {
//        Console.WriteLine($"{devName} will provide you  Complex APIs with authentication .");
//    }
//    public void LearningSession()
//    {
//         Console.WriteLine($"Our Quality developer will provide you session.");
//    }


//}

//Abstraction

// Facebook user, admin panel, 



//Encapsulation

//



//Access Modifiers

//1. public : any one can access.

//2. private : only owner class can access.

//3. protected : only owner class and child class can access


//Watch citizen = new Watch("CZ123", 5600, "Titanium Black");
//Console.WriteLine(citizen.model);
////Console.WriteLine(citizen.price);
////Console.WriteLine(citizen.color);
//citizen.ShowPrice();
//citizen.ShowColor();

//SmartWatch appleWatch = new SmartWatch("series 9",45000,"Silver",true);
//appleWatch.showWatch();


//public class Watch
//{
//    public string? model;
//    private int price;
//    protected string? color;

//    public Watch(string model, int price , string color)
//    {
//        this.model = model;
//        this.price = price;
//        this.color = color;
//    }  
//    public void ShowPrice()
//    {
//        Console.WriteLine(this.price);
//    } public void ShowColor()
//    {
//        Console.WriteLine(this.color);
//    }

//}

//public class SmartWatch : Watch
//{
//    public bool canCall;
//    public SmartWatch(string model, int price, string color, bool canCall):base(model, price, color)
//    {
//        this.canCall = canCall;
//    }
//    public void showWatch()
//    {
//        Console.WriteLine(this.model);
//        // Console.WriteLine(this.price);// cant access a private property in child class
//        this.ShowPrice();
//        Console.WriteLine(this.color);// can access a protected property in child class
//        Console.WriteLine(this.canCall);
//    }
//}


//Ternary Operator
//string check = (Condtion)? firstValue : SecondValue

//int check = (98 >= 56) ? 7 : 9;// if-else
//Console.WriteLine(check);

//Multicast Delegates

//Maths.Calculate Evaluate;

//Evaluate = Maths.Add;
//Evaluate(45,5.2);

//Evaluate = Maths.Multiply;
//Evaluate(50, 5);

//Evaluate = Maths.Divide;

//Evaluate(50, 0);

////Evaluate = Maths.Sub;

////Evaluate(50,4);
//////Evaluate = Maths.PercentageCalculator;

//Maths.PercentageCalculator(45, 78, 49, 300);


//public class Maths
//{
//    public delegate void Calculate(double num1, double num2);

//    public static void Add(double num1, double num2)
//    {
//        Console.WriteLine(num1 + num2);
//    }

//    public static void Sub(double num1, double num2)
//    {
//        Console.WriteLine(num1 - num2);
//    }
//    public static void Multiply(double num1, double num2)
//    {
//        Console.WriteLine(num1 * num2);
//    }
//    public static void Divide(double num1, double num2)
//    {
//        if (num2 != 0)
//        {
//            Console.WriteLine(num1 / num2);
//        }
//        else
//        {
//            Console.WriteLine("Can't divide by zero");
//        }
//    }
//    public static void PercentageCalculator(double num1, double num2, double num3, double total)
//    {
//        double per = (num1 + num2 + num3) / total * 100;
//        Console.WriteLine(per);
//    }
//}

//Office.Hiring employee;

//employee = Office.AcademicsDepart;
//employee("Haris Naseer", 788888, "haris@gmail.com");

//employee = Office.SalesDepart;
//employee("Umair Tariq", 650000, "umairtariq@gmail.com");

//employee = Office.HRDepart;
//employee("Umair Tariq", 650000, "umairtariq@gmail.com");

//Office.HRDepart("Yahya", 50000);

//public class Office
//{
//    public delegate void Hiring(string name, int salary, string email);

//    public static void AcademicsDepart(string name, int salary, string email)
//    {
//        Console.WriteLine($"{name} is hired in Academic Department at {salary} PKR. He can be contacted at {email}");
//    }
//    public static void AccountDepart(string name, int salary, string email)
//    {
//        Console.WriteLine($"{name} is hired in Accounts Department at {salary} PKR. He can be contacted at {email}");
//    }
//    public static void SalesDepart(string name, int salary, string email)
//    {
//        Console.WriteLine($"{name} is hired in Sales Department at {salary} PKR. He can be contacted at {email}");
//    }
//    public static void HRDepart(string name, int salary)
//    {
//        Console.WriteLine($"{name} is hired in Sales Department at {salary} PKR. ");
//    }

//}


//getter and setter (encapsulation)
//Burger majestic = new Burger("The Majestic", 730);
//Console.WriteLine(majestic.name);
//Console.WriteLine(majestic.Price);


//Burger Doppler = new Burger("The Doppler", 2730);
//Console.WriteLine(Doppler.name);
//Console.WriteLine(Doppler.Price);


//public class Burger
//{
//    public string name;
//    private int price;
//   // public int Price { get; set; }//auto complete properties

//    public int Price
//    {
//        get { return price; }
//        set { 
//            if(value <= 2000)
//            {
//            price = value;
//            }
//            else
//            {
//                price = 2000;
//            }

//        }
//    }

//    public Burger(string name, int price)
//    {
//        this.name = name;
//        this.Price = price;
//    }
//}

//auto complete properties

//enums (collection of constant integers);

//Implicit (small to big)
//Explicit (big to small)

//Console.WriteLine(Players.fakhar+ " has "+ (int)Players.fakhar+ " jersey number");

//enum Players
//{
//    saim =43,
//    babar =56,
//    rizwan =100,
//    fakhar= 78,
//    amir= 5,

//}


//LINQ (Language Integerated Query)
//Ienumerable (foreach)
//Iqueryable (database like queries can be implemented)

//Lambda Expression (Arrow Function) e => e.id

//Employee emp1 = new Employee(1,"Murtaza","Web Developer",50000,32,"Web");
//Employee emp2 = new Employee(2,"Arham","Web Designer",45000,43,"Web");
//Employee emp3 = new Employee(3,"Noman","Content Creator",47000,45,"Media");
//Employee emp4 = new Employee(4,"Furqan","Team Lead",70000,53,"Web");
//Employee emp5 = new Employee(5,"Adeel","Sales Executive",60000,42,"Sales");

//Employee emp6 = new Employee(6, "Muzammil", "Seo & Marketing officer",57000,46,"Marketing");

//List<Employee> employees = new List<Employee>();
//employees.Add(emp1);
//employees.Add(emp2);
//employees.Add(emp3);
//employees.Add(emp4);
//employees.Add(emp5);
//employees.Add(emp6);


//1 ForEach
//employees.ForEach(emp => Console.WriteLine("id : {0}, name : {1}, designation : {2}, salary : {3} , age : {4}, department : {5} ", emp.id, emp.name, emp.designation, emp.salary, emp.age, emp.depart));

//2 OrderBy
//employees = employees.OrderBy(emp=> emp.name).ToList();

//employees = employees.OrderBy(emp => emp.name).ThenBy(emp => emp.depart).ToList();
//employees = employees.OrderByDescending(emp => emp.name).ThenByDescending(emp => emp.depart).ToList();

//3 Select
//IEnumerable<string> names = employees.Select(emp => emp.name);
//foreach (var name in names) { Console.WriteLine(name); }

//Console.WriteLine();

//4 Where 
//employees = employees.Where(emp => emp.age >35 && emp.salary <=56000).ToList();

//employees = employees.Where(emp => emp.age > 35 || emp.salary != 57000).ToList();


//5 Skip and Take
//employees = employees.Where(emp => emp.age > 35 || emp.salary != 57000).Skip(3).ToList();

//employees = employees.Where(emp => emp.age > 35 || emp.salary != 57000).Take(3).ToList();
//employees = employees.Where(emp => emp.age > 35 || emp.salary != 57000).Skip(2).Take(3).ToList();


// First , Last , Single , FirstOrDefault, LastOrDefault

//Employee first = employees.First(t => t.depart =="Web");
//Employee last = employees.Last(t => t.depart =="Web");

//Employee single = employees.Single(t => t.salary == 60000);


//Console.WriteLine(single.name);


//Aggregate Methods

//Console.WriteLine(employees.Count());

//Console.WriteLine(employees.Min(emp => emp.salary));//returns a min value

//Employee minSalPerson = employees.MinBy(emp => emp.salary);
//Console.WriteLine(minSalPerson.name+" gets "+ minSalPerson.salary);//returns  min value Object




//foreach (Employee emp in employees)
//{
//    Console.WriteLine("id : {0}, name : {1}, designation : {2}, salary : {3} , age : {4}, department : {5} ", emp.id, emp.name, emp.designation, emp.salary, emp.age, emp.depart);
//}


//public class Employee
//{
//    public int id { get; set; }
//    public string name { get; set; }
//    public int salary { get; set; }
//    public string designation { get; set; }
//    public string depart { get; set; }
//    public int age { get; set; }

//    public Employee(int id, string name, string designation, int salary, int age , string depart) { 


//        this.id = id;
//        this.name = name;   
//        this.designation = designation;
//        this.salary = salary;
//        this.age = age;
//        this.depart = depart;
//    }


//}

//Task
//1.Order the list in ascending order by name and then by descending order by id
//2. Get employees which are getting salary more than or equal to 60000 at the age of less than 33 years.
//3. Get data of first four employees skipping 
//4. get Maximum salary we are paying and also get the object.
//5. Get last employees whose salary is below 50000.

//records , indexers, namespaces



//Person a = new Person();
//a.name = "Haris";
//a.age = 24;

//Person aa = new Person();
//aa.name = "Haris";
//aa.age = 24;

//Console.WriteLine(a == aa);



//creating object of record class
//Person2 b = new Person2();
//b.name = "Haris Naseer";
//b.age = 24;

//Person2 bb = new Person2();
//bb.name = "Haris";
//bb.age = 24;

//Console.WriteLine(b);
//Console.WriteLine(b == bb);
//public class Person
//{
//    public string? name { get; set; }
//    public int? age { get; set; }
//}

//public record Person2
//{
//    public string? name { get; set; }
//    public int? age { get; set; }
//}


//Indexers - if we want our object to behave like an array we apply indexers.

//SuperHeroes fav3 = new SuperHeroes();
//fav3[0] = "Iron Man";
//fav3[1] = "Hulk";
//fav3[2] = "Super Man";


//Console.WriteLine(fav3[1]);


//public class SuperHeroes
//{
//    public string[] superNames = new string[3];

//    public string this[int i]
//    {
//        get { return superNames[i]; }
//        set
//        {
//            superNames[i] = value;
//        }

//    }

//}

//namespaces (collection of related classes)

//using System;
//using System.Collections;

//using _2301C2firstConsoleApp;

////tooltax
//Vehicle toyota = new Vehicle()
//{
//    name = "Toyota corolla",
//    regno = 2,
//};

//tooltax a = new tooltax()
//{
//    amount = 5,
//    isPaid = false
//};

//Console.WriteLine(a.isPaid);

//events
MyCar civic = new MyCar();
civic.speedUp += new MyCar.speedCar(MyCar.carMoved);
civic.drive();

public class MyCar
{
    public delegate void speedCar();
    public event speedCar speedUp;
    public int speed = 0;

    public void drive()
    {
        for(int i= 0; i<20; i++)
        {
            if (i >= 15)
             speedUp();
            Console.WriteLine("Car is moving at "+i +" mph");
            System.Threading.Thread.Sleep(1000);
        }
   
    }
    public static void carMoved()
    {
        Console.WriteLine("The car speed limit is exceeded");
    }
}

//Create a class Game having delegate gamemethod and event boost.It has 2 methods play and levelup. When play method is called, user is asked to enter name. It user enters "Haris" event boost should be fired and level up method is called.