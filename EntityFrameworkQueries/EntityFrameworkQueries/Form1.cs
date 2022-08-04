using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            APContext dbContext = new APContext();

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from vendor in dbContext.Vendors
                                       select vendor).ToList();
        }

        private void btnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(vendor => vendor.VendorState == "CA")
                                        .OrderBy(vendor => vendor.VendorState)
                                        .ToList();

            List<Vendor> vendorList2 = (from vendor in dbContext.Vendors
                                       where vendor.VendorState == "CA"
                                       orderby vendor.VendorName
                                       select vendor).ToList();
                                    
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        { 
            APContext dbContext = new APContext();
            // Anonymous type
            List<VendorLocation> results = (from vendor in dbContext.Vendors
                           select new VendorLocation 
                           { VendorName = vendor.VendorName,
                             VendorState = vendor.VendorState,
                             VendorCity = vendor.VendorCity}).ToList();

            StringBuilder displayString = new();
            foreach(VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }
    }
    class VendorLocation
    {
        public string VendorName { get; set; }
        public string VendorState { get; set; }
        public string VendorCity { get; set; }

    }
}