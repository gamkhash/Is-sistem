namespace Electronic_store
{
    partial class Form3
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
            this._The_IP_of_the_electronic_store_DataSet2 = new Electronic_store._The_IP_of_the_electronic_store_DataSet2();
            this.marcetingmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marceting_materialTableAdapter = new Electronic_store._The_IP_of_the_electronic_store_DataSet2TableAdapters.Marceting_materialTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcetingmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // _The_IP_of_the_electronic_store_DataSet2
            // 
            this._The_IP_of_the_electronic_store_DataSet2.DataSetName = "_The_IP_of_the_electronic_store_DataSet2";
            this._The_IP_of_the_electronic_store_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcetingmaterialBindingSource
            // 
            this.marcetingmaterialBindingSource.DataMember = "Marceting_material";
            this.marcetingmaterialBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet2;
            // 
            // marceting_materialTableAdapter
            // 
            this.marceting_materialTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView3.DataSource = this.marcetingmaterialBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(821, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_M_M";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_M_M";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type_of_marceting_materials";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type_of_marceting_materials";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "The_platform_used";
            this.dataGridViewTextBoxColumn3.HeaderText = "The_platform_used";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Profit_the_platform";
            this.dataGridViewTextBoxColumn4.HeaderText = "Profit_the_platform";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_o_a_c";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_o_a_c";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcetingmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource theIPoftheelectronicstoreDataSetBindingSource;
        private _The_IP_of_the_electronic_store_DataSet _The_IP_of_the_electronic_store_DataSet;
        private System.Windows.Forms.BindingSource ordersandcustomersBindingSource;
        private _The_IP_of_the_electronic_store_DataSetTableAdapters.Orders_and_customersTableAdapter orders_and_customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thepriseoftheprodyctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodycnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _The_IP_of_the_electronic_store_DataSet2 _The_IP_of_the_electronic_store_DataSet2;
        private System.Windows.Forms.BindingSource marcetingmaterialBindingSource;
        private _The_IP_of_the_electronic_store_DataSet2TableAdapters.Marceting_materialTableAdapter marceting_materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofmarcetingmaterialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theplatformusedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profittheplatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}