﻿namespace TMS_HomeWork12;

internal class WrongPasswordException : Exception
{
    public WrongPasswordException() : base() { }
    public WrongPasswordException(string message) : base(message) { }
  
}
