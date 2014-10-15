public class Site
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string URL { get; set; }

    public string ImageURL { get; set; }

    public Site(int id, string name, string url, string imageUrl)
    {
        this.Id = id;
        this.Name = name;
        this.URL = url;
        this.ImageURL = imageUrl;
    }
}
