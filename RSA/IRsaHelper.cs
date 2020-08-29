using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSA_Angular_.NET_CORE.RSA
{
    public interface IRsaHelper
    {
        string Encrypt(string text);
        string Decrypt(string encrypted);

    }
}
