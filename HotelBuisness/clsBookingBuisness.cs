using HotelData;
using System;
using System.Data;

namespace HotelBuisness
{
    public class clsBookingBuisness
    {
        private enum enMode { add, join, update }

        private enMode _mode { get; set; }
        // Properties
        public int id { get; set; }
        public int customerId { get; set; }
        public DateTime addDate { get; set; }
        public DateTime outDate { get; set; }
        public DateTime? realDayOut { get; set; }
        public decimal totalPrice { get; set; }
        public decimal firstPayment { get; set; }
        public decimal reminderPayment { get; set; }
        public decimal? additionalPayment { get; set; }
        public bool isAvailable { get; set; }
        public int? addedBy { get; set; }
        public int? belongsToBooking { get; set; }
        public int roomID { get; set; }
        public clsCustomerBuisness customerInf { get; set; }
        public clsRoomBuisness roomInfo { get; set; }
        public clsBookingBuisness bookingInfo { get; set; }
        public clsEmployeeBuisness employeeInfo { get; set; }

        private clsBookingBuisness
            (
            enMode mode,
            int id,
            int customerId,
            DateTime addDate,
            DateTime outDate,
            DateTime? realDayOut,
            decimal totalPrice,
            decimal firstPayment,
            decimal reminderPayment,
            decimal? additionalPayment,
            bool isAvailable,
            int? addedBy,
            int? belongsToBooking,
            int roomID

            )
        {
            this.id = id;
            this.customerId = customerId;
            this.addDate = addDate;
            this.outDate = outDate;
            this.realDayOut = realDayOut;
            this.totalPrice = totalPrice;
            this.firstPayment = firstPayment;
            this.reminderPayment = reminderPayment;
            this.additionalPayment = additionalPayment;
            this.isAvailable = isAvailable;
            this.addedBy = addedBy;
            this.belongsToBooking = belongsToBooking;
            this.roomID = roomID;
            this._mode = mode;
            if (addedBy != null)
                this.employeeInfo = clsEmployeeBuisness.findEmployeeByID(addedBy ?? 0);
            this.customerInf = clsCustomerBuisness.findCustomerByID(customerId);
            this.roomInfo = clsRoomBuisness.getRoomByID(roomID);
        }

        public clsBookingBuisness()
        {
            id = 0;
            customerId = 0;
            addDate = DateTime.MinValue;
            outDate = DateTime.Now;
            realDayOut = null;
            totalPrice = 0;
            firstPayment = 0;
            reminderPayment = 0;
            additionalPayment = null;
            isAvailable = false;
            addedBy = null;
            belongsToBooking = null;
            roomID = 0;
            _mode = enMode.add;
        }


        public static clsBookingBuisness findBookingByID(int id)
        {
            int customerId = 0;
            DateTime addDate = DateTime.MinValue;
            DateTime outDate = DateTime.Now;
            DateTime? realDayOut = null;
            decimal totalPrice = 0;
            decimal firstPayment = 0;
            decimal reminderPayment = 0;
            decimal? additionalPayment = 0;
            bool isAvailable = false;
            int? addedBy = null;
            int? belongsToBooking = 0;
            int roomID = 0;
            if (clsBookingData.findBookingByID(
                id,
                ref customerId,
                ref addDate,
                ref outDate,
                ref realDayOut,
                ref totalPrice,
                ref firstPayment,
                ref reminderPayment,
                ref additionalPayment,
                ref isAvailable,
                ref addedBy,
                ref belongsToBooking,
                ref roomID))
            {
                return new clsBookingBuisness(enMode.join, id, customerId, addDate, outDate, realDayOut, totalPrice, firstPayment, reminderPayment, additionalPayment, isAvailable, addedBy, belongsToBooking, roomID);
            }

            return null;
        }

        private bool _add()
        {
            this.id = clsBookingData.createBooking(customerId, addDate, outDate, realDayOut, totalPrice, firstPayment, reminderPayment, additionalPayment, isAvailable, addedBy, belongsToBooking, roomID);
            clsRoomBuisness.getRoomByID(roomID).updateRoomState(1);
            return (this.id != 0);
        }

        private bool _update()
        {
            return clsBookingData.updateBooking(
                id,
                customerId,
                addDate,
                outDate,
                realDayOut,
                totalPrice,
                firstPayment,
                reminderPayment,
                additionalPayment,
                isAvailable,
                addedBy,
                belongsToBooking,
                roomID
                );
        }

        private bool _join()
        {
            this.id = clsBookingData.joinBooking(this.id, this.customerId, this.addedBy);
            return (this.id != 0);
        }

        public bool save()
        {
            switch (_mode)
            {
                case enMode.add:
                    {
                        if (_add())
                        {
                            _mode = enMode.update;
                            return true;
                        }
                        return false;
                    }
                case enMode.update:
                    {
                        if (_update())
                        {
                            return true;
                        }
                        return false;
                    }
                case enMode.join:
                    {
                        if (_update())
                        {
                            return true;
                        }
                        return false;
                    }
            }
            return false;
        }

        public static DataTable getBookings()
        {
            return clsBookingData.getBookings();
        }

        public static DataTable getBookingsBelong(int id)
        {
            return clsBookingData.getBookingsBelong(id);
        }

        public static bool isBookingBelong(int id, int cutomerID)
        {
            return clsBookingData.isCustomerBelong(id, cutomerID);
        }

        public static bool isCustomerBookingRoom(int customerID, int bookingRoom)
        {
            return clsBookingData.isCustomerBookingThisRoom(customerID, bookingRoom);
        }

    }



}
