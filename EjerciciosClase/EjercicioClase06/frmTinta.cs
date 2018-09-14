using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06
{
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }
            this.cboColor.SelectedItem = ConsoleColor.Blue;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoTinta tipo in Enum.GetValues(typeof(ETipoTinta)))
            {
                this.cboTinta.Items.Add(tipo);
            }
            this.cboTinta.SelectedItem = ETipoTinta.Comun;
            this.cboTinta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
