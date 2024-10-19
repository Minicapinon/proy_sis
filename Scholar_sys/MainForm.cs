/*
 * Created by CapinonMStudio
 * User: angel
 * Date: 17/10/2024
 * version 5.1 of Sharpdevelop
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Scholar_sys
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

		//Declaración de las credenciales de el administrador
		public string user = "CapinonM";
		public string passwd = "mypasswd";

		// Para los forms
		private Alumnform alumn = null;
		private MateriasForm materias = null;

		public MainForm()
		{
			InitializeComponent();
			materias = new MateriasForm();
		}

		// Boton de entrar
		void BtnenterClick(object sender, EventArgs e)
		{
			// Comprueba si las credenciales son correctas
			if(txtbpasswd.Text == passwd && txtbuser.Text == user)
			{
				/*
					se uso explicacion de
					https://www.c-sharpcorner.com/UploadFile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
				
					Se uso parte de 
					https://stackoverflow.com/questions/3965043/how-to-open-a-new-form-from-another-form para saber como ocultar los forms
				*/

				// Declara el mensaje a mostrar
				const string message = "Bienvenido!!";
				// Asigna el titulo del MessageBox
				const string title = "Credenciales correctas";
				// Muestra el boton de "Aceptar"		
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				// Muestra el MessageBox final
				MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

				txtbpasswd.Text = "";
				txtbuser.Text = "";

				txtbpasswd.Clear();
    			txtbuser.Clear();
				
				//Abre el formulario alumn
				if (alumn == null)
				{
					alumn = new Alumnform(this,materias);
					alumn.FormClosed += (s, args) => { this.Show(); alumn = null; };
					alumn.Show();
					this.Hide();
				}
				else
				{
					alumn.Show();
					this.Hide();
				}
			}
			// Si no lo son
			else
			{
				// Declara el mensaje a mostrar
				const string message = "Comprueba las credenciales";
				// Asigna el titulo del MessageBox
				const string title = "Error de credenciales";
				// Muestra el boton de "Aceptar"		
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				// Muestra el MessageBox final
				MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
			}
		}
		// Limpia ambos textbox
		void BtncleanClick(object sender, EventArgs e)
		{
			txtbpasswd.Text = "";
			txtbuser.Text = "";
		}

		// Variable para controlar el color
		bool isblackmode = false;
		void BtncolorClick(object sender, EventArgs e)
		{
			if(!isblackmode) // Si no es oscuro
			{
				// Para el Mainform
				this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

				// Para los botones
				btnclean.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btnenter.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btncolor.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

				// Para el texto de los botones
				btnclean.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnenter.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btncolor.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);

				// Para los labels
				lbluser.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);
				lblpasswd.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);

				//Para el fondo de los textbox
				txtbuser.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				txtbpasswd.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				
				// Para el texto de los textbox
				txtbuser.ForeColor = System.Drawing.Color.FromArgb(245,245,245);
				txtbpasswd.ForeColor = System.Drawing.Color.FromArgb(245,245,245);

				// Actualiza el valor a que es oscuro
				isblackmode = true;
			}
			else // Si es oscuro
			{
				// Para el Mainform
				this.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);

				// Para los botones
				btnclean.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btnenter.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btncolor.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);

				// Para el texto de los botones
				btnclean.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnenter.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btncolor.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);

				// Para los labels
				lbluser.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);
				lblpasswd.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);

				//Para el fondo de los textbox
				txtbuser.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				txtbpasswd.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				
				// Para el texto de los textbox
				txtbuser.ForeColor = System.Drawing.Color.FromArgb(64,64,64);
				txtbpasswd.ForeColor = System.Drawing.Color.FromArgb(64,64,64);

				// Actualiza el valor a que no es oscuro
				isblackmode = false;
			}
		}
	}
}