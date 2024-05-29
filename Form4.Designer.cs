namespace Electronic_store
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listofthebetatestersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._The_IP_of_the_electronic_store_DataSet1 = new Electronic_store._The_IP_of_the_electronic_store_DataSet1();
            this.list_of_the_betatestersTableAdapter = new Electronic_store._The_IP_of_the_electronic_store_DataSet1TableAdapters.List_of_the_betatestersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.idlBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnamebetatestersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarybetatestersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thetesterspartofthesystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofthebetatestersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlBDataGridViewTextBoxColumn,
            this.fullnamebetatestersDataGridViewTextBoxColumn,
            this.salarybetatestersDataGridViewTextBoxColumn,
            this.thetesterspartofthesystemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listofthebetatestersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listofthebetatestersBindingSource
            // 
            this.listofthebetatestersBindingSource.DataMember = "List_of_the_betatesters";
            this.listofthebetatestersBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet1;
            // 
            // _The_IP_of_the_electronic_store_DataSet1
            // 
            this._The_IP_of_the_electronic_store_DataSet1.DataSetName = "_The_IP_of_the_electronic_store_DataSet1";
            this._The_IP_of_the_electronic_store_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_of_the_betatestersTableAdapter
            // 
            this.list_of_the_betatestersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // idlBDataGridViewTextBoxColumn
            // 
            this.idlBDataGridViewTextBoxColumn.DataPropertyName = "id_l_B";
            this.idlBDataGridViewTextBoxColumn.HeaderText = "id_l_B";
            this.idlBDataGridViewTextBoxColumn.Name = "idlBDataGridViewTextBoxColumn";
            this.idlBDataGridViewTextBoxColumn.Width = 160;
            // 
            // fullnamebetatestersDataGridViewTextBoxColumn
            // 
            this.fullnamebetatestersDataGridViewTextBoxColumn.DataPropertyName = "full_name_betatesters";
            this.fullnamebetatestersDataGridViewTextBoxColumn.HeaderText = "full_name_betatesters";
            this.fullnamebetatestersDataGridViewTextBoxColumn.Name = "fullnamebetatestersDataGridViewTextBoxColumn";
            this.fullnamebetatestersDataGridViewTextBoxColumn.Width = 170;
            // 
            // salarybetatestersDataGridViewTextBoxColumn
            // 
            this.salarybetatestersDataGridViewTextBoxColumn.DataPropertyName = "Salary_betatesters";
            this.salarybetatestersDataGridViewTextBoxColumn.HeaderText = "Salary_betatesters";
            this.salarybetatestersDataGridViewTextBoxColumn.Name = "salarybetatestersDataGridViewTextBoxColumn";
            this.salarybetatestersDataGridViewTextBoxColumn.Width = 170;
            // 
            // thetesterspartofthesystemDataGridViewTextBoxColumn
            // 
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.DataPropertyName = "The_testers_part_of_the_system";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.HeaderText = "The_testers_part_of_the_system";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.Name = "thetesterspartofthesystemDataGridViewTextBoxColumn";
            this.thetesterspartofthesystemDataGridViewTextBoxColumn.Width = 220;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofthebetatestersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _The_IP_of_the_electronic_store_DataSet1 _The_IP_of_the_electronic_store_DataSet1;
        private System.Windows.Forms.BindingSource listofthebetatestersBindingSource;
        private _The_IP_of_the_electronic_store_DataSet1TableAdapters.List_of_the_betatestersTableAdapter list_of_the_betatestersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnamebetatestersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarybetatestersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thetesterspartofthesystemDataGridViewTextBoxColumn;
    }
}