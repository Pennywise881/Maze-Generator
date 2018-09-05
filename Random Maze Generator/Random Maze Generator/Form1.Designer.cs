namespace Random_Maze_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.btn_genMaze = new System.Windows.Forms.Button();
            this.lbl_license = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo.Image")));
            this.lbl_logo.Location = new System.Drawing.Point(84, 84);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(135, 134);
            this.lbl_logo.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Silkscreen Expanded", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(25, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(262, 54);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Random Maze   Generator";
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(87, 276);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(132, 20);
            this.tb_width.TabIndex = 2;
            this.tb_width.Text = "10";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(87, 318);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(132, 20);
            this.tb_height.TabIndex = 3;
            this.tb_height.Text = "10";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(87, 257);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(59, 12);
            this.lbl_width.TabIndex = 4;
            this.lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(87, 303);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(67, 12);
            this.lbl_height.TabIndex = 5;
            this.lbl_height.Text = "Height:";
            // 
            // btn_genMaze
            // 
            this.btn_genMaze.Location = new System.Drawing.Point(87, 356);
            this.btn_genMaze.Name = "btn_genMaze";
            this.btn_genMaze.Size = new System.Drawing.Size(132, 23);
            this.btn_genMaze.TabIndex = 6;
            this.btn_genMaze.Text = "Generate Maze";
            this.btn_genMaze.UseVisualStyleBackColor = true;
            this.btn_genMaze.Click += new System.EventHandler(this.btn_genMaze_Click);
            // 
            // lbl_license
            // 
            this.lbl_license.AutoSize = true;
            this.lbl_license.Location = new System.Drawing.Point(75, 432);
            this.lbl_license.Name = "lbl_license";
            this.lbl_license.Size = new System.Drawing.Size(169, 13);
            this.lbl_license.TabIndex = 7;
            this.lbl_license.Text = "Random Maze Generator 2016 (C)";
            // 
            // btn_back
            // 
            this.btn_back.Enabled = false;
            this.btn_back.Location = new System.Drawing.Point(87, 386);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(309, 454);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_license);
            this.Controls.Add(this.btn_genMaze);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Random Maze Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button btn_genMaze;
        private System.Windows.Forms.Label lbl_license;
        private System.Windows.Forms.Button btn_back;
    }
}

