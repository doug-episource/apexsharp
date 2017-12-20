namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SerializationException : Exception
    {
        // infrastructure
        public SerializationException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SerializationException));
            }
        }

        // API
        public SerializationException()
        {
            Self = Implementation.Constructor();
        }

        public SerializationException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SerializationException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public SerializationException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
