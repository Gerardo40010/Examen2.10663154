﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public Producto ObtenerIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);

        }
        public DataTable ListarTotalProductoBss()
        {
            return dal.ListarTotalProductoDal();
        }
       
         public DataTable ListarProductoVencBss()
        {
            return dal.ListarProductoVencDal();
        }
        public DataTable ListarProductoVendidoBss()
        {
            return dal.ListarProductoVendidoDal();
        }
        public DataTable ListarProductoTiposBss()
        {
            return dal.ListarProductoTiposDal();
        }
    }
}
