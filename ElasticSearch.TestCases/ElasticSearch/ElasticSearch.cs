using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticSearchSolution
{
    public class ElasticSearch
    {
        ElasticClient client = null;
        public ElasticSearch()
        {
            var uri = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(uri);
            client = new ElasticClient(settings);
            settings.DefaultIndex("hotel");
        }
        public List<Hotel> GetResult()
        {
            if (client.IndexExists("hotel").Exists)
            {
                var response = client.Search<Hotel>();
                return response.Documents.ToList();
            }
            return null;
        }

        public List<Hotel> GetResult(string condition)
        {
            if (client.IndexExists("hotel").Exists)
            {
                var query = condition;

                return client.SearchAsync<Hotel>(s => s
                .From(0)
                .Take(10)
                .Query(qry => qry
                    .Bool(b => b
                        .Must(m => m
                            .QueryString(qs => qs
                                .DefaultField("_all")
                                .Query(query)))))).Result.Documents.ToList();
            }
            return null;
        }

        public void AddNewIndex(Hotel hotel)
        {
            client.IndexAsync<Hotel>(hotel, null);
        }
    }
}
