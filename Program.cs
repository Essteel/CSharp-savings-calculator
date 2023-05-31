Console.WriteLine("Please enter the initial deposit:");
var depositInput = Console.ReadLine();
var deposit = double.Parse(depositInput);

Console.WriteLine("Please enter the monthly interest rate:");
var interestRateInput = Console.ReadLine();
var interestRate = double.Parse(interestRateInput);

Console.WriteLine("How many months will you save for?");
var monthsSavedInput = Console.ReadLine();
var monthsSaved = int.Parse(monthsSavedInput);

var savings = deposit * Math.Pow(1 + (interestRate/100), monthsSaved);
Console.WriteLine($"After {monthsSaved} months you will have {savings}");
