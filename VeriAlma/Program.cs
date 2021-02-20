using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";
            var data = HttpHelper.GetDataFromApi<List<Post>>(apiUrl).Result;
            Console.WriteLine(data);
        }
    }
}