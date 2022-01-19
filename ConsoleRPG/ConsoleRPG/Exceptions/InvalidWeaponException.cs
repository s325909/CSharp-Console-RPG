using System;
using System.Runtime.Serialization;

namespace ConsoleRPG.Exceptions
{
    [Serializable()]
    public class InvalidWeaponException : Exception, ISerializable
    {
        public InvalidWeaponException() : base() { }
        public InvalidWeaponException(string message) : base(message) { }
        public InvalidWeaponException(string message, System.Exception inner) : base(message, inner) { }
        public InvalidWeaponException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}