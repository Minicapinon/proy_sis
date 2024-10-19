/*
 * Created by SharpDevelop.
 * User: angel
 * Date: 17/10/2024
 * Time: 08:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Scholar_sys
{
	partial class Alumnform
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btncolor;
		private System.Windows.Forms.TextBox txtalum;
		private System.Windows.Forms.TextBox txtmat;
		private System.Windows.Forms.Label lblaluser;
		private System.Windows.Forms.Label lblalumat;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnaddalum;
		private System.Windows.Forms.Button btnlist;
		private System.Windows.Forms.Button btnmater;
		private System.Windows.Forms.Button btnlogout;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnform));
			this.btncolor = new System.Windows.Forms.Button();
			this.txtalum = new System.Windows.Forms.TextBox();
			this.txtmat = new System.Windows.Forms.TextBox();
			this.lblaluser = new System.Windows.Forms.Label();
			this.lblalumat = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnaddalum = new System.Windows.Forms.Button();
			this.btnlist = new System.Windows.Forms.Button();
			this.btnmater = new System.Windows.Forms.Button();
			this.btnlogout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btncolor
			// 
			this.btncolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btncolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncolor.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btncolor.Location = new System.Drawing.Point(15, 490);
			this.btncolor.MaximumSize = new System.Drawing.Size(125, 40);
			this.btncolor.MinimumSize = new System.Drawing.Size(125, 40);
			this.btncolor.Name = "btncolor";
			this.btncolor.Size = new System.Drawing.Size(125, 40);
			this.btncolor.TabIndex = 8;
			this.btncolor.Text = "Color";
			this.btncolor.UseVisualStyleBackColor = false;
			this.btncolor.Click += new System.EventHandler(this.BtncolorClick);
			// 
			// txtalum
			// 
			this.txtalum.BackColor = System.Drawing.Color.White;
			this.txtalum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtalum.Location = new System.Drawing.Point(60, 230);
			this.txtalum.MaximumSize = new System.Drawing.Size(200, 40);
			this.txtalum.MinimumSize = new System.Drawing.Size(200, 40);
			this.txtalum.Name = "txtalum";
			this.txtalum.Size = new System.Drawing.Size(200, 26);
			this.txtalum.TabIndex = 10;
			// 
			// txtmat
			// 
			this.txtmat.BackColor = System.Drawing.Color.White;
			this.txtmat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtmat.Location = new System.Drawing.Point(280, 230);
			this.txtmat.MaximumSize = new System.Drawing.Size(200, 40);
			this.txtmat.MaxLength = 8;
			this.txtmat.MinimumSize = new System.Drawing.Size(200, 40);
			this.txtmat.Name = "txtmat";
			this.txtmat.Size = new System.Drawing.Size(200, 26);
			this.txtmat.TabIndex = 11;
			// 
			// lblaluser
			// 
			this.lblaluser.BackColor = System.Drawing.Color.Transparent;
			this.lblaluser.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblaluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lblaluser.Location = new System.Drawing.Point(60, 200);
			this.lblaluser.MaximumSize = new System.Drawing.Size(200, 30);
			this.lblaluser.MinimumSize = new System.Drawing.Size(200, 30);
			this.lblaluser.Name = "lblaluser";
			this.lblaluser.Size = new System.Drawing.Size(200, 30);
			this.lblaluser.TabIndex = 12;
			this.lblaluser.Text = "Alumno:";
			this.lblaluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblalumat
			// 
			this.lblalumat.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblalumat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lblalumat.Location = new System.Drawing.Point(280, 200);
			this.lblalumat.MaximumSize = new System.Drawing.Size(200, 30);
			this.lblalumat.MinimumSize = new System.Drawing.Size(200, 30);
			this.lblalumat.Name = "lblalumat";
			this.lblalumat.Size = new System.Drawing.Size(200, 30);
			this.lblalumat.TabIndex = 13;
			this.lblalumat.Text = "Matricula:";
			this.lblalumat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 130);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// btnaddalum
			// 
			this.btnaddalum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnaddalum.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnaddalum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnaddalum.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnaddalum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnaddalum.Location = new System.Drawing.Point(530, 230);
			this.btnaddalum.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnaddalum.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnaddalum.Name = "btnaddalum";
			this.btnaddalum.Size = new System.Drawing.Size(125, 40);
			this.btnaddalum.TabIndex = 15;
			this.btnaddalum.Text = "Añadir";
			this.btnaddalum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnaddalum.UseVisualStyleBackColor = false;
			this.btnaddalum.Click += new System.EventHandler(this.BtnaddalumClick);
			// 
			// btnlist
			// 
			this.btnlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlist.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnlist.Location = new System.Drawing.Point(280, 490);
			this.btnlist.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnlist.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnlist.Name = "btnlist";
			this.btnlist.Size = new System.Drawing.Size(125, 40);
			this.btnlist.TabIndex = 16;
			this.btnlist.Text = "Listar";
			this.btnlist.UseVisualStyleBackColor = false;
			this.btnlist.Click += new System.EventHandler(this.BtnlistClick);
			// 
			// btnmater
			// 
			this.btnmater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnmater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnmater.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnmater.Location = new System.Drawing.Point(540, 490);
			this.btnmater.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnmater.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnmater.Name = "btnmater";
			this.btnmater.Size = new System.Drawing.Size(125, 40);
			this.btnmater.TabIndex = 17;
			this.btnmater.Text = "Materias";
			this.btnmater.UseVisualStyleBackColor = false;
			this.btnmater.Click += new System.EventHandler(this.BtnmaterClick);
			// 
			// btnlogout
			// 
			this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlogout.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnlogout.Location = new System.Drawing.Point(540, 12);
			this.btnlogout.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnlogout.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.Size = new System.Drawing.Size(125, 40);
			this.btnlogout.TabIndex = 18;
			this.btnlogout.Text = "Salir";
			this.btnlogout.UseVisualStyleBackColor = false;
			this.btnlogout.Click += new System.EventHandler(this.BtnlogoutClick);
			// 
			// Alumnform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ClientSize = new System.Drawing.Size(678, 544);
			this.Controls.Add(this.btnlogout);
			this.Controls.Add(this.btnmater);
			this.Controls.Add(this.btnlist);
			this.Controls.Add(this.btnaddalum);
			this.Controls.Add(this.lblalumat);
			this.Controls.Add(this.lblaluser);
			this.Controls.Add(this.txtmat);
			this.Controls.Add(this.txtalum);
			this.Controls.Add(this.btncolor);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(700, 600);
			this.MinimumSize = new System.Drawing.Size(700, 600);
			this.Name = "Alumnform";
			this.Text = "Alumnform";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
