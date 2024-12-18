//  functions
#region functions
//task 1 function
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

string Greetings(string name)
{
    return "Greetings "+ name;
}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Task 2 function
 double BoxVolume(double length,double width ,double  height)
{
    double box_volume = (length * width * height);
    return box_volume;
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Task 3 function
double Task3(double num1)
{
    if ( num1 % 2 == 0)
    {
        return num1 * 2;
    }
    else
    {
        return num1 * num1;
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Task 4 Function

double TaskTemp(double num1) 
{
    double fahren = (num1 * 9 / 5) + 32;
    return fahren;
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//Task 5 function
string Checking(char alpha)
{
    if (char.IsLetter(alpha))    // bonus 
    {
        if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            return alpha + " is a Vowel ";
        else
            return alpha + " is a consonant";
    }
    else
        return alpha + " is not aphabetical";  //bonus 
}



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Task 6 function

double  Currency(double num10, double num11)
{
    double convertedAmount = num10 * num11;
    return convertedAmount;
}


#endregion

// Task 1 function call
Console.WriteLine("Enter your Name: ");
string name1 = Console.ReadLine();
Console.WriteLine(Greetings(name1));
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Task 2 function call
Console.WriteLine("Enter Length : ");
double length1 =Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Enter Width : ");
double width1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Height : ");
double height1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Volume of the Box is " +BoxVolume(length1,width1,height1));

// bonus task 2 
// function overloading is a method of using a function several times with different parameters and data types for the paramets and the return valus of the function and is works 


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Task 3 Function Call
Console.WriteLine("Enter Number  : ");
double num_check = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Task3(num_check));


//Task 4 Function Call
Console.WriteLine("Enter temperature in Celsius to convert to Fahrenheit  : ");
double cel_temp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(TaskTemp(cel_temp));




// Task 5 function call

Console.WriteLine("please Enter a single  letter");
char alpha_letter= Convert.ToChar(Console.ReadLine());
Console.WriteLine(Checking(alpha_letter));


// task 6 function call

Console.WriteLine("Please Enter the Original Amount");
double originalAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter the Converion Rate Amount");
double conversionRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Converted amount: " + Currency(originalAmount,conversionRate));