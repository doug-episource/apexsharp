namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UnsupportedOperationException
    {
        // infrastructure
        public UnsupportedOperationException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UnsupportedOperationException));
            }
        }

        // API
        public UnsupportedOperationException()
        {
            Self = Implementation.Constructor();
        }

        public UnsupportedOperationException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public UnsupportedOperationException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}
