namespace Hello_World_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LBL_WORKERS = new System.Windows.Forms.Label();
            this.TXT_BOX_WORKERS = new System.Windows.Forms.TextBox();
            this.LBL_FURBS = new System.Windows.Forms.Label();
            this.TXT_BOX_FURBS = new System.Windows.Forms.TextBox();
            this.LBL_FANGS = new System.Windows.Forms.Label();
            this.TXT_BOX_FANGS = new System.Windows.Forms.TextBox();
            this.LBL_FIRES = new System.Windows.Forms.Label();
            this.TXT_BOX_FIRES = new System.Windows.Forms.TextBox();
            this.LBL_SATYRS = new System.Windows.Forms.Label();
            this.TXT_BOX_SATYRS = new System.Windows.Forms.TextBox();
            this.BTN_RESULT = new System.Windows.Forms.Button();
            this.LBL_TIME_INF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_WORKERS
            // 
            this.LBL_WORKERS.AutoSize = true;
            this.LBL_WORKERS.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_WORKERS.Location = new System.Drawing.Point(32, 22);
            this.LBL_WORKERS.Name = "LBL_WORKERS";
            this.LBL_WORKERS.Size = new System.Drawing.Size(67, 15);
            this.LBL_WORKERS.TabIndex = 0;
            this.LBL_WORKERS.Text = "Workers";
            // 
            // TXT_BOX_WORKERS
            // 
            this.TXT_BOX_WORKERS.Enabled = false;
            this.TXT_BOX_WORKERS.Location = new System.Drawing.Point(12, 40);
            this.TXT_BOX_WORKERS.Name = "TXT_BOX_WORKERS";
            this.TXT_BOX_WORKERS.Size = new System.Drawing.Size(100, 23);
            this.TXT_BOX_WORKERS.TabIndex = 1;
            this.TXT_BOX_WORKERS.TextChanged += new System.EventHandler(this.TXT_BOX_WORKERS_TextChanged);
            // 
            // LBL_FURBS
            // 
            this.LBL_FURBS.AutoSize = true;
            this.LBL_FURBS.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_FURBS.Location = new System.Drawing.Point(32, 78);
            this.LBL_FURBS.Name = "LBL_FURBS";
            this.LBL_FURBS.Size = new System.Drawing.Size(69, 15);
            this.LBL_FURBS.TabIndex = 2;
            this.LBL_FURBS.Text = "Furbolgs";
            // 
            // TXT_BOX_FURBS
            // 
            this.TXT_BOX_FURBS.Enabled = false;
            this.TXT_BOX_FURBS.Location = new System.Drawing.Point(12, 105);
            this.TXT_BOX_FURBS.Name = "TXT_BOX_FURBS";
            this.TXT_BOX_FURBS.Size = new System.Drawing.Size(100, 23);
            this.TXT_BOX_FURBS.TabIndex = 3;
            // 
            // LBL_FANGS
            // 
            this.LBL_FANGS.AutoSize = true;
            this.LBL_FANGS.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_FANGS.Location = new System.Drawing.Point(12, 141);
            this.LBL_FANGS.Name = "LBL_FANGS";
            this.LBL_FANGS.Size = new System.Drawing.Size(115, 15);
            this.LBL_FANGS.TabIndex = 4;
            this.LBL_FANGS.Text = "Fang Harvesters";
            // 
            // TXT_BOX_FANGS
            // 
            this.TXT_BOX_FANGS.Enabled = false;
            this.TXT_BOX_FANGS.Location = new System.Drawing.Point(12, 169);
            this.TXT_BOX_FANGS.Name = "TXT_BOX_FANGS";
            this.TXT_BOX_FANGS.Size = new System.Drawing.Size(100, 23);
            this.TXT_BOX_FANGS.TabIndex = 5;
            // 
            // LBL_FIRES
            // 
            this.LBL_FIRES.AutoSize = true;
            this.LBL_FIRES.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_FIRES.Location = new System.Drawing.Point(170, 22);
            this.LBL_FIRES.Name = "LBL_FIRES";
            this.LBL_FIRES.Size = new System.Drawing.Size(120, 15);
            this.LBL_FIRES.TabIndex = 6;
            this.LBL_FIRES.Text = "Fire Deforesters";
            // 
            // TXT_BOX_FIRES
            // 
            this.TXT_BOX_FIRES.Enabled = false;
            this.TXT_BOX_FIRES.Location = new System.Drawing.Point(166, 40);
            this.TXT_BOX_FIRES.Name = "TXT_BOX_FIRES";
            this.TXT_BOX_FIRES.Size = new System.Drawing.Size(100, 23);
            this.TXT_BOX_FIRES.TabIndex = 7;
            // 
            // LBL_SATYRS
            // 
            this.LBL_SATYRS.AutoSize = true;
            this.LBL_SATYRS.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_SATYRS.Location = new System.Drawing.Point(193, 88);
            this.LBL_SATYRS.Name = "LBL_SATYRS";
            this.LBL_SATYRS.Size = new System.Drawing.Size(52, 15);
            this.LBL_SATYRS.TabIndex = 8;
            this.LBL_SATYRS.Text = "Satyrs";
            // 
            // TXT_BOX_SATYRS
            // 
            this.TXT_BOX_SATYRS.Enabled = false;
            this.TXT_BOX_SATYRS.Location = new System.Drawing.Point(166, 106);
            this.TXT_BOX_SATYRS.Name = "TXT_BOX_SATYRS";
            this.TXT_BOX_SATYRS.Size = new System.Drawing.Size(100, 23);
            this.TXT_BOX_SATYRS.TabIndex = 9;
            // 
            // BTN_RESULT
            // 
            this.BTN_RESULT.Location = new System.Drawing.Point(193, 182);
            this.BTN_RESULT.Name = "BTN_RESULT";
            this.BTN_RESULT.Size = new System.Drawing.Size(102, 41);
            this.BTN_RESULT.TabIndex = 10;
            this.BTN_RESULT.Text = "CALCULATE";
            this.BTN_RESULT.UseVisualStyleBackColor = true;
            this.BTN_RESULT.Click += new System.EventHandler(this.BTN_RESULT_Click);
            // 
            // LBL_TIME_INF
            // 
            this.LBL_TIME_INF.AutoSize = true;
            this.LBL_TIME_INF.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_TIME_INF.Location = new System.Drawing.Point(321, 88);
            this.LBL_TIME_INF.Name = "LBL_TIME_INF";
            this.LBL_TIME_INF.Size = new System.Drawing.Size(107, 15);
            this.LBL_TIME_INF.TabIndex = 11;
            this.LBL_TIME_INF.Text = "AWAITING INPUT";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 235);
            this.Controls.Add(this.LBL_TIME_INF);
            this.Controls.Add(this.BTN_RESULT);
            this.Controls.Add(this.TXT_BOX_SATYRS);
            this.Controls.Add(this.LBL_SATYRS);
            this.Controls.Add(this.TXT_BOX_FIRES);
            this.Controls.Add(this.LBL_FIRES);
            this.Controls.Add(this.TXT_BOX_FANGS);
            this.Controls.Add(this.LBL_FANGS);
            this.Controls.Add(this.TXT_BOX_FURBS);
            this.Controls.Add(this.LBL_FURBS);
            this.Controls.Add(this.TXT_BOX_WORKERS);
            this.Controls.Add(this.LBL_WORKERS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Worker Tab";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LBL_WORKERS;
        private TextBox TXT_BOX_WORKERS;
        private Label LBL_FURBS;
        private TextBox TXT_BOX_FURBS;
        private Label LBL_FANGS;
        private TextBox TXT_BOX_FANGS;
        private Label LBL_FIRES;
        private TextBox TXT_BOX_FIRES;
        private Label LBL_SATYRS;
        private TextBox TXT_BOX_SATYRS;
        private Button BTN_RESULT;
        private Label LBL_TIME_INF;
    }
}