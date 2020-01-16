/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 01.01.2020
 * Время: 23:14
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Viri
{
	partial class FormViri
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.OpenFileDialog openFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn coNr;
		private System.Windows.Forms.DataGridViewTextBoxColumn coFilename;
		private System.Windows.Forms.DataGridViewTextBoxColumn coCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn coLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn coSumLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn coDimple;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViri));
			this.buttonOpen = new System.Windows.Forms.Button();
			this.labelError = new System.Windows.Forms.Label();
			this.grid = new System.Windows.Forms.DataGridView();
			this.openFiles = new System.Windows.Forms.OpenFileDialog();
			this.coNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coSumLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coDimple = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(12, 22);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(75, 42);
			this.buttonOpen.TabIndex = 0;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
			// 
			// labelError
			// 
			this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(129, 22);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(647, 42);
			this.labelError.TabIndex = 1;
			this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.coNr,
			this.coFilename,
			this.coCount,
			this.coLength,
			this.coSumLength,
			this.coDimple});
			this.grid.Location = new System.Drawing.Point(12, 83);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.grid.Size = new System.Drawing.Size(764, 408);
			this.grid.TabIndex = 2;
			// 
			// openFiles
			// 
			this.openFiles.FileName = "openFileDialog1";
			this.openFiles.Multiselect = true;
			// 
			// coNr
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.coNr.DefaultCellStyle = dataGridViewCellStyle1;
			this.coNr.HeaderText = "#";
			this.coNr.Name = "coNr";
			this.coNr.ReadOnly = true;
			this.coNr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// coFilename
			// 
			this.coFilename.HeaderText = "Filename";
			this.coFilename.Name = "coFilename";
			this.coFilename.ReadOnly = true;
			this.coFilename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// coCount
			// 
			this.coCount.HeaderText = "Count";
			this.coCount.Name = "coCount";
			this.coCount.ReadOnly = true;
			this.coCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// coLength
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.coLength.DefaultCellStyle = dataGridViewCellStyle2;
			this.coLength.HeaderText = "Length";
			this.coLength.Name = "coLength";
			this.coLength.ReadOnly = true;
			this.coLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// coSumLength
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.coSumLength.DefaultCellStyle = dataGridViewCellStyle3;
			this.coSumLength.HeaderText = "Total Length";
			this.coSumLength.Name = "coSumLength";
			this.coSumLength.ReadOnly = true;
			this.coSumLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// coDimple
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.coDimple.DefaultCellStyle = dataGridViewCellStyle4;
			this.coDimple.HeaderText = "Dimple";
			this.coDimple.Name = "coDimple";
			this.coDimple.ReadOnly = true;
			this.coDimple.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// FormViri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 503);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.buttonOpen);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 250);
			this.Name = "FormViri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIRI File Info";
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
