using HotelData;
using System;
using System.Data;

namespace HotelBuisness
{
    public class clsRoomBuisness
    {


        public enum enState { none, booking, closing, outServices }
        private enum enMode { add, update }
        private enMode _mode { get; set; }

        public int id { get; set; }
        public byte capacity { get; set; }
        public byte bedNumber { get; set; }
        public double pricePerDay { get; set; }
        public enState state { get; set; }
        public int? addBy { get; set; }
        public short floorNumber { get; set; }
        public DateTime createdDate { get; set; }
        public int roomTypeID { get; set; }

        public clsRoomTypeBuisness roomTypeInfo { get; set; }
        public clsEmployeeBuisness addByInfo { get; set; }

        public clsRoomBuisness()
        {
            this.id = 0;
            this.capacity = 0;
            this.bedNumber = 0;
            this.pricePerDay = 0;
            this.state = enState.none;
            this.addBy = null;
            this.floorNumber = 0;
            this.createdDate = DateTime.Now;
            this._mode = enMode.add;
            this.roomTypeID = 0;
        }

        private clsRoomBuisness(enMode mode, int id, byte capacity, byte bedNumber, double pricePerDay, enState state, int? addBy, short floorNumber, DateTime createdDate, int roomTypeID)

        {
            this._mode = mode;
            this.id = id;
            this.capacity = capacity;
            this.bedNumber = bedNumber;
            this.pricePerDay = pricePerDay;
            this.addBy = addBy;
            this.floorNumber = floorNumber;
            this.roomTypeID = roomTypeID;
            if (addBy != null)
                addByInfo = clsEmployeeBuisness.findEmployeeByID(addBy ?? 0);
            this.state = state;
            this.createdDate = createdDate;
            this.roomTypeID = roomTypeID;
            this.roomTypeInfo = roomTypeInfo;
            this.roomTypeInfo = clsRoomTypeBuisness.findRoomTypeByID(roomTypeID);
        }

        public static clsRoomBuisness getRoomByID(int id)
        {
            byte capacity = 0;
            byte bedNumber = 0;
            double pricePerDay = 0.0;
            byte state = 0;
            int? addBy = null;
            short floorNumber = 0;
            int roomTypeID = 0;
            DateTime createdDate = DateTime.Now;

            if (clsRoomData.findRoomByID(id, ref capacity, ref bedNumber, ref pricePerDay, ref state, ref addBy, ref floorNumber, ref createdDate, ref roomTypeID))
            {
                return new clsRoomBuisness(enMode.update, id, capacity, bedNumber, pricePerDay, (enState)state, addBy, floorNumber, createdDate, roomTypeID);
            }

            return null;
        }


        private bool _add()
        {
            this.id = clsRoomData.createRoom(capacity, bedNumber, pricePerDay, (byte)state, addBy, floorNumber, roomTypeID);

            return (this.id != 0);
        }

        private bool _update()
        {
            return clsRoomData.UpdateRoom(id, capacity, bedNumber, pricePerDay, (byte)state, addBy, floorNumber, roomTypeID);
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
                            return true;
                        return false;
                    }
            }
            return false;
        }


        public static DataTable getRooms()
        {
            return clsRoomData.getRooms();
        }

        public static bool deleteRoom(int id)
        {
            return clsRoomData.deleteRoom(id);
        }
        public bool updateRoomState(int state)
        {
            return clsRoomData.UpdateRoom(id, capacity, bedNumber, pricePerDay, (byte)state, addBy, floorNumber, roomTypeID);
        }


    }
}
