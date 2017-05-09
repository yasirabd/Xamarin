using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;
using System.Diagnostics;
using Catalog_Movie.Data;
using Catalog_Movie.Models;
using System.Text.RegularExpressions;

namespace Catalog_Movie.Data
{
    public class RestService : IRestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task RefreshDataAsync()
        {
            var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                //  Debug.WriteLine(uri);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    XDocument xmlFile = XDocument.Parse(content);
                    var query = from c in xmlFile.Descendants("item") select c;
                    foreach (XElement book in query)
                    {
                        //Debug.WriteLine("Judul: " + book.Element("title").Value);
                        //Debug.WriteLine("link: " + book.Element("link").Value);
                        //Debug.WriteLine("pubDate: " + book.Element("pubDate").Value);
                        //Debug.WriteLine("category: " + book.Element("category").Value);
                        //Debug.WriteLine("guid: " + book.Element("guid").Value);
                        //Debug.WriteLine("Des: " + RemoveHtmlTags(book.Element("description").Value));

                        Movie movie = new Movie();
                        movie.Title = book.Element("title").Value;
                        movie.Link2 = book.Element("link").Value;
                        movie.PubDate = book.Element("pubDate").Value;
                        movie.Category = book.Element("category").Value;
                        movie.Guid = book.Element("guid").Value;
                        movie.Description = RemoveHtmlTags(book.Element("description").Value);

                        string image = (string)("<xml>" + IgnoreHtmlTags(book.Element("description").Value) + "</xml>");
                        XElement xe = XElement.Parse(image);
                        var query2 = from c in xe.Descendants("img") select c;
                        foreach (XElement book2 in query2)
                        {
                            Debug.WriteLine("Image: " + book2.Attribute("src").Value);
                            movie.ImageUrl = book2.Attribute("src").Value;
                        }
                        Movie.All.Add(movie);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Kesalahan {0}", ex.Message);
            }
        }


        string RemoveHtmlTags(string html)
        {
            return Regex.Replace(html, "<.+?>", string.Empty);
        }


        // mengambil
        string IgnoreHtmlTags(string html)
        {
            MatchCollection mc = Regex.Matches(html, "<.+?>");
            string data = "";
            foreach (Match m in mc)
            {
                data += m.Value;
            }
            return data;
        }
    }
}
