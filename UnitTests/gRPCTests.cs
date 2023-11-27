using Sample;

namespace UnitTests; 

public class GRpcTests {

    [Fact]
    async Task shouldGetPhoneBook() {

        var api = ApiClient.Instance;

        var response = await api.Client.GetAddressBookAsync(new EmptyRequest());

        Assert.NotEmpty(response.People);
    }
    
}