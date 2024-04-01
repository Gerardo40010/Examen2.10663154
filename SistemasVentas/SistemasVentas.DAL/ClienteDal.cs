using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                        "'" + cliente.TipoCliente + "'," +
                                                        "'" + cliente.CodigoCliente + "'," +
                                                        "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente c = new Cliente();

            if (tabla.Rows.Count > 0)
            {
                c.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                c.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                c.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                c.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                c.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return c;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set idpersona=" + c.IdPersona + "," +
                                                  "tipocliente='" + c.TipoCliente + "'," +
                                                  "codigocliente='" + c.CodigoCliente + "'" +
                                              "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable ListarIngresoClienteDal()
        {
            string consulta = "SELECT c.IDCLIENTE, p.NOMBRE AS Cliente, SUM(v.TOTAL) AS TotalIngresos\r\nFROM CLIENTE c\r\nJOIN VENTA v ON c.IDCLIENTE = v.IDCLIENTE\r\nJOIN PERSONA p ON c.IDPERSONA = p.IDPERSONA\r\nGROUP BY c.IDCLIENTE, p.NOMBRE;\r\n";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public DataTable ListarTopClienteDal()
        {
            string consulta = "SELECT p.NOMBRE AS Cliente, SUM(v.TOTAL) AS TotalCompras\r\nFROM CLIENTE c\r\nJOIN VENTA v ON c.IDCLIENTE = v.IDCLIENTE\r\nJOIN PERSONA p ON c.IDPERSONA = p.IDPERSONA\r\nGROUP BY p.NOMBRE\r\nHAVING SUM(v.TOTAL) > 80;";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public DataTable ListarNombresClienteDal()
        {
            string consulta = "SELECT P.NOMBRE, P.APELLIDO \" +\r\n                              \"FROM PERSONA P \" +\r\n                              \"JOIN CLIENTE C ON P.IDPERSONA = C.IDPERSONA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
