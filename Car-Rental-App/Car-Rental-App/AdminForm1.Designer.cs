
namespace Car_Rental_App
{
    partial class AdminForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_lablel = new System.Windows.Forms.Label();
            this.fullnamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.Button();
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_databaseDataSet = new Car_Rental_App.car_rental_databaseDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.dateascbtn = new System.Windows.Forms.Button();
            this.datedescbtn = new System.Windows.Forms.Button();
            this.customerbtn = new System.Windows.Forms.Button();
            this.auditTableAdapter = new Car_Rental_App.car_rental_databaseDataSetTableAdapters.auditTableAdapter();
            this.little_car = new System.Windows.Forms.PictureBox();
            this.auditBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_databaseDataSet1 = new Car_Rental_App.car_rental_databaseDataSet1();
            this.auditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.auditTableAdapter1 = new Car_Rental_App.car_rental_databaseDataSet1TableAdapters.auditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // id_lablel
            // 
            this.id_lablel.AutoSize = true;
            this.id_lablel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lablel.Location = new System.Drawing.Point(71, 232);
            this.id_lablel.Name = "id_lablel";
            this.id_lablel.Size = new System.Drawing.Size(51, 16);
            this.id_lablel.TabIndex = 1;
            this.id_lablel.Text = "id here";
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.AutoSize = true;
            this.fullnamelbl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnamelbl.Location = new System.Drawing.Point(50, 216);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(98, 16);
            this.fullnamelbl.TabIndex = 2;
            this.fullnamelbl.Text = "full name here";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 10);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks";
            // 
            // vehicle
            // 
            this.vehicle.Location = new System.Drawing.Point(209, 350);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(106, 42);
            this.vehicle.TabIndex = 5;
            this.vehicle.Text = "Vehicle";
            this.vehicle.UseVisualStyleBackColor = true;
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataMember = "audit";
            this.auditBindingSource.DataSource = this.car_rental_databaseDataSet;
            // 
            // car_rental_databaseDataSet
            // 
            this.car_rental_databaseDataSet.DataSetName = "car_rental_databaseDataSet";
            this.car_rental_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "sort by:";
            // 
            // dateascbtn
            // 
            this.dateascbtn.Location = new System.Drawing.Point(350, 226);
            this.dateascbtn.Name = "dateascbtn";
            this.dateascbtn.Size = new System.Drawing.Size(79, 29);
            this.dateascbtn.TabIndex = 11;
            this.dateascbtn.Text = "date (asc)";
            this.dateascbtn.UseVisualStyleBackColor = true;
            // 
            // datedescbtn
            // 
            this.datedescbtn.Location = new System.Drawing.Point(449, 226);
            this.datedescbtn.Name = "datedescbtn";
            this.datedescbtn.Size = new System.Drawing.Size(79, 29);
            this.datedescbtn.TabIndex = 12;
            this.datedescbtn.Text = "date (desc)";
            this.datedescbtn.UseVisualStyleBackColor = true;
            // 
            // customerbtn
            // 
            this.customerbtn.Location = new System.Drawing.Point(388, 350);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(106, 42);
            this.customerbtn.TabIndex = 13;
            this.customerbtn.Text = "Customer";
            this.customerbtn.UseVisualStyleBackColor = true;
            // 
            // auditTableAdapter
            // 
            this.auditTableAdapter.ClearBeforeFill = true;
            // 
            // little_car
            // 
            this.little_car.Image = ((System.Drawing.Image)(resources.GetObject("little_car.Image")));
            this.little_car.Location = new System.Drawing.Point(650, 417);
            this.little_car.Name = "little_car";
            this.little_car.Size = new System.Drawing.Size(67, 67);
            this.little_car.TabIndex = 14;
            this.little_car.TabStop = false;
            // 
            // auditBindingSource2
            // 
            this.auditBindingSource2.DataMember = "audit";
            this.auditBindingSource2.DataSource = this.car_rental_databaseDataSet1;
            // 
            // car_rental_databaseDataSet1
            // 
            this.car_rental_databaseDataSet1.DataSetName = "car_rental_databaseDataSet1";
            this.car_rental_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditBindingSource1
            // 
            this.auditBindingSource1.DataMember = "audit";
            this.auditBindingSource1.DataSource = this.car_rental_databaseDataSet;
            // 
            // auditTableAdapter1
            // 
            this.auditTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(719, 484);
            this.Controls.Add(this.little_car);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.datedescbtn);
            this.Controls.Add(this.dateascbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullnamelbl);
            this.Controls.Add(this.id_lablel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminForm1";
            this.Text = "AdminForm1";
            this.Load += new System.EventHandler(this.AdminForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.little_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id_lablel;
        private System.Windows.Forms.Label fullnamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dateascbtn;
        private System.Windows.Forms.Button datedescbtn;
        private System.Windows.Forms.Button customerbtn;
        private car_rental_databaseDataSet car_rental_databaseDataSet;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private car_rental_databaseDataSetTableAdapters.auditTableAdapter auditTableAdapter;
        private System.Windows.Forms.PictureBox little_car;
        private System.Windows.Forms.BindingSource auditBindingSource1;
        private car_rental_databaseDataSet1 car_rental_databaseDataSet1;
        private System.Windows.Forms.BindingSource auditBindingSource2;
        private car_rental_databaseDataSet1TableAdapters.auditTableAdapter auditTableAdapter1;
    }
}