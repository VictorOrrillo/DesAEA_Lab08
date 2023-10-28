using entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data;

namespace bussiness
{
    public class Bcustomer
    {

        public List<Cliente> ListarClientes()
        {
            
            List<Cliente> clientes = Dcustomer.ListarClientes();

            return clientes;
        }

        public Cliente BuscarPorNombre(string name)
        {
            List<Cliente> customers = new List<Cliente>();
            customers = Dcustomer.ListarClientes();

            foreach (var cust in customers)
            {
                if (cust.Name.Equals(name))
                {
                    return cust;
                }
            }

            return null;
        }
    }
}
    