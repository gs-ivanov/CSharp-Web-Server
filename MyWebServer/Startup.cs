namespace MyWebServer
{
    using MyWebServer.Server;
    using MyWebServer.Server.Responses;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Startup
    {
        static void Map(string s)
        {
            Console.WriteLine(s);
        }

        static void Map2(Action<string> action)
        {
            Console.WriteLine(action());
        }
        public static async Task Main()
        {
            Action<string> action = new Action<string>(Map);

            action("KKKKKKKk");

            // Action<string> a =new Action<string>Map2;
            Map2();

            List<int> integers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int num in integers.Where(n => n % 2 == 0).ToList())
            {
                //Console.WriteLine(num);
            }

            int[] integersB = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int num in integers.Where(n =>
                {
                    if (n % 2 == 0)
                        return true;
                    return false;
                }
            ))
                Console.WriteLine(num);

        

            //() => Console.WriteLine(9999);

            //Action<string> action = new Action<string>(Map);
            return;
            var objG = new GttpServer(r => r
              //.MapGet("/", new TextResponse("Hello from Ivo!"))
              .MapGet("/Cats", request =>
             {
                 const string nameKey = "Name";

                 var query = request.Query;

                 var catName = query.ContainsKey(nameKey)
                     ? query[nameKey]
                     : "the cats";

                 var result = $"<h1>Hello from {catName}!</h1>";

                 return new HtmlResponse(result);
             })
            );
            var obj = new HttpServer(r => r
            //.MapGet("/", new TextResponse("Hello from Ivo!"))
            .MapGet("/Cats", request =>
                {
                    const string nameKey = "Name";

                    var query = request.Query;

                    var catName = query.ContainsKey(nameKey)
                        ? query[nameKey]
                        : "the cats";

                    var result = $"<h1>Hello from {catName}!</h1>";

                    return new HtmlResponse(result);
                })
            );
        }
        //=> await new HttpServer(routes => routes
        //    .MapGet("/", new TextResponse("Hello from Ivo!"))
        //    .MapGet("/Cats", request =>
        //    {
        //        const string nameKey = "Name";

        //        var query = request.Query;

        //        var catName = query.ContainsKey(nameKey)
        //            ? query[nameKey]
        //            : "the cats";

        //        var result = $"<h1>Hello from {catName}!</h1>";

        //        return new HtmlResponse(result);
        //    })
        //    .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
        //.Start();
    }
}
