using DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;

namespace Common.Interface.Master
{
    public class SupplierRepository : iSupplierRepository
    {
        Supplier suppliers = new Supplier();
        MyContext mycontext = new MyContext();
        bool status = false;
        public bool delete(int? Id)
        {
            var result = 0;
            Supplier suppliers = Get(Id);
            suppliers.IsDelete = true;
            suppliers.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            result = mycontext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Supplier> Get()
        {
            var get = mycontext.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }
        public Supplier Get(int? Id)
        {
            var get = mycontext.Suppliers.Find(Id);
            return get;
        }

        public bool insert(SupplierParam supplierParam)
        {
            var result = 0;
            suppliers.Name = supplierParam.Name;
            suppliers.CreateDate = DateTimeOffset.Now.LocalDateTime;
            suppliers.IsDelete = false;
            mycontext.Suppliers.Add(suppliers);
            result = mycontext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool update(int? Id, SupplierParam supplierParam)
        {
            var result = 0;
            Supplier suppliers = Get(Id);
            suppliers.Name = supplierParam.Name;
            suppliers.IsDelete = false;
            mycontext.Suppliers.Add(suppliers);
            result = mycontext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;

        }
    }
}
