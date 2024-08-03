using MyCalcApp.Compornents;
using MyCalcApp.Services;

namespace MyCalcApp
{
    public partial class MainForm : Form
    {
        public MyCalcService _clsMain;

        public MainForm()
        {
            InitializeComponent();
            _clsMain = new MyCalcService();
            ButtonClickMain();
        }
        private void ButtonClickMain()
        {
            try
            {

                foreach (var calcBtn in this.Controls.OfType<MyCalcButton>())
                {
                    ButtonClickSub(calcBtn);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void ButtonClickSub(MyCalcButton button)
        {
            try
            {
                button.Click += (sender, e) => Button_Click(button, e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void Button_Click(MyCalcButton button, EventArgs e)
        {
            try
            {
                _clsMain.CalcOperation(button);
                lblDisplay.Text = _clsMain.Display;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
