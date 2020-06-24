﻿using System;

namespace Arkanoid.Controlador
{
    public class ArgumentOutOfRangeException : Exception
    {
        public ArgumentOutOfRangeException(string Message) : base(Message) { }
    }
}