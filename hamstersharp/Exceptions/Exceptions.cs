using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamstersharp.Exceptions.Auth
{
    public class InvalidTokenException : Exception
    {
        public InvalidTokenException() : base("The token is invalid or expired.") { }
    }
    public class NullResponseContent : Exception
    {
        public NullResponseContent(int statuscode) : base($"The status code did not indicate success ({statuscode}) or the response content was null.") { }
    }
}
namespace hamstersharp.Exceptions.System
{
    public class ParsingException : Exception
    {
        public ParsingException() : base("The returned content could not be parsed. This is usually a package error, please open an issue.") { }
    }
}