using System;
using System.Runtime.Serialization;

namespace ConsoleRPG.Exceptions
{
    [Serializable()]
    public class InvalidArmorException : Exception, ISerializable
    {
        public InvalidArmorException() : base() { }
        public InvalidArmorException(string message) : base(message) { }
        public InvalidArmorException(string message, System.Exception inner) : base(message, inner) { }
        public InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}