namespace CarsSelectListApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbEngineCapacity = new System.Windows.Forms.ComboBox();
            this.cbEngineType = new System.Windows.Forms.ComboBox();
            this.cbGear = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enginetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enginecapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(338, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(115, 23);
            this.btnColor.TabIndex = 22;
            this.btnColor.Text = "Choise Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbEngineCapacity
            // 
            this.cbEngineCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEngineCapacity.FormattingEnabled = true;
            this.cbEngineCapacity.Items.AddRange(new object[] {
            "2.0",
            "2.4",
            "2.6",
            "3.0",
            "3.5",
            "4.2",
            "4.5",
            "4.8",
            "5.0",
            "5.2",
            "5.6",
            "6.0",
            "6.2"});
            this.cbEngineCapacity.Location = new System.Drawing.Point(742, 52);
            this.cbEngineCapacity.Name = "cbEngineCapacity";
            this.cbEngineCapacity.Size = new System.Drawing.Size(134, 21);
            this.cbEngineCapacity.TabIndex = 21;
            // 
            // cbEngineType
            // 
            this.cbEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEngineType.FormattingEnabled = true;
            this.cbEngineType.Items.AddRange(new object[] {
            "Gasoline",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.cbEngineType.Location = new System.Drawing.Point(596, 52);
            this.cbEngineType.Name = "cbEngineType";
            this.cbEngineType.Size = new System.Drawing.Size(140, 21);
            this.cbEngineType.TabIndex = 20;
            // 
            // cbGear
            // 
            this.cbGear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGear.FormattingEnabled = true;
            this.cbGear.Items.AddRange(new object[] {
            "Manual",
            "Automatic",
            "Tryptonic"});
            this.cbGear.Location = new System.Drawing.Point(459, 52);
            this.cbGear.Name = "cbGear";
            this.cbGear.Size = new System.Drawing.Size(131, 21);
            this.cbGear.TabIndex = 19;
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Volvo S60",
            "Volvo S90",
            "Volvo XC60",
            "Volvo XC90",
            "Audi A5",
            "Audi A7",
            "Audi Q5",
            "Audi Q6",
            "Audi Q7",
            "Maserati Ghibli",
            "Jaguar F Type",
            "Aston Martin Vantage",
            "Aston Martin DB12",
            "Corvette Z06",
            "Mercedes Cls63",
            "Mercedes G63",
            "Bmw 420i",
            "Bmw 620i",
            "Bmw X5",
            "Bmw X6",
            "Bmw X7",
            ""});
            this.cbModel.Location = new System.Drawing.Point(211, 52);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Engine Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Engine Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gear Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Car Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Car Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name/Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1078, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Location = new System.Drawing.Point(990, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 39);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(899, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1078, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 57);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Model,
            this.Color,
            this.Gear,
            this.Enginetype,
            this.Enginecapacity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1057, 471);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name/Surname";
            this.Name.Width = 164;
            // 
            // Model
            // 
            this.Model.Text = "Car Model";
            this.Model.Width = 133;
            // 
            // Color
            // 
            this.Color.Text = "Car Colour";
            this.Color.Width = 145;
            // 
            // Gear
            // 
            this.Gear.Text = "Gear Type";
            this.Gear.Width = 145;
            // 
            // Enginetype
            // 
            this.Enginetype.Text = "Engine Type";
            this.Enginetype.Width = 161;
            // 
            // Enginecapacity
            // 
            this.Enginecapacity.Text = "Engine Capacity";
            this.Enginecapacity.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 594);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbEngineCapacity);
            this.Controls.Add(this.cbEngineType);
            this.Controls.Add(this.cbGear);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cbEngineCapacity;
        private System.Windows.Forms.ComboBox cbEngineType;
        private System.Windows.Forms.ComboBox cbGear;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Gear;
        private System.Windows.Forms.ColumnHeader Enginetype;
        private System.Windows.Forms.ColumnHeader Enginecapacity;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

