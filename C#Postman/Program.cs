using System;
using RestSharp;

namespace HelloWorldApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reqres = new Reqres();
            reqres.ExecuteAllRequests();
        }
    }

    public class Reqres
    {
        public void ExecuteAllRequests()
        {
            GetListOfUsers();
            GetSingleUser();
            GetSingleUserNotFound();
            GetListUnknown();
            GetSingleUnknown();
            GetSingleResourcesNotFound();
            PostCreate();
            PostRegisterSuccessful();
            PostRegisterUnsuccessful();
            PostLoginSuccessful();
            PostLoginUnsuccessful();
            PutUpdate();
        }

        public void GetListOfUsers()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetSingleUser()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetSingleUserNotFound()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/23", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetListUnknown()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetSingleUnknown()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/2", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void GetSingleResourcesNotFound()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/23", Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PostCreate()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""name"": ""morpheus"",
" + "\n" +
                @"    ""job"": ""leader""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PostRegisterSuccessful()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
                @"    ""password"": ""pistol""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PostRegisterUnsuccessful()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""email"": ""sydney@fife""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PostLoginSuccessful()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
                @"    ""password"": ""cityslicka""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PostLoginUnsuccessful()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""email"": ""peter@klaven""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        public void PutUpdate()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
                @"    ""name"": ""morpheus"",
" + "\n" +
                @"    ""job"": ""zion resident""
" + "\n" +
                @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}


        