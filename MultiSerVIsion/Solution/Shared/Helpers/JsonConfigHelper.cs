using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.Helpers
{
    public static class JsonConfigHelper
    {
        public static JsonSerializerOptions GetDefaultOptions()
        {
            return new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNameCaseInsensitive = true,
            };
        }
        public static readonly JsonSerializerOptions Default=GetDefaultOptions();
    }
}
