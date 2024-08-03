using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalcApp.Calc.Interfaces;
using MyCalcApp.Libraries;

namespace MyCalcApp.Calc
{
    /// <summary>
    /// 乗算クラス
    /// </summary>
    internal class CalcMultiply : ICalc
    {
        private readonly decimal _prevValue;　//前の項
        private readonly decimal _nextValue;   //次の項

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="prevValue">前の項</param>
        /// <param name="thisValue">今回の項</param>
        public CalcMultiply(decimal prevValue, decimal nextValue)
        {
            _prevValue = prevValue;
            _nextValue = nextValue;
        }

        /// <summary>
        /// 乗算処理
        /// </summary>
        /// <returns></returns>
        public decimal Execute()
        {
            return _prevValue * _nextValue;
        }
    }
}
