using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcApp.Libraries
{
    public static class Common
    {
        /// <summary>
        /// int型に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue">変換できない場合に置き換える値</param>
        /// <returns></returns>
        public static int ConvToInt(object? value, int defaultValue)
        {
            if (value != null)
            {
                if (int.TryParse(value.ToString(), out int result))
                {
                    return result;
                }
            }

            return defaultValue;
        }


        /// <summary>
        /// Decimal型に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue">変換できない場合に置き換える値</param>
        /// <returns></returns>
        public static decimal ConvToDecimal(object? value, decimal defaultValue = 0)
        {
            if (value != null)
            {
                if (decimal.TryParse(value.ToString(), out decimal result))
                {
                    return result;
                }
            }

            return defaultValue;
        }

        /// <summary>
        /// string型に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue">変換できない場合に置き換える値</param>
        /// <returns></returns>
        public static string ConvToString(object? value, string defaultValue = "")
        {
            return value?.ToString() ?? defaultValue;

        }

        /// <summary>
        /// DateTime型に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue">変換できない場合に置き換える値</param>
        /// <returns></returns>
        public static DateTime ConvToDate(object? value, DateTime defaultValue)
        {
            if (value != null)
            {
                if (DateTime.TryParse(value.ToString(), out DateTime result))
                {
                    return result;
                }
            }

            return defaultValue;
        }

        /// <summary>
        /// 空のファイルを作成
        /// </summary>
        /// <param name="path">出力ファイルのパス</param>
        /// <param name="enc">Encoding</param>
        /// <exception cref="Exception"></exception>
        public static void WriteEmptyFile(string path, System.Text.Encoding enc)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (var streamWriter = new StreamWriter(path, false, enc))
                    {
                        // エンコードを指定して空のファイルを作成
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        /// <summary>
        /// 文字列をファイルに書き込む
        /// </summary>
        /// <param name="path">出力ファイルのパス</param>
        /// <param name="text">書き込む文字列</param>
        /// <param name="enc">Encoding</param>
        /// <param name="append">true:追加、false:新規</param>
        /// <exception cref="Exception"></exception>
        public static void WriteTxt(string path, string text, bool append, System.Text.Encoding enc)
        {

            try
            {
                if (File.Exists(path))
                {
                    using (var streamWriter = new StreamWriter(path, append, enc))
                    {
                        streamWriter.WriteLine(text);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Enum型のDisplay属性を返す
        /// </summary>
        /// <param name="enumValue">対象の値</param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var enumName = enumValue.ToString();
            var member = enumType.GetMember(enumName).FirstOrDefault();
            var displayAttribute = member?.GetCustomAttribute<DisplayAttribute>();

            // Display属性が設定されている場合、そのNameプロパティを返す。設定されていない場合はEmpty。
            return displayAttribute?.Name ?? "";
        }

    }
}
