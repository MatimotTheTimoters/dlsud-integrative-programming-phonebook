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
using System.Windows.Forms.VisualStyles;

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
            ClearBind();
            BindData();
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if there are selected rows
            bool isRowSelected = gridViewPeople.SelectedRows != null &&
                                 gridViewPeople.SelectedRows.Count > 0;
            if (!isRowSelected)
            {
                MessageBox.Show("Please select a single row to edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isMultipleSelection = gridViewPeople.SelectedRows.Count > 1;
            if (isMultipleSelection)
            {
                MessageBox.Show("Please select only one row to edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataGridViewRow selectedRow = gridViewPeople.SelectedRows[0];

            string oldName = selectedRow.Cells[0].Value.ToString();
            int oldPhoneNumber = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());

            string newName = txtBoxName.Text; 
            int newPhoneNumber = Convert.ToInt32(txtBoxPhoneNumber.Text);

            myHelper.EditUser(oldName, oldPhoneNumber, newName, newPhoneNumber);
            MessageBox.Show($"Updated record: {oldName} ({oldPhoneNumber}) -> {newName} ({newPhoneNumber})", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearBind();
            BindData();
            ClearInput();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AssignInput();
            ArrayList newPeople = myHelper.GetUsers(name, phoneNumber);

            if (newPeople == null ||
                newPeople.Count == 0)
            {
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBind();
                return;
            }
            BindData(newPeople);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearBind();
            BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check there is row selected
            if (gridViewPeople.SelectedRows == null ||
                gridViewPeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a single row to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Limit to single selection
            if (gridViewPeople.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = gridViewPeople.SelectedRows[0];

            string name = selectedRow.Cells[0].Value.ToString();
            int phoneNumber = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());

            bool deleted = myHelper.DeleteUser(name, phoneNumber);

            if (deleted)
            {
                MessageBox.Show($"Deleted {name} ({phoneNumber}).", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBind();
                BindData();
            }
            else
            {
                MessageBox.Show("Could not find specified user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
