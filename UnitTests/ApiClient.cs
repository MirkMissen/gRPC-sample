using Microsoft.AspNetCore.Mvc.Testing;
using Sample;

namespace UnitTests; 

public class ApiClient {

    public static readonly ApiClient Instance = new ApiClient();

    public readonly AddressesService.AddressesServiceClient Client;

    private ApiClient() {

        var factory = new WebApplicationFactory<Program>();
        var options = new Grpc.Net.Client.GrpcChannelOptions() {
            HttpHandler = factory.Server.CreateHandler()
        };

        var channel = Grpc.Net.Client.GrpcChannel.ForAddress(factory.Server.BaseAddress, options);
        Client = new AddressesService.AddressesServiceClient(channel);
    }

}