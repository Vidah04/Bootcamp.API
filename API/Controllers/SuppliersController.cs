using Bussines_Logic.Interface;
using DataAccess.Model;
using DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    
    public class SuppliersController : ApiController
    {
        private readonly iSupplierService _supplierService;
        public SuppliersController(iSupplierService supplierService)

        {
            _supplierService = supplierService;
        }
        // GET: api/Suppliers
        public IEnumerable<Supplier> Get()
        {
            return _supplierService.Get();
        }

        // GET: api/Suppliers/5
        public Supplier Get(int Id)
        {
            return _supplierService.Get(Id);
        }

        // POST: api/Suppliers
        public void Post(SupplierParam supplierParam)
        {
            _supplierService.Insert(supplierParam);
        }

        // PUT: api/Suppliers/5
        public void Put(int? Id, SupplierParam supplierParam)
        {
            _supplierService.Update(Id, supplierParam);
        }

        // DELETE: api/Suppliers/5
        public void Delete(int Id)
        {
            _supplierService.Delete(Id);
        }
    }
}
