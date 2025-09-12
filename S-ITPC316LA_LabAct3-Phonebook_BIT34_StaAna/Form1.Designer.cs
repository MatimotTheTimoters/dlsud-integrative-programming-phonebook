namespace S_ITPC316LA_LabAct3_Phonebook_BIT34_StaAna
{
    partial class formPhonebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.gridViewPeople = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tableMain.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.tableInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableMain.Controls.Add(this.tableButtons, 0, 1);
            this.tableMain.Controls.Add(this.tableInput, 1, 0);
            this.tableMain.Controls.Add(this.gridViewPeople, 1, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableMain.Size = new System.Drawing.Size(480, 657);
            this.tableMain.TabIndex = 0;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 1;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableButtons.Controls.Add(this.btnDelete, 0, 4);
            this.tableButtons.Controls.Add(this.btnView, 0, 3);
            this.tableButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tableButtons.Controls.Add(this.btnEdit, 0, 1);
            this.tableButtons.Controls.Add(this.btnSearch, 0, 2);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(3, 167);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 5;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.Size = new System.Drawing.Size(138, 487);
            this.tableButtons.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 93);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(3, 294);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 91);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 91);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(3, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 91);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(3, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 91);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableInput
            // 
            this.tableInput.ColumnCount = 1;
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInput.Controls.Add(this.txtBoxPhoneNumber, 0, 3);
            this.tableInput.Controls.Add(this.lblName, 0, 0);
            this.tableInput.Controls.Add(this.lblPhoneNumber, 0, 2);
            this.tableInput.Controls.Add(this.txtBoxName, 0, 1);
            this.tableInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableInput.Location = new System.Drawing.Point(147, 3);
            this.tableInput.Name = "tableInput";
            this.tableInput.RowCount = 4;
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableInput.Size = new System.Drawing.Size(330, 158);
            this.tableInput.TabIndex = 1;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(3, 120);
            this.txtBoxPhoneNumber.Multiline = true;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(324, 35);
            this.txtBoxPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 78);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(324, 39);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "PHONE NUMBER";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxName.Location = new System.Drawing.Point(3, 42);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(324, 33);
            this.txtBoxName.TabIndex = 2;
            // 
            // gridViewPeople
            // 
            this.gridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewPeople.Location = new System.Drawing.Point(147, 167);
            this.gridViewPeople.Name = "gridViewPeople";
            this.gridViewPeople.Size = new System.Drawing.Size(330, 487);
            this.gridViewPeople.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(324, 39);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formPhonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 657);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formPhonebook";
            this.Text = "Phonebook";
            this.tableMain.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.tableInput.ResumeLayout(false);
            this.tableInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel tableInput;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.DataGridView gridViewPeople;
        private System.Windows.Forms.Label lblName;
    }
}

