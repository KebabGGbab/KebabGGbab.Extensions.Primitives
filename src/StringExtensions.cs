using System.Text;

namespace KebabGGbab.Extensions.Primitives
{
    public static class StringExtensions
    {
        /// <summary>
        /// Преобразовать объект типа string в объект типа Stream.
        /// </summary>
        /// <param name="str">Строка, которая будет преобразована.</param>
        /// <param name="encoding">Кодировка строки. По умолчанию UTF-8.</param>
        /// <returns>Объект типа Stream, содержащий переданную строку.</returns>
        public static Stream ToStream(this string str, Encoding? encoding = null)
        {
            return new MemoryStream((encoding ?? Encoding.UTF8).GetBytes(str));
        }
    }
}
