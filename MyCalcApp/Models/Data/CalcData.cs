using static MyCalcApp.Categories.MyCategory;

namespace MyCalcApp.Models.Data
{
    /// <summary>
    /// 計算用モデルクラス(操作データ)
    /// </summary>
    public class CalcData
    {
        public string PrevValue { get; set; } = "";   //前の項
        public EnumCommandType2 Operation { get; set; } = EnumCommandType2.Other;  //演算子
        public string NextValue { get; set; } = "";   //次の項

    }
}
