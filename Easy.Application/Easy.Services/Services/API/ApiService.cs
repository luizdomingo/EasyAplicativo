using Easy.Services.Dtos.UserIdentity;
using Easy.Services.Interfaces.API;
using Easy.Services.Shared;
using RestSharp;
using System.Net;

namespace Easy.Services.Services.API
{
    public class ApiService : IApiService
    {
        public async Task<string> Post(string url, object objPost)
        {
            try
            {


                string token = null;
                if (objPost is UsuarioLoginRequest)
                {

                }
                else
                {
                    //if (Globais.UserLogado.AccessToken != null)
                    //    token = Globais.UserLogado.AccessToken;
                }


                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Post);
                request.RequestFormat = DataFormat.Json;


                if (token != null)
                    request.AddHeader("authorization", "Bearer " + token);

                if (objPost != null)
                    request.AddBody(objPost);


                RestResponse response = await client.ExecuteAsync(request);


                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                    return GetStatusCode(response);


            }
            catch (HttpStatusCodeResponseErrors ex)
            {
                throw new HttpStatusCodeResponseErrors(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
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
               // string token = Globais.UserLogado.AccessToken;

                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Put);
                request.RequestFormat = DataFormat.Json;


                //if (token != null)
                //    request.AddHeader("authorization", "Bearer " + token);

                if (objUpdate != null)
                    request.AddBody(objUpdate);


                RestResponse response = await client.ExecuteAsync(request);


                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                    return GetStatusCode(response);


            }
            catch (HttpStatusCodeResponseErrors ex)
            {
                throw new HttpStatusCodeResponseErrors(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
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

                //string token = Globais.UserLogado.AccessToken;

                RestClient client;
                RestRequest request;
                client = new RestClient(url);
                request = new RestRequest(url, Method.Get);
                request.RequestFormat = DataFormat.Json;


                //if (token != null)
                //    request.AddHeader("authorization", "Bearer " + token);

                RestResponse response = await client.ExecuteAsync(request);


                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                    return GetStatusCode(response);


            }
            catch (HttpStatusCodeResponseErrors ex)
            {
                throw new HttpStatusCodeResponseErrors(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GetStatusCode(RestResponse response)
        {
            if (!response.IsSuccessStatusCode)
            {
                switch (response.StatusCode)
                {

                    case HttpStatusCode.NoContent:
                        throw new HttpStatusCodeResponseErrors("No Content");

                    case HttpStatusCode.BadRequest:
                        throw new HttpStatusCodeResponseErrors($"Bad Request: {response.Content}");


                    case HttpStatusCode.Unauthorized:
                        throw new HttpStatusCodeResponseErrors("Sem permisão");

                    case HttpStatusCode.NotFound:
                        throw new HttpStatusCodeResponseErrors($"Not Found- {response.ResponseUri}");

                    case HttpStatusCode.MethodNotAllowed:
                        throw new HttpStatusCodeResponseErrors("Não implementado");

                    case HttpStatusCode.InternalServerError:
                        throw new HttpStatusCodeResponseErrors("Erro no servidor");
                    case HttpStatusCode.NotImplemented:
                        break;
                    case HttpStatusCode.UnsupportedMediaType:
                        throw new HttpStatusCodeResponseErrors(response.Content.ToString());
                    default:
                        throw new HttpStatusCodeResponseErrors(response.ErrorMessage);
                }
            }
            return "Erro não detalhado";
        }

    }
}
