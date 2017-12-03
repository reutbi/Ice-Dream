namespace IceDream
{
    partial class incomeOutcome
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incomeOutcome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSumOut = new System.Windows.Forms.Label();
            this.lbl_sumOut = new System.Windows.Forms.Label();
            this.lblSumIn = new System.Windows.Forms.Label();
            this.lbl_sumIn = new System.Windows.Forms.Label();
            this.lbl_Incomes = new System.Windows.Forms.Label();
            this.dgvOutcomes = new System.Windows.Forms.DataGridView();
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.lbl_Outcomes = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.send_mail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.emailTxeBox = new System.Windows.Forms.TextBox();
            this.printDialog_Report = new System.Windows.Forms.PrintDialog();
            this.printDoc_Report = new System.Drawing.Printing.PrintDocument();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lbl_IS = new System.Windows.Forms.Label();
            this.gbCuurentBalance = new System.Windows.Forms.GroupBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            this.gbCuurentBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSumOut);
            this.groupBox1.Controls.Add(this.lbl_sumOut);
            this.groupBox1.Controls.Add(this.lblSumIn);
            this.groupBox1.Controls.Add(this.lbl_sumIn);
            this.groupBox1.Controls.Add(this.lbl_Incomes);
            this.groupBox1.Controls.Add(this.dgvOutcomes);
            this.groupBox1.Controls.Add(this.dgvIncomes);
            this.groupBox1.Controls.Add(this.lbl_Outcomes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(296, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(960, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מאזן הכנסות/הוצאות";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(627, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 180;
            this.label5.Text = "₪";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(144, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 179;
            this.label4.Text = "₪";
            // 
            // lblSumOut
            // 
            this.lblSumOut.AutoSize = true;
            this.lblSumOut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOut.ForeColor = System.Drawing.Color.Red;
            this.lblSumOut.Location = new System.Drawing.Point(174, 434);
            this.lblSumOut.Name = "lblSumOut";
            this.lblSumOut.Size = new System.Drawing.Size(26, 29);
            this.lblSumOut.TabIndex = 7;
            this.lblSumOut.Text = "0";
            // 
            // lbl_sumOut
            // 
            this.lbl_sumOut.AutoSize = true;
            this.lbl_sumOut.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumOut.ForeColor = System.Drawing.Color.Red;
            this.lbl_sumOut.Location = new System.Drawing.Point(237, 434);
            this.lbl_sumOut.Name = "lbl_sumOut";
            this.lbl_sumOut.Size = new System.Drawing.Size(154, 29);
            this.lbl_sumOut.TabIndex = 6;
            this.lbl_sumOut.Text = "סיכום הוצאות:";
            // 
            // lblSumIn
            // 
            this.lblSumIn.AutoSize = true;
            this.lblSumIn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumIn.ForeColor = System.Drawing.Color.Green;
            this.lblSumIn.Location = new System.Drawing.Point(657, 434);
            this.lblSumIn.Name = "lblSumIn";
            this.lblSumIn.Size = new System.Drawing.Size(26, 29);
            this.lblSumIn.TabIndex = 5;
            this.lblSumIn.Text = "0";
            // 
            // lbl_sumIn
            // 
            this.lbl_sumIn.AutoSize = true;
            this.lbl_sumIn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumIn.ForeColor = System.Drawing.Color.Green;
            this.lbl_sumIn.Location = new System.Drawing.Point(720, 434);
            this.lbl_sumIn.Name = "lbl_sumIn";
            this.lbl_sumIn.Size = new System.Drawing.Size(157, 29);
            this.lbl_sumIn.TabIndex = 4;
            this.lbl_sumIn.Text = "סיכום הכנסות:";
            // 
            // lbl_Incomes
            // 
            this.lbl_Incomes.AutoSize = true;
            this.lbl_Incomes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Incomes.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Incomes.Location = new System.Drawing.Point(679, 43);
            this.lbl_Incomes.Name = "lbl_Incomes";
            this.lbl_Incomes.Size = new System.Drawing.Size(87, 29);
            this.lbl_Incomes.TabIndex = 2;
            this.lbl_Incomes.Text = "הכנסות";
            // 
            // dgvOutcomes
            // 
            this.dgvOutcomes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvOutcomes.AllowDrop = true;
            this.dgvOutcomes.AllowUserToAddRows = false;
            this.dgvOutcomes.AllowUserToDeleteRows = false;
            this.dgvOutcomes.AllowUserToResizeColumns = false;
            this.dgvOutcomes.AllowUserToResizeRows = false;
            this.dgvOutcomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutcomes.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvOutcomes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutcomes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOutcomes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutcomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutcomes.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutcomes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOutcomes.Location = new System.Drawing.Point(15, 87);
            this.dgvOutcomes.MultiSelect = false;
            this.dgvOutcomes.Name = "dgvOutcomes";
            this.dgvOutcomes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutcomes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOutcomes.RowHeadersVisible = false;
            this.dgvOutcomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgvOutcomes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOutcomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOutcomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOutcomes.Size = new System.Drawing.Size(457, 335);
            this.dgvOutcomes.TabIndex = 1;
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvIncomes.AllowDrop = true;
            this.dgvIncomes.AllowUserToAddRows = false;
            this.dgvIncomes.AllowUserToDeleteRows = false;
            this.dgvIncomes.AllowUserToResizeColumns = false;
            this.dgvIncomes.AllowUserToResizeRows = false;
            this.dgvIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncomes.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvIncomes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIncomes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvIncomes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncomes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIncomes.Location = new System.Drawing.Point(490, 87);
            this.dgvIncomes.MultiSelect = false;
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncomes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIncomes.RowHeadersVisible = false;
            this.dgvIncomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgvIncomes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIncomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIncomes.Size = new System.Drawing.Size(457, 335);
            this.dgvIncomes.TabIndex = 0;
            // 
            // lbl_Outcomes
            // 
            this.lbl_Outcomes.AutoSize = true;
            this.lbl_Outcomes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Outcomes.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Outcomes.Location = new System.Drawing.Point(195, 43);
            this.lbl_Outcomes.Name = "lbl_Outcomes";
            this.lbl_Outcomes.Size = new System.Drawing.Size(84, 29);
            this.lbl_Outcomes.TabIndex = 3;
            this.lbl_Outcomes.Text = "הוצאות";
            // 
            // btnResetData
            // 
            this.btnResetData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetData.BackColor = System.Drawing.Color.Transparent;
            this.btnResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnResetData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnResetData.Image = ((System.Drawing.Image)(resources.GetObject("btnResetData.Image")));
            this.btnResetData.Location = new System.Drawing.Point(101, 511);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(102, 106);
            this.btnResetData.TabIndex = 3;
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(101, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 106);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // send_mail
            // 
            this.send_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.send_mail.BackColor = System.Drawing.Color.Transparent;
            this.send_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.send_mail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.send_mail.Image = ((System.Drawing.Image)(resources.GetObject("send_mail.Image")));
            this.send_mail.Location = new System.Drawing.Point(101, 243);
            this.send_mail.Name = "send_mail";
            this.send_mail.Size = new System.Drawing.Size(102, 106);
            this.send_mail.TabIndex = 5;
            this.send_mail.UseVisualStyleBackColor = false;
            this.send_mail.Click += new System.EventHandler(this.send_mail_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(97, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "איפוס נתונים";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "הדפס דו\"ח";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "שלח למייל";
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.BackColor = System.Drawing.Color.HotPink;
            this.back_btn.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(100, 654);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(152, 75);
            this.back_btn.TabIndex = 173;
            this.back_btn.Text = "חזור";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // emailTxeBox
            // 
            this.emailTxeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTxeBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.emailTxeBox.Location = new System.Drawing.Point(44, 186);
            this.emailTxeBox.Name = "emailTxeBox";
            this.emailTxeBox.Size = new System.Drawing.Size(222, 29);
            this.emailTxeBox.TabIndex = 174;
            // 
            // printDialog_Report
            // 
            this.printDialog_Report.UseEXDialog = true;
            // 
            // printDoc_Report
            // 
            this.printDoc_Report.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_Report_PrintPage);
            // 
            // lblMailTo
            // 
            this.lblMailTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.BackColor = System.Drawing.Color.Transparent;
            this.lblMailTo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblMailTo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMailTo.Location = new System.Drawing.Point(132, 152);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(134, 22);
            this.lblMailTo.TabIndex = 175;
            this.lblMailTo.Text = ":הזן כתובת מייל";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Balance.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Balance.Location = new System.Drawing.Point(158, 36);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Balance.Size = new System.Drawing.Size(183, 34);
            this.lbl_Balance.TabIndex = 176;
            this.lbl_Balance.Text = "המאזן הנוכחי:";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentBalance.Location = new System.Drawing.Point(110, 36);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentBalance.Size = new System.Drawing.Size(31, 34);
            this.lblCurrentBalance.TabIndex = 177;
            this.lblCurrentBalance.Text = "0";
            // 
            // lbl_IS
            // 
            this.lbl_IS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_IS.AutoSize = true;
            this.lbl_IS.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_IS.Location = new System.Drawing.Point(71, 36);
            this.lbl_IS.Name = "lbl_IS";
            this.lbl_IS.Size = new System.Drawing.Size(39, 34);
            this.lbl_IS.TabIndex = 178;
            this.lbl_IS.Text = "₪";
            // 
            // gbCuurentBalance
            // 
            this.gbCuurentBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCuurentBalance.BackColor = System.Drawing.Color.Transparent;
            this.gbCuurentBalance.Controls.Add(this.lbl_Balance);
            this.gbCuurentBalance.Controls.Add(this.lblCurrentBalance);
            this.gbCuurentBalance.Controls.Add(this.lbl_IS);
            this.gbCuurentBalance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuurentBalance.Location = new System.Drawing.Point(895, 623);
            this.gbCuurentBalance.Name = "gbCuurentBalance";
            this.gbCuurentBalance.Size = new System.Drawing.Size(361, 85);
            this.gbCuurentBalance.TabIndex = 179;
            this.gbCuurentBalance.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(95, 56);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(57, 29);
            this.lblClock.TabIndex = 180;
            this.lblClock.Text = "שעון";
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 1000;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // incomeOutcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::IceDream.Properties.Resources.ice_team_background_with_logo_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1268, 741);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblMailTo);
            this.Controls.Add(this.emailTxeBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send_mail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.gbCuurentBalance);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "incomeOutcome";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income/Outcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.incomeOutcome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            this.gbCuurentBalance.ResumeLayout(false);
            this.gbCuurentBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIncomes;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button send_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dgvOutcomes;
        private System.Windows.Forms.Label lbl_Outcomes;
        private System.Windows.Forms.Label lbl_Incomes;
        private System.Windows.Forms.TextBox emailTxeBox;
        private System.Windows.Forms.PrintDialog printDialog_Report;
        private System.Drawing.Printing.PrintDocument printDoc_Report;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label lblSumOut;
        private System.Windows.Forms.Label lbl_sumOut;
        private System.Windows.Forms.Label lblSumIn;
        private System.Windows.Forms.Label lbl_sumIn;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lbl_IS;
        private System.Windows.Forms.GroupBox gbCuurentBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer_Clock;
    }
}

