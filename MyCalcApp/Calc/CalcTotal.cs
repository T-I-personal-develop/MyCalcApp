using MyCalcApp.Models.Data;
using MyCalcApp.Calc.Interfaces;
using static MyCalcApp.Categories.MyCategory;

namespace MyCalcApp.Calc
{
    /// <summary>
    /// 計算結果クラス
    /// </summary>
    public class CalcTotal : ICalc
    {
        List<CalcData> _calcDatas;

        public CalcTotal(List<CalcData> calcDatas)
        {
            _calcDatas = calcDatas;
        }

        /// <summary>
        /// 合計処理(×÷優先は考慮しない)
        /// </summary>
        /// <returns></returns>
        public decimal Execute()
        {
            decimal decResult = 0;
            ICalc calcCommand;

            foreach (var data in _calcDatas)
            {
                if (string.IsNullOrEmpty(data.PrevValue))
                {
                    //前の項の入力がない場合:今までの処理結果をitem.PrevValueに設定
                    data.PrevValue = decResult.ToString();
                    decResult = 0;
                }
                switch (data.Operation)
                {
                    case EnumCommandType2.Add:
                        // +の場合
                        calcCommand = new CalcAdd(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Substract:
                        // -の場合
                        calcCommand = new CalcSubstract(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Multiply:
                        // *の場合
                        calcCommand = new CalcMultiply(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Divide:
                        // (/)の場合
                        calcCommand = new CalcDivide(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    default:
                        break;
                }
            }

            return decResult;
        }
    }
}
