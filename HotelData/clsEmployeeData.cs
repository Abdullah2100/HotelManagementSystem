using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsEmployeeData
    {
        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;

        public static bool findEmployeeByID
            (
          int id,
          ref string userName,
          ref string password,
          ref int employeeTypeID,
          ref int personID,
          ref string address,
          ref string phone,
          ref bool isBlock
            )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"select * from Employees where employeeID = @id";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["userName"] != DBNull.Value)
                                    userName = (string)reader["userName"];
                                else
                                    userName = "";

                                if (reader["password"] != DBNull.Value)
                                    password = (string)reader["password"];
                                else
                                    password = "";

                                employeeTypeID = (int)reader["employeeTypeID"];

                                personID = (int)reader["personID"];
                                address = (string)reader["address"];
                                phone = (string)reader["phone"];
                                isBlock = (bool)reader["isBlock"];


                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }


            return isFound;
        }



        public static bool findEmployeeByUserNameAndPassword
         (
        string userName,
        string password,
        ref int id,
        ref int employeeTypeID,
        ref int personID,
        ref string address,
        ref string phone,
        ref bool isBlock
         )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"select * from Employees where userName = @userName and password = @password";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                id = (int)reader["employeeID"];

                                employeeTypeID = (int)reader["employeeTypeID"];

                                personID = (int)reader["personID"];
                                address = (string)reader["address"];
                                phone = (string)reader["phone"];
                                isBlock = (bool)reader["isBlock"];


                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }


            return isFound;
        }




        public static bool findEmployeeByPhone
            (
            string phone,
            ref int id,
            ref string userName,
            ref string password,
            ref int employeeTypeID,
            ref int personID,
            ref string address,
            ref bool isBlock
      )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"select * from Employees where phone = @phone";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = (int)reader["employeeID"];

                                if (reader["userName"] != DBNull.Value)
                                    userName = (string)reader["userName"];
                                else
                                    userName = "";

                                if (reader["password"] != DBNull.Value)
                                    password = (string)reader["password"];
                                else
                                    password = "";

                                employeeTypeID = (int)reader["employeeTypeID"];

                                personID = (int)reader["personID"];
                                address = (string)reader["address"];
                                isBlock = (bool)reader["isBlock"];


                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }


            return isFound;
        }

        public static int createEmployee
            (
            string phone,

            int id,
            string userName,
            string password,
            int employeeTypeID,
            int personID,
            string address
      )
        {
            int employeeID = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"
                           insert into  Employees 
                           (userName,password,employeeTypeID,personID,address,phone)
                           values (@userName,@password,@employeeTypeID,@personID,@address,@phone);
                           select SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {


                        cmd.Parameters.AddWithValue("@userName", userName);
                        if (password == "")
                            cmd.Parameters.AddWithValue("@password", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@employeeTypeID", employeeTypeID);
                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@address", phone);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            employeeID = resultID;
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }


            return employeeID;
        }




        public static bool updateEmployee
            (
            int id,
            string phone,
            string userName,
            string password,
            int employeeTypeID,
            int personID,
            string address,
            bool isBlock
            )
        {
            bool isUpdate = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"
                           update  Employees  set 
                           userName = @userName,
                           password = @password,
                           employeeTypeID =  @employeeTypeID,
                           personID = @personID,
                           address = @address,
                           phone = @phone,
                           isBlock = @isBlock
                           where employeeID = @id";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {


                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@userName", userName);


                        if (password == "")
                            cmd.Parameters.AddWithValue("@password", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@employeeTypeID", employeeTypeID);
                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@isBlock", isBlock);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            isUpdate = true;
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }


            return isUpdate;
        }



        public static bool deleteEmployeeByID(int id)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"SP_deletEmployeeByID";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {


                        cmd.Parameters.AddWithValue("@employeeID", id);


                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            isDeleted = resultID == 1 ? true : false;
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }

            return isDeleted;
        }

        public static bool deleteEmployeeByPhone(string phone)
        {
            bool isDeleted = false;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"SP_deletEmployeeByPHone";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {


                        cmd.Parameters.AddWithValue("@phone", phone);


                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            isDeleted = resultID == 1 ? true : false;
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }

            return isDeleted;
        }


        public static DataTable getEmployees()
        {

            DataTable dtEmployee = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"select * from Employee_view";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {




                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtEmployee.Load(reader);
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }

            return dtEmployee;
        }


    }
}
