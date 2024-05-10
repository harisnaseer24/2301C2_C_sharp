
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

// here we are creating a class
//1. Inheritance
//access modifiers



//Vehicle accord = new Vehicle();
//accord.run();


Car camry = new Car("Toyota Camry","2024 LE","v8","320 kph");
camry.run();
camry.stop();

//Parent Class (Base class)(Super Class)
public class Vehicle
{
    public string speed;

    public void run()
    {
        Console.WriteLine("the Vehicle started running.");
    } 
    public void run(string name)
    {
        Console.WriteLine($"the {name} started running.");
    } 
    public void stop()
    {
        Console.WriteLine("the Vehicle is stopped.");
    }
}

//Child Class (sub class)(Derived Class)
//class Car extends Vehicle
class Car: Vehicle
{
   public string name;
   public string model;
   public string power;

    public Car(string name, string model, string power, string speed)
    {
        this.name = name;
        this.model = model;
        this.power = power;
        this.speed = speed;
    }

    //Overriding run() and stop() methods here
    public void run()
    {   
        //run funtion now prints the name and speed of car too.
        Console.WriteLine($"{this.name} is running at {this.speed}");
    }
    public void stop()
    {   
        //stop funtion now prints the name and dift of car too when stopping.
        Console.WriteLine($"the {this.name} is stopped with drift.");
    }

}
