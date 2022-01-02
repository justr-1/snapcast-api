using System;

namespace justr.SnapcastApi.Exceptions;

class SnapcastApiException : Exception
{
    public SnapcastApiException(string message) : base(message) { }
}
