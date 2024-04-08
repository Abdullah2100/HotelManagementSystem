using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsPeoplesData
    {

        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;

        public static bool findPersonByID
            (
            int personID,
            ref string firstName,
            ref string lastName,
            ref DateTime brithDay,
            ref DateTime createdDate,
            ref bool isBlock
            )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"select * from Peoples where personID = @personID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@personID", personID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                firstName = (string)reader["firstName"];
                                lastName = (string)reader["lastName"];
                                brithDay = (DateTime)reader["brithDay"];
                                createdDate = (DateTime)reader["createdDate"];
                                isBlock = (bool)reader["isBlock"];

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }


            return isFound;
        }


        public static int createPerson
        (
         string firstName,
         string lastName,
        DateTime brithDay,
        DateTime createdDate
            )
        {
            int personID = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"
                                    insert into Peoples(firstName,lastName,brithDay ,createdDate)
                                    values(@firstName,@lastName,@brithDay ,@createdDate);
                                    select SCOPE_IDENTITY();
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@brithDay", brithDay);
                        cmd.Parameters.AddWithValue("@createdDate", createdDate);


                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            personID = resultID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }


            return personID;
        }


        public static bool updatePerson
            (
            int personID,
            string firstName,
            string lastName,
            DateTime brithDay,
            bool isBlock
            )
        {
            bool isUpdate = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"
                                    update Peoples set 
                                    firstName = @firstName,
                                    lastName = @lastName,
                                    brithDay = @brithDay,
                                    isBlock = @isBlock 
                                    where personID = @personID
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@brithDay", brithDay);
                        cmd.Parameters.AddWithValue("@isBlock", isBlock);


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
                Console.WriteLine("Error is :" + ex.ToString());

            }


            return isUpdate;
        }








        public static bool deletePersonByID(int personID)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"delete Peoples where personID = @personID
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@personID", personID);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            isDeleted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }

            return isDeleted;
        }



        public static bool blockPersonByID(int personID)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"update  Peoples set isBlock =1   where personID = @personID
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@personID", personID);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            isDeleted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }

            return isDeleted;
        }


        public static bool isPersonBlocked(int personID)
        {
            bool isBlock = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"select found = 1 from Peoples where  isBlock =1 and personID = @personID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@personID", personID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isBlock = (bool)reader.Read();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }

            return isBlock;
        }


    }
}
