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
                new Category(){ Name = "Plastik", Description= "Plastik ürünleri"},
                new Category(){ Name = "Cam", Description= "Cam ürünleri"},
                new Category(){ Name = "Pil", Description= "Pil ürünleri"},
                new Category(){ Name = "Elektronik Atık", Description= "Elektronik Atık ürünleri"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name="Hayat Su",Description = "Plasitk ürünleri",Price = 110,Stock = 200,IsApproved=true,CategoryId = 1, IsHome=true,Image="hayatsu.png" },
                new Product(){ Name="Damla Su",Description = "Plasitk ürünleri",Price = 110,Stock = 200,IsApproved=true,CategoryId = 1, IsHome=true,Image="hayatsu.png" },
                new Product(){ Name="Hazır Gıda",Description = "Plasitk ürünleri",Price = 110,Stock = 200,IsApproved=true,CategoryId = 1, IsHome=true,Image="hayatsu.png" },

                new Product(){ Name="Coca Cola Şişe",Description = "Cam ürünleri geri dönüştürülmesi gereken önemli atıklardan biridir. Bu ürünlerin barkodunu bize ileterek gerekli geri dönüşümü kolayca sağlayabilirsiniz ",Price = 17,Stock = 100,IsApproved=true,CategoryId= 2 , IsHome=true,Image="Coca-Cola.png"  },
                new Product(){ Name="Su Şişe",Description = "Cam ürünleri ",Price = 17,Stock = 100,IsApproved=true,CategoryId= 2 , IsHome=true,Image="Coca-Cola.png"  },

                new Product(){ Name="Kalem Pil",Description = "Pil ürünleri",Price = 881,Stock = 100,IsApproved=true,CategoryId=3, IsHome =true,Image="kalempil.jpg"  },

                new Product(){ Name="Bilgisayar",Description = "Elektronik Atık ürünleri",Price = 999,Stock = 100,IsApproved=true,CategoryId=4,Image="pc.png"  },

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