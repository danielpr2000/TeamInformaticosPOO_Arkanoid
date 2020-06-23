using System;

namespace Arkanoid.Controlador
{
    public class ExceededMaxCharactersException : Exception
    {
        public ExceededMaxCharactersException(string Message) : base(Message) { }
    }
}