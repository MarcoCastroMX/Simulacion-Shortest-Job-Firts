using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shortest_Job_First
{
    public partial class Form1 : Form
    {
        List<Proceso> ListaProcesos = new List<Proceso>();
        public Form1()
        {
            InitializeComponent();
            Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            String Nombre;
            int Tiempo;
            if (TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }
            Nombre = TxtNombre.Text;
            foreach(Proceso i in ListaProcesos)
            {
                if (i.GetNombre().Equals(Nombre))
                    return;
            }
            Random rand = new Random();
            Tiempo = rand.Next(1, 25);
            Proceso P = new Proceso(Nombre,Tiempo);
            ListaProcesos.Add(P);
            BtnIniciar.Enabled = true;
            TxtNombre.Text = "";
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int n = ListaProcesos.Count;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (ListaProcesos[j].GetTiempo() > ListaProcesos[j + 1].GetTiempo())
                    {
                        Proceso Temporal = new Proceso();
                        Temporal = ListaProcesos[j];
                        ListaProcesos[j] = ListaProcesos[j + 1];
                        ListaProcesos[j + 1] = Temporal;
                    }
                }
            }
            foreach(Proceso P in ListaProcesos)
            {
                LbNombre.Text = P.GetNombre();
                LbNombre.Refresh();
                LbTiempo.Text = P.GetTiempo().ToString();
                LbTiempo.Refresh();
                for(int i= 0; i < P.GetTiempo(); i++)
                {
                    Grafica.Series["Procesos"].Points.AddY(P.GetTiempo());
                    Grafica.Series["Procesos"].BorderWidth = 5;
                    Grafica.Update();
                    Thread.Sleep(400);
                }
                DataGridViewRow Fila = new DataGridViewRow();
                this.Tabla.DefaultCellStyle.Font = new Font("Arial", 14);
                Fila.CreateCells(Tabla);
                Fila.Cells[0].Value = P.GetNombre();
                Tabla.Rows.Add(Fila);
                Tabla.Update();
            }
        }
    }
}
