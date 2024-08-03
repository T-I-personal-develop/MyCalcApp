using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcApp.Categories
{
    /// <summary>
    /// カテゴリクラス
    /// </summary>
    public class MyCategory
    {
        /// <summary>
        /// コマンドタイプ大項目
        /// </summary>
        public enum EnumCommandType1
        {
            Num,        //数値
            Calc,       //演算子
            ClearAll,   //全てクリア
            ClearEntry, //入力クリア
            Equal,      //計算
        }

        /// <summary>
        /// コマンドタイプ小項目
        /// </summary>
        public enum EnumCommandType2
        {
            Other,　//演算子でない場合
            Add,    //＋
            Substract,//―
            Multiply,//×
            Divide,//÷

        }
    }
}
