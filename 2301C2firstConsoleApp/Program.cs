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
*/
string[,] groups =
{
    {
        "Fazal",
        "Afzal"
    },
    {
        "Yahya", 
        "umer" 
    },
    {
        "Waleed", 
        "Zeeshan" 
    }
};

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


