namespace DateTimeSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudMonthBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbBeforeAfterDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLeapYearDisp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBirthYear = new System.Windows.Forms.NumericUpDown();
            this.nudBirthMonth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudBirthDay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDayCountDisp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btDayCount = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNow.Location = new System.Drawing.Point(32, 35);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(140, 39);
            this.btNow.TabIndex = 0;
            this.btNow.Text = "現在日時";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(197, 35);
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.Size = new System.Drawing.Size(422, 39);
            this.tbNowDisp.TabIndex = 1;
            // 
            // nudMonthBeforeAfter
            // 
            this.nudMonthBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonthBeforeAfter.Location = new System.Drawing.Point(198, 107);
            this.nudMonthBeforeAfter.Name = "nudMonthBeforeAfter";
            this.nudMonthBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudMonthBeforeAfter.TabIndex = 2;
            this.nudMonthBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(323, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ヵ月";
            // 
            // btBefore
            // 
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBefore.Location = new System.Drawing.Point(197, 172);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(86, 52);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfter.Location = new System.Drawing.Point(298, 172);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(86, 52);
            this.btAfter.TabIndex = 4;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbBeforeAfterDisp
            // 
            this.tbBeforeAfterDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBeforeAfterDisp.Location = new System.Drawing.Point(197, 241);
            this.tbBeforeAfterDisp.Name = "tbBeforeAfterDisp";
            this.tbBeforeAfterDisp.Size = new System.Drawing.Size(422, 39);
            this.tbBeforeAfterDisp.TabIndex = 1;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(395, 107);
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudDayBeforeAfter.TabIndex = 2;
            this.nudDayBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(521, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "日";
            // 
            // tbLeapYearDisp
            // 
            this.tbLeapYearDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYearDisp.Location = new System.Drawing.Point(197, 298);
            this.tbLeapYearDisp.Name = "tbLeapYearDisp";
            this.tbLeapYearDisp.Size = new System.Drawing.Size(422, 39);
            this.tbLeapYearDisp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(61, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "誕生日";
            // 
            // nudBirthYear
            // 
            this.nudBirthYear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudBirthYear.Location = new System.Drawing.Point(290, 411);
            this.nudBirthYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudBirthYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudBirthYear.Name = "nudBirthYear";
            this.nudBirthYear.Size = new System.Drawing.Size(120, 39);
            this.nudBirthYear.TabIndex = 2;
            this.nudBirthYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBirthYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudBirthMonth
            // 
            this.nudBirthMonth.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudBirthMonth.Location = new System.Drawing.Point(468, 411);
            this.nudBirthMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBirthMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthMonth.Name = "nudBirthMonth";
            this.nudBirthMonth.Size = new System.Drawing.Size(120, 39);
            this.nudBirthMonth.TabIndex = 2;
            this.nudBirthMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBirthMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(415, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "年";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(594, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "月";
            // 
            // nudBirthDay
            // 
            this.nudBirthDay.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudBirthDay.Location = new System.Drawing.Point(647, 411);
            this.nudBirthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudBirthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthDay.Name = "nudBirthDay";
            this.nudBirthDay.Size = new System.Drawing.Size(120, 39);
            this.nudBirthDay.TabIndex = 2;
            this.nudBirthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBirthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(773, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(204, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "西暦";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(206, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "生まれてから";
            // 
            // tbDayCountDisp
            // 
            this.tbDayCountDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayCountDisp.Location = new System.Drawing.Point(384, 481);
            this.tbDayCountDisp.Name = "tbDayCountDisp";
            this.tbDayCountDisp.Size = new System.Drawing.Size(204, 39);
            this.tbDayCountDisp.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(594, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "日目です。";
            // 
            // btDayCount
            // 
            this.btDayCount.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCount.Location = new System.Drawing.Point(32, 474);
            this.btDayCount.Name = "btDayCount";
            this.btDayCount.Size = new System.Drawing.Size(168, 52);
            this.btDayCount.TabIndex = 4;
            this.btDayCount.Text = "日数計算";
            this.btDayCount.UseVisualStyleBackColor = true;
            this.btDayCount.Click += new System.EventHandler(this.btDayCount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(48, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "閏年判定";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 595);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btDayCount);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudBirthDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudBirthMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBirthYear);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.nudMonthBeforeAfter);
            this.Controls.Add(this.tbLeapYearDisp);
            this.Controls.Add(this.tbDayCountDisp);
            this.Controls.Add(this.tbBeforeAfterDisp);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudMonthBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbBeforeAfterDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLeapYearDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBirthYear;
        private System.Windows.Forms.NumericUpDown nudBirthMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBirthDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDayCountDisp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btDayCount;
        private System.Windows.Forms.Label label10;
    }
}

