


#region task10
Console.WriteLine(); //new line

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(@"            *");
Console.WriteLine(@"           / \");
Console.WriteLine(@"          /   \");
Console.WriteLine(@"         /     \");
Console.WriteLine(@"        /       \");
Console.WriteLine(@"       /         \");
Console.WriteLine(@"      /           \");
Console.WriteLine(@"     /             \");
Console.WriteLine(@"    /               \");
Console.WriteLine(@"   /                 \");
Console.WriteLine(@"  /                   \");
Console.WriteLine(@" /                     \");
Console.WriteLine(@" === Triangle Wizard ===");
Console.WriteLine(); //new line

Console.WriteLine("Please enter the first (out of three) side length of the triangle.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTriangleA = Console.ReadLine();
double userInputTriangleDoubleA = Convert.ToDouble(userInputTriangleA);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Please enter the second (out of three) side length of the triangle.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTriangleB = Console.ReadLine();
double userInputTriangleDoubleB = Convert.ToDouble(userInputTriangleB);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Please enter the third (out of three) side length of the triangle.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTriangleC = Console.ReadLine();
double userInputTriangleDoubleC = Convert.ToDouble(userInputTriangleC);

//bool isTriangle = false;

if (
   ( userInputTriangleDoubleA < userInputTriangleDoubleB + userInputTriangleDoubleC) &&    
   ( userInputTriangleDoubleB < userInputTriangleDoubleA + userInputTriangleDoubleC) && 
   ( userInputTriangleDoubleC < userInputTriangleDoubleA + userInputTriangleDoubleB)
   )
{ //isTriangle = true;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congratulations. You have a triangle"); 
}

else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("We are sorry. It's not a triangle, but maybe it's better this way."); }

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
//ilgiausia krastine turi buti mazesne nei kitu dvieju krastiniu sudetis
//bet kurie dviejų kraštinių ilgiai turi būti didesni už likusiosios kraštinės ilgį.
#endregion

    #region nextTask

Console.WriteLine();
Console.WriteLine("Do you want to continue?");

Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

string userInputContinue9 = Console.ReadLine();

if (userInputContinue9 == "no" || userInputContinue9 == "n")
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(" ============ Thank you.Goodbye ============ ");

    Environment.Exit(0);
}


else if (userInputContinue9 == "yes" || userInputContinue9 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

Console.WriteLine();

#endregion 

#region task9B
Console.WriteLine(); //new line

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Temperature Guessing Wizard ============");

Console.WriteLine("         Please enter a year.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask9B0 = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Thank you. But nobody cares. ");
Console.WriteLine("         Please write the name of the month you are thinking about.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask9BA = Console.ReadLine().ToLowerInvariant();

//bool task9B = false;

string task9BHot = "It is hot";
string task9BCold = "It is cold";
string task9BMedium = "It's ok";

if (userInputTask9BA == "january" || userInputTask9BA == "february" || userInputTask9BA == "december")    
{    Console.ForegroundColor = ConsoleColor.DarkCyan;                                                      Console.WriteLine(task9BCold); }

else if (userInputTask9BA == "june" || userInputTask9BA == "july" || userInputTask9BA == "august")        
{    Console.ForegroundColor = ConsoleColor.Red;                                                 Console.WriteLine(task9BCold); }

else if (userInputTask9BA == "march" || userInputTask9BA == "april" || userInputTask9BA == "may")        
{    Console.ForegroundColor = ConsoleColor.Yellow;                                                   Console.WriteLine(task9BMedium); }

else { Console.WriteLine("Error. Such a month doesn't exist."); }



Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
#endregion

#region task9A
Console.WriteLine(); //new line
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Positive Sum Wizard ============");
Console.WriteLine("         Please input the first (out of three) number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask9A = Console.ReadLine();
int userInputTask9IntegerA = Convert.ToInt32(userInputTask9A);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Please input the second (out of two) number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask9B = Console.ReadLine();
int userInputTask9IntegerB = Convert.ToInt32(userInputTask9B);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Please input the third (out of three) number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask9C = Console.ReadLine();
int userInputTask9IntegerC = Convert.ToInt32(userInputTask9C);

bool task9ArePositive = false;
if (
   (userInputTask9IntegerA > 0 && userInputTask9IntegerB > 0) || //a+b
   (userInputTask9IntegerA > 0 && userInputTask9IntegerC > 0) || //a+c
   (userInputTask9IntegerB > 0 && userInputTask9IntegerC > 0) //b+c
   )

    { task9ArePositive = true;
    int task9Sum = userInputTask9IntegerA + userInputTask9IntegerB + userInputTask9IntegerC;
    if (task9ArePositive = true) { Console.WriteLine("The sum of your numbers is: " + task9Sum); }
    }
else  { 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Fatal Error. Be more positive in the future."); }

#endregion

    #region nextTask

Console.WriteLine();
Console.WriteLine("Do you want to continue?");

Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

string userInputContinue8 = Console.ReadLine();

if (userInputContinue8 == "no" || userInputContinue8 == "n")
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(" ============ Thank you.Goodbye ============ ");

    Environment.Exit(0);
}


else if (userInputContinue8 == "yes" || userInputContinue8 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

Console.WriteLine();

#endregion 

#region task8A
Console.WriteLine(); //new line
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Positive Number Wizard ============");
Console.WriteLine("         Please input the first (out of two) number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask8A = Console.ReadLine();
int userInputTask8IntegerA = Convert.ToInt32(userInputTask8A);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Please input the second (out of two) number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask8B = Console.ReadLine();
int userInputTask8IntegerB = Convert.ToInt32(userInputTask8B);

Console.WriteLine(); Console.WriteLine("*Initiating*"); Console.WriteLine("*Calculating*");Console.WriteLine("*Processing*");Console.WriteLine("*Stealing your system data*"); Console.WriteLine("*Finalizing*");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
if (userInputTask8IntegerA >= 0 && userInputTask8IntegerB >= 0) { Console.WriteLine("Your both numbers are positive"); }
else if ((userInputTask8IntegerA >= 0 && userInputTask8IntegerB <= 0) || (userInputTask8IntegerA <= 0 && userInputTask8IntegerB >= 0)) 
{ Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("Only one of your numbers is positive"); }
else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Both of your numbers are negative"); }

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
#endregion

#region  task8B
Console.WriteLine();//new line
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Casino Lotto Number Wizard ============");
Console.WriteLine("         Please input the first (out of three) lucky number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask82A = Console.ReadLine();
int userInputTask82IntegerA = Convert.ToInt32(userInputTask82A);

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Please input the second (out of three) lucky number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask82B = Console.ReadLine();
int userInputTask82IntegerB = Convert.ToInt32(userInputTask82B);


Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("         Please input the third (out of three) lucky number.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask82C = Console.ReadLine();
int userInputTask82IntegerC = Convert.ToInt32(userInputTask82C);


Console.WriteLine();

if ((userInputTask82IntegerA == userInputTask82IntegerB) && (userInputTask82IntegerB == userInputTask82IntegerC)) { Console.WriteLine("BINGO! Your all numbers are equally lucky"); }


Console.WriteLine();
#endregion

    #region nextTask

Console.WriteLine();
Console.WriteLine("Do you want to continue?");

Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

string userInputContinue7 = Console.ReadLine();

if (userInputContinue7 == "no" || userInputContinue7 == "n")
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(" ============ Thank you.Goodbye ============ ");

    Environment.Exit(0);
}


else if (userInputContinue7 == "yes" || userInputContinue7 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

Console.WriteLine();

#endregion

#region task7
Console.WriteLine();
Console.WriteLine("Please enter any number and you will some magic.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask7 = Console.ReadLine();
double userInputToDoubleTask7 = Convert.ToDouble(userInputTask7);

if ((userInputToDoubleTask7 % 3 == 0) && (userInputToDoubleTask7 % 5 == 0))
{ Console.WriteLine("BazingaPop"); }

else if (userInputToDoubleTask7 % 3 == 0) { Console.WriteLine("Bazinga"); }

else if (userInputToDoubleTask7 % 5 == 0) { Console.WriteLine("Pop"); }

else { Console.WriteLine("The number is not magical enough"); }

Console.WriteLine();
#endregion


    #region nextTask

Console.WriteLine();
Console.WriteLine("Do you want to continue?");

Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

string userInputContinue6 = Console.ReadLine();

if (userInputContinue6 == "no" || userInputContinue6 == "n")
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(" ============ Thank you.Goodbye ============ ");

    Environment.Exit(0);
}


else if (userInputContinue6 == "yes" || userInputContinue6 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

Console.WriteLine();

#endregion 

#region task 6

//Console.WriteLine();
//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine(@"=================== Welcome to the best DarkWeb Shop ===================");
//Console.WriteLine(@"   ================== You may select up to 3 items.==================");
//Console.WriteLine(@"     ===== If you purchase 2 identical items -> 10% discount.===== ");
//Console.WriteLine(@"        == If you purchase 3 identical items -> 15% discount.==");
//Console.WriteLine(@"                            = Choose wisely =");
//Console.WriteLine(@"========================================================================");

//string item1 = "T-shirt";       double item1Price = 25;
//string item2 = "Hat";           double item2Price = 15;
//string item3 = "Sweater";       double item3Price = 30;
//string item4 = "Pillow";        double item4Price = 20;
//string item5 = "Socks";         double item5Price = 5;
//string item6 = "Backpack";      double item6Price = 66;
//string item7 = "Sticker";       double item7Price = 0.5;

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine(@"Item 1: " + item1 + " " + item1Price + " eur");
//Console.WriteLine(@"Item 2: " + item2 + " " + item2Price + " eur");
//Console.WriteLine(@"Item 3: " + item3 + " " + item3Price + " eur");
//Console.WriteLine(@"Item 4: " + item4 + " " + item4Price + " eur");
//Console.WriteLine(@"Item 5: " + item5 + " " + item5Price + " eur");
//Console.WriteLine(@"Item 6: " + item6 + " " + item6Price + " eur");
//Console.WriteLine(@"Item 7: " + item7 + " " + item7Price + " eur");

//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("========================================================================");
//Console.WriteLine("Please input the number of the first item you want");
//Console.ForegroundColor = ConsoleColor.White;
//string userInputTask6Item1 = Console.ReadLine();
//double userInputToDoubleTask6Item1 = Convert.ToDouble(userInputTask6Item1);

//Console.WriteLine();
//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("========================================================================");
//Console.WriteLine("Please input the number of the second item you want");
//Console.ForegroundColor = ConsoleColor.White;
//string userInputTask6Item2 = Console.ReadLine();
//double userInputToDoubleTask6Item2 = Convert.ToDouble(userInputTask6Item2);

//Console.WriteLine();
//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("========================================================================");
//Console.WriteLine("Please input the number of the third and final item you want");
//Console.ForegroundColor = ConsoleColor.White;
//string userInputTask6Item3 = Console.ReadLine();
//double userInputToDoubleTask6Item3 = Convert.ToDouble(userInputTask6Item3);

//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("========================================================================");

////susieti kainas su user pasirinkimais


//if (userInputTask6Item1 = item1 ) { }






////price of cart
//double Task6Cart = userInputToDoubleTask6Item1 + userInputToDoubleTask6Item2 + userInputToDoubleTask6Item3; //item cart

//Console.WriteLine("Your cart: ");


////double priceOfCart = ;

////double Task6Discount2 = Task6InitialSum *0.85;

////if ((userInputToDoubleTask6Item1 == userInputToDoubleTask6Item2) || (userInputToDoubleTask6Item2 == userInputToDoubleTask6Item3) || (userInputToDoubleTask6Item1 == userInputToDoubleTask6Item3))
////{ }


////Console.WriteLine("Your current cart is: " + Task6InitialSum + " eur");




////Console.WriteLine("Do you have a loyalty card?");

//Console.WriteLine();

#endregion

    #region nextTask

    Console.WriteLine();
    Console.WriteLine("Do you want to continue?");

    Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
    Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
    Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

    string userInputContinue5 = Console.ReadLine();

    if (userInputContinue5 == "no" || userInputContinue5 == "n")
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(" ============ Thank you.Goodbye ============ ");

        Environment.Exit(0);
    }


    else if (userInputContinue5 == "yes" || userInputContinue5 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

    Console.WriteLine();

    #endregion

#region task5
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Leap Year Wizard ============");
Console.WriteLine("         Please input a year.");
Console.ForegroundColor = ConsoleColor.White;
string userInputTask5 = Console.ReadLine();
int userInputTask5Integer = Convert.ToInt32(userInputTask5);

//bool isLeapYear = false;

if ((userInputTask5Integer % 4 == 0) && (userInputTask5Integer !% 100 == 0) || (userInputTask5Integer! % 400 == 0))
{ Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("It IS a leap year!");
    Console.ForegroundColor = ConsoleColor.White;
}

else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("It's NOT a leap year");
    Console.ForegroundColor = ConsoleColor.White;
}

//|| userInputTask5Integer %100
#endregion

    #region next Task

Console.WriteLine();
Console.WriteLine("Do you want to continue?");

Console.ForegroundColor = ConsoleColor.Green; Console.Write("yes");
Console.ForegroundColor = ConsoleColor.White; Console.Write("/");
Console.ForegroundColor = ConsoleColor.Red; Console.Write("no");
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();

string userInputContinue4 = Console.ReadLine();

if (userInputContinue4 == "no" || userInputContinue4 == "n" ) 
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(" ============ Thank you.Goodbye ============ "); 

    Environment.Exit(0); }


else if (userInputContinue4 == "yes" || userInputContinue4 == "y") { Console.WriteLine(""); Console.WriteLine("Continue to next task ---> "); }

Console.WriteLine();

#endregion 

#region task4

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("============ Life Stage Wizard ============");
Console.WriteLine("         How old are you?");
Console.ForegroundColor = ConsoleColor.White;

string userInputTask4 = Console.ReadLine();
int userInputTask4Integer = Convert.ToInt32(userInputTask4);

if (userInputTask4Integer < 18) { Console.WriteLine("Go to school"); }
else if (userInputTask4Integer >18 &&  userInputTask4Integer <65) { Console.WriteLine("Go to work."); }
else if (userInputTask4Integer >65) { Console.WriteLine("Don't forget your doctor's appointment"); }
#endregion

//finish line
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Congratulations. You've reached the end of the tasks.");


#region Lesson Theory 


//keletas dalyku kartu combining
#region
//int age = 25;
//bool hasLicense = true;

//if ((age >= 18 && hasLicense) || age >=65){ //atsargiai su skliausteliais
//    Console.WriteLine("Jus turite arba teise vairuoti arba priklauso pensija"); }
#endregion

// || arba
#region
//string userInput = Console.ReadLine();
//if (userInput == "admin" || userInput == "administratorius") //reikia pakartoti userInput

//{ Console.WriteLine("Jus turite prieiga"); }

#endregion


//&& ir
#region
//int age = 25;
//bool hasLicense = true; //jeigu butu false, tai IFe zinuteje sitas kintamasis butu kaip ir tuscias

//if (age>=18 && hasLicense) { 
//    Console.WriteLine("jus turite teise vairuoti nes turi abudu dalykus"); 
//}
#endregion



//if nesting

//int age = 25;
//bool hasLicense = true;

//if(age >= 18) 
//{ 
//    Console.WriteLine("jus esate pilnametis");
//    if (hasLicense) Console.WriteLine("jus turite teise vairuoti");

//    else
//    { Console.WriteLine("jums nera leidziama vairuoti"); }
//}

//else { Console.WriteLine("jus esate nepilnametis"); }


//bool isLogged = false;
//if (!isLogged) { Console.WriteLine("jus neprisijunges"); }

//bool isLogged2 = true;
//if (!isLogged2) { Console.WriteLine("nesimato???"); }


//bool


#region

//if (isLogged) { Console.WriteLine("jus esate prisijunges"); }

//bool isLogged2 = false;
//if (isLogged2) { Console.WriteLine("jus nesate prisijunges ir todel sito nematot"); }
#endregion
#endregion