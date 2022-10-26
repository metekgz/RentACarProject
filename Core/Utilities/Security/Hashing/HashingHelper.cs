using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // CreatePasswordHash ona verdiğimiz passwordun salt ve hashini oluşturacak
        // bir passord verilecek ve dışarıya out olan iki değeri çıkarak yapı tasarlandı
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            // HMACSHA512 ile password salt ve hash oluşturulması
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                // salt olarak verilecek değer
                passwordSalt = hmac.Key;
                // hash olarak verilecek değer
                //Encoding.UTF8.GetBytes = bir stringin byte karşılığını almak için kullanılan yöntem
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        // passwordhashi doğrulama
        // kullanıcı sisteme sonradan girince olacak işlem
        // passwordHash veri tabaındaki hash olacak o hash ile kullanıcının gönderdiği passwordun olacak hashini karşılaştır
        // hashler eşitse true değilse false olacak
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                // bu iki değerleri aynı mı diye karşılaştırmak için döngü yapıldı
                for (int i = 0; i < computedHash.Length; i++)
                {
                    // computedHashin değeri veri tabanından gönderilen hashin değerine eşit değilse false eşitse true
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
