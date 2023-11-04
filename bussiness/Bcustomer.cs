using entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using data;

namespace bussiness
{
    public class Bcustomer


    {
        private Dcustomer dcustomer;

        public Bcustomer() 
        {
            dcustomer = new Dcustomer();
        }

        public List<Cliente> ListarClientes()
        {
            
            List<Cliente> clientes = dcustomer.ListarClientes();

            return clientes;
        }

        public Cliente BuscarPorNombre(string name)
        {
            List<Cliente> customers = new List<Cliente>();
            customers = dcustomer.ListarClientes();

            foreach (var cust in customers)
            {
                if (cust.Name.Equals(name))
                {
                    return cust;
                }
            }

            return null;
        }

        public void InsertarCliente(Cliente cliente)
        {
            dcustomer.InsertarCliente(cliente);
        }
    }
}
    