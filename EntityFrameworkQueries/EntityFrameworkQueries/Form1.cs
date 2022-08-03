using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;

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
    }
}