﻿using SistemasVentas.BSS;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorListarVista : Form
    {
        public VendedorListarVista()
        {
            InitializeComponent();
        }

        private void VendedorListarVista_Load(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /* ClienteBss bss = new ClienteBss();
            dataGridView1.DataSource = bss.ListarClienteBss();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetalleIngBss bss = new DetalleIngBss();
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ClienteBss bss = new ClienteBss();
          //  dataGridView1.DataSource = bss.ListarClienteBss();
           DataTable clientes = conexion.ObtenerClientes();

          
           dataGridView1.DataSource = clientes;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DetalleIngBss bss = new DetalleIngBss();
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //VendedorInicioSesionVista vendedorForm = new VendedorInicioSesionVista();
            // vendedorForm.Show();
            MessageBox.Show("Se canceló la venta");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Venta Exitosa");
        }
    }
}
