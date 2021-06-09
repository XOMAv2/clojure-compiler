using System;

namespace ClojureCompiler.Exceptions
{
    /// <summary>
    /// Thrown during parsing if the language rules are not satisfied.
    /// </summary>
    [Serializable]
    public class TypeCastException : Exception
    {
        public TypeCastException()
        { }

        public TypeCastException(string message)
            : base(message)
        { }

        public TypeCastException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
