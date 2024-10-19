/*
 * Created by SharpDevelop.
 * User: angel
 * Date: 17/10/2024
 * Time: 08:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Scholar_sys
{
	partial class MateriasForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnlist;
		private System.Windows.Forms.Button btnaddalum;
		private System.Windows.Forms.Label lblmatgru;
		private System.Windows.Forms.Label lblmat;
		private System.Windows.Forms.TextBox txtmatgru;
		private System.Windows.Forms.TextBox txtmat;
		private System.Windows.Forms.Button btncolor;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbldisplay;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasForm));
			this.btnlist = new System.Windows.Forms.Button();
			this.btnaddalum = new System.Windows.Forms.Button();
			this.lblmatgru = new System.Windows.Forms.Label();
			this.lblmat = new System.Windows.Forms.Label();
			this.txtmatgru = new System.Windows.Forms.TextBox();
			this.txtmat = new System.Windows.Forms.TextBox();
			this.btncolor = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbldisplay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnlist
			// 
			this.btnlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlist.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnlist.Location = new System.Drawing.Point(541, 497);
			this.btnlist.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnlist.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnlist.Name = "btnlist";
			this.btnlist.Size = new System.Drawing.Size(125, 40);
			this.btnlist.TabIndex = 26;
			this.btnlist.Text = "Listar";
			this.btnlist.UseVisualStyleBackColor = false;
			this.btnlist.Click += new System.EventHandler(this.BtnlistClick);
			// 
			// btnaddalum
			// 
			this.btnaddalum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnaddalum.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnaddalum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnaddalum.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnaddalum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btnaddalum.Location = new System.Drawing.Point(539, 163);
			this.btnaddalum.MaximumSize = new System.Drawing.Size(125, 40);
			this.btnaddalum.MinimumSize = new System.Drawing.Size(125, 40);
			this.btnaddalum.Name = "btnaddalum";
			this.btnaddalum.Size = new System.Drawing.Size(125, 40);
			this.btnaddalum.TabIndex = 25;
			this.btnaddalum.Text = "Añadir";
			this.btnaddalum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnaddalum.UseVisualStyleBackColor = false;
			this.btnaddalum.Click += new System.EventHandler(this.BtnaddalumClick);
			// 
			// lblmatgru
			// 
			this.lblmatgru.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmatgru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lblmatgru.Location = new System.Drawing.Point(285, 140);
			this.lblmatgru.MaximumSize = new System.Drawing.Size(200, 30);
			this.lblmatgru.MinimumSize = new System.Drawing.Size(200, 30);
			this.lblmatgru.Name = "lblmatgru";
			this.lblmatgru.Size = new System.Drawing.Size(200, 30);
			this.lblmatgru.TabIndex = 23;
			this.lblmatgru.Text = "Grupo:";
			this.lblmatgru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblmat
			// 
			this.lblmat.BackColor = System.Drawing.Color.Transparent;
			this.lblmat.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(24)))), ((int)(((byte)(144)))));
			this.lblmat.Location = new System.Drawing.Point(65, 140);
			this.lblmat.MaximumSize = new System.Drawing.Size(200, 30);
			this.lblmat.MinimumSize = new System.Drawing.Size(200, 30);
			this.lblmat.Name = "lblmat";
			this.lblmat.Size = new System.Drawing.Size(200, 30);
			this.lblmat.TabIndex = 22;
			this.lblmat.Text = "Materia:";
			this.lblmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtmatgru
			// 
			this.txtmatgru.BackColor = System.Drawing.Color.White;
			this.txtmatgru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtmatgru.Location = new System.Drawing.Point(285, 170);
			this.txtmatgru.MaximumSize = new System.Drawing.Size(200, 40);
			this.txtmatgru.MaxLength = 8;
			this.txtmatgru.MinimumSize = new System.Drawing.Size(200, 40);
			this.txtmatgru.Name = "txtmatgru";
			this.txtmatgru.Size = new System.Drawing.Size(200, 40);
			this.txtmatgru.TabIndex = 21;
			// 
			// txtmat
			// 
			this.txtmat.BackColor = System.Drawing.Color.White;
			this.txtmat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtmat.Location = new System.Drawing.Point(65, 170);
			this.txtmat.MaximumSize = new System.Drawing.Size(200, 40);
			this.txtmat.MinimumSize = new System.Drawing.Size(200, 40);
			this.txtmat.Name = "txtmat";
			this.txtmat.Size = new System.Drawing.Size(200, 40);
			this.txtmat.TabIndex = 20;
			// 
			// btncolor
			// 
			this.btncolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btncolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncolor.Font = new System.Drawing.Font("JetBrainsMono NFM SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncolor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(150)))), ((int)(((byte)(25)))));
			this.btncolor.Location = new System.Drawing.Point(22, 497);
			this.btncolor.MaximumSize = new System.Drawing.Size(125, 40);
			this.btncolor.MinimumSize = new System.Drawing.Size(125, 40);
			this.btncolor.Name = "btncolor";
			this.btncolor.Size = new System.Drawing.Size(125, 40);
			this.btncolor.TabIndex = 19;
			this.btncolor.Text = "Color";
			this.btncolor.UseVisualStyleBackColor = false;
			this.btncolor.Click += new System.EventHandler(this.BtncolorClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(7, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 130);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// lbldisplay
			// 
			this.lbldisplay.Location = new System.Drawing.Point(47, 230);
			this.lbldisplay.Name = "lbldisplay";
			this.lbldisplay.Size = new System.Drawing.Size(595, 253);
			this.lbldisplay.TabIndex = 27;
			this.lbldisplay.Text = "-";
			// 
			// MateriasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ClientSize = new System.Drawing.Size(678, 544);
			this.Controls.Add(this.lbldisplay);
			this.Controls.Add(this.btnlist);
			this.Controls.Add(this.btnaddalum);
			this.Controls.Add(this.lblmatgru);
			this.Controls.Add(this.lblmat);
			this.Controls.Add(this.txtmatgru);
			this.Controls.Add(this.txtmat);
			this.Controls.Add(this.btncolor);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(700, 600);
			this.MinimumSize = new System.Drawing.Size(700, 600);
			this.Name = "MateriasForm";
			this.Text = "MateriasForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
