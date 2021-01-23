
namespace AppPrincipal
{
    partial class Ventas
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
            this.button1 = new System.Windows.Forms.Button();
            this.empresaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet5 = new AppPrincipal.empresaDataSet5();
            this.empresaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet = new AppPrincipal.empresaDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empresaDataSet5BindingSource
            // 
            this.empresaDataSet5BindingSource.DataSource = this.empresaDataSet5;
            this.empresaDataSet5BindingSource.Position = 0;
            // 
            // empresaDataSet5
            // 
            this.empresaDataSet5.DataSetName = "empresaDataSet5";
            this.empresaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaDataSetBindingSource
            // 
            this.empresaDataSetBindingSource.DataSource = this.empresaDataSet;
            this.empresaDataSetBindingSource.Position = 0;
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "empresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(624, 344);
            this.dataGridView1.TabIndex = 7;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource empresaDataSetBindingSource;
        private empresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource empresaDataSet5BindingSource;
        private empresaDataSet5 empresaDataSet5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}