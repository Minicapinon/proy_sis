/*
 * Created by CapinonMStudio.
 * User: angel
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scholar_sys
{
	/// <summary>
	/// Description of MateriasForm.
	/// </summary>
	public partial class MateriasForm : Form
	{
		public MateriasForm()
		{
			InitializeComponent();
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
				

				// Para el texto de los botones
				btncolor.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnaddalum.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);
				btnlist.ForeColor = System.Drawing.Color.FromArgb(184, 240, 115);

				// Para los labels
				lblmat.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);
				lblmatgru.ForeColor = System.Drawing.Color.FromArgb(160, 90, 200);

				//Para el fondo de los textbox
				txtmat.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				txtmatgru.BackColor = System.Drawing.Color.FromArgb(24,24,24);
				
				// Para el texto de los textbox
				txtmat.ForeColor = System.Drawing.Color.FromArgb(245,245,245);
				txtmatgru.ForeColor = System.Drawing.Color.FromArgb(245,245,245);

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

				// Para el texto de los botones
				btncolor.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnaddalum.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);
				btnlist.ForeColor = System.Drawing.Color.FromArgb(70, 150, 25);

				// Para los labels
				lblmat.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);
				lblmatgru.ForeColor = System.Drawing.Color.FromArgb(115, 24, 144);

				//Para el fondo de los textbox
				txtmat.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				txtmatgru.BackColor = System.Drawing.Color.FromArgb(255,255,255);
				
				// Para el texto de los textbox
				txtmat.ForeColor = System.Drawing.Color.FromArgb(64,64,64);
				txtmatgru.ForeColor = System.Drawing.Color.FromArgb(64,64,64);

				// Actualiza el valor a que no es oscuro
				isblackmode = false;
			}
		}
		int mat_id = 1;
		void BtnaddalumClick(object sender, EventArgs e)
		{
			if(txtmat.Text == "" || txtmatgru.Text == "")
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
				if(mat_id <= 10)
				{
					MatCont newMat = new MatCont
					{
						id = mat_id,
						matname = txtmatgru.Text,
						matgru = txtmatgru.Text
					};

					// Incrementa el contador de alumnos
					mat_id++;
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
		void BtnlistClick(object sender, EventArgs e)
		{
			
		}

		// Estructura para almacenar las materias (solo se guardan cuando el ptrograma esta ejecutandose)
        public struct MatCont
        {
            public int id;
            public string matname;
            public string matgru;
		}
	}
}
