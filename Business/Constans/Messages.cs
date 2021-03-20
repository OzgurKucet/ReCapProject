using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string ProductNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Ürünler listelendi";
        public static string CarImageLimitExceeded = "Daha fazla ürün girilemez";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatasi";
        public static string SuccessfulLogin = "Basarili giris";
        public static string UserAlreadyExists = "Kullanici Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
