using MyCalcApp.Compornents;
using MyCalcApp.Libraries;
using MyCalcApp.Models.Data;
using static MyCalcApp.Categories.MyCategory;
using MyCalcApp.Calc.Interfaces;
using MyCalcApp.Calc;

namespace MyCalcApp.Services
{

    /// <summary>
    /// 電卓操作サービスクラス
    /// </summary>
    public class MyCalcService
    {

        List<CalcData> _calcDatas;


        /// <summary>
        /// 操作結果表示Property
        /// </summary>
        public string Display { get; set; } = "";


        public MyCalcService()
        {
            _calcDatas = new List<CalcData>();
        }

        /// <summary>
        /// >小数点の有効桁数５桁までを有効とし、現在の値に新しい値をつなぐ
        /// </summary>
        /// <param name="currentValue">現在の値</param>
        /// <param name="newValue">新しい値</param>
        /// <returns></returns>
        private string GetValue(string currentValue, string newValue)
        {
            int LastDecPoint = currentValue.IndexOf("."); //.のIndex
            int DecPointLength;　　　　　　　　　　　　　 //.より後の桁数
            string strValue = currentValue + newValue; //返す値

            if (LastDecPoint > -1)
            {
                //文字列内に.が含まれる場合
                DecPointLength = currentValue.Substring(currentValue.IndexOf(".")).Length - 1;

                if (newValue == ".")
                {
                    //新しい値が.の場合は新しい値は無効
                    strValue = currentValue;
                }
                else if (DecPointLength >= 5)
                {
                    //小数点有効桁数が5桁になっている場合は新しい値は無効
                    strValue = currentValue;
                }
            }

            return strValue;
        }

        /// <summary>
        /// 電卓操作
        /// </summary>
        /// <param name="button"></param>
        public void CalcOperation(MyCalcButton? button)
        {
            try
            {
                switch (button?.CommandType1)
                {
                    //操作ボタンによる対応
                    case EnumCommandType1.Num:
                        //数値
                        SetNum(button);
                        Display = GetDisplay();
                        MyLog.Info($"数値: {button?.Display ?? ""}, Display: {Display}");
                        break;
                    case EnumCommandType1.ClearEntry:
                        //入力クリア
                        ClearEntry();
                        Display = GetDisplay();
                        MyLog.Info("入力クリア");
                        break;
                    case EnumCommandType1.ClearAll:
                        //全てクリア
                        ClearAll();
                        Display = "";
                        MyLog.Info("全てクリア");
                        break;
                    case EnumCommandType1.Equal:
                        //計算処理

#warning Windows標準の電卓で8*9*=5184とでるが、この8*9*=0となる　この差異の解消を実装できませんでした。確認後適切な処理の実装をお願いします。　
#warning 数値が巨大になった場合、エラーで落ちませんが、途中から0を返します。確認後適切な処理の実装をお願いします。
#warning =を連打した場合の処理のケアができていません（現状は9×8=72=0=0=0となります）確認後適切な処理の実装をお願いします。
 
                        var decResult = Calculate();
                        Display += $"={decResult.ToString("#,##0.#####")}";
                        ClearAll();
                        MyLog.Info($"計算: {button?.Display ?? ""} Display: {Display}");
                        MyLog.Info($"計算結果: {decResult.ToString()} ");
                        break;
                    case EnumCommandType1.Calc:
                        //演算子
                        SetOperation(button);
                        Display = GetDisplay();
                        MyLog.Info($"演算子: {button?.Display ?? ""}, Display: {Display}");
                        break;
                    default:
                        MyLog.Error($"想定外の操作");
                        break;
                }
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// 数値の処理(.)も含む
        /// </summary>
        /// <param name="button"></param>
        private void SetNum(MyCalcButton? button)
        {
            try
            {
                CalcData? lastCalcData;
                string strValue = "";

                if (_calcDatas.Count == 0)
                {
                    //データが無い場合
                    _calcDatas.Add(new CalcData());
                }

                //最後の操作データ
                lastCalcData = _calcDatas.LastOrDefault();

                if (lastCalcData != null)
                {
                    if (lastCalcData?.Operation == EnumCommandType2.Other)
                    {
                        //演算子コマンドの操作が未の場合前の項に値を繋ぐ
                        strValue = GetValue(lastCalcData?.PrevValue ?? "", button?.Display ?? "");
                        lastCalcData!.PrevValue = strValue;
                    }
                    else
                    {
                        //演算子コマンドの操作がありの場合次の項に値を繋ぐ
                        strValue = GetValue(lastCalcData?.NextValue ?? "", button?.Display ?? "");
                        lastCalcData!.NextValue = strValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// 演算子の処理
        /// </summary>
        /// <param name="button"></param>
        private void SetOperation(MyCalcButton button)
        {
            try
            {
                CalcData? lastCalcData;

                if (_calcDatas.Count == 0)
                {
                    //データが無い場合
                    _calcDatas.Add(new CalcData());
                    Display = "";
                }

                //最後の操作データ
                lastCalcData = _calcDatas.LastOrDefault();

                if (lastCalcData?.Operation == EnumCommandType2.Other)
                {
                    lastCalcData.Operation = button.CommandType2;
                }
                else if (!string.IsNullOrEmpty(lastCalcData?.NextValue))
                {
                    //次の項に値がある場合は操作データを追加
                    _calcDatas.Add(new CalcData());
                    lastCalcData = _calcDatas.LastOrDefault();
                    if (lastCalcData != null)
                    {
                        lastCalcData.Operation = button.CommandType2;
                    }
                }
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// 計算処理
        /// </summary>
        private decimal Calculate()
        {
            try
            {
                decimal decResult = 0;
                //計算処理(Totalクラスで処理)
                ICalc calcCommand = new CalcTotal(_calcDatas);
                decResult = calcCommand.Execute();
                return decResult;
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }


        /// <summary>
        /// 全てクリア処理
        /// </summary>
        private void ClearAll()
        {
            try
            {
                _calcDatas.Clear();
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// 入力処理
        /// </summary>
        private void ClearEntry()
        {
            try
            {
                if (_calcDatas.Count > 0)
                {
                    //最後のデータをクリア
                    _calcDatas.RemoveAt(_calcDatas.Count - 1);
                }
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }

        /// <summary>
        /// Labelに表示するテキストを取得
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string GetDisplay()
        {
            try
            {
                string strDisplay = "";
                decimal decRevResult = 0;
                decimal decNextResult = 0;

                foreach (var data in _calcDatas)
                {
                    decRevResult = Common.ConvToDecimal(data.PrevValue, 0);
                    decNextResult = Common.ConvToDecimal(data.NextValue, 0);

#warning Displayの設定処理の対応に課題があります。確認後適切な処理の実装をお願いします。
#warning (①#,##0.#####とすると、9押下で90となる、②#,###.#####とすると0.押下の場合1桁目の0が省かれる。①は明らかにNGなので②の設定を優先しています。)

                    strDisplay += decRevResult.ToString("#,###.#####")
                        + data.Operation.GetDisplayName()
                        + decNextResult.ToString("#,###.#####");
                }

                return strDisplay;
            }
            catch (Exception ex)
            {
                MyLog.Error($"システムエラー: {ex.Message}, 詳細: {ex.StackTrace}");
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
