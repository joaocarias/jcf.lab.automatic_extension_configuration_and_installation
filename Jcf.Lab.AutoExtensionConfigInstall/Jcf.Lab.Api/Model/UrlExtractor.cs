namespace Jcf.Lab.Api.Model
{
    public static class UrlExtractor
    {
        public static string? Url { get; private set; } 
        public static DateTime? Date { get; private set; }

        public static void Update(string url){
            Url = url;
            Date = DateTime.Now;

            Console.WriteLine(Print());
        }
        
        public static string Print(){
            var _url = string.IsNullOrEmpty(Url) ? "N/A" : Url;
            var _date = Date is null ? DateTime.Now : Date;
            return $"{_url} - {_date}";
        }
    }
}