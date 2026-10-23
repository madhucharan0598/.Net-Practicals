using Practical8.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical8.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        string cs = ConfigurationManager
            .ConnectionStrings["InventoryDB"].ConnectionString;

        // READ: Display all products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Products", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        Price = Convert.ToDecimal(dr["Price"])
                    });
                }
            }

            return View(products);
        }

        // CREATE: Display the add form
        public ActionResult Create()
        {
            return View();
        }

        // CREATE: Save a new product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Products
                    (ProductName, Quantity, Price)
                    VALUES (@name, @qty, @price)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@name", SqlDbType.VarChar, 100)
                    .Value = p.ProductName;
                cmd.Parameters.Add("@qty", SqlDbType.Int)
                    .Value = p.Quantity;

                SqlParameter price = cmd.Parameters.Add(
                    "@price", SqlDbType.Decimal);
                price.Precision = 10;
                price.Scale = 2;
                price.Value = p.Price;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }

        // UPDATE: Display the selected product
        public ActionResult Edit(int id)
        {
            Product p = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Products WHERE ProductId=@id", con);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    p = new Product
                    {
                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        Price = Convert.ToDecimal(dr["Price"])
                    };
                }
            }

            if (p == null)
                return HttpNotFound();

            return View(p);
        }

        // UPDATE: Save the changes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Products
                    SET ProductName=@name,
                        Quantity=@qty,
                        Price=@price
                    WHERE ProductId=@id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@name", SqlDbType.VarChar, 100)
                    .Value = p.ProductName;
                cmd.Parameters.Add("@qty", SqlDbType.Int)
                    .Value = p.Quantity;

                SqlParameter price = cmd.Parameters.Add(
                    "@price", SqlDbType.Decimal);
                price.Precision = 10;
                price.Scale = 2;
                price.Value = p.Price;

                cmd.Parameters.Add("@id", SqlDbType.Int)
                    .Value = p.ProductId;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }

        // DELETE: Remove a product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Products WHERE ProductId=@id", con);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
    }
}