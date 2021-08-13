using Microsoft.AspNetCore.Mvc;
using SMS.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InventoryController : ControllerBase
	{
		private MysqlDataContext _dbContext;

        public InventoryController(MysqlDataContext dbContext)
        {
			this._dbContext = dbContext;

		}

		// GET: api/<InventoryController>
		[HttpGet ("Inventory")]
		public IEnumerable<Inventory> Inventory()
		{
			return this._dbContext.Inventorys.ToList();
		}

		// GET api/<InventoryController>/5
		[HttpGet("Inventory/{id}")]
		public IEnumerable<Inventory> Inventory(int id)
		{
			return this._dbContext.Inventorys.Where(X => X.InventoryId == id).ToList();
		}

		// POST api/<InventoryController>
		[HttpPost ("InsertInventory")]
		public void InsertInventory([FromBody] InventoryReq IR)
		{
			var I = new Inventory();

			I.ItemCode = IR.ItemCode;
			I.ItemName = IR.ItemName;
			I.ModelNumber = IR.ModelNumber;
			I.SerialNumber = IR.SerialNumber;
			I.Brand = IR.Brand;
			I.Quantity = IR.Quantity;
			I.WarrenOrGarantee = IR.WarrenOrGarantee;
			I.WarrenOrGarenInfo = IR.WarrenOrGarenInfo;
			I.Price = IR.Price;
			I.VendorName = IR.VendorName;
			I.VendorNumber = IR.VendorNumber;
			I.VendorAddress = IR.VendorAddress;

			_dbContext.Inventorys.Add(I);
			_dbContext.SaveChanges();

		}

		// PUT api/<InventoryController>/5
		[HttpPut("UpdateInventory/{id}")]
		public void UpdateInventory(int id, [FromBody] InventoryReq value)
		{
			_dbContext.Entry(_dbContext.Inventorys.Where(X => X.InventoryId == id).SingleOrDefault()).CurrentValues.SetValues(value);
			_dbContext.SaveChanges();
		}

		// DELETE api/<InventoryController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			var Result =_dbContext.Inventorys.Where(X => X.InventoryId == id).SingleOrDefault();

			_dbContext.Remove(Result);
			_dbContext.SaveChanges();
		}
	}
}
