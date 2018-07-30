using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace HeroExplorer.Models
{
    public class MarvelFacade
    {
        private const string PrivateKey = "3d4dd2b4e243c385face9e4e03bca9a7ade0c5ba";
        private const string PublicKey = "c071117ff67703709baa3ea7952beb73";
        private const int MaxCharacters = 1500;


        public static async Task<CharacterDataWrapper> GetCharacterListAsync()
        {
            var offset = new Random().Next(MaxCharacters);
            var timeStamp = DateTime.Now.Ticks.ToString();
            string url = String.Format($"https://gateway.marvel.com:443/v1/public/characters?offset={offset}&apikey={PublicKey}&ts={timeStamp}&hash={CreateHash(timeStamp)}");
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));
            return serializer.ReadObject(ms) as CharacterDataWrapper;
            //var data = JsonConvert.DeserializeObject<CharacterDataWrapper>(jsonMessage);
        }

        private static string CreateHash(string timeStamp) => ComputeMD5(timeStamp + PrivateKey + PublicKey);

        private static string ComputeMD5(string str)
        {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);
            return res;
        }
    }
}
