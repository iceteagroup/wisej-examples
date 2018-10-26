using System.ComponentModel;

namespace DataBinding.Model
{
    public class VendorList : BindingList<Vendor>
    {
        private static VendorList _instance;

        public static VendorList GetVendorList()
        {
            if (_instance == null)
                BuildInstance();

            return _instance;
        }

        public static bool Contains(int vendorId)
        {
            foreach (var vendor in _instance)
            {
                if (vendor.VendorId == vendorId)
                    return true;
            }

            return false;
        }

        public static Vendor GetVendor(int vendorId)
        {
            foreach (var vendor in _instance)
            {
                if (vendor.VendorId == vendorId)
                    return vendor;
            }

            return null;
        }

        private static void BuildInstance()
        {
            _instance = new VendorList();
            new Vendor
            {
                FirstName = "Ella",
                LastName = "Fitzgerald",
                Town = "Newport News",
                State = States.VA
            }.Save();

            new Vendor
            {
                FirstName = "Louis",
                LastName = "Armstrong",
                Town = "New Orleans",
                State = States.LA
            }.Save();
        }
    }
}