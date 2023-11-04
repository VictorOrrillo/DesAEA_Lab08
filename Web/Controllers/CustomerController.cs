using bussiness;
using entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web.Models;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {

            Bcustomer bCustomer = new Bcustomer();

            List<Cliente> customers = bCustomer.ListarClientes();


            //Convertir nuestro listado de entidades a listado de modelo
            //Entity=>Model
            List<CustomerModel> models = new List<CustomerModel>();

            models = customers.Select(x=> new CustomerModel
            {
                CustomerID= x.CustomerID,
                Name = x.Name,
                Phone = x.Phone,

            }).ToList();

            return View(models);
            
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel model)
        {
            try
            {
                Bcustomer bcustomer = new Bcustomer();

                Cliente cliente = new Cliente
                {
                    Name = model.Name,
                    Phone = model.Phone,
                };

                bcustomer.InsertarCliente(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
