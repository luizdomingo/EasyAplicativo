using Easy.Services.Dtos.UserIdentity;
using Easy.Services.Interfaces.API;
using Easy.Services.Shared;
using RestSharp;

namespace Easy.Services.Services.API
{
    public class ApiService : IApiService
    {
        public async Task<string> Post(string url, object objPost)
        {
            try
            {

                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Post);
                request.RequestFormat = DataFormat.Json;


                if (objPost is UsuarioLoginRequest)
                {

                }
                else
                {
                    request.AddHeader("authorization", "Bearer " + Globais.GetToken());
                }

                if (objPost != null)
                    request.AddBody(objPost);


                RestResponse response = await client.ExecuteAsync(request);
                if (response.StatusCode == 0)
                {
                    throw new Exception(response.ErrorMessage);
                }
                return response.Content;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Put(string url, object objUpdate)
        {
            try
            {

                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Put);
                request.RequestFormat = DataFormat.Json;

                string token = Globais.GetToken();
                if (token != null)
                    request.AddHeader("authorization", "Bearer " + token);


                if (objUpdate != null)
                    request.AddBody(objUpdate);


                RestResponse response = await client.ExecuteAsync(request);
                if (response.StatusCode == 0)
                {
                    throw new Exception(response.ErrorMessage);
                }

                return response.Content;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Get(string url)
        {
            try
            {

                string token = Globais.GetToken();

                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Get);
                request.RequestFormat = DataFormat.Json;


                if (token != null)
                    request.AddHeader("authorization", "Bearer " + token);

                RestResponse response = await client.ExecuteAsync(request);
                if (response.StatusCode == 0)
                {
                    throw new Exception(response.ErrorMessage);
                }

                return response.Content;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
