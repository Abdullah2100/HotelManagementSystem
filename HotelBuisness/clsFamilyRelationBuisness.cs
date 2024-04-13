using HotelData;
using System.Data;

namespace HotelBuisness
{
    public class clsFamilyRelationBuisness
    {

        enum enMode { add, update };
        private enMode _mode { get; set; }
        public int id { get; set; }
        public string name { get; set; }

        public clsFamilyRelationBuisness()
        {
            _mode = enMode.add;
            id = 0;
            name = "";
        }

        private clsFamilyRelationBuisness(enMode mode, int id, string name)
        {
            _mode = mode;
            this.id = id;
            this.name = name;
        }

        public static clsFamilyRelationBuisness findFamilyRelationByID(int id)
        {
            string name = "";
            if (clsFamilyRelationData.findFamilyRelation(id, ref name))
            {
                return new clsFamilyRelationBuisness(enMode.update, id, name);
            }
            return null;
        }

        public static clsFamilyRelationBuisness findFamilyRelationByName(string name)
        {
            int id = 0;
            if (clsFamilyRelationData.findFamilyRelation(name, ref id))
            {
                return new clsFamilyRelationBuisness(enMode.update, id, name);
            }
            return null;
        }

        private bool _add()
        {
            this.id = clsFamilyRelationData.createFamilyRelation(name);
            return (this.id != 0);
        }

        private bool _update()
        {
            return clsFamilyRelationData.updateFamilyRelation(name, id);
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

        public static DataTable getFamilyRelations()
        {
            return clsFamilyRelationData.getFamilyRelations();
        }

        public static bool deleteFamilyRelation(int id)
        {
            return clsFamilyRelationData.deleteFamilyRelation(id);
        }

        public static bool isFamilyRelationExistByName(string name)
        {
            return clsFamilyRelationData.isFamilyRelationExistByName(name);
        }
    }
}
