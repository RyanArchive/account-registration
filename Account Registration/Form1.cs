using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text.ToString());
            StudentInfoClass.Program = cmbProgram.Text.ToString();
            StudentInfoClass.LastName = txtLastName.Text.ToString();
            StudentInfoClass.FirstName = txtFirstName.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddleName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text.ToString());
            StudentInfoClass.Address = txtAddress.Text.ToString();

            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.ShowDialog();

            if (frmConfirm.DialogResult == DialogResult.OK)
            {
                txtStudentNo.Clear();
                cmbProgram.SelectedItem = null;
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();
            }
        }
    }
}
