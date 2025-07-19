// FrmMain.Designer.cs
// CST-150 Milestone 6
// Author: Eric Gathinji
// Date: July 2025

namespace PresentationLayer
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDescription = new TextBox();
            this.txtQuantity = new TextBox();
            this.txtCost = new TextBox();
            this.txtSupplier = new TextBox();
            this.btnAdd = new Button();
            this.btnDelete = new Button();
            this.btnInc = new Button();
            this.btnDec = new Button();
            this.dgvInventory = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(30, 30);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(200, 27);

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(250, 30);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 27);

            // txtCost
            this.txtCost.Location = new System.Drawing.Point(370, 30);
            this.txtCost.Name = "txtCost";
            this.txtCost.PlaceholderText = "Cost";
            this.txtCost.Size = new System.Drawing.Size(100, 27);

            // txtSupplier
            this.txtSupplier.Location = new System.Drawing.Point(490, 30);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PlaceholderText = "Supplier";
            this.txtSupplier.Size = new System.Drawing.Size(150, 27);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(660, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(750, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnInc
            this.btnInc.Location = new System.Drawing.Point(840, 30);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(40, 30);
            this.btnInc.Text = "+";
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);

            // btnDec
            this.btnDec.Location = new System.Drawing.Point(890, 30);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(40, 30);
            this.btnDec.Text = "-";
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);

            // dgvInventory
            this.dgvInventory.Location = new System.Drawing.Point(30, 80);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(900, 400);
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.Add("Description", "Description");
            this.dgvInventory.Columns.Add("Quantity", "Quantity");
            this.dgvInventory.Columns.Add("Cost", "Cost");
            this.dgvInventory.Columns.Add("Supplier", "Supplier");
            this.dgvInventory.Columns.Add("DateAdded", "Date Added");

            // FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.dgvInventory);
            this.Text = "Inventory Manager - Milestone 6";

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtCost;
        private TextBox txtSupplier;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnInc;
        private Button btnDec;
        private DataGridView dgvInventory;
    }
}
