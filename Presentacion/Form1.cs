using RepositorioDePuntoDeVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Distrito_> distritos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (CMV_LOCAL3Entities db = new CMV_LOCAL3Entities())
            {
                distritos = db.Distrito_.Include("Zona_").ToList();
                distritos.ForEach(distrito => agregarDistritosATabla(distrito));
            }
        }
        private void agregarDistritosATabla(Distrito_ distrito) {
            dataGridView1.Rows.Add(distrito.id, distrito.nombre);
        }

        private void agregarZonasATabla(Distrito_ distrito)
        {
            dataGridView2.Rows.Clear();
            foreach (Zona_ zona in distrito.Zona_) {
                dataGridView2.Rows.Add(zona.id,zona.nombre,zona.descripcion);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var distrito = this.distritos.FirstOrDefault(x => x.id.Equals(id));
            this.agregarZonasATabla(distrito);
        }
    }
}
