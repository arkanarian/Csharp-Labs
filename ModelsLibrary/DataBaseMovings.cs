using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;
using ModelsLibrary.Interfaces;
using ModelsLibrary.Entities;

namespace ModelsLibrary
{
    public class DataBaseMovings
    {
        AesCryptoServiceProvider crypto_povider;
        private const String _filePath = "D://OOP//lab1//data.txt";
        public IUser ActiveUser { get; set; }
        public IBank ActiveBank { get; set; }
        public List<String> LogList = new List<String>();
        public void Initialization()
        {
            ActiveBank = null;
            ActiveUser = null;
        }
        public DataBaseMovings()
        {
            InitializeAES();
            Initialization();
        }
        public void InitializeAES()
        {
            crypto_povider = new AesCryptoServiceProvider();
            crypto_povider.BlockSize = 128;
            crypto_povider.KeySize = 256;
            crypto_povider.GenerateIV();
            crypto_povider.GenerateKey();
            crypto_povider.Mode = CipherMode.CBC;
            crypto_povider.Padding = PaddingMode.PKCS7;
        }
        public void SaveDataBase(FinancialSystem finSystem, String filePath = _filePath)
        {
            string dataJson = SerializeData(finSystem);
            //byte[] dataEnc = EncryptData(dataJson);
            string dataEnc = EncryptData(dataJson);
            //File.WriteAllBytes(filePath, dataEnc);
            File.WriteAllText(filePath, dataEnc);
        }
        string SerializeData(FinancialSystem finSystem)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(finSystem, finSystem.GetType(), options);
            return jsonString;
        }
        string EncryptData(String clear_text)
        {
            ICryptoTransform transform = crypto_povider.CreateEncryptor();
            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);
            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
            //return encrypted_bytes;
        }

        //void SaveDataToFile(string filePath, byte[] data) => File.WriteAllBytes(filePath, data);

        public FinancialSystem GetDataBase(String filePath = _filePath)
        {
            //byte[] data = LoadDataFromFile(filePath);
            string data = LoadDataFromFile(filePath);
            string dataDecrypted = DecryptData(data);
            FinancialSystem finSystem = ParseData(dataDecrypted);
            return finSystem;
        }

        //byte[] LoadDataFromFile(String FilePath) => File.ReadAllBytes(FilePath);
        string LoadDataFromFile(String FilePath) => File.ReadAllText(FilePath);

        string DecryptData(string cipher_text)
        {
            ICryptoTransform transform = crypto_povider.CreateDecryptor();
            byte[] enc_bytes = Convert.FromBase64String(cipher_text);
            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);
            string str = ASCIIEncoding.ASCII.GetString(decrypted_bytes);
            return str;
        }

        FinancialSystem ParseData(string dataJson) => JsonSerializer.Deserialize<FinancialSystem>(dataJson);






        public FinancialSystem LoadDataFromFile2()
        {
            // Decrypting file
            byte[] MyFile = File.ReadAllBytes(_filePath);
            byte[] NewFile = Crypt(MyFile);

            String tempDecryptedFileName = _filePath + "temp";
            File.WriteAllBytes(tempDecryptedFileName, NewFile);

            var newjsonliststring = File.ReadAllText(tempDecryptedFileName);
            var finSystem = JsonSerializer.Deserialize<FinancialSystem>(newjsonliststring);
            File.Delete(tempDecryptedFileName);

            //            var newjsonliststring = File.ReadAllText(_filePath);
            //            Banks = JsonSerializer.Deserialize<Dictionary<Guid, Bank>>(newjsonliststring);
            return finSystem;

        }

        public void StoreDataToFile2(FinancialSystem finSystem)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(finSystem, finSystem.GetType(), options);
            File.WriteAllText(_filePath, jsonString);

            //Encrypting

            byte[] MyFile = File.ReadAllBytes(_filePath);
            byte[] NewFile = Crypt(MyFile);

            String tempEncryptedFileName = _filePath + "temp";
            File.WriteAllBytes(tempEncryptedFileName, NewFile);

            File.Delete(_filePath);
            File.Copy(tempEncryptedFileName, _filePath);
            File.Delete(tempEncryptedFileName);
        }

        private byte[] Crypt(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] ^= 1;
            return bytes;
        }

    }
}
