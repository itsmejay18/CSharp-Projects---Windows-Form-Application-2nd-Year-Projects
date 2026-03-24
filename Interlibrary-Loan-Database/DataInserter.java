import java.util.Random;

import java.sql.*;

import java.io.*;
import java.util.*;


//  javac -cp .:./mariadb-java-client-2.7.3.jar DataInserter.java
//  java -cp .:./mariadb-java-client-2.7.3.jar DataInserter






public class DataInserter {
  /** Name of the database */
  private static final String dbName = "proj_niebart";

  /** Database username */
  private static final String dbUser = "aneibart";

  /** Database password */
  private static final String dbPass = "pass4716";

  /** A database connection */
  Connection connect;

  private Random rand;

  private ArrayList<String> words;
  private ArrayList<String> streetnames;
  private ArrayList<String> names;
  private ArrayList<String> genres;

  private static final int num_libraries = 25;
  private static final int num_cardholders = 1000;
  private static final int num_authors = 300;
  private static final int num_books = 1000;
  private static final int num_items = 3000;
  private static final int num_borrows = 1000;
  private static final int num_reserves = 1500;




  public DataInserter() throws Exception {
    this.rand = new Random();

    this.words = new ArrayList<String>();
    this.streetnames = new ArrayList<String>();
    this.names = new ArrayList<String>();
    this.genres = new ArrayList<String>();

    try{
        // Use JDBC
        //Class.forName("com.mysql.jdbc.Driver");

        // Connect to the database
        connect = DriverManager.getConnection(
          "jdbc:mariadb://cslab.skidmore.edu:3306/" + dbName + "?user="
          + dbUser + "&password=" + dbPass);
    } catch(Exception e) {
        throw e;
    } // end of connection try/catch


    try {
      Scanner s1 = new Scanner(new File("words.txt"));
      while (s1.hasNextLine()) {
        this.words.add(s1.nextLine());
      }
      s1.close();

      Scanner s2 = new Scanner(new File("streetnames.txt"));
      while (s2.hasNextLine()) {
        this.streetnames.add(s2.nextLine());
      }
      s2.close();

      Scanner s3 = new Scanner(new File("names.txt"));
      while (s3.hasNextLine()) {
        this.names.add(s3.nextLine());
      }
      s3.close();

      Scanner s4 = new Scanner(new File("genres.txt"));
      while (s4.hasNextLine()) {
        this.genres.add(s4.nextLine());
      }
      s4.close();

    } catch(FileNotFoundException e) {
      System.exit(1);
    } // end of data loading try/catch
  } // end constructor



  // destructor
  @Override
  public void finalize() throws Throwable {
      super.finalize();
      connect.close();
  } // end destructor


  public void clearTables() throws Exception {
    PreparedStatement clear;
    try {
      clear = connect.prepareStatement("DELETE FROM Borrows");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Reserves");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM WrittenBy");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Item");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Book");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Author");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Cardholder");
      clear.executeUpdate();

      clear = connect.prepareStatement("DELETE FROM Library");
      clear.executeUpdate();
    } catch(Exception e) {
        throw e;
    } // end of try/catch
  } // end of clearTables



  public void generateLibraries() throws Exception {
    int words_size = this.words.size();
    int streetnames_size = this.streetnames.size();
    String insert_name;
    String insert_address;

    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO Library (libID,address,name) values (?,?,?)");
      while (index < num_libraries) {
        insert_name = this.words.get(this.rand.nextInt(words_size)) + this.words.get(this.rand.nextInt(words_size)) + " Library";
        insert_address = this.rand.nextInt(900) + " " + this.words.get(this.rand.nextInt(words_size)) + " " + this.streetnames.get(this.rand.nextInt(streetnames_size));
        insert.setInt(1, index);
        insert.setString(2, insert_address);
        insert.setString(3, insert_name);

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setString(2, "49 Henry Street, Saratoga Springs, NY");
      insert.setString(3, "Saratoga Springs Public Library");

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateLibraries


  public void generateCardholders() throws Exception {
    int words_size = this.words.size();
    int names_size = this.names.size();
    String insert_name;


    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO Cardholder (cardID,name,balance,memberOf) values (?,?,?,?)");
      while (index < num_cardholders) {
        insert_name = this.names.get(this.rand.nextInt(names_size));
        insert_name += " ";
        insert_name += this.words.get(this.rand.nextInt(words_size));
        insert_name += this.words.get(this.rand.nextInt(words_size));

        insert.setInt(1, index);
        insert.setString(2, insert_name);
        insert.setFloat(3, this.rand.nextInt(10) + this.rand.nextFloat());
        insert.setInt(4, this.rand.nextInt(num_libraries)+1);

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setString(2, "John Smith");
      insert.setFloat(3, this.rand.nextInt(10) + this.rand.nextFloat());
      insert.setInt(4, num_libraries);

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateCardholders



  public void generateAuthors() throws Exception {
    int words_size = this.words.size();
    int names_size = this.names.size();
    String insert_name;

    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO Author (authID,name) values (?,?)");
      while (index < num_authors) {
        insert_name = this.names.get(this.rand.nextInt(names_size));
        insert_name += " ";
        insert_name += this.words.get(this.rand.nextInt(words_size));
        insert_name += this.words.get(this.rand.nextInt(words_size));

        insert.setInt(1, index);
        insert.setString(2, insert_name);

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setString(2, "Anonymous");

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateAuthors


  public void generateBooks() throws Exception {
    int words_size = this.words.size();
    int genres_size = this.genres.size();
    String insert_title;

    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO Book (bookID,title,genre) values (?,?,?)");
      while (index < num_books) {
        insert_title = this.words.get(this.rand.nextInt(words_size)) + this.words.get(this.rand.nextInt(words_size));
        insert.setInt(1, index);
        insert.setString(2, insert_title);
        insert.setString(3, this.genres.get(this.rand.nextInt(genres_size)));

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setString(2, "Generic Title");
      insert.setString(3, "mystery");

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateBooks


  public void generateItems() throws Exception {
    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO Item (itemID,isCopyOf,belongsTo) values (?,?,?)");
      while (index < num_items) {
        insert.setInt(1, index);
        insert.setInt(2, this.rand.nextInt(num_books)+1);
        insert.setInt(3, this.rand.nextInt(num_libraries)+1);

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setInt(2, num_books);
      insert.setInt(3, num_libraries);

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateItems



  public void generateWrittenBy() throws Exception {
    int index = 1;

    try {
      PreparedStatement insert = connect.prepareStatement("INSERT INTO WrittenBy (bookID,authID) values (?,?)");
      while (index < num_books) {
        insert.setInt(1, index);
        insert.setInt(2, this.rand.nextInt(num_authors)+1);

        insert.executeUpdate();
        index += 1;
      }

      insert.setInt(1, index);
      insert.setInt(2, num_authors);

      insert.executeUpdate();
    } catch(Exception e) {
        throw e;
    }
  } // end generateWrittenBy



  public void generateBorrowsAndReserves() throws Exception {
    ArrayList<Integer> available = new ArrayList<Integer>();
    ArrayList<Integer> borrowed = new ArrayList<Integer>();

    int randomNum;
    int month;
    int day;

    for (int i=1; i <= num_items; i++) {
      available.add(i);
    }

    for (int i=0; i < num_borrows; i++) {
      randomNum = this.rand.nextInt(available.size());
      borrowed.add(available.get(randomNum));
      available.remove((int)randomNum);

    }

    try {
      PreparedStatement insert1 = connect.prepareStatement("INSERT INTO Borrows (cardID,itemID,startDate,dueDate) values (?,?,?,?)");
      for (Integer itemID : borrowed) {
        insert1.setInt(1, this.rand.nextInt(num_cardholders)+1);

        insert1.setInt(2, itemID);

        month = this.rand.nextInt(12)+1;
        day = this.rand.nextInt(29);
        insert1.setString(3, "2021-" + month + "-" + day);

        month = this.rand.nextInt(12)+1;
        day = this.rand.nextInt(29);
        insert1.setString(4, "2021-" + month + "-" + day);

        insert1.executeUpdate();
      } // end of for loop
    } catch(Exception e) {
        throw e;
    } // end of Borrows insertion


    try {
      PreparedStatement insert2 = connect.prepareStatement("INSERT INTO Reserves (cardID,itemID,reserveDate) values (?,?,?)");
      for (int i=0; i < num_reserves; i++) {
        insert2.setInt(1, this.rand.nextInt(num_cardholders)+1);
        insert2.setInt(2, borrowed.get(this.rand.nextInt(num_borrows)));

        month = this.rand.nextInt(12)+1;
        day = this.rand.nextInt(29);
        insert2.setString(3, "2021-" + month + "-" + day);

        insert2.executeUpdate();
      } // end of for loop
    } catch(Exception e) {
        throw e;
    } // end of reserves insertion

  } // end generateBorrowsAndReserves



  public static void main(String[] args) throws Exception {
    DataInserter di = new DataInserter();
    di.clearTables();

    di.generateLibraries();
    di.generateCardholders();

    di.generateAuthors();
    di.generateBooks();

    di.generateItems();

    di.generateWrittenBy();
    di.generateBorrowsAndReserves();

  }




} // end class
