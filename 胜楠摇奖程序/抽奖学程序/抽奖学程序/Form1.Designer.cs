namespace 抽奖学程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_NAME = new System.Windows.Forms.Label();
            this.lab_prize = new System.Windows.Forms.Label();
            this.btn_START = new System.Windows.Forms.Button();
            this.btn_END = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_NAME
            // 
            this.lab_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_NAME.AutoSize = true;
            this.lab_NAME.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_NAME.Location = new System.Drawing.Point(117, 59);
            this.lab_NAME.Name = "lab_NAME";
            this.lab_NAME.Size = new System.Drawing.Size(170, 70);
            this.lab_NAME.TabIndex = 0;
            this.lab_NAME.Text = "name";
            this.lab_NAME.Click += new System.EventHandler(this.NAME_Click);
            // 
            // lab_prize
            // 
            this.lab_prize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_prize.AutoSize = true;
            this.lab_prize.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_prize.Location = new System.Drawing.Point(552, 64);
            this.lab_prize.Name = "lab_prize";
            this.lab_prize.Size = new System.Drawing.Size(205, 70);
            this.lab_prize.TabIndex = 1;
            this.lab_prize.Text = "prize";
            // 
            // btn_START
            // 
            this.btn_START.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_START.AutoSize = true;
            this.btn_START.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_START.Location = new System.Drawing.Point(60, 286);
            this.btn_START.Name = "btn_START";
            this.btn_START.Size = new System.Drawing.Size(277, 134);
            this.btn_START.TabIndex = 2;
            this.btn_START.Text = "开始";
            this.btn_START.UseVisualStyleBackColor = true;
            this.btn_START.Click += new System.EventHandler(this.btn_START_Click);
            // 
            // btn_END
            // 
            this.btn_END.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_END.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_END.Location = new System.Drawing.Point(488, 286);
            this.btn_END.Name = "btn_END";
            this.btn_END.Size = new System.Drawing.Size(320, 134);
            this.btn_END.TabIndex = 3;
            this.btn_END.Text = "停止";
            this.btn_END.UseVisualStyleBackColor = true;
            this.btn_END.Click += new System.EventHandler(this.btn_END_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_number
            // 
            this.lab_number.AutoSize = true;
            this.lab_number.Location = new System.Drawing.Point(422, 111);
            this.lab_number.Name = "lab_number";
            this.lab_number.Size = new System.Drawing.Size(0, 15);
            this.lab_number.TabIndex = 4;
            this.lab_number.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 528);
            this.Controls.Add(this.lab_number);
            this.Controls.Add(this.btn_END);
            this.Controls.Add(this.btn_START);
            this.Controls.Add(this.lab_prize);
            this.Controls.Add(this.lab_NAME);
            this.Name = "Form1";
            this.Text = "马胜楠的摇奖小程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_NAME;
        private System.Windows.Forms.Label lab_prize;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Button btn_END;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_number;
    }
}

