namespace DisconnectedDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnfindbyid = new Button();
            btnfindbyname = new Button();
            txtprodid = new TextBox();
            txtprodname = new TextBox();
            txtunitsinStock = new TextBox();
            txtsuppid = new TextBox();
            txtQtyPerUnit = new TextBox();
            txtcatid = new TextBox();
            txtreorderlevel = new TextBox();
            txtUnitsOnorder = new TextBox();
            comboBox1 = new ComboBox();
            txtprice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 434);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(914, 42);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(125, 38);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "New Product";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(914, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 36);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(914, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 36);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnfindbyid
            // 
            btnfindbyid.Location = new Point(924, 256);
            btnfindbyid.Name = "btnfindbyid";
            btnfindbyid.Size = new Size(115, 36);
            btnfindbyid.TabIndex = 4;
            btnfindbyid.Text = "Find By ID";
            btnfindbyid.UseVisualStyleBackColor = true;
            btnfindbyid.Click += btnfindbyid_Click;
            // 
            // btnfindbyname
            // 
            btnfindbyname.Location = new Point(924, 336);
            btnfindbyname.Name = "btnfindbyname";
            btnfindbyname.Size = new Size(115, 36);
            btnfindbyname.TabIndex = 5;
            btnfindbyname.Text = "FindByName";
            btnfindbyname.UseVisualStyleBackColor = true;
            btnfindbyname.Click += btnfindbyname_Click;
            // 
            // txtprodid
            // 
            txtprodid.Location = new Point(579, 46);
            txtprodid.Name = "txtprodid";
            txtprodid.PlaceholderText = "Enter Productid";
            txtprodid.Size = new Size(125, 27);
            txtprodid.TabIndex = 6;
            // 
            // txtprodname
            // 
            txtprodname.Location = new Point(579, 89);
            txtprodname.Name = "txtprodname";
            txtprodname.PlaceholderText = "Enter ProductNAme";
            txtprodname.Size = new Size(313, 27);
            txtprodname.TabIndex = 7;
            txtprodname.TextChanged += textBox2_TextChanged;
            // 
            // txtunitsinStock
            // 
            txtunitsinStock.Location = new Point(579, 279);
            txtunitsinStock.Name = "txtunitsinStock";
            txtunitsinStock.PlaceholderText = "Enter UnitsInStock";
            txtunitsinStock.Size = new Size(125, 27);
            txtunitsinStock.TabIndex = 8;
            // 
            // txtsuppid
            // 
            txtsuppid.Location = new Point(579, 122);
            txtsuppid.Name = "txtsuppid";
            txtsuppid.PlaceholderText = "Enter Supplier ID";
            txtsuppid.Size = new Size(125, 27);
            txtsuppid.TabIndex = 9;
            // 
            // txtQtyPerUnit
            // 
            txtQtyPerUnit.Location = new Point(579, 237);
            txtQtyPerUnit.Name = "txtQtyPerUnit";
            txtQtyPerUnit.PlaceholderText = "Enter Qty PEr unit";
            txtQtyPerUnit.Size = new Size(125, 27);
            txtQtyPerUnit.TabIndex = 10;
            // 
            // txtcatid
            // 
            txtcatid.Location = new Point(579, 196);
            txtcatid.Name = "txtcatid";
            txtcatid.PlaceholderText = "Enter Categoryid";
            txtcatid.Size = new Size(125, 27);
            txtcatid.TabIndex = 11;
            // 
            // txtreorderlevel
            // 
            txtreorderlevel.Location = new Point(579, 349);
            txtreorderlevel.Name = "txtreorderlevel";
            txtreorderlevel.PlaceholderText = "Enter REorder LEvel";
            txtreorderlevel.Size = new Size(125, 27);
            txtreorderlevel.TabIndex = 13;
            // 
            // txtUnitsOnorder
            // 
            txtUnitsOnorder.Location = new Point(579, 315);
            txtUnitsOnorder.Name = "txtUnitsOnorder";
            txtUnitsOnorder.PlaceholderText = "Enter Units on ORder";
            txtUnitsOnorder.Size = new Size(159, 27);
            txtUnitsOnorder.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select Status:", "True", "False" });
            comboBox1.Location = new Point(579, 384);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(579, 155);
            txtprice.Name = "txtprice";
            txtprice.PlaceholderText = "Enter Price";
            txtprice.Size = new Size(125, 27);
            txtprice.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 661);
            Controls.Add(txtprice);
            Controls.Add(comboBox1);
            Controls.Add(txtUnitsOnorder);
            Controls.Add(txtreorderlevel);
            Controls.Add(txtcatid);
            Controls.Add(txtQtyPerUnit);
            Controls.Add(txtsuppid);
            Controls.Add(txtunitsinStock);
            Controls.Add(txtprodname);
            Controls.Add(txtprodid);
            Controls.Add(btnfindbyname);
            Controls.Add(btnfindbyid);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnfindbyid;
        private Button btnfindbyname;
        private TextBox txtprodid;
        private TextBox txtprodname;
        private TextBox txtunitsinStock;
        private TextBox txtsuppid;
        private TextBox txtQtyPerUnit;
        private TextBox txtcatid;
        private TextBox txtreorderlevel;
        private TextBox txtUnitsOnorder;
        private ComboBox comboBox1;
        private TextBox txtprice;
    }
}
