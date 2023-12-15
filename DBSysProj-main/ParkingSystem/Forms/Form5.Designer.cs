namespace ParkingSystem.Forms
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDec);
            this.panel1.Controls.Add(this.grid2);
            this.panel1.Controls.Add(this.btnApp);
            this.panel1.Location = new System.Drawing.Point(31, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 487);
            this.panel1.TabIndex = 21;
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(387, 426);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(90, 29);
            this.btnDec.TabIndex = 16;
            this.btnDec.Text = "Decline";
            this.btnDec.UseVisualStyleBackColor = true;
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(249, 426);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(90, 29);
            this.btnApp.TabIndex = 15;
            this.btnApp.Text = "Approve";
            this.btnApp.UseVisualStyleBackColor = true;
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(3, 3);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidth = 62;
            this.grid2.RowTemplate.Height = 28;
            this.grid2.Size = new System.Drawing.Size(734, 348);
            this.grid2.TabIndex = 20;
            this.grid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid2_CellClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.DataGridView grid2;
    }
}