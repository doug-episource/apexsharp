namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PhotoInput
    {
        // infrastructure
        public PhotoInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PhotoInput));
            }
        }

        // API
        object cropSize
        {
            get
            {
                return Self.cropSize;
            }
            set
            {
                Self.cropSize = value;
            }
        }

        object cropX
        {
            get
            {
                return Self.cropX;
            }
            set
            {
                Self.cropX = value;
            }
        }

        object cropY
        {
            get
            {
                return Self.cropY;
            }
            set
            {
                Self.cropY = value;
            }
        }

        object fileId
        {
            get
            {
                return Self.fileId;
            }
            set
            {
                Self.fileId = value;
            }
        }

        object versionNumber
        {
            get
            {
                return Self.versionNumber;
            }
            set
            {
                Self.versionNumber = value;
            }
        }

        public PhotoInput()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
