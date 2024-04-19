using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsRoomData
    {

        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;

        public static bool findRoomByID
            (
            int id,
            ref byte capacity,
            ref byte bedNumber,
            ref double pricePerDay,
            ref byte state,
            ref int? addBy,
            ref short floorNumber,
            ref DateTime createdDate,
            ref int roomTypeID
            )
        {
            bool isFound = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from Rooms where roomID = @id ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;

                                capacity = (byte)reader["capacity"];
                                bedNumber = (byte)reader["bedNumber"];
                                pricePerDay = (double)reader["pricePerDay"];
                                state = (byte)reader["state"];
                                floorNumber = (short)reader["floorNumber"];
                                createdDate = (DateTime)reader["createdDate"];
                                roomTypeID = (int)reader["roomTypeID"];

                                if (reader["addBy"] == DBNull.Value)
                                    addBy = null;
                                else
                                    addBy = (int)reader["addBy"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is : " + ex.ToString());
            }


            return isFound;
        }

        public static int createRoom
                (
                byte capacity,
                byte bedNumber,
                double pricePerDay,
                byte state,
                 int? addBy,
                 short floorNumber,
                 int roomTypeID
                )
        {
            int ID = 0;
            try
            {

                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @" 
                                   INSERT INTO Rooms
                                   (capacity,bedNumber,pricePerDay ,state,addBy,roomTypeID,floorNumber)
                                   VALUES
                                   (@capacity,@bedNumber,@pricePerDay,@state,@addBy,@roomTypeID,@floorNumber);
                                     select SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@bedNumber", bedNumber);
                        cmd.Parameters.AddWithValue("@pricePerDay", pricePerDay);
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@floorNumber", floorNumber);
                        cmd.Parameters.AddWithValue("@roomTypeID", roomTypeID);
                        if (addBy == null)
                            cmd.Parameters.AddWithValue("@addBy", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@addBy", addBy);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            ID = resultID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is : " + ex.ToString());
            }


            return ID;
        }


        public static bool UpdateRoom
            (
            int id,
            byte capacity,
            byte bedNumber,
            double pricePerDay,
            byte state,
            int? addBy,
            short floorNumber,
            int roomTypeID
            )
        {
            bool isUpdate = false;
            try
            {

                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @" 
                                   update Rooms set 
                                   capacity = @capacity ,
                                   bedNumber = @bedNumber,
                                   pricePerDay = @pricePerDay,
                                   state = @state ,
                                   addBy = @addBy,
                                   floorNumber = @floorNumber,
                                   roomTypeID = @roomTypeID
                                   where roomID = @id  ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@bedNumber", bedNumber);
                        cmd.Parameters.AddWithValue("@pricePerDay", pricePerDay);
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@floorNumber", floorNumber);
                        cmd.Parameters.AddWithValue("@roomTypeID", roomTypeID);
                        if (addBy == null)
                            cmd.Parameters.AddWithValue("@addBy", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@addBy", addBy);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            isUpdate = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is : " + ex.ToString());
            }

            return isUpdate;
        }

        public static bool deleteRoom
            (
            int id
            )
        {
            bool isUpdate = false;
            try
            {

                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"delete Rooms  where roomID = @id  ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            isUpdate = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is : " + ex.ToString());
            }

            return isUpdate;
        }

        public static DataTable getRooms()
        {
            DataTable dtRooms = new DataTable();
            try
            {

                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from room_view";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtRooms.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is : " + ex.ToString());
            }

            return dtRooms;
        }
    }
}
