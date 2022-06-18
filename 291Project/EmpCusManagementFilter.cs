using System.Windows.Forms;

namespace _291Project
{
    public partial class EmpCusManagementFilter : Form
    {
        bool MemberFilter;
        bool IdFilter;
        bool FirstNameFilter;
        bool LastNameFilter;
        bool EmailFilter;
        bool DriverNumFilter;
        bool GenderFilter;
        bool PostalCodeFilter;
        bool ProvinceFilter;
        bool CityFilter;
        bool PhoneFilter;


        public EmpCusManagementFilter(EmpCustomerManagement parentmenu)
        {
            InitializeComponent();
            parentmenu.filters_on = true;
        }

        private void SubmitFilterBtn(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void Email_TextChanged(object sender, System.EventArgs e)
        {
            if (Email.Text.Length != 0)
                EmailFilter = true;
            else EmailFilter = false;
        }

        private void FirstName_TextChanged(object sender, System.EventArgs e)
        {
            if (FirstName.Text.Length != 0)
                FirstNameFilter = true;
            else FirstNameFilter = false;

        }

        private void LastName_TextChanged(object sender, System.EventArgs e)
        {
            if (LastName.Text.Length != 0)
                LastNameFilter = true;
            else LastNameFilter = false;

        }

        private void License_TextChanged(object sender, System.EventArgs e)
        {
            if (License.Text.Length != 0)
                DriverNumFilter = true;
            else DriverNumFilter = false;

        }

        private void Gender_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (Gender.SelectedIndex > -1)
                GenderFilter = true;
            else GenderFilter = false;
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void EmpCusManagementFilter_Load(object sender, System.EventArgs e)
        {

        }

        private void Province_TextChanged(object sender, System.EventArgs e)
        {
            if (Province.Text.Length != 0)
                ProvinceFilter = true;
            else ProvinceFilter = false;
        }

        private void City_TextChanged(object sender, System.EventArgs e)
        {
            if (City.Text.Length != 0)
                CityFilter = true;
            else CityFilter = false;

        }

        private void PhoneNum_TextChanged(object sender, System.EventArgs e)
        {
            if (PhoneNum.Text.Length != 0)
                PhoneFilter = true;
            else PhoneFilter = false;

        }

        private void postalcode_TextChanged(object sender, System.EventArgs e)
        {
            if (postalcode.Text.Length != 0)
                PostalCodeFilter = true;
            else PostalCodeFilter = false;

        }

        private void EmailLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void customerID_TextChanged(object sender, System.EventArgs e)
        {
            if (customerID.Text.Length != 0)
                IdFilter = true;
            else IdFilter = false;

        }

        private void membershipType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (membershipType.SelectedIndex > -1)
                MemberFilter = true;
            else MemberFilter = false;

        }

        private void FilterInfoBoxHeader_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
