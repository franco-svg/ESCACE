using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEC
{
    public static class Encriptador
    {

        private static readonly string Clave = "ClaveSegura12345";  //AES 128 bits

        //Para la encriptación, se optó por utilizar AES
        public static string Encriptar(string sPass)
        {
            using (Aes aes = Aes.Create()) //using = obj temporal || obj aes vendria a ser "motor de cifrado"
            {
                aes.Key = Encoding.UTF8.GetBytes(Clave);
                aes.IV = new byte[16]; // IV fijo (Intialization Vector), valor adicional que 'saltea' la encriptación. Hacerlo dinamica para seguridad total

                using (var ms = new MemoryStream()) //ms es donde se guardan los datos temporalmente
                {
                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write)) //cs es "canal" donde se cifra/descifra. todo lo que pase por cs, va a salir cifrado y terminar en ms
                    using (var sw = new StreamWriter(cs)) //le pasa los bytes a cs
                    {
                        sw.Write(sPass); //
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        //pass ->SW La pasa a bytes -> CS cifra esos bytes -> Se guardan en MS
        

        public static string Desencriptar(string sEncriptado)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Clave);
                aes.IV = new byte[16];

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(sEncriptado)))//se carga el string cifrado, en bytes, en el ms
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))//lee lo que esta en ms y lo descifra
                using (StreamReader sr = new StreamReader(cs))//lee los bytes que estan en el cs
                {
                    return sr.ReadToEnd();//devuelve esos bytes a string
                }
            }
        }
        //bytes cifrados en MS -> CS los lee y descifra -> SR pasa esos bytes a string -> pass descifrada
    }
}