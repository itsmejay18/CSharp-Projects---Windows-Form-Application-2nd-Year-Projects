import java.io.*;
import java.util.*;



/**
* Test program for the Interlibrary Loan Database API.
*
* Compile this program with:
javac -cp .:./mariadb-java-client-2.7.3.jar InterLibraryLoanAPI.java APITest.java
*
* Run this program with:
java -cp .:./mariadb-java-client-2.7.3.jar APITest
*
* @author Alex Neibart
*/
public class APITest {


  /**
  * Prints each string in the ArrayList on a separate line.
  *
  * @param result The list of strings to print
  */
  private static void printResult(ArrayList<String> result) {
    for(String s : result) {
      System.out.println(s);
    }
  } // end of printresult


  private static int menuChoice(Scanner s1) {
    System.out.println("\n\n----------------------------------------");
    System.out.println("1: Retrieve titles of books which belong to a specified genre.");
    System.out.println("2: Retrieve titles of books which were written by the author(s) with a specifed name.");
    System.out.println("3: Selects cardholders from the library with a specified name who have balances greater than 0.");
    System.out.println("4: Counts the total number of books that have been borrowed by all cardholders belonging to the library with a specified name.");
    System.out.println("5: Displays the number of reservations pertaining to each book in the system, provided that a copy of that book been reserved at least once.");
    System.out.println("6: Selects the IDs and titles of all books that are available at the library with a specified name but not elsewhere.");
    System.out.println("7: Quit.");
    System.out.println("\n");
    System.out.print("Select a query: ");

    int choice = -1;
    while(choice < 1 || choice > 7) {
      try {
        choice = s1.nextInt();
        if (choice < 1 || choice > 7) {
          System.out.print("\nInvalid input. Select a query: ");
        }
      } catch(InputMismatchException e) {
        System.out.print("\nInvalid input. Select a query: ");
      } finally {

        // Clear any junk from keyboard input
        if(s1.hasNextLine()) {
          s1.nextLine();
        }
      }

    } // loop for correct choice

    System.out.println();

    return choice;
  } // end of menuChoice



  /**
  * Program execution begins at the main method.
  *
  * @param args Not used
  */
  public static void main(String[] args) {

    // Create a InterLibraryLoanAPI object
    InterLibraryLoanAPI api = new InterLibraryLoanAPI();

    // List for the query result
    ArrayList<String> result;

    boolean cont = true;
    int choice;

    Scanner keyboardIn = new Scanner(System.in);

    while (cont) {
      choice = APITest.menuChoice(keyboardIn);
      if (choice == 1) {
        System.out.print("Run query 1 for which genre?: ");
        result = api.runQ1(keyboardIn.nextLine());
        APITest.printResult(result);

      } else if (choice == 2) {
        System.out.print("Run query 2 for which author?: ");
        result = api.runQ2(keyboardIn.nextLine());
        APITest.printResult(result);

      } else if (choice == 3) {
        System.out.print("Run query 3 for which library?: ");
        result = api.runQ3(keyboardIn.nextLine());
        APITest.printResult(result);

      } else if (choice == 4) {
        System.out.print("Run query 4 for which library?: ");
        result = api.runQ4(keyboardIn.nextLine());
        APITest.printResult(result);

      } else if (choice == 5) {
        result = api.runQ5();
        APITest.printResult(result);

      } else if (choice == 6) {
        System.out.print("Run query 6 for which library?: ");
        result = api.runQ6(keyboardIn.nextLine());
        APITest.printResult(result);

      } else if (choice == 7) {
        cont = false;
      } // end of if statement

    } // end of while loop



  } // end of main

} // end of class
