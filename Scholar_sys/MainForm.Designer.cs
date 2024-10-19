/*
 * Created by SharpDevelop.
 * User: angel
 * Date: 17/10/2024
 * Time: 07:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Scholar_sys
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtbuser;
		private System.Windows.Forms.TextBox txtbpasswd;
		private System.Windows.Forms.Label lbluser;
		private System.Windows.Forms.Label lblpasswd;
		private System.Windows.Forms.Button btnclean;
		private System.Windows.Forms.Button btnenter;
		private System.Windows.Forms.Button btncolor;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtbuser = new System.Windows.Forms.TextBox();
			this.txtbpasswd = new System.Windows.Forms.TextBox();
			this.lbluser = new System.Windows.Forms.Label();
			this.lblpasswd = new System.Windows.Forms.Label();
			this.btnclean = new System.Windows.Forms.Button();
			this.btnenter = new System.Windows.Forms.Button();
			this.btncolor = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtbuser
			// 
			this.txtbuser.BackColor = System.Drawing.Color.White;
			this.txtbuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbuser.Location = new System.Drawing.Point(195, 120);
			this.txtbuser.MaximumSize = new System.Drawing.Size(200, 35);
			this.txtbuser.MinimumSize = new System.Drawing.Size(200, 35);
			this.txtbuser.Name = "txtbuser";
			this.txtbuser.Size = new System.Drawing.Size(200, 26);
			this.txtbuser.TabIndex = 1;
			// 
			// txtbpasswd
			// 
			this.txtbpasswd.BackColor = System.Drawing.Color.White;
			this.txtbpasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbpasswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtbpasswd.Location = new System.Drawing.Point(195, 200);
			this.txtbpasswd.MaximumSize = new System.Drawing.Size(200, 35);
			this.txtbpasswd.MinimumSize = new System.Drawing.Size(200, 35);
			this.txtbpasswd.Name = "txtbpasswd";
			this.txtbpasswd.PasswordChar = '*';
			this.txtbpasswd.Size = new System.Drawing.Size(200, 26);
			this.txtbpasswd.TabIndex = 2;
			// 
			// lbluser
			// 
			this.lbluser.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lbluser.Location = new System.Drawing.Point(40, 120);
			this.lbluser.MaximumSize = new System.Drawing.Size(150, 35);
			this.lbluser.MinimumSize = new System.Drawing.Size(150, 35);
			this.lbluser.Name = "lbluser";
			this.lbluser.Size = new System.Drawing.Size(150, 35);
			this.lbluser.TabIndex = 3;
			this.lbluser.Text = "Usuario:";
			// 
			// lblpasswd
			// 
			this.lblpasswd.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpasswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lblpasswd.Location = new System.Drawing.Point(40, 200);
			this.lblpasswd.MaximumSize = new System.Drawing.Size(150, 35);
			this.lblpasswd.MinimumSize = new System.Drawing.Size(150, 35);
			this.lblpasswd.Name = "lblpasswd";
			this.lblpasswd.Size = new System.Drawing.Size(150, 35);
			this.lblpasswd.TabIndex = 4;
			this.lblpasswd.Text = "Contraseña:";
			// 
			// btnclean
			// 
			this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnclean.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnclean.Location = new System.Drawing.Point(83, 300);
			this.btnclean.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnclean.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnclean.Name = "btnclean";
			this.btnclean.Size = new System.Drawing.Size(125, 40);
			this.btnclean.TabIndex = 5;
			this.btnclean.Text = "Limpiar";
			this.btnclean.UseVisualStyleBackColor = false;
			this.btnclean.Click += new System.EventHandler(this.BtncleanClick);
			// 
			// btnenter
			// 
			this.btnenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnenter.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnenter.Location = new System.Drawing.Point(250, 300);
			this.btnenter.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnenter.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnenter.Name = "btnenter";
			this.btnenter.Size = new System.Drawing.Size(125, 40);
			this.btnenter.TabIndex = 6;
			this.btnenter.Text = "Entrar";
			this.btnenter.UseVisualStyleBackColor = false;
			this.btnenter.Click += new System.EventHandler(this.BtnenterClick);
			// 
			// btncolor
			// 
			this.btncolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btncolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncolor.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btncolor.Location = new System.Drawing.Point(12, 392);
			this.btncolor.MaximumSize = new System.Drawing.Size(125, 40);
			this.btncolor.MinimumSize = new System.Drawing.Size(125, 40);
			this.btncolor.Name = "btncolor";
			this.btncolor.Size = new System.Drawing.Size(125, 40);
			this.btncolor.TabIndex = 7;
			this.btncolor.Text = "Color";
			this.btncolor.UseVisualStyleBackColor = false;
			this.btncolor.Click += new System.EventHandler(this.BtncolorClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 130);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ClientSize = new System.Drawing.Size(478, 444);
			this.Controls.Add(this.btncolor);
			this.Controls.Add(this.btnenter);
			this.Controls.Add(this.btnclean);
			this.Controls.Add(this.lblpasswd);
			this.Controls.Add(this.lbluser);
			this.Controls.Add(this.txtbpasswd);
			this.Controls.Add(this.txtbuser);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimumSize = new System.Drawing.Size(500, 500);
			this.Name = "MainForm";
			this.Text = " ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
