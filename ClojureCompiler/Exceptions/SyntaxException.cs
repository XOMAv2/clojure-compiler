using System;

namespace ClojureCompiler.Exceptions
{
    /// <summary>
    /// Thrown during parsing if the language rules are not satisfied.
    /// </summary>
    [Serializable]
    public class SyntaxException : Exception
    {
        public SyntaxException()
        { }

        public SyntaxException(string message)
            : base(message)
        { }

        public SyntaxException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
