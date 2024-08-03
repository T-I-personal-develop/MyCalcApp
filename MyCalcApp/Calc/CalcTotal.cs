using MyCalcApp.Libraries;
using MyCalcApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                }
                switch (data.Operation)
                {
                    case EnumCommandType2.Add:
                        calcCommand = new CalcAdd(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Substract:
                        calcCommand = new CalcSubstract(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Multiply:
                        calcCommand = new CalcMultiply(data.PrevValue, data.NextValue);
                        decResult += calcCommand.Execute();
                        break;
                    case EnumCommandType2.Divide:
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
