using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);

        }
        public DataTable ListarIngresoClienteBss()
        {
            return dal.ListarIngresoClienteDal();
        }
        public DataTable ListarTopClienteBss()
        {
            return dal.ListarTopClienteDal();
        }
        public DataTable ListarNombresClienteBss()
        {
            return dal.ListarNombresClienteDal();
        }
    }
}
