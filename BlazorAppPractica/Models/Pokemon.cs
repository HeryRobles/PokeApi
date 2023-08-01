namespace BlazorAppPractica.Models
{
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    

    public class Root
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Pokemon> results { get; set; }
    }
}