using System;
using System.Collections.Generic;

public class Program {

  public static void Main() {
    

    Console.WriteLine("Enter your Queen's coordinate separated by a comma: ");
    string[] queen = Console.ReadLine().Split(",");
    int[] q = Array.ConvertAll(queen, int.Parse);

    Console.WriteLine("Enter opponent's coordinate separated by a comma: ");
    string[] opponent = Console.ReadLine().Split(",");
    int[] o = Array.ConvertAll(opponent, int.Parse);

    if ( q[0] == o[0] || q[1] == o[1] ) {
      Console.WriteLine("Queen Won!");      
    }
    else if (checkInRange(q,o)) {
      Console.WriteLine("Queen Won! - Diagonal");
    }
    else {
      Console.WriteLine("Opponent Won!");
    }

    Console.WriteLine("Do you want to try again?[Y][N]");
    string again = Console.ReadLine().ToLower().Trim();

    if(again == "y") {
      Main();
    }
    else Console.WriteLine("Thank you for Playing! Goodbye!");


  }

  public static bool checkInRange(int[] queen, int[] opponent) {
    int x = opponent[0] - queen[0];
    int y = opponent[1] - queen[0];

    if(x%y == 0) {
      return true;
    }
    else return false;
  }

}

//int[] primeNumbers = { 2, 3, 5, 7, 11 };