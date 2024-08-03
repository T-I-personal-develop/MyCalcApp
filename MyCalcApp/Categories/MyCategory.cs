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
        public enum EnumCommandType
        {
            Num,        //数値
            Add,    //＋
            Substract,//―
            Multiply,//×
            Divide,//÷
            ClearAll,   //全てクリア
            ClearEntry, //入力クリア
            Equal,      //計算
        }
    
    }
}
