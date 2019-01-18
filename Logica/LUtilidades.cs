using System.Windows.Forms;

namespace Logica
{
    public class LUtilidades
    {
        public void Mensajes(string titulo, string mensaje)
        {
            switch (titulo.ToLower())
            {
                case "advertencia":
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "error":
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "información":
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
