import java.sql.*;

public class App {

    public static void main(String[] args) throws Exception {
        System.out.println("SQL Start...");
        Class.forName("com.mysql.jdbc.Driver");
        System.out.println("Driver updated.");
        try {
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/testjavadb", "admin",
                    "*********");
            System.out.println("connection done.");
            Statement stmt = con.createStatement();
            int isdone1 = stmt.executeUpdate("insert into employee values(1,'Haydar')");
            System.out.println("Is done: " + isdone1);
            ResultSet res = stmt.executeQuery("select * from employee");

            while (res.next())
                System.out.println(res.getInt(1) + " " + res.getString(2));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}

/*
 * Parametric PreparedStatement
 * stmt=con.prepareStatement("insert into Emp values(?,?)"); stmt.setInt(1,100);
 * stmt.setString(2,"Veli");
 * 
 * int i=stmt.executeUpdate();
 */