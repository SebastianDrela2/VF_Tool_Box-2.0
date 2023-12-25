using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_App
{
    public partial class Form2 : Form
    {
        public string result_string { get; set; }

        public string time_string { get; set; }
   
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void TXT_BOX_WORKERS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
                    }

        private void BTN_RESULT_Click(object sender, EventArgs e)
        {
            int result_int = int.Parse(result_string);
          

            TXT_BOX_WORKERS.Text = (result_int / 85).ToString();
            TXT_BOX_FURBS.Text = (result_int / 1700).ToString();
            TXT_BOX_FANGS.Text = (result_int / 6000).ToString();
            TXT_BOX_FIRES.Text = (result_int / 32000).ToString();
            TXT_BOX_SATYRS.Text = (result_int / 200000).ToString();

            LBL_TIME_INF.Text = "Minute Input For " + time_string;

        }
    }
}
