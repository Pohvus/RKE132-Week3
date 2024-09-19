

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//Kas kasutaja arv on paaris või on paaritu

int result = userNum % 2;

Console.WriteLine(result);


if (result != 0) //!= ei ole võrdne ja == on võrdne
{
    Console.WriteLine("User number is odd.");
}else
{
    Console.WriteLine("User number is even.");
}
