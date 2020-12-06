
namespace Game_project
{
    partial class Game_Form
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Image_showBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_showBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.DimGray;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Load.Location = new System.Drawing.Point(66, 376);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(122, 47);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.DimGray;
            this.btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Spin.Location = new System.Drawing.Point(238, 376);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(122, 47);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.DimGray;
            this.btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Shoot.Location = new System.Drawing.Point(406, 376);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(122, 47);
            this.btn_Shoot.TabIndex = 2;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.BackColor = System.Drawing.Color.DimGray;
            this.btn_ShootAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShootAway.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ShootAway.Location = new System.Drawing.Point(573, 376);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(122, 47);
            this.btn_ShootAway.TabIndex = 3;
            this.btn_ShootAway.Text = "Shoot_Away";
            this.btn_ShootAway.UseVisualStyleBackColor = false;
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.DimGray;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_PlayAgain.Location = new System.Drawing.Point(649, 43);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(122, 47);
            this.btn_PlayAgain.TabIndex = 4;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Exit.Location = new System.Drawing.Point(649, 129);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 47);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Image_showBox
            // 
            this.Image_showBox.Location = new System.Drawing.Point(115, 43);
            this.Image_showBox.Name = "Image_showBox";
            this.Image_showBox.Size = new System.Drawing.Size(453, 277);
            this.Image_showBox.TabIndex = 6;
            this.Image_showBox.TabStop = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Image_showBox);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Load);
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.Image_showBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_ShootAway;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox Image_showBox;
    }
}

