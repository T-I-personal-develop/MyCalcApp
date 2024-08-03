using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyCalcApp.Categories.MyCategory;

namespace MyCalcApp.Models.Data
{
    /// <summary>
    /// 計算用モデルクラス(操作データ)
    /// </summary>
    public class CalcData
    {
        public decimal PrevValue { get; set; } = 0;   //前の項
        public EnumCommandType2 Operation { get; set; } = EnumCommandType2.Other;  //演算子
        public decimal NextValue { get; set; } = 0;   //次の項

    }
}
