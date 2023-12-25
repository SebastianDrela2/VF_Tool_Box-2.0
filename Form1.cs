namespace Hello_World_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void TXT_BOX_WOOD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void LBL_RESULT_Click(object sender, EventArgs e)
        {

        }

        private void TXT_BOX_RESULT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_BOT_TIME_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CALCULATE_Click(object sender, EventArgs e)
        {
            var wood = TXT_BOX_WOOD.Text;
            var time = TXT_BOT_TIME_1.Text;
            
                  var wood_int = int.Parse(wood);
                  var time_int = int.Parse(time);
                  if (wood_int == 100 && time_int == 100)
                  {
                      Close();
                  }
            if (wood_int == 0 || time_int == 0 || TXT_BOX_WOOD.Text == "")
            {
                MessageBox.Show("ERROR: Please Input Correct Values");
            }
            else
            {
                int result = 2 * wood_int + (time_int - 1) * wood_int / 2 * time_int;
                int gold_mines = result / 12000;
                int comets = result / 125000;
                TXT_BOX_RESULT.Text = result.ToString();
                TXT_BOX_GOLDMINES.Text = gold_mines.ToString();
                TXT_BOX_COMETS.Text = comets.ToString();
            }
        }

        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_OPEN_WORKER_FORM_Click(object sender, EventArgs e)
        {
            Form2 win2 = new Form2();
            win2.Show();
            win2.result_string = TXT_BOX_RESULT.Text;
            win2.time_string = TXT_BOT_TIME_1.Text;
            
           
        }
    }
}