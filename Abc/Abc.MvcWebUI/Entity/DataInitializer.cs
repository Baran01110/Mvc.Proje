using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>() 
            { 
                new Category(){ Name = "Su", Description= "Su ürünleri"},
                new Category(){ Name = "Kola", Description= "Kola ürünleri"},
                new Category(){ Name = "Pil", Description= "Pil ürünleri"},
                new Category(){ Name = "Elektronik Atık", Description= "Elektronik Atık ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name="Hayat Su",Description = "Su ürünleri",Price = 777,Stock = 200,IsApproved=true,CategoryId = 1, IsHome=true },
                

                new Product(){ Name="Coca Cola",Description = "Kola ürünleri",Price = 555,Stock = 100,IsApproved=true,CategoryId= 2 , IsHome=true },

                new Product(){ Name="Kalem Pil",Description = "Pil ürünleri",Price = 555,Stock = 100,IsApproved=true,CategoryId=3, IsHome =true },

                new Product(){ Name="Bilgisayar",Description = "Elektronik Atık ürünleri",Price = 555,Stock = 100,IsApproved=true,CategoryId=4,IsHome = true }

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}