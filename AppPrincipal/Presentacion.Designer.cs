
namespace AppPrincipal
{
    partial class Presentacion
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
            this.app1 = new APP.App();
            this.SuspendLayout();
            // 
            // app1
            // 
            this.app1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.app1.Location = new System.Drawing.Point(160, 56);
            this.app1.Name = "app1";
            this.app1.Size = new System.Drawing.Size(683, 395);
            this.app1.TabIndex = 2;
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1003, 507);
            this.Controls.Add(this.app1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.ResumeLayout(false);

        }

        #endregion

        private APP.App app1;
    }
}