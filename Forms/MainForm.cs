namespace Hello_World_App.Forms
{
    public partial class MainForm : Form
    {
        private const int CometPrice = 125000;
        private const int GoldMinePrice = 12000;
        public MainForm()
        {
            InitializeComponent();
        }

        private int GetFormulaResult(int woodAmount, int timeAmount) => 2 * woodAmount + (timeAmount - 1) * woodAmount / 2 * timeAmount;

        private void SetUiResult(int formulaResult, int goldMines, int comets)
        {
            _txtBoxResult.Text = formulaResult.ToString();
            _txtBoxGoldMines.Text = goldMines.ToString();
            _txtBoxComets.Text = comets.ToString();
        }
        
        private void OnCalculateClicked(object sender, EventArgs e)
        {
            var woodAmount = int.Parse(_txtBoxWood.Text);
            var timeAmount = int.Parse(_txtBoxTime.Text);
            
            if (woodAmount == 0 || timeAmount == 0 || _txtBoxWood.Text == "")
            {
                MessageBox.Show(@"ERROR: Please Input Correct Values");
            }
            else
            {
                var formulaResult = GetFormulaResult(woodAmount, timeAmount);

                var goldMines = formulaResult / GoldMinePrice;
                var comets = formulaResult / CometPrice;

                SetUiResult(formulaResult, goldMines, comets);
            }
        }

        private void OnWorkerFormClicked(object sender, EventArgs e)
        {
            _ = new WorkerForm(_txtBoxResult.Text, _txtBoxTime.Text);
        }
    }
}