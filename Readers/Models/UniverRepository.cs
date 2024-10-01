using RestSharp;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Readers.Models
{
    public class UniverRepository
    {
        private RestClient _restClient;

        private string baseUrl = "http://libapi.gubkin.ru/lib";

        private UniverContext _univerContext;

        private static UniverRepository instance;
        public static UniverRepository getInstance()
        {
            if (instance is null)
                instance = new UniverRepository();

            return instance;
        }

        public UniverRepository()
        {
            _univerContext = new UniverContext();
        }

        public StudentUniver GetStudent(string code)
        {
            _restClient = new RestClient(baseUrl + $"/get.php?cardcode={code}&model=z2");
            var request = new RestRequest();
            var response = _restClient.Get(request);
            var student = JsonSerializer.Deserialize<StudentUniver>(response.Content!)!;

            return student;
        }
    }
}
