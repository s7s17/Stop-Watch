namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lb_time = new Label();
            btn_start = new Button();
            btn_stop = new Button();
            btn_record = new Button();
            btn_reset = new Button();
            lv_records = new ListView();
            Records = new ColumnHeader();
            lb_caption = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Location = new Point(129, 113);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(26, 20);
            lb_time.TabIndex = 0;
            lb_time.Text = "0.0";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(23, 247);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(82, 29);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(172, 247);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(82, 29);
            btn_stop.TabIndex = 2;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_record
            // 
            btn_record.Enabled = false;
            btn_record.Location = new Point(23, 318);
            btn_record.Name = "btn_record";
            btn_record.Size = new Size(82, 29);
            btn_record.TabIndex = 3;
            btn_record.Text = "Record";
            btn_record.UseVisualStyleBackColor = true;
            btn_record.Click += btn_record_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(172, 318);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(82, 29);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // lv_records
            // 
            lv_records.Columns.AddRange(new ColumnHeader[] { Records });
            lv_records.GridLines = true;
            lv_records.Location = new Point(410, 113);
            lv_records.Name = "lv_records";
            lv_records.Size = new Size(185, 230);
            lv_records.TabIndex = 7;
            lv_records.UseCompatibleStateImageBehavior = false;
            lv_records.View = View.Details;
            // 
            // Records
            // 
            Records.Text = "Records";
            Records.Width = 160;
            // 
            // lb_caption
            // 
            lb_caption.AutoSize = true;
            lb_caption.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_caption.ForeColor = SystemColors.ControlText;
            lb_caption.Location = new Point(282, 9);
            lb_caption.Name = "lb_caption";
            lb_caption.Size = new Size(210, 48);
            lb_caption.TabIndex = 8;
            lb_caption.Text = "stopWatch";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(lb_caption);
            Controls.Add(lv_records);
            Controls.Add(btn_reset);
            Controls.Add(btn_record);
            Controls.Add(btn_stop);
            Controls.Add(btn_start);
            Controls.Add(lb_time);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "stopWatch Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lb_time;
        private Button btn_start;
        private Button btn_stop;
        private Button btn_record;
        private Button btn_reset;
        private ListView lv_records;
        private ColumnHeader Records;
        private Label lb_caption;
    }
}
