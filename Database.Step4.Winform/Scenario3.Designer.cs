namespace Database.Step4.Winform
{
    partial class Scenario3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chinookDataSet = new Database.Step4.Winform.chinookDataSet();
            this.chinookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chinookDataSet1 = new Database.Step4.Winform.chinookDataSet1();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackTableAdapter = new Database.Step4.Winform.chinookDataSet1TableAdapters.TrackTableAdapter();
            this.trackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millisecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriceSum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작곡가를 입력시 해당 작곡가가 포함된 Track 리스트 출력과 발매된 총 앨범 가격의 합을 구하시오";
            // 
            // PriceSum
            // 
            this.PriceSum.Location = new System.Drawing.Point(747, 60);
            this.PriceSum.Name = "PriceSum";
            this.PriceSum.Size = new System.Drawing.Size(206, 25);
            this.PriceSum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "작곡가가 발매한 곡들의 총매출";
            // 
            // listView
            // 
            this.listView.AutoGenerateColumns = false;
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.albumIdDataGridViewTextBoxColumn,
            this.mediaTypeIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.composerDataGridViewTextBoxColumn,
            this.millisecondsDataGridViewTextBoxColumn,
            this.bytesDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.listView.DataSource = this.trackBindingSource;
            this.listView.Location = new System.Drawing.Point(25, 107);
            this.listView.Name = "listView";
            this.listView.RowTemplate.Height = 27;
            this.listView.Size = new System.Drawing.Size(928, 310);
            this.listView.TabIndex = 3;
            this.listView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListView_CellContentClick);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(388, 59);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "입력";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(175, 58);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(207, 25);
            this.txtKeyword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "작곡가를 입력하세요";
            // 
            // chinookDataSet
            // 
            this.chinookDataSet.DataSetName = "chinookDataSet";
            this.chinookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinookDataSetBindingSource
            // 
            this.chinookDataSetBindingSource.DataSource = this.chinookDataSet;
            this.chinookDataSetBindingSource.Position = 0;
            // 
            // chinookDataSet1
            // 
            this.chinookDataSet1.DataSetName = "chinookDataSet1";
            this.chinookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "Track";
            this.trackBindingSource.DataSource = this.chinookDataSet1;
            // 
            // trackTableAdapter
            // 
            this.trackTableAdapter.ClearBeforeFill = true;
            // 
            // trackIdDataGridViewTextBoxColumn
            // 
            this.trackIdDataGridViewTextBoxColumn.DataPropertyName = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.HeaderText = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.Name = "trackIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // mediaTypeIdDataGridViewTextBoxColumn
            // 
            this.mediaTypeIdDataGridViewTextBoxColumn.DataPropertyName = "MediaTypeId";
            this.mediaTypeIdDataGridViewTextBoxColumn.HeaderText = "MediaTypeId";
            this.mediaTypeIdDataGridViewTextBoxColumn.Name = "mediaTypeIdDataGridViewTextBoxColumn";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // composerDataGridViewTextBoxColumn
            // 
            this.composerDataGridViewTextBoxColumn.DataPropertyName = "Composer";
            this.composerDataGridViewTextBoxColumn.HeaderText = "Composer";
            this.composerDataGridViewTextBoxColumn.Name = "composerDataGridViewTextBoxColumn";
            // 
            // millisecondsDataGridViewTextBoxColumn
            // 
            this.millisecondsDataGridViewTextBoxColumn.DataPropertyName = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.HeaderText = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.Name = "millisecondsDataGridViewTextBoxColumn";
            // 
            // bytesDataGridViewTextBoxColumn
            // 
            this.bytesDataGridViewTextBoxColumn.DataPropertyName = "Bytes";
            this.bytesDataGridViewTextBoxColumn.HeaderText = "Bytes";
            this.bytesDataGridViewTextBoxColumn.Name = "bytesDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // Scenario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Scenario3";
            this.Text = "Scenario3";
            this.Load += new System.EventHandler(this.Scenario3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.TextBox PriceSum;
        private System.Windows.Forms.Label label2;
        private chinookDataSet chinookDataSet;
        private System.Windows.Forms.BindingSource chinookDataSetBindingSource;
        private chinookDataSet1 chinookDataSet1;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private chinookDataSet1TableAdapters.TrackTableAdapter trackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millisecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bytesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}