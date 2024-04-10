using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Hotel.General
{
    public class clsUtil
    {


        private static Guid _generateName()
        {
            return new Guid();
        }


        private static string _imageExtention(string image)
        {

            FileInfo imageFile = new FileInfo(image);
            return imageFile.Extension;
        }

        public static bool saveImageToLocal(ref string image)
        {
            string filePath = @"C:\Users\ali77\OneDrive\Desktop\hotelEmployeeImage\";
            string imageName = _generateName().ToString();
            string imageNewFullPath = filePath + imageName + _imageExtention(image);

            try
            {
                File.Copy(image, imageNewFullPath);
                image = imageNewFullPath;
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error is : " + ex.ToString());
                return false;
            }

        }

        public static string decodePassword(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));

                return BitConverter.ToString(hash).Replace("-", "").ToString();
            }
        }

        public static bool isTwoPasswordEqual(string password, string hashPass)
        {
            return decodePassword(password) == hashPass;
        }

    }
}
