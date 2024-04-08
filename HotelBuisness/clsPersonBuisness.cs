using HotelData;
using System;

namespace HotelBuisness
{
    public class clsPersonBuisness
    {

        enum enMode { add, update };
        private enMode _mode { get; set; }
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime brithDay { get; set; }
        public DateTime createdDate { get; set; }
        public bool isBlock { get; set; }

        public clsPersonBuisness()
        {
            _mode = enMode.add;
            id = 0;
            firstName = "";
            lastName = "";
            brithDay = DateTime.Now;
            createdDate = DateTime.Now;
            isBlock = false;
            _mode = enMode.add;
        }

        private clsPersonBuisness(enMode mode, int id, string firstName, string lastName, DateTime brithDay, DateTime createdDate, bool isBlock)
        {
            _mode = mode;
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.brithDay = brithDay;
            this.createdDate = createdDate;
            this.isBlock = isBlock;
            this._mode = mode;
        }


        public static clsPersonBuisness findPersonByID(int id)
        {
            string firstName = "";
            string lastName = "";
            DateTime brithDay = DateTime.Now;
            DateTime createdDate = DateTime.Now;
            bool isBlock = false;

            if (clsPeoplesData.findPersonByID(id, ref firstName, ref lastName, ref brithDay, ref createdDate, ref isBlock))
            {
                return new clsPersonBuisness(enMode.update, id, firstName, lastName, brithDay, createdDate, isBlock);
            }

            return null;
        }

        private bool _add()
        {
            this.id = clsPeoplesData.createPerson(firstName, lastName, brithDay, createdDate);
            return (id != 0);
        }

        private bool _update()
        {
            return clsPeoplesData.updatePerson(id, firstName, lastName, brithDay, isBlock);
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

            }
            return false;
        }


        public static bool deletePersonByID(int id)
        {
            return clsPeoplesData.deletePersonByID(id);
        }

        public static bool blockPersonByID(int id)
        {
            return clsPeoplesData.blockPersonByID(id);
        }

        public static bool isPersonBlock(int id)
        {
            return clsPeoplesData.isPersonBlocked(id);
        }

    }
}
