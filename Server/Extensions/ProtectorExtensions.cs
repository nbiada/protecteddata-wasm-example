using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ProtectedDataWasmExample.Server.Extensions
{
    public class LookupProtector : ILookupProtector
    {
        public string Protect(string keyId, string data)
        {
            return new string(data?.Reverse().ToArray());
        }

        public string Unprotect(string keyId, string data)
        {
            return new string(data?.Reverse().ToArray());
        }
    }

    public class PersonalDataProtector : IPersonalDataProtector
    {
        public string Protect(string data)
        {
            return new string(data?.Reverse().ToArray());
        }

        public string Unprotect(string data)
        {
            return new string(data?.Reverse().ToArray());
        }
    }

    public class KeyRing : ILookupProtectorKeyRing
    {
        public string this[string keyId] => "key";

        public string CurrentKeyId => "key";

        public IEnumerable<string> GetAllKeyIds()
        {
            return new string[] { "key" };
        }
    }
}
