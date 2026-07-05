using MultiSerVIsion.Solution.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

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
                        /* return Activator.CreateInstance<T>();*/
                        throw new FileNotFoundException("存储文件不存在", filePath);

                    string json = File.ReadAllText(filePath);
                    var result=JsonSerializer.Deserialize<T>(json, options ?? JsonConfigHelper.Default);

                    if (result == null)
                        throw new JsonException("JSON文件解析失败，数据格式异常");
                    
                   return result;
                }
                catch (IOException ex)
                {
                    throw new StorageIoException(filePath, ex.Message);
                }
                catch (JsonException ex)
                {
                    throw new StorageIoException(filePath, $"JSON解析异常：{ex.Message}");
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

                    var serializeOpt=options ?? JsonConfigHelper.Default;
                    string json=JsonSerializer.Serialize(data,serializeOpt);
                    
                    File.WriteAllText(filePath, json);
                }
                catch (IOException ex)
                {
                    throw new StorageIoException(filePath, ex.Message);
                }
                
            }
        }
    }
}
