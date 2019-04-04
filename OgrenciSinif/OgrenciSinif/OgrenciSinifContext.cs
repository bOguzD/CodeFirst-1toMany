namespace OgrenciSinif
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class OgrenciSinifContext : DbContext
    {
        // Your context has been configured to use a 'OgrenciSinif' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OgrenciSinif.OgrenciSinif' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OgrenciSinif' 
        // connection string in the application configuration file.
        public OgrenciSinifContext()
            : base("name=OgrenciSinif")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Sinif> Siniflar { get; set; }
    }
    [Table("Ogrenci")]
    public class Ogrenci
    {
        [Key, DisplayName("Kimlik Numaras�")] //Alttaki prop u PrimaryKey yap�yor. E�er Key yazmazsak ID'li olan� PrimaryKey yap�yor.
        public long TcKimlikID { get; set; }

        //StringLength Alt taki prop i�in ge�erlidir.
        [StringLength(80)]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Ad Soyad Bo� Olamaz")] //Hata Mesaj� Tan�mland�
        public string AdSoyad { get; set; }
        public int SinifID { get; set; }
        public int Yas { get; set; }
        public virtual Sinif sinif { get; set; }

    }
    [Table("Sinif")]
    public class Sinif
    {
        public Sinif()
        {
            this.ogrenciler = new HashSet<Ogrenci>();   //performans�n� artt�r�r.

            //ICollection tan�mland���nda hemen bir constructor a��l�r ve bu i�lem performans� artt�r�r
        }
        [Key]
        public int SinifID { get; set; }
        [StringLength(50)]
        public string Aciklama { get; set; }
        public virtual ICollection<Ogrenci> ogrenciler { get; set; }


    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}