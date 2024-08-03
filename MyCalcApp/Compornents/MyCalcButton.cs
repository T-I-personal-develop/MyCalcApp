using System.ComponentModel;
using static MyCalcApp.Categories.MyCategory;

namespace MyCalcApp.Compornents
{
   
    public class MyCalcButton : Button
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("表示するボタン名")]
        public string? Display
        {
            get => this.Text;
            set => this.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("ボタンのコマンドタイプ(大項目)")]
        public EnumCommandType1 CommandType1 { get; set; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("ボタンのコマンドタイプ(小項目)")]
        public EnumCommandType2 CommandType2 { get; set; }
     
    }
}
