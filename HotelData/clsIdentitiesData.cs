using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsIdentitiesData
    {

        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;

        public static bool findIdentitie
            (
            int id,
            ref string name
            )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"select * from Identities where identityID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                name = (string)reader["name"];

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


        public static bool findIdentitie
            (
            string name,
            ref int id
            )
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"select * from Identities where name = @name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@name", name);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                id = (int)reader["identityID"];

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



        public static int createIdentitie(string name)
        {
            int id = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"
                                    insert into Identities(name) values(@name);
                                    select SCOPE_IDENTITY();
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@name", name);


                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            id = resultID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());

            }


            return id;
        }


        public static bool updateIdentitie
            (
            string name,
             int id
            )
        {
            bool isUpdate = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"
                                    update Identities set 
                                    name = @name
                                    where identityID = @id
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);


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


        public static bool deleteIdentitie(int id)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"delete Identities  where identityID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@id", id);


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



        public static DataTable getIdentities()
        {

            DataTable dtEmployeeType = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string qery = @"select * from Identities";

                    using (SqlCommand cmd = new SqlCommand(qery, con))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtEmployeeType.Load(reader);
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is :" + ex.Message);
            }

            return dtEmployeeType;
        }

        public static bool isIdentitieExistByName(string name)
        {
            bool isBlock = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionUrl))
                {
                    conn.Open();
                    string query = @"select found = 1 from Identities where  name = @name ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
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
