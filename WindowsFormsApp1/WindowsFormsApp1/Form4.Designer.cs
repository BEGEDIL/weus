namespace WindowsFormsApp1
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlitelnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachaloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lonechDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet16 = new WindowsFormsApp1.DataSet16();
            this.realtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new WindowsFormsApp1.DataSet5();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet18 = new WindowsFormsApp1.DataSet18();
            this.sdelkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new WindowsFormsApp1.DataSet6();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idrabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet17 = new WindowsFormsApp1.DataSet17();
            this.nedvijimostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new WindowsFormsApp1.DataSet7();
            this.realtorTableAdapter = new WindowsFormsApp1.DataSet5TableAdapters.RealtorTableAdapter();
            this.sdelkaTableAdapter = new WindowsFormsApp1.DataSet6TableAdapters.SdelkaTableAdapter();
            this.nedvijimostTableAdapter = new WindowsFormsApp1.DataSet7TableAdapters.nedvijimostTableAdapter();
            this._111TableAdapter = new WindowsFormsApp1.DataSet16TableAdapters._111TableAdapter();
            this._112TableAdapter = new WindowsFormsApp1.DataSet17TableAdapters._112TableAdapter();
            this.tableeTableAdapter = new WindowsFormsApp1.DataSet18TableAdapters.tableeTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdelkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvijimostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.filmDataGridViewTextBoxColumn,
            this.dlitelnostDataGridViewTextBoxColumn,
            this.nachaloDataGridViewTextBoxColumn,
            this.lonechDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(70, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // filmDataGridViewTextBoxColumn
            // 
            this.filmDataGridViewTextBoxColumn.DataPropertyName = "film";
            this.filmDataGridViewTextBoxColumn.HeaderText = "film";
            this.filmDataGridViewTextBoxColumn.Name = "filmDataGridViewTextBoxColumn";
            // 
            // dlitelnostDataGridViewTextBoxColumn
            // 
            this.dlitelnostDataGridViewTextBoxColumn.DataPropertyName = "dlitelnost";
            this.dlitelnostDataGridViewTextBoxColumn.HeaderText = "dlitelnost";
            this.dlitelnostDataGridViewTextBoxColumn.Name = "dlitelnostDataGridViewTextBoxColumn";
            // 
            // nachaloDataGridViewTextBoxColumn
            // 
            this.nachaloDataGridViewTextBoxColumn.DataPropertyName = "nachalo";
            this.nachaloDataGridViewTextBoxColumn.HeaderText = "nachalo";
            this.nachaloDataGridViewTextBoxColumn.Name = "nachaloDataGridViewTextBoxColumn";
            // 
            // lonechDataGridViewTextBoxColumn
            // 
            this.lonechDataGridViewTextBoxColumn.DataPropertyName = "lonech";
            this.lonechDataGridViewTextBoxColumn.HeaderText = "lonech";
            this.lonechDataGridViewTextBoxColumn.Name = "lonechDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "111";
            this.bindingSource1.DataSource = this.dataSet16;
            // 
            // dataSet16
            // 
            this.dataSet16.DataSetName = "DataSet16";
            this.dataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorBindingSource
            // 
            this.realtorBindingSource.DataMember = "Realtor";
            this.realtorBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(801, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 21;
            this.button4.Text = "фильмы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "пользователи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.button2.Location = new System.Drawing.Point(801, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "работники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.famDataGridViewTextBoxColumn,
            this.imiaDataGridViewTextBoxColumn,
            this.otchDataGridViewTextBoxColumn,
            this.teleDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(70, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(650, 287);
            this.dataGridView2.TabIndex = 23;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "fam";
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            // 
            // imiaDataGridViewTextBoxColumn
            // 
            this.imiaDataGridViewTextBoxColumn.DataPropertyName = "imia";
            this.imiaDataGridViewTextBoxColumn.HeaderText = "imia";
            this.imiaDataGridViewTextBoxColumn.Name = "imiaDataGridViewTextBoxColumn";
            // 
            // otchDataGridViewTextBoxColumn
            // 
            this.otchDataGridViewTextBoxColumn.DataPropertyName = "otch";
            this.otchDataGridViewTextBoxColumn.HeaderText = "otch";
            this.otchDataGridViewTextBoxColumn.Name = "otchDataGridViewTextBoxColumn";
            // 
            // teleDataGridViewTextBoxColumn
            // 
            this.teleDataGridViewTextBoxColumn.DataPropertyName = "tele";
            this.teleDataGridViewTextBoxColumn.HeaderText = "tele";
            this.teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tablee";
            this.bindingSource3.DataSource = this.dataSet18;
            // 
            // dataSet18
            // 
            this.dataSet18.DataSetName = "DataSet18";
            this.dataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sdelkaBindingSource
            // 
            this.sdelkaBindingSource.DataMember = "Sdelka";
            this.sdelkaBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrabDataGridViewTextBoxColumn,
            this.fDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(70, 87);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 287);
            this.dataGridView3.TabIndex = 24;
            // 
            // idrabDataGridViewTextBoxColumn
            // 
            this.idrabDataGridViewTextBoxColumn.DataPropertyName = "id_rab";
            this.idrabDataGridViewTextBoxColumn.HeaderText = "id_rab";
            this.idrabDataGridViewTextBoxColumn.Name = "idrabDataGridViewTextBoxColumn";
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "I";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "112";
            this.bindingSource2.DataSource = this.dataSet17;
            // 
            // dataSet17
            // 
            this.dataSet17.DataSetName = "DataSet17";
            this.dataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nedvijimostBindingSource
            // 
            this.nedvijimostBindingSource.DataMember = "nedvijimost";
            this.nedvijimostBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorTableAdapter
            // 
            this.realtorTableAdapter.ClearBeforeFill = true;
            // 
            // sdelkaTableAdapter
            // 
            this.sdelkaTableAdapter.ClearBeforeFill = true;
            // 
            // nedvijimostTableAdapter
            // 
            this.nedvijimostTableAdapter.ClearBeforeFill = true;
            // 
            // _111TableAdapter
            // 
            this._111TableAdapter.ClearBeforeFill = true;
            // 
            // _112TableAdapter
            // 
            this._112TableAdapter.ClearBeforeFill = true;
            // 
            // tableeTableAdapter
            // 
            this.tableeTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 25;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 724);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdelkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvijimostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource realtorBindingSource;
        private DataSet5TableAdapters.RealtorTableAdapter realtorTableAdapter;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource sdelkaBindingSource;
        private DataSet6TableAdapters.SdelkaTableAdapter sdelkaTableAdapter;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource nedvijimostBindingSource;
        private DataSet7TableAdapters.nedvijimostTableAdapter nedvijimostTableAdapter;
        private System.Windows.Forms.BindingSource tableeBindingSource;
        private DataSet16 dataSet16;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet16TableAdapters._111TableAdapter _111TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlitelnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lonechDataGridViewTextBoxColumn;
        private DataSet17 dataSet17;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DataSet17TableAdapters._112TableAdapter _112TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private DataSet18 dataSet18;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DataSet18TableAdapters.tableeTableAdapter tableeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}