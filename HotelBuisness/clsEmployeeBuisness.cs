namespace HotelBuisness
{
    class clsEmployeeBuisness
    {
        enum enMode { add, update };
        private enMode _mode { get; set; }
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int employeeTypeID { get; set; }
        public int personID { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public bool isBlock { get; set; }
        public clsPersonBuisness personInfo { get; set; }
        public clsEmployeeTypeBuisness employeeTypeInfo { get; set; }

        public clsEmployeeBuisness()
        {
            _mode = enMode.add;
            id = 0;
            userName = "";
            password = "";
            employeeTypeID = 0;
            personID = 0;
            address = "";
            phone = "";
            isBlock = false;
        }

        private clsEmployeeBuisness(enMode mode, int id, string userName, string password, int employeeTypeID, int personID, string address, string phone, bool isBlock, clsPersonBuisness personInfo, clsEmployeeTypeBuisness employeeTypeInfo)
        {
            _mode = mode;
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.employeeTypeID = employeeTypeID;
            this.personID = personID;
            this.address = address;
            this.phone = phone;
            this.isBlock = isBlock;
            this.personInfo = personInfo;
            this.employeeTypeInfo = employeeTypeInfo;

            employeeTypeInfo = clsEmployeeTypeBuisness.findEmployeeTypeByID(employeeTypeID);
            personInfo = clsPersonBuisness.findPersonByID(personID);
        }
    }
}
