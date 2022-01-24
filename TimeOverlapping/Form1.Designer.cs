namespace TimeOverlapping
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tse_start1 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.tse_end1 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tse_end2 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tse_start2 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_count = new System.Windows.Forms.Button();
            this.tse_result = new DevExpress.XtraEditors.TimeSpanEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tse_start1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_end1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tse_end2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_start2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_result.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "END";
            // 
            // tse_start1
            // 
            this.tse_start1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tse_start1.Location = new System.Drawing.Point(66, 22);
            this.tse_start1.Name = "tse_start1";
            this.tse_start1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tse_start1.Size = new System.Drawing.Size(100, 20);
            this.tse_start1.TabIndex = 3;
            // 
            // tse_end1
            // 
            this.tse_end1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tse_end1.Location = new System.Drawing.Point(66, 48);
            this.tse_end1.Name = "tse_end1";
            this.tse_end1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tse_end1.Size = new System.Drawing.Size(100, 20);
            this.tse_end1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tse_end1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tse_start1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAIN TIME SPAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tse_end2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tse_start2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SECONDARY TIME SPAN";
            // 
            // tse_end2
            // 
            this.tse_end2.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tse_end2.Location = new System.Drawing.Point(66, 48);
            this.tse_end2.Name = "tse_end2";
            this.tse_end2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tse_end2.Size = new System.Drawing.Size(100, 20);
            this.tse_end2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "START";
            // 
            // tse_start2
            // 
            this.tse_start2.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tse_start2.Location = new System.Drawing.Point(66, 22);
            this.tse_start2.Name = "tse_start2";
            this.tse_start2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tse_start2.Size = new System.Drawing.Size(100, 20);
            this.tse_start2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "END";
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(12, 101);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(406, 23);
            this.btn_count.TabIndex = 7;
            this.btn_count.Text = "COUNT";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // tse_result
            // 
            this.tse_result.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tse_result.Location = new System.Drawing.Point(178, 130);
            this.tse_result.Name = "tse_result";
            this.tse_result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tse_result.Size = new System.Drawing.Size(100, 20);
            this.tse_result.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 158);
            this.Controls.Add(this.tse_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TIME OVERLAPPING";
            ((System.ComponentModel.ISupportInitialize)(this.tse_start1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_end1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tse_end2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_start2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tse_result.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TimeSpanEdit tse_start1;
        private DevExpress.XtraEditors.TimeSpanEdit tse_end1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TimeSpanEdit tse_end2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TimeSpanEdit tse_start2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_count;
        private DevExpress.XtraEditors.TimeSpanEdit tse_result;
        private System.Windows.Forms.Label label5;
    }
}

