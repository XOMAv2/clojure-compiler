using System;

namespace ClojureCompiler.Exceptions
{
    /// <summary>
    /// Thrown during parsing if the language rules are not satisfied.
    /// </summary>
    [Serializable]
    public class ArityException : Exception
    {
        public ArityException()
        { }

        public ArityException(string message)
            : base(message)
        { }

        public ArityException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
