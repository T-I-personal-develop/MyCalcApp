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
 
    }
}
