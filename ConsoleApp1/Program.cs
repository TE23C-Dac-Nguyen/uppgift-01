
// 1

//     Console.WriteLine("skriv in ditt användarnamn");

// String användarnamn = Console.ReadLine();

// if (användarnamn == "kalleanka")
// {
//  Console.WriteLine("Välkommen");
// }
// else    
// {
//     Console.WriteLine ("GET OUT");
// }

//     Console.ReadLine();


// 2

// Console.WriteLine("skriv in ditt användarnamn");

// String användarnamn = Console.ReadLine();
// Console.WriteLine("Skriv in ditt lösenord");

// String lösenordet = Console.ReadLine();



// if (användarnamn == "kalleanka" & lösenordet == "12345")
// {
//  Console.WriteLine("Välkommen");
// }
// else    
// {
//     Console.WriteLine ("Wrong username or password");
// }

//     Console.ReadLine();


// 3

// int number = 0;

// while (number < 32)
// {
//     Console.WriteLine("hello world!");
//     number++;
// }

// Console.ReadLine();


// 4

// String lösenord = Console.ReadLine();

// while (lösenord == "12345")
// {

//   Console.WriteLine("Välkommen!");
// else    
// {
// Console.WriteLine ("try again...");
// }
//     Console.ReadLine();
// }


// Console.WriteLine("you have 5 chances to type in number");

// for (int i = 0; i < 5; i++) 
// {
//   String guesses = Console.ReadLine();
//   int guess = 0;
//   bool success = int.TryParse(guesses, out guess);
  

//   if (success == true)
//   {
    
//     if (guess == 5)
//     {
//       Console.WriteLine("your number is 5");
//     }
//     else if (guess > 5)
//     {
//       Console.WriteLine("Its higher than 5");
//     }
//     else if (guess < 5)
//     {
//       Console.WriteLine("Its lower than 5");
//     }
//   }
// }

// 6

Console.WriteLine("Try to guess a number from 0-10");

for (int i = 0; i < 10; i++)
{
  string guess = Console.ReadLine();
}

