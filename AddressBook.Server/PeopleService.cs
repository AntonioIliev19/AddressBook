using AddressBook.Server.Modals;

public class PeopleService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PeopleService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IEnumerable<object>> GetPeopleAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetFromJsonAsync<Root>("https://randomuser.me/api/?results=36&exc=login");

        if (response == null)
        {
            return Enumerable.Empty<object>();
        }

        return response.Results.Select(p => new
        {
            FullName = new
            {
                p.Name.Title,
                p.Name.First,
                p.Name.Last
            },
            Phone = p.Phone,
            Email = p.Email,
            Location = new
            {
                p.Location.City,
                p.Location.State,
                p.Location.Country,
            },
            Picture = new
            {
                p.Picture.Large,
                p.Picture.Medium,
                p.Picture.Thumbnail,
            }
        });
    }
}
