namespace Minesweeper
{
    partial class Form1
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
            this.AutoStart = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.GridSizeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AutoStart
            // 
            this.AutoStart.Location = new System.Drawing.Point(822, 115);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(114, 23);
            this.AutoStart.TabIndex = 2;
            this.AutoStart.Text = "Generate";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.Click += new System.EventHandler(this.AutoStart_Click);
            // 
            // Grid
            // 
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(625, 624);
            this.Grid.TabIndex = 3;
            // 
            // GridSizeText
            // 
            this.GridSizeText.Location = new System.Drawing.Point(822, 54);
            this.GridSizeText.Name = "GridSizeText";
            this.GridSizeText.Size = new System.Drawing.Size(114, 20);
            this.GridSizeText.TabIndex = 4;
            this.GridSizeText.TextChanged += new System.EventHandler(this.GridSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Grid Size (MAX 100)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 764);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridSizeText);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.AutoStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AutoStart;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.TextBox GridSizeText;
        private System.Windows.Forms.Label label1;
    }
}

