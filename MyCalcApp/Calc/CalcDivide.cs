using MyCalcApp.Calc.Interfaces;
using MyCalcApp.Libraries;

namespace MyCalcApp.Calc
{
    /// <summary>
    /// 除算クラス
    /// </summary>
    public class CalcDivide : ICalc
    {
        private readonly decimal _prevValue;　//前の項
        private readonly decimal _nextValue;   //次の項

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="prevValue">前の項</param>
        /// <param name="thisValue">今回の項</param>
        public CalcDivide(decimal prevValue, decimal nextValue)
        {
            _prevValue = prevValue;
            _nextValue = nextValue;
        }

        public CalcDivide(string prevValue, string nextValue)
        {
            _prevValue = Common.ConvToDecimal(prevValue, 0);
            _nextValue = Common.ConvToDecimal(nextValue, 0);
        }

        /// <summary>
        /// 除算処理
        /// </summary>
        /// <returns></returns>
        public decimal Execute()
        {
#warning 0で割る場合の処理　今回は0を返します、ご確認お願いします。

            if (_nextValue != 0)
            {
                return _prevValue / _nextValue;
            }
            {
                return 0;
            }
        }
    }
}