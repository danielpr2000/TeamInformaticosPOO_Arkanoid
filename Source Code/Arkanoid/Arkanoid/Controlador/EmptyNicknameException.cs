﻿using System;

namespace Arkanoid.Controlador
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string Message) : base(Message) { }
    }
    
}
    