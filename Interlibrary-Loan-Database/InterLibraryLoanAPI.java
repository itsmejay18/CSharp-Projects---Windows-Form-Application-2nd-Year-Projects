import java.sql.*;
import java.util.ArrayList;

/**
* Database API (Project Phase 5)
*
* @author Alex Neibart
*/
public class InterLibraryLoanAPI {
  /** Name of the database */
  private static final String dbName = "proj_niebart";

  /** Database username */
  private static final String dbUser = "aneibart";

  /** Database password */
  private static final String dbPass = "pass4716";

  /** A database connection */
  Connection dbConnect;

  /** Prepared statement objects for queryies*/
  PreparedStatement psQ1;
  PreparedStatement psQ2;
  PreparedStatement psQ3;
  PreparedStatement psQ4;
  PreparedStatement psQ5;
  PreparedStatement psQ6;

  public InterLibraryLoanAPI() {

    // Using try-catch for the SQLException because I don't want the application
    // layer to need to use any items from the java.sql package.

    try {
      // Connect to the database
      this.dbConnect = DriverManager.getConnection(
        "jdbc:mariadb://cslab.skidmore.edu:3306/" + dbName + "?user="
        + dbUser + "&password=" + dbPass);

        // Initialize prepared statements

        // Query 1: Retrieve titles of books which belong to a specified genre.
        String q1SQL = "SELECT b.title FROM Book b WHERE b.genre = ?";
        this.psQ1 = dbConnect.prepareStatement(q1SQL);

        // Query 2: Retrieve titles of books which were written by the author(s) with a specifed name.
        String q2SQL = "SELECT b.title FROM Book b, Author a, WrittenBy w WHERE b.bookID = w.bookID AND a.authID = w.authID AND a.name = ?";
        this.psQ2 = dbConnect.prepareStatement(q2SQL);

        // Query 3: Selects cardholders from the library with a specified name who have balances greater than 0.
        String q3SQL = "SELECT c.* FROM Cardholder c, Library l WHERE c.memberOf = l.libID AND l.name = ? AND c.balance > 0";
        this.psQ3 = dbConnect.prepareStatement(q3SQL);

        // Query 4: Counts the total number of books that have been borrowed by all cardholders belonging to the library with a specified name.
        String q4SQL = "SELECT COUNT(*) as num_books FROM Library l, Cardholder c, Borrows b WHERE l.libID = c.memberOf AND c.cardID = b.cardID AND l.name = ?";
        this.psQ4 = dbConnect.prepareStatement(q4SQL);

        // Query 5: Displays the number of reservations pertaining to each book in the system, provided that a copy of that book been reserved at least once.
        String q5SQL = "SELECT b.bookID, b.title, COUNT(*) as num_reservations FROM Reserves r, Book b, Item i WHERE r.itemID = i.itemID AND i.isCopyOf = b.bookID GROUP BY b.bookID, b.title HAVING num_reservations > 0";
        this.psQ5 = dbConnect.prepareStatement(q5SQL);

        // Query 6: Selects the IDs and titles of all books that are available at the library with a specified name but not elsewhere.
        String q6SQL = "SELECT DISTINCT b.bookID, b.title FROM Library l, Book b, Item i WHERE l.libID = i.belongsTo AND i.isCopyOF = b.BookID AND l.name = ?"
                        + "AND NOT EXISTS (SELECT * FROM Library l2, Book b2, Item i2 WHERE l2.libID = i2.belongsTo AND i2.isCopyOF = b2.BookID AND NOT l2.name = ? AND b.bookID = b2.bookID)";
        this.psQ6 = dbConnect.prepareStatement(q6SQL);

    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

  } // end of constructor


  /**
  * Runs Query 1: Retrieve titles of books which belong to a specified genre.
  *
  * @param genre the specified genre
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ1(String genre) {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Set the query parameter
      this.psQ1.setString(1, genre);

      // Execute the query
      ResultSet rs = this.psQ1.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        String title = rs.getString("title");
        result.add(title);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q1


  /**
  * Runs Query 2: Retrieve titles of books which were written by the author(s) with a specifed name.
  *
  * @param name the specified name
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ2(String name) {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Set the query parameter
      this.psQ2.setString(1, name);

      // Execute the query
      ResultSet rs = this.psQ2.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        String title = rs.getString("title");
        result.add(title);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q2


  /**
  * Runs Query 3: Selects cardholders from the library with a specified name who have balances greater than 0.
  *
  * @param name the specified name
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ3(String name) {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Set the query parameter
      this.psQ3.setString(1, name);

      // Execute the query
      ResultSet rs = this.psQ3.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        int cardID = rs.getInt("cardID");
        String cardholderName = rs.getString("name");
        float balance = rs.getFloat("balance");
        int memberOf = rs.getInt("memberOf");
        String row = cardID + ", " + cardholderName + ", " + balance + ", " + memberOf;
        result.add(row);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q3


  /**
  * Runs Query 4: Counts the total number of books that have been borrowed by all cardholders belonging to the library with a specified name.
  *
  * @param name the specified name
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ4(String name) {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Set the query parameter
      this.psQ4.setString(1, name);

      // Execute the query
      ResultSet rs = this.psQ4.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        String num_books = rs.getString("num_books");
        result.add(num_books);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q4


  /**
  * Runs Query 5: Displays the number of reservations pertaining to each book in the system, provided that a copy of that book been reserved at least once.
  *
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ5() {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Execute the query
      ResultSet rs = this.psQ5.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        int bookID = rs.getInt("bookID");
        String num_reservations = rs.getString("num_reservations");
        String title = rs.getString("title");
        String row = bookID + ", " + title + ", " + num_reservations;
        result.add(row);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q5


  /**
  * Runs Query 6: Selects the IDs and titles of all books that are available at the library with a specified name but not elsewhere.
  *
  * @param name the specified name
  * @return List containing each row of the result represented as a string.
  */
  public ArrayList<String> runQ6(String name) {

    ArrayList<String> result = new ArrayList<String>();

    try {
      // Set the query parameter
      this.psQ6.setString(1, name);
      this.psQ6.setString(2, name);

      // Execute the query
      ResultSet rs = this.psQ6.executeQuery();

      // Process the result set. Create a string for each row and add that string to a list.
      while(rs.next()) {
        int bookID = rs.getInt("bookID");
        String title = rs.getString("title");
        String row = bookID + ", " + title;
        result.add(row);
      }
    } catch(SQLException e) {
      e.printStackTrace();
      System.out.println("Terminating program");
      System.exit(1);
    }

    return result;
  } // end q6

}
