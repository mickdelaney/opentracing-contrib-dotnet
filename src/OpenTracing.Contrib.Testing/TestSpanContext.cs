using System;
using System.Collections.Generic;

namespace OpenTracing.Contrib.Testing
{
    public class TestSpanContext : ISpanContext
    {
        private readonly IDictionary<string, string> _baggage;

        public TestSpanContext(IDictionary<string, string> baggage = null)
        {
            _baggage = baggage ?? new Dictionary<string, string>();
        }

        public void SetBaggageItem(string key, string value)
        {
            _baggage[key] = value;
        }

        public string GetBaggageItem(string key)
        {
            if (key == null)
                throw new ArgumentNullException();

            string value;
            _baggage.TryGetValue(key, out value);
            return value;
        }

        public IEnumerable<KeyValuePair<string, string>> GetBaggageItems()
        {
            return _baggage;
        }
    }
}