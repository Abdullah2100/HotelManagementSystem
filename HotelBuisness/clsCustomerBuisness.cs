using HotelData;
using System.Data;

namespace HotelBuisness
{
    public class clsCustomerBuisness
    {
        private enum enMode { add, update }
        private enMode _mode { get; set; }

        public int id { get; set; }
        public int familyRelationID { get; set; }
        public int personID { get; set; }
        public int? addBy { get; set; }
        public int? belongTo { get; set; }
        public int identityID { get; set; }
        public bool isBlock { get; set; }

        public clsFamilyRelationBuisness familyRelationInfo { get; set; }
        public clsPersonBuisness personInfo { get; set; }
        public clsEmployeeBuisness employeeInfo { get; set; }
        public clsCustomerBuisness beLongInfo { get; set; }
        public clsIdentitiesBuisness identitiesInfo { get; set; }


        private clsCustomerBuisness(enMode mode, int id, int familyRelationID, int personID, int? addBy, int? belongTo, int identityID, bool isBlock)
        {
            _mode = mode;
            this.id = id;
            this.familyRelationID = familyRelationID;
            this.personID = personID;
            this.addBy = addBy;
            this.belongTo = belongTo;
            this.identityID = identityID;
            this.isBlock = isBlock;
            this.familyRelationInfo = clsFamilyRelationBuisness.findFamilyRelationByID(this.familyRelationID);
            this.personInfo = clsPersonBuisness.findPersonByID(this.personID);
            if (this.addBy != null)
                this.employeeInfo = clsEmployeeBuisness.findEmployeeByID(this.addBy ?? 0);
            if (this.belongTo != null)
                this.beLongInfo = clsCustomerBuisness.findCustomerByID(this.belongTo ?? 0);
            this.identitiesInfo = clsIdentitiesBuisness.findIdentitieByID(this.identityID);
        }

        public clsCustomerBuisness()
        {
            this.id = 0;
            this.familyRelationID = 0;
            this.personID = 0;
            this.belongTo = 0;
            this.identityID = 0;
            this.isBlock = false;
            this._mode = enMode.add;
        }


        public static clsCustomerBuisness findCustomerByID(int id)
        {
            int familyRelationID = 0;
            int personID = 0;
            int? addBy = null;
            int? belongTo = null;
            int identityID = 0;
            bool isBlock = false;

            if (clsCustomersData.findCustomer(id, ref familyRelationID, ref personID, ref addBy, ref identityID, ref belongTo, ref isBlock))
            {
                return new clsCustomerBuisness(enMode.update, id, familyRelationID, personID, addBy, belongTo, identityID, isBlock);
            }
            return null;
        }

        public static clsCustomerBuisness findCustomerByPersonID(int personID)
        {
            int id = 0;
            int familyRelationID = 0;
            int? addBy = null;
            int? belongTo = null;
            int identityID = 0;
            bool isBlock = false;

            if (clsCustomersData.findCustomer(personID, ref id, ref familyRelationID, ref addBy, ref identityID, ref belongTo, ref isBlock))
            {
                return new clsCustomerBuisness(enMode.update, id, familyRelationID, personID, addBy, belongTo, identityID, isBlock);
            }
            return null;
        }

        private bool _add()
        {
            this.id = clsCustomersData.createCustomer(familyRelationID, personID, addBy, identityID, belongTo);
            return (this.id != 0);
        }

        private bool _update()
        {
            return clsCustomersData.updateCustomer(id, familyRelationID, personID, addBy, identityID, belongTo, isBlock);
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
        public static DataTable getCustomers()
        {
            return clsCustomersData.getCustomers();
        }

        public static bool deleteCustomer(int id)
        {
            return clsCustomersData.deletCustomer(id);
        }

        public static bool activateCusotmer(int id)
        {
            return clsCustomersData.chagneCusotmerState(id, true);
        }

        public static bool deactivateCusotmer(int id)
        {
            return clsCustomersData.chagneCusotmerState(id, false);
        }
        public static bool isCustomerBlock(int id)
        {
            return clsCustomersData.isCustomerBlock(id);
        }
        public static bool isCustomerExistByID(int id)
        {
            return clsCustomersData.isCustomerExistByID(id);
        }

        public static clsCustomerBuisness findCustomerByNatinoalNo(string natioNo)
        {
            clsPersonBuisness _perosn = clsPersonBuisness.findPersonByNationalNo(natioNo);
            if (_perosn != null)
            {
                return clsCustomerBuisness.findCustomerByPersonID(_perosn.id);
            }
            return null;
        }

    }
}
