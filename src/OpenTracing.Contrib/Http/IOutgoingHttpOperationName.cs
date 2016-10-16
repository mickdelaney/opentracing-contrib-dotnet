using System.Net.Http;

namespace OpenTracing.Contrib.Http
{
    /// <summary>
    /// Derives an operation name from an HTTP request message.
    /// </summary>
    public interface IOutgoingHttpOperationName
    {
        /// <summary>
        /// Derives an operation name from an HTTP request message.
        /// </summary>
        string GetOperationName(HttpRequestMessage request);
    }
}