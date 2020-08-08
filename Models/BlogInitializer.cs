using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YapılacaklarListesi.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Tarihi Yerler"},
                new Category(){KategoriAdi="Müzeler"},
                new Category(){KategoriAdi="Yeme-İçme"},
                new Category(){KategoriAdi="Konaklama"}
            };
            foreach (var item in Kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog(){Baslik="Merhaba",Sehir="Ankara" ,Aciklama="Merhabamerhaba",Resim="Ankara.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=1},
                new Blog(){Baslik="Merhaba",Sehir="Avusturalya" ,Aciklama="Merhabamerhaba",Resim="Ankara.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=1},
                new Blog(){Baslik="Merhaba",Sehir="İsveç" ,Aciklama="Merhabamerhaba",Resim="Ankara.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=1},
                new Blog(){Baslik="Merhaba",Sehir="İstanbul" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=2},
                new Blog(){Baslik="Merhaba",Sehir="Kocaeli" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=2},
                new Blog(){Baslik="Merhaba",Sehir="Danimarka" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=2},
                new Blog(){Baslik="Merhaba",Sehir="Muğla" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=3},
                new Blog(){Baslik="Merhaba",Sehir="Hollanda" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=3},
                new Blog(){Baslik="Merhaba",Sehir="Almanya" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=3},
                new Blog(){Baslik="Merhaba",Sehir="İzmir" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=4},
                new Blog(){Baslik="Merhaba",Sehir="Manisa" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=4},
                new Blog(){Baslik="Merhaba",Sehir="Antalya" ,Aciklama="Merhabamerhaba",Resim="1.jpg",Icerik="MerhabamerhabaMerhabamerhabaMerhabamerhaba",EklenmeTarihi=DateTime.Now.AddDays(-10) ,Anasayfa=true,CategoryId=4}

            };

            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}