namespace Brutus
{
    partial class ConditionalEventEditor
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
            this.ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pauseTimelineCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstValueBox = new System.Windows.Forms.RichTextBox();
            this.secondValueBox = new System.Windows.Forms.RichTextBox();
            this.ExecuteInputBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomCommandCheck = new System.Windows.Forms.CheckBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition";
            // 
            // ConditionComboBox
            // 
            this.ConditionComboBox.FormattingEnabled = true;
            this.ConditionComboBox.Items.AddRange(new object[] {
            "If True",
            "If False",
            "If Greater",
            "If Less",
            "If Equal",
            "If Greater or Equal",
            "If Less or Equal"});
            this.ConditionComboBox.Location = new System.Drawing.Point(69, 16);
            this.ConditionComboBox.Name = "ConditionComboBox";
            this.ConditionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ConditionComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pause Timeline";
            // 
            // pauseTimelineCheck
            // 
            this.pauseTimelineCheck.AutoSize = true;
            this.pauseTimelineCheck.Checked = true;
            this.pauseTimelineCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseTimelineCheck.Location = new System.Drawing.Point(281, 19);
            this.pauseTimelineCheck.Name = "pauseTimelineCheck";
            this.pauseTimelineCheck.Size = new System.Drawing.Size(15, 14);
            this.pauseTimelineCheck.TabIndex = 3;
            this.pauseTimelineCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Element/Value 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Element/Value 2";
            // 
            // firstValueBox
            // 
            this.firstValueBox.Location = new System.Drawing.Point(15, 71);
            this.firstValueBox.Name = "firstValueBox";
            this.firstValueBox.Size = new System.Drawing.Size(281, 49);
            this.firstValueBox.TabIndex = 6;
            this.firstValueBox.Text = "";
            // 
            // secondValueBox
            // 
            this.secondValueBox.Location = new System.Drawing.Point(15, 139);
            this.secondValueBox.Name = "secondValueBox";
            this.secondValueBox.Size = new System.Drawing.Size(281, 49);
            this.secondValueBox.TabIndex = 7;
            this.secondValueBox.Text = "";
            // 
            // ExecuteInputBox
            // 
            this.ExecuteInputBox.Enabled = false;
            this.ExecuteInputBox.Location = new System.Drawing.Point(15, 232);
            this.ExecuteInputBox.Name = "ExecuteInputBox";
            this.ExecuteInputBox.Size = new System.Drawing.Size(281, 88);
            this.ExecuteInputBox.TabIndex = 8;
            this.ExecuteInputBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Function";
            // 
            // CustomCommandCheck
            // 
            this.CustomCommandCheck.AutoSize = true;
            this.CustomCommandCheck.Location = new System.Drawing.Point(15, 194);
            this.CustomCommandCheck.Name = "CustomCommandCheck";
            this.CustomCommandCheck.Size = new System.Drawing.Size(111, 17);
            this.CustomCommandCheck.TabIndex = 10;
            this.CustomCommandCheck.Text = "Custom Command";
            this.CustomCommandCheck.UseVisualStyleBackColor = true;
            this.CustomCommandCheck.CheckedChanged += new System.EventHandler(this.CustomCommandCheck_CheckedChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(15, 327);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(281, 34);
            this.SubmitBtn.TabIndex = 11;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ConditionalEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 373);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.CustomCommandCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExecuteInputBox);
            this.Controls.Add(this.secondValueBox);
            this.Controls.Add(this.firstValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pauseTimelineCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConditionComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ConditionalEventEditor";
            this.Text = "ConditionalEventEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConditionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox pauseTimelineCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox firstValueBox;
        private System.Windows.Forms.RichTextBox secondValueBox;
        private System.Windows.Forms.RichTextBox ExecuteInputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CustomCommandCheck;
        private System.Windows.Forms.Button SubmitBtn;
    }
}