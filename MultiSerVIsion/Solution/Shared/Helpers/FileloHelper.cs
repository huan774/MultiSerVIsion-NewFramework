using MultiSerVIsion.Solution.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.Helpers
{
    public static class FileloHelper
    {
        private static readonly object _fileLock=new object();

        public static T ReadJsonFile<T>(string filePath, JsonSerializerOptions options)
        {
            lock (_fileLock)
            {
                try
                {
                    if (!File.Exists(filePath))
                        return Activator.CreateInstance<T>();

                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<T>(json, options);
                }
                catch (IOException ex)
                {

                    throw new StorageIoException(filePath, ex.Message);
                }
            }
        }

        public static void WriteJsonFile<T>(string filePath, T data, JsonSerializerOptions options = null)
        {
            lock (_fileLock)
            {
                try
                {
                    string dir = Path.GetDirectoryName(filePath);
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    string json = JsonSerializer.Serialize(data, options ?? new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                }
                catch (IOException ex)
                {
                    throw new StorageIoException(filePath, ex.Message);
                }
                ;
            }
        }
    }
}
