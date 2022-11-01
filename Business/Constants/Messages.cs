using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models.Concrete;
using Models.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated ="Araç Güncellendi";
        public static string CarNameInvalid = "Araç ismi Geçersiz";
        public static string DailyPriceAdded = "Araç Fiyatı Eklendi";
        public static string DailyPriceInvalid = "Araç Fiyatı Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarsListed = "Araçlar Listelendi";

        public static string InvalidRental = "Kiralama Geçersiz";
        public static string RentalAdded = "Kiralandı";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string AuthorizationDenied = "Yetki yok";


        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        public static string ImageAdded = "Resim Yüklendi";
        public static string ImageDeleted = "Resim Silindi";
        public static string ImageUpdated = "Resim Güncellendi";
    }
}
