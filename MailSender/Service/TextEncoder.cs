using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MailSender.Service
{
    public static class TextEncoder
    {
        /// <summary>
        /// Кодирование текста
        /// </summary>
        /// <param name="text">введите текст</param>
        /// <param name="key">ключ для кодирования</param>
        /// <returns></returns>
        public static string Encoder(this string text, int key=1)
        {
            return new string(text.Select(c => (char)(c + key)).ToArray());
        }          

        /// <summary>
        /// Раскодирование текста
        /// </summary>
        /// <param name="text">введите текст</param>
        /// <param name="key">ключ для раскодирования</param>
        /// <returns></returns>
        public static string Decoder(this string text, int key = 1)
        {
            return new string(text.Select(c => (char)(c - key)).ToArray());
        }

    }
}
