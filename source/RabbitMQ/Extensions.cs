using System.Text;
using System.Text.Json;

namespace RabbitMQ
{
    public static class Extensions
    {
        public static byte[] Bytes(this object obj)
        {
            return Encoding.Default.GetBytes(JsonSerializer.Serialize(obj));
        }

        public static T Object<T>(this byte[] bytes)
        {
            return JsonSerializer.Deserialize<T>(Encoding.Default.GetString(bytes));
        }
    }
}
