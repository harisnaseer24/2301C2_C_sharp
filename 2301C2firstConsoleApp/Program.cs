// See https://aka.ms/new-console-template for more information

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
int[] evenNumbers = { 2, 14, 22, 8, 2 };
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
*/


//Collections

//Generics -- (Dynamic Size) List + Additional Methods
//Non Generics -- (Fixed Size) Arrays



//List

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







