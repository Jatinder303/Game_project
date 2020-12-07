
namespace Game_project
{
    partial class Instuction_Form
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
            this.lbl_ins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ins
            // 
            this.lbl_ins.AutoSize = true;
            this.lbl_ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ins.Location = new System.Drawing.Point(225, 55);
            this.lbl_ins.Name = "lbl_ins";
            this.lbl_ins.Size = new System.Drawing.Size(204, 24);
            this.lbl_ins.TabIndex = 0;
            this.lbl_ins.Text = "This is Instruction Form";
            // 
            // Instuction_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ins);
            this.Name = "Instuction_Form";
            this.Text = "Instuction_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ins;
    }
}