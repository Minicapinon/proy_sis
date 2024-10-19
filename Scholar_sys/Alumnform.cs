/*
 * Created by CapinonMStudio
 * User: angel
 * Date: 17/10/2024
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scholar_sys
{
	/// <summary>
	/// Description of Alumnform.
	/// </summary>
	public partial class Alumnform : Form
	{
		private MainForm mainForm;
		private MateriasForm materias;

		public Alumnform(MainForm form, MateriasForm materi)
		{
			InitializeComponent();
			this.mainForm = form;
			this.materias = materi;
		}
		// Variable para controlar el color
		bool isblackmode = false;
		void BtncolorClick(object sender, EventArgs e)
		{
			if(!isblackmode)
			{
				// Para el Alumnform
				this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

				// Para los botones
				btncolor.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btnaddalum.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btnlist.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btnlogout.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
				btnmater.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);

				// Para el texto de los botones
				btncolor.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnaddalum.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnlist.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnlogout.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnmater.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);

				// Para los labels
				lblalumat.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);
				lblaluser.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);

				//Para el fondo de los textbox
				txtalum.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				txtmat.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				
				// Para el texto de los textbox
				txtalum.ForeColor = System.Drawing.Color.FromArgb(245,245,245);
				txtmat.ForeColor = System.Drawing.Color.FromArgb(245,245,245);

				// Actualiza el valor a que es oscuro
				isblackmode = true;
			}
			// Else
			else
			{
				// Para el Alumnform
				this.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);

				// Para los botones
				btncolor.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btnaddalum.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btnlist.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btnlogout.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
				btnmater.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);

				// Para el texto de los botones
				btncolor.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnaddalum.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnlist.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnlogout.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnmater.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);

				// Para los labels
				lblalumat.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);
				lblaluser.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);

				//Para el fondo de los textbox
				txtalum.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				txtmat.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				
				// Para el texto de los textbox
				txtalum.ForeColor = System.Drawing.Color.FromArgb(64,64,64);
				txtmat.ForeColor = System.Drawing.Color.FromArgb(64,64,64);

				// Actualiza el valor a que no es oscuro
				isblackmode = false;
			}
		}

		int alumn_id = 1;
		void BtnaddalumClick(object sender, EventArgs e)
        {
			if(txtalum.Text == "" || txtmat.Text == "")
			{
				// Declara el mensaje a mostrar
				const string message = "No puede estar vacio \n ningun campo";
				// Asigna el titulo del MessageBox
				const string title = "Error";
				// Muestra el boton de "Aceptar"		
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				// Muestra el MessageBox final
				MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
			}
			else
			{
				if(alumn_id <= 10)
				{
					AlumnCont newAlumn = new AlumnCont
					{
						id = alumn_id,
						alumnname = txtalum.Text,
						alumnmatri = txtmat.Text
					};

					// Incrementa el contador de alumnos
					alumn_id++;
				}
				else
				{
					// Declara el mensaje a mostrar
					const string message = "Se alcanzo el limite\n de alumnos (10)";
					// Asigna el titulo del MessageBox
					const string title = "Maximo de alumnos";;
					// Muestra el boton de "Aceptar"		
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					// Muestra el MessageBox final
					MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
				}
			}
        }
		//Cierra la sesion (muestra el Login otra ves)
		void BtnlogoutClick(object sender, EventArgs e)
		{
			this.mainForm.Show();
			this.Hide();
			materias.Hide();
		}
		void BtnmaterClick(object sender, EventArgs e)
		{
			this.materias.Show();
		}
		void BtnlistClick(object sender, EventArgs e)
		{
			//
		}

		// Estructura para almacenar los alumnos (solo se guardan cuando el ptrograma esta ejecutandose)
        public struct AlumnCont
        {
            public int id;
            public string alumnname;
            public string alumnmatri;
		}
	}
}
