using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelData
{
    public class clsBookingData
    {

        static string connectionUrl = ConfigurationManager.ConnectionStrings["urlConnection"].ConnectionString;

        public static bool findBookingByID
            (
            int ID,
            ref int customerID,
            ref DateTime addDate,
            ref DateTime outDate,
            ref DateTime? realDayOut,
            ref decimal totalPrice,
            ref decimal firstPayment,
            ref decimal reminderPayment,
            ref decimal? adionalPayment,
            ref bool isAvilable,
            ref int? addBy,
            ref int? belongToBooking,
            ref int roomID
            )
        {
            bool isFound = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from Bookings where bookingID = @id ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customerID = (int)reader["customerID"];
                                addDate = (DateTime)reader["addDate"];
                                outDate = (DateTime)reader["outDate"];

                                if (reader["realDayOut"] == DBNull.Value)
                                    realDayOut = null;
                                else
                                    realDayOut = (DateTime)reader["realDayOut"];

                                totalPrice = (decimal)reader["totalPrice"];
                                firstPayment = (decimal)reader["firstPayment"];
                                reminderPayment = (decimal)reader["reminderPayment"];

                                if (reader["outDate"] == DBNull.Value)
                                    adionalPayment = null;
                                else
                                    adionalPayment = (decimal)reader["adionalPayment"];

                                isAvilable = (bool)reader["isAvilable"];

                                if (reader["addBy"] == DBNull.Value)
                                    addBy = null;
                                else
                                    addBy = (int)reader["addBy"];

                                if (reader["belongToBooking"] == DBNull.Value)
                                    belongToBooking = null;
                                else
                                    belongToBooking = (int)reader["belongToBooking"];

                                roomID = (int)reader["roomID"];
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());

            }


            return isFound;
        }


        public static int createBooking
            (
            int customerID,
            DateTime addDate,
            DateTime? outDate,
            DateTime? realDayOut,
            decimal totalPrice,
            decimal firstPayment,
            decimal reminderPayment,
            decimal? adionalPayment,
            bool isAvilable,
            int? addBy,
            int? belongToBooking,
            int roomID

            )
        {
            int id = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"INSERT INTO Bookings
                                     (customerID,addDate,outDate,realDayOut,totalPrice,
                                     firstPayment,reminderPayment,adionalPayment,isAvilable,
                                     addBy,belongToBooking,roomID)
                                     VALUES (@customerID,@addDate,@outDate,@realDayOut,@totalPrice, 
                                     @firstPayment,@reminderPayment,@adionalPayment,@isAvilable,
                                     @addBy,@belongToBooking,@roomID);
		                             select SCOPE_IDENTITY()";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);


                        cmd.Parameters.AddWithValue("@addDate", addDate);



                        cmd.Parameters.AddWithValue("@outDate", outDate);

                        cmd.Parameters.AddWithValue("@roomID", roomID);

                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                        if (realDayOut == null)
                        { cmd.Parameters.AddWithValue("@realDayOut", DBNull.Value); }
                        else
                        { cmd.Parameters.AddWithValue("@realDayOut", realDayOut); }

                        cmd.Parameters.AddWithValue("@firstPayment", firstPayment);
                        cmd.Parameters.AddWithValue("@reminderPayment", reminderPayment);

                        if (adionalPayment == null)
                        { cmd.Parameters.AddWithValue("@adionalPayment", DBNull.Value); }
                        else
                        { cmd.Parameters.AddWithValue("@adionalPayment", adionalPayment); }

                        cmd.Parameters.AddWithValue("@isAvilable", isAvilable);

                        if (addBy == null)
                        { cmd.Parameters.AddWithValue("@addBy", DBNull.Value); }
                        else
                        { cmd.Parameters.AddWithValue("@addBy", addBy); }

                        if (belongToBooking == null)
                        {
                            cmd.Parameters.AddWithValue("@belongToBooking", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@belongToBooking", belongToBooking);
                        }


                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int resultID))
                        {
                            id = resultID;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());

            }


            return id;
        }



        public static bool updateBooking
            (
            int id,
            int customerID,
            DateTime addDate,
            DateTime outDate,
            DateTime? realDayOut,
            decimal totalPrice,
            decimal firstPayment,
            decimal reminderPayment,
            decimal? adionalPayment,
            bool isAvilable,
            int? addBy,
            int? belongToBooking,
            int roomID
            )
        {
            bool isUpdate = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"update Bookings set 
                                     customerID = @customerID,
                                     addDate = @addDate ,
                                     outDate = @outDate ,
                                     realDayOut = @realDayOut,
                                     totalPrice = @totalPrice,
                                     firstPayment = @firstPayment ,
                                     reminderPayment  = @reminderPayment ,
                                     adionalPayment = @adionalPayment,
                                     isAvilable = @isAvilable,
                                     addBy = @addBy ,
                                     belongToBooking = @belongToBooking
		                             where bookingID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@addDate", addDate);
                        cmd.Parameters.AddWithValue("@outDate", outDate);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                        if (realDayOut == null)
                            cmd.Parameters.AddWithValue("@realDayOut", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@realDayOut", realDayOut);

                        cmd.Parameters.AddWithValue("@firstPayment", firstPayment);
                        cmd.Parameters.AddWithValue("@reminderPayment", reminderPayment);

                        if (adionalPayment == null)
                            cmd.Parameters.AddWithValue("@adionalPayment", adionalPayment);
                        else
                            cmd.Parameters.AddWithValue("@adionalPayment", adionalPayment);

                        cmd.Parameters.AddWithValue("@isAvilable", isAvilable);

                        if (addBy == null)
                            cmd.Parameters.AddWithValue("@isAvilable", null);
                        else
                            cmd.Parameters.AddWithValue("@isAvilable", addBy);

                        if (belongToBooking == null)
                            cmd.Parameters.AddWithValue("@belongToBooking", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@belongToBooking", belongToBooking);

                        cmd.Parameters.AddWithValue("@roomID", roomID);


                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            isUpdate = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());

            }


            return isUpdate;
        }


        public static DataTable getBookings()
        {
            DataTable dtBookings = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from booking_view";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBookings.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());
            }

            return dtBookings;
        }

        public static DataTable getBookingsBelong(int id)
        {
            DataTable dtBookings = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select * from dbo.getbooking_by_belong @BlongID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBookings.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());
            }

            return dtBookings;
        }


        public static bool isCustomerBelong(int id, int customerId)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select found = 1 from dbo.getbooking_by_belong(@id) where customerID = @customerID ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@customerID", customerId);

                        object result = cmd.ExecuteScalar();


                        if (result != null)
                        {
                            isFound = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());
            }

            return isFound;
        }

        public static bool isCustomerBookingThisRoom(int customerID, int roomID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"select found = 1 from Bookings  where customerID = @customerID and roomID =@roomID and realDayOut is not null ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@roomID", roomID);

                        object result = cmd.ExecuteScalar();


                        if (result != null)
                        {
                            isFound = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());
            }

            return isFound;
        }

        public static int joinBooking(int bookingID, int customerId, int? addBy)
        {
            int id = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionUrl))
                {
                    con.Open();
                    string query = @"
                                   SP_joinCustomerToBooking @CustomerID  = @customerID,
                                   @BookingID  = @bookingID,
                                   @AddBy = @addBy ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerId);

                        if (addBy != null)
                            cmd.Parameters.AddWithValue("@addDate", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@addDate", addBy);

                        cmd.Parameters.AddWithValue("@bookingID", bookingID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                id = (int)reader["bookingID"];
                            }

                        }


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());

            }


            return id;

        }
    }
}
