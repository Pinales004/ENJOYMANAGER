using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PRESENTACION
{
    internal class btn_icon_hover
    {
        public static void AplicarFormaRedonda(PictureBox pictureBox)
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            int redondez = 30; // Ajusta el valor de redondez según tus preferencias

            GraphicsPath path = new GraphicsPath();

            // Crear un cuadro con esquinas redondeadas
            int radio = redondez;
            if (width < height)
            {
                radio = width / 3; // Ajusta la proporción para hacerlo más cuadrado
            }
            else
            {
                radio = height / 3; // Ajusta la proporción para hacerlo más cuadrado
            }

            path.AddLine(radio, 0, width - radio, 0); // Línea superior
            path.AddArc(width - radio, 0, radio, radio, 270, 90); // Esquina superior derecha
            path.AddLine(width, radio, width, height - radio); // Línea derecha
            path.AddArc(width - radio, height - radio, radio, radio, 0, 90); // Esquina inferior derecha
            path.AddLine(width - radio, height, radio, height); // Línea inferior
            path.AddArc(0, height - radio, radio, radio, 90, 90); // Esquina inferior izquierda
            path.AddLine(0, height - radio, 0, radio); // Línea izquierda
            path.AddArc(0, 0, radio, radio, 180, 90); // Esquina superior izquierda

            Region region = new Region(path);

            // Establecer la región del PictureBox para darle forma cuadrada con esquinas redondeadas
            pictureBox.Region = region;
        }
        public static void CambiarColorHover(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            // Cambia el color de fondo según el botón
            if (button.Name == "btn_agregar")
                button.BackColor = Color.Green;
            else if (button.Name == "btn_editar")
                button.BackColor = Color.Yellow;
            else if (button.Name == "btn_eliminar")
                button.BackColor = Color.Red;
            else if (button.Name == "btn_volver")
                button.BackColor = Color.Gray;
            else if (button.Name == "btn_limpiar")
                button.BackColor = Color.SkyBlue;
            else if (button.Name == "btn_guardar")
                button.BackColor = Color.Green;
        }

        public static void RestaurarColorOriginal(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            // Restaura el color de fondo original al salir del botón
            button.BackColor = SystemColors.Control;
        }
    }
}
