namespace Hello_World_App.Forms
{
    public partial class WorkerForm : Form
    {
        private const int WorkerHarvest = 85;
        private const int FurbolgHarvest = 1700;
        private const int FangHarvest = 6000;
        private const int FireHarvest = 32000;
        private const int SatyrHarvest = 200000;

        public string Result { get; set; }
        public string Time { get; set; }

        public WorkerForm(string result, string time)
        {
            Result = result;
            Time = time;

            InitializeComponent(); 
            Show();
        }
        
        private void OnResultClicked(object sender, EventArgs e)
        {
            var formulaResult = int.Parse(Result);
            
            _txtBoxWorkers.Text = (formulaResult / WorkerHarvest).ToString();
            _txtBoxFurbs.Text = (formulaResult / FurbolgHarvest).ToString();
            _txtBoxFangs.Text = (formulaResult / FangHarvest).ToString();
            _txtBoxFires.Text = (formulaResult / FireHarvest).ToString();
            _txtBoxSatyrs.Text = (formulaResult / SatyrHarvest).ToString();

            _lblTimeInf.Text = @"Minute Input For " + Time;

        }
    }
}
