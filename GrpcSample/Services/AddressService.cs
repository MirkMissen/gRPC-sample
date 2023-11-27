using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Sample;

namespace GrpcSample.Services; 

public class AddressService : AddressesService.AddressesServiceBase {
    
    public override Task<AddressBook> GetAddressBook(EmptyRequest request, ServerCallContext context) {

        var result = new AddressBook() {
            People = {
                new Person() {
                    Email = "e-mail1",
                    Id = 1,
                    LastUpdated = Timestamp.FromDateTime(DateTime.UtcNow),
                    Name = "Person 1"
                }
            }
        };

        return Task.FromResult(result);
    }
}