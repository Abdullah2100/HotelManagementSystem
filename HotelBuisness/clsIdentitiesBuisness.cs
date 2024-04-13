using HotelData;
using System.Data;

namespace HotelBuisness
{
    public class clsIdentitiesBuisness
    {

        enum enMode { add, update };
        private enMode _mode { get; set; }
        public int id { get; set; }
        public string name { get; set; }

        public clsIdentitiesBuisness()
        {
            _mode = enMode.add;
            id = 0;
            name = "";
        }

        private clsIdentitiesBuisness(enMode mode, int id, string name)
        {
            _mode = mode;
            this.id = id;
            this.name = name;
        }

        public static clsIdentitiesBuisness findIdentitieByID(int id)
        {
            string name = "";
            if (clsIdentitiesData.findIdentitie(id, ref name))
            {
                return new clsIdentitiesBuisness(enMode.update, id, name);
            }
            return null;
        }

        public static clsIdentitiesBuisness findIdentitieByName(string name)
        {
            int id = 0;
            if (clsIdentitiesData.findIdentitie(name, ref id))
            {
                return new clsIdentitiesBuisness(enMode.update, id, name);
            }
            return null;
        }

        private bool _add()
        {
            this.id = clsIdentitiesData.createIdentitie(name);
            return (this.id != 0);
        }

        private bool _update()
        {
            return clsIdentitiesData.updateIdentitie(name, id);
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

        public static DataTable getIdentities()
        {
            return clsIdentitiesData.getIdentities();
        }

        public static bool deleteIdentitie(int id)
        {
            return clsIdentitiesData.deleteIdentitie(id);
        }

        public static bool isIdentitieExistByName(string name)
        {
            return clsIdentitiesData.isIdentitieExistByName(name);
        }
    }
}
