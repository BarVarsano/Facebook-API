namespace LikedPages
{
    public partial class LikedPagesController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.likedPagesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // likedPagesDataGridView
            // 
            this.likedPagesDataGridView.AllowUserToAddRows = false;
            this.likedPagesDataGridView.AllowUserToDeleteRows = false;
            this.likedPagesDataGridView.AllowUserToResizeColumns = false;
            this.likedPagesDataGridView.AllowUserToResizeRows = false;
            this.likedPagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.likedPagesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.likedPagesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.likedPagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.likedPagesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.likedPagesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.likedPagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.likedPagesDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.likedPagesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.likedPagesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.likedPagesDataGridView.Location = new System.Drawing.Point(3, 0);
            this.likedPagesDataGridView.MultiSelect = false;
            this.likedPagesDataGridView.Name = "likedPagesDataGridView";
            this.likedPagesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.likedPagesDataGridView.RowHeadersVisible = false;
            this.likedPagesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.likedPagesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.likedPagesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.likedPagesDataGridView.ShowCellErrors = false;
            this.likedPagesDataGridView.ShowCellToolTips = false;
            this.likedPagesDataGridView.ShowEditingIcon = false;
            this.likedPagesDataGridView.ShowRowErrors = false;
            this.likedPagesDataGridView.Size = new System.Drawing.Size(253, 386);
            this.likedPagesDataGridView.TabIndex = 0;
            this.likedPagesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.likedPagesDataGridView_DataError);
            // 
            // likedPagesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.likedPagesDataGridView);
            this.Name = "likedPagesViewer";
            this.Size = new System.Drawing.Size(253, 386);
            ((System.ComponentModel.ISupportInitialize)(this.likedPagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView likedPagesDataGridView;
    }
}
