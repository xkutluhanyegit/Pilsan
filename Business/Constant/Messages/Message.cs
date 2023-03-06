using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Constant.Messages
{
    public static class Message
    {
        public static string AddedSuccess = "Ekleme işlemi başarıyla gerçekleşti";
        public static string UpdateSuccess = "Güncelleme işlemi başarıyla gerçekleşti";
        public static string ListedSuccces = "Listeleme işlemi başarııyla gerçekleşti";
        public static string AuthorizationDenied = "Yetkilendirme Hatası";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}