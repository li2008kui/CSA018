using System.Collections.Generic;
using System.Text;

namespace ThisCoder.CSA018
{
    /// <summary>
    /// 字节数组助手类。
    /// </summary>
    public static class ByteArrayHelper
    {
        /// <summary>
        /// 将字节数组转换为十六进制字符串。
        /// </summary>
        /// <param name="value">要转换的字节数组。</param>
        /// <param name="separator">
        /// 分隔符。
        /// <para>默认为空格。</para>
        /// </param>
        /// <returns></returns>
        public static string ToHexString(this byte[] value, string separator = " ")
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in value)
            {
                sb.Append(item.ToString("X2") + separator);
            }

            List<char> trimCharList = new List<char>(separator.ToCharArray());
            trimCharList.AddRange(new char[] { '0', ' ' });
            return sb.ToString().TrimEnd(trimCharList.ToArray());
        }

        /// <summary>
        /// 将字节数组转换为对应的字符串。
        /// </summary>
        /// <param name="value">要转换的字节数组。</param>
        /// <returns></returns>
        public static string ToString2(this byte[] value) => Encoding.UTF8.GetString(value);
    }
}