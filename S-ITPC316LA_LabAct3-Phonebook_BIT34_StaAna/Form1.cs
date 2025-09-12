using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Collections;

namespace S_ITPC316LA_LabAct3_Phonebook_BIT34_StaAna
{
    public partial class formPhonebook : Form
    {
        // Variables
        DataHelper myHelper = new DataHelper();
        string name;
        int phoneNumber;
        DataTable tempTable;

        public formPhonebook()
        {
            InitializeComponent();
        }



        // Input methods
        public void AssignInput()
        {
            name = txtBoxName.Text;
            phoneNumber = Convert.ToInt32(txtBoxPhoneNumber.Text);
        }

        public void ClearInput()
        {
            txtBoxName.Text = "";
            txtBoxPhoneNumber.Text = null;
        }



        // BindData overloads
        public void BindData()
        {
            ArrayList people = myHelper.GetPeople();
            gridViewPeople.DataSource = people;
        }

        public void BindData(ArrayList people)
        {
            gridViewPeople.DataSource = people;
        }

        public void ClearBind()
        {
            gridViewPeople.DataSource = null;
        }


        // Button event listeners
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AssignInput();
            myHelper.AddUser(name, phoneNumber);
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AssignInput();
            //myHelper.EditUser(name, phoneNumber);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AssignInput();
            ArrayList newPeople = new ArrayList();
            newPeople = myHelper.GetUsers(name, phoneNumber);
            BindData(newPeople);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearBind();
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get cell count
            int selectedRowCount = gridViewPeople.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                // Get selected row
                DataGridViewRow selectedRow = gridViewPeople.SelectedRows[0];
                string name = selectedRow.Cells[0].Value.ToString();
                int phoneNumber = Convert.ToInt32(selectedRow.Cells[1].Value);

                myHelper.DeleteUser(name, phoneNumber);
                BindData();
            }
        }
    }
}
