using DVLD.Global_Classes;
using DVLD_Business;
using DVLD_Business.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {


        private string _StoredHashedPassword = "";
        private const string _PasswordPlaceholder = "********"; 
        private bool _isHashedPassword = false;

        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashedPassword = _isHashedPassword
                ? _StoredHashedPassword.Trim()
                : clsCryptography.ComputeHash(txtPassword.Text.Trim());

            clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), hashedPassword);
            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), hashedPassword);

                    _StoredHashedPassword = hashedPassword;
                    txtPassword.Text = "********";
                    _isHashedPassword = true;


                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    _StoredHashedPassword = "";
                    _isHashedPassword = false;
                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();


            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                _StoredHashedPassword = Password;
                txtPassword.Text = _PasswordPlaceholder;
                _isHashedPassword = true;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _isHashedPassword = false;
        }
    }
}
