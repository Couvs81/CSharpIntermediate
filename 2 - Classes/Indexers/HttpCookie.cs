namespace Indexers
{
    // Indexers are a way to access elements in a class that represents a list of values
    // e.g. array, List
    // array[0] = 1

    // Indexer needed for classes with collection semantics (such as the HTTP cookie class)

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
