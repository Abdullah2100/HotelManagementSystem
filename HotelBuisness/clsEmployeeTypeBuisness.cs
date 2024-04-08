using HotelData;
using System.Data;

namespace HotelBuisness
{
    public class clsEmployeeTypeBuisness
    {
        enum enMode { add, update };
        private enMode _mode { get; set; }
        public int id { get; set; }
        public string name { get; set; }

        public clsEmployeeTypeBuisness()
        {
            _mode = enMode.add;
            id = 0;
            name = "";
        }

        private clsEmployeeTypeBuisness(enMode mode, int id, string name)
        {
            _mode = mode;
            this.id = id;
            this.name = name;
        }

        public static clsEmployeeTypeBuisness findEmployeeTypeByID(int id)
        {
            string name = "";
            if (clsEmployeeTypeData.findEmployeeTypByID(id, ref name))
            {
                return new clsEmployeeTypeBuisness(enMode.update, id, name);
            }
            return null;
        }

        public static clsEmployeeTypeBuisness findEmployeeTypeByName(string name)
        {
            int id = 0;
            if (clsEmployeeTypeData.findEmployeeTypByName(name, ref id))
            {
                return new clsEmployeeTypeBuisness(enMode.update, id, name);
            }
            return null;
        }

        private bool _add()
        {
            this.id = clsEmployeeTypeData.createEmployeeeType(name);
            return (this.id != 0);
        }

        private bool _update()
        {
            return clsEmployeeTypeData.updateEmployeeType(name, id);
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

        public static DataTable getEmployeeTypes()
        {
            return clsEmployeeTypeData.getEmployeeTypes();
        }

        public static bool deleteEmployeeType(int id)
        {
            return clsEmployeeTypeData.deleteEmployeeType(id);
        }

        public static bool isEmployeeTypeExistByName(string name)
        {
            return clsEmployeeTypeData.isEmployeeTypeExistByName(name);
        }
    }
}
