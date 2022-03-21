using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class Ficha : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int id = 0;
        public Ficha(int idActual)
        {
            InitializeComponent();
            id = idActual; 
            misPokemons = miConexion.getPokemonPorId(id);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            label1.Text = misPokemons.Rows[0]["descripcion"].ToString();
            label2.Text = misPokemons.Rows[0]["habilidad"].ToString();
            label3.Text = misPokemons.Rows[0]["especie"].ToString();
            label4.Text = misPokemons.Rows[0]["habitat"].ToString();
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
