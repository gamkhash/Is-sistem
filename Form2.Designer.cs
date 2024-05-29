namespace Electronic_store
{
    partial class Form2
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
            this.idOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thepriseoftheprodyctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodycnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersandcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._The_IP_of_the_electronic_store_DataSet = new Electronic_store._The_IP_of_the_electronic_store_DataSet();
            this.orders_and_customersTableAdapter = new Electronic_store._The_IP_of_the_electronic_store_DataSetTableAdapters.Orders_and_customersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersandcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdersDataGridViewTextBoxColumn,
            this.clientsfullnameDataGridViewTextBoxColumn,
            this.paymentmethodDataGridViewTextBoxColumn,
            this.thepriseoftheprodyctDataGridViewTextBoxColumn,
            this.prodycnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersandcustomersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // idOrdersDataGridViewTextBoxColumn
            // 
            this.idOrdersDataGridViewTextBoxColumn.DataPropertyName = "id_Orders";
            this.idOrdersDataGridViewTextBoxColumn.HeaderText = "id_Orders";
            this.idOrdersDataGridViewTextBoxColumn.Name = "idOrdersDataGridViewTextBoxColumn";
            this.idOrdersDataGridViewTextBoxColumn.Width = 90;
            // 
            // clientsfullnameDataGridViewTextBoxColumn
            // 
            this.clientsfullnameDataGridViewTextBoxColumn.DataPropertyName = "Clients_full_name";
            this.clientsfullnameDataGridViewTextBoxColumn.HeaderText = "Clients_full_name";
            this.clientsfullnameDataGridViewTextBoxColumn.Name = "clientsfullnameDataGridViewTextBoxColumn";
            this.clientsfullnameDataGridViewTextBoxColumn.Width = 166;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            this.paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "Payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.HeaderText = "Payment_method";
            this.paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            this.paymentmethodDataGridViewTextBoxColumn.Width = 166;
            // 
            // thepriseoftheprodyctDataGridViewTextBoxColumn
            // 
            this.thepriseoftheprodyctDataGridViewTextBoxColumn.DataPropertyName = "The_prise_of_the_prodyct";
            this.thepriseoftheprodyctDataGridViewTextBoxColumn.HeaderText = "The_prise_of_the_prodyct";
            this.thepriseoftheprodyctDataGridViewTextBoxColumn.Name = "thepriseoftheprodyctDataGridViewTextBoxColumn";
            this.thepriseoftheprodyctDataGridViewTextBoxColumn.Width = 166;
            // 
            // prodycnameDataGridViewTextBoxColumn
            // 
            this.prodycnameDataGridViewTextBoxColumn.DataPropertyName = "Prodyc_name";
            this.prodycnameDataGridViewTextBoxColumn.HeaderText = "Prodyc_name";
            this.prodycnameDataGridViewTextBoxColumn.Name = "prodycnameDataGridViewTextBoxColumn";
            this.prodycnameDataGridViewTextBoxColumn.Width = 166;
            // 
            // ordersandcustomersBindingSource
            // 
            this.ordersandcustomersBindingSource.DataMember = "Orders_and_customers";
            this.ordersandcustomersBindingSource.DataSource = this._The_IP_of_the_electronic_store_DataSet;
            // 
            // _The_IP_of_the_electronic_store_DataSet
            // 
            this._The_IP_of_the_electronic_store_DataSet.DataSetName = "_The_IP_of_the_electronic_store_DataSet";
            this._The_IP_of_the_electronic_store_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders_and_customersTableAdapter
            // 
            this.orders_and_customersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersandcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._The_IP_of_the_electronic_store_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _The_IP_of_the_electronic_store_DataSet _The_IP_of_the_electronic_store_DataSet;
        private System.Windows.Forms.BindingSource ordersandcustomersBindingSource;
        private _The_IP_of_the_electronic_store_DataSetTableAdapters.Orders_and_customersTableAdapter orders_and_customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thepriseoftheprodyctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodycnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}