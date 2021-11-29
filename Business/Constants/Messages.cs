using Core.Entities.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //Constants: Sabit
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başsrıyla Eklendi";
        public static string ProductNameInvalid = "Ürün Adı Geçersiz";
        public static string ProductListed = "Ürünler başarıyla listelendi";
        public static string ProductDeleted = "Ürünler başarıyla silindi";
        public static string ProductImageNotFound = "Ürün Resmi Bulunamadı";
        public static string ProductImageDeleted = "Ürün Resmi Silindi";
        public static string ProductImageListed = "Ürün Resimleri Listelendi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfullLogin = "Başarılı Bir Şekilde Giriş Yapıldı";
        public static string UserAlreadyExist = "Kullanıcı Mevcut";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi";
        public static string AccesstokenCreated = "Token Oluşturuldu";
    }
}
