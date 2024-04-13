using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsCustomersData
    {
        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;
        public static bool findCustomer
            (

            int id,
            ref int familyRelationID,
            ref int personID,
            ref int? addBy,
            ref int identityID,
            ref int? belongTo,
            ref bool isBlock
            )
        {

            bool isFound = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from Customers where customerID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                familyRelationID = (int)reader["familyRelationID"];
                                personID = (int)reader["personID"];

                                if (reader["addBy"] == DBNull.Value)
                                    addBy = null;
                                else
                                    addBy = (int)reader["addBy"];

                                identityID = (int)reader["identityID"];

                                if (reader["belongTo"] == DBNull.Value)
                                    addBy = null;
                                else
                                    addBy = (int)reader["belongTo"];

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


        public static int createCustomer
            (
            int familyRelationID,
            int personID,
            int? addBy,
            int identityID,
            int? belongTo
            )
        {

            int id = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"
                                   insert into Customers (addBy,familyRelationID,identityID,personID,belongTo)
                                   values (@addBy,@familyRelationID,@identityID,@personID,@belongTo);
                                   select SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (addBy != null)
                            cmd.Parameters.AddWithValue("@addBy", addBy);
                        else
                            cmd.Parameters.AddWithValue("@addBy", DBNull.Value);

                        cmd.Parameters.AddWithValue("@familyRelationID", familyRelationID);
                        cmd.Parameters.AddWithValue("@identityID", identityID);
                        cmd.Parameters.AddWithValue("@personID", personID);

                        if (belongTo != null)
                            cmd.Parameters.AddWithValue("@belongTo", belongTo);
                        else
                            cmd.Parameters.AddWithValue("@belongTo", DBNull.Value);


                        object reasult = cmd.ExecuteScalar();

                        if (reasult != null && int.TryParse(reasult.ToString(), out int resultID))
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


        public static bool updateCustomer
            (
            int id,
            int familyRelationID,
            int personID,
            int? addBy,
            int identityID,
            int? belongTo,
            bool isBlock
            )
        {

            bool isUpdate = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"
                                   update Customers  set 
                                   addBy = @addBy,
                                   familyRelationID = @familyRelationID,
                                   identityID = @identityID,
                                   personID = @personID,
                                   belongTo = @belongTo,
                                   isBlock = @isBlock
                                   where customerID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@id", id);
                        if (addBy != null)
                            cmd.Parameters.AddWithValue("@addBy", addBy);
                        else
                            cmd.Parameters.AddWithValue("@addBy", DBNull.Value);

                        cmd.Parameters.AddWithValue("@familyRelationID", familyRelationID);
                        cmd.Parameters.AddWithValue("@identityID", identityID);
                        cmd.Parameters.AddWithValue("@personID", personID);

                        if (belongTo != null)
                            cmd.Parameters.AddWithValue("@belongTo", belongTo);
                        else
                            cmd.Parameters.AddWithValue("@belongTo", DBNull.Value);

                        cmd.Parameters.AddWithValue("@isBlock", isBlock);

                        int reasult = cmd.ExecuteNonQuery();

                        if (reasult > 0)
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

        public static DataTable getCustomers()
        {

            DataTable dtCustomer = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from Customer_view";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtCustomer.Load(reader);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());
            }

            return dtCustomer;

        }

        public static bool deletCustomer(int personID)
        {

            bool isDelete = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"SP_deleteCustomer @personID =@personID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@personID", personID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isDelete = true;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());
            }

            return isDelete;

        }

        public static bool isCustomerBlock(int id)
        {

            bool isBlock = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select found = 1 from Customers where customerID = id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isBlock = true;
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

        public static bool chagneCusotmerState(int id, bool state)
        {

            bool isChagneState = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"update Customers set isBlock = @state where customerID = id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@state", state);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isChagneState = true;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is :" + ex.ToString());
            }

            return isChagneState;

        }

    }
}
