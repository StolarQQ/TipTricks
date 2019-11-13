using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TipTricks")]
namespace FriendlyAssembly
{
    internal class Friend1
    {
        public string RandomString => "Hello world";
    }
}
