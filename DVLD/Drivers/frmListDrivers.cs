using DVLD.Licenses;
using DVLD.Licenses.International_Licenses;
using DVLD.People;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtAllDrivers;

        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvDrivers3.DataSource = _dtAllDrivers;
            lblRecordsCount.Text = dgvDrivers3.Rows.Count.ToString();
            if (dgvDrivers3.Rows.Count > 0)
            {
                dgvDrivers3.Columns[0].HeaderText = "Driver ID";
                dgvDrivers3.Columns[0].Width = 120;

                dgvDrivers3.Columns[1].HeaderText = "Person ID";
                dgvDrivers3.Columns[1].Width = 120;

                dgvDrivers3.Columns[2].HeaderText = "National No.";
                dgvDrivers3.Columns[2].Width = 180;

                dgvDrivers3.Columns[3].HeaderText = "Full Name";
                dgvDrivers3.Columns[3].Width = 380;

                dgvDrivers3.Columns[4].HeaderText = "Date";
                dgvDrivers3.Columns[4].Width = 280;

                dgvDrivers3.Columns[5].HeaderText = "Active Licenses";
                dgvDrivers3.Columns[5].Width = 200;
            }



        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDrivers3.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
            {
                if (!int.TryParse(txtFilterValue.Text.Trim(), out int id))
                    return;
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers3.CurrentRow.Cells[1].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
            //refresh
            frmListDrivers_Load(null, null);

        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");

          
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers3.CurrentRow.Cells[1].Value;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void dgvDrivers3_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDrivers3.ClearSelection();
                dgvDrivers3.Rows[e.RowIndex].Selected = true;
                dgvDrivers3.CurrentCell = dgvDrivers3.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }



        private void dgvDrivers3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                                                    dgvDrivers3.RowHeadersWidth, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, rowNumber, dgvDrivers3.Font, headerBounds,
                                   Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

 
        }
    }

