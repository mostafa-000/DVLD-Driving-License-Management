using DVLD_Business;
using DVLD_Business.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            ApplyStroke(label1, Color.Black, 1.5f);
            ApplyStroke(label2, Color.Black, 1f);
            ApplyStroke(label3, Color.Black, 1f);

            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            } 
            ctrlUserCard1.LoadUserInfo(_UserID);

        }

        private bool _ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current password cannot be blank!");
                isValid = false;
            }
            else if (!clsCryptography.VerifyPassword(txtCurrentPassword.Text.Trim(), _User.Password))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank!");
                isValid = false;
            }

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.ChangePassword(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the new password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void ApplyStroke(Label lbl, Color strokeColor, float strokeWidth = 1.5f)
        {
            lbl.Paint += (sender, e) =>
            {
                Label l = (Label)sender;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddString(l.Text, l.Font.FontFamily, (int)l.Font.Style,
                                    l.Font.Size * 96f / 72f / e.Graphics.DpiY * e.Graphics.DpiY, 
                                    new PointF(0, 0), StringFormat.GenericDefault);

                    //  (Outline)
                    using (Pen strokePen = new Pen(strokeColor, strokeWidth))
                    {
                        strokePen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        e.Graphics.DrawPath(strokePen, path);
                    }

                    // 
                    using (SolidBrush fillBrush = new SolidBrush(l.ForeColor))
                    {
                        e.Graphics.FillPath(fillBrush, path);
                    }
                }
            };

            lbl.Invalidate();
        }
    }
}
