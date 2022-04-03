namespace Brutus
{
    partial class EventEditor
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
            this.FunctionComB = new System.Windows.Forms.ComboBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loopCB = new System.Windows.Forms.CheckBox();
            this.LoopCount = new System.Windows.Forms.NumericUpDown();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.ItemHTMLTxt = new System.Windows.Forms.RichTextBox();
            this.refCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemIndex = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoopCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionComB
            // 
            this.FunctionComB.FormattingEnabled = true;
            this.FunctionComB.Items.AddRange(new object[] {
            "Click",
            "String Input"});
            this.FunctionComB.Location = new System.Drawing.Point(67, 7);
            this.FunctionComB.Name = "FunctionComB";
            this.FunctionComB.Size = new System.Drawing.Size(121, 21);
            this.FunctionComB.TabIndex = 1;
            this.FunctionComB.Text = "Click";
            this.FunctionComB.SelectionChangeCommitted += new System.EventHandler(this.FunctionComB_SelectionChangeCommitted);
            // 
            // InputBox
            // 
            this.InputBox.Enabled = false;
            this.InputBox.Location = new System.Drawing.Point(12, 145);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(301, 171);
            this.InputBox.TabIndex = 2;
            this.InputBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Function:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loop:";
            // 
            // loopCB
            // 
            this.loopCB.AutoSize = true;
            this.loopCB.Location = new System.Drawing.Point(231, 10);
            this.loopCB.Name = "loopCB";
            this.loopCB.Size = new System.Drawing.Size(15, 14);
            this.loopCB.TabIndex = 6;
            this.loopCB.UseVisualStyleBackColor = true;
            this.loopCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoopCount
            // 
            this.LoopCount.Enabled = false;
            this.LoopCount.Location = new System.Drawing.Point(253, 7);
            this.LoopCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LoopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopCount.Name = "LoopCount";
            this.LoopCount.Size = new System.Drawing.Size(62, 20);
            this.LoopCount.TabIndex = 7;
            this.LoopCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(79, 322);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(234, 38);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input Text:";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(9, 40);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(71, 15);
            this.label90.TabIndex = 10;
            this.label90.Text = "Item HTML:";
            // 
            // ItemHTMLTxt
            // 
            this.ItemHTMLTxt.Location = new System.Drawing.Point(12, 68);
            this.ItemHTMLTxt.Name = "ItemHTMLTxt";
            this.ItemHTMLTxt.Size = new System.Drawing.Size(301, 56);
            this.ItemHTMLTxt.TabIndex = 11;
            this.ItemHTMLTxt.Text = "<Class = >";
            // 
            // refCB
            // 
            this.refCB.FormattingEnabled = true;
            this.refCB.Items.AddRange(new object[] {
            "Class",
            "Id",
            "Name",
            "Tag"});
            this.refCB.Location = new System.Drawing.Point(86, 39);
            this.refCB.Name = "refCB";
            this.refCB.Size = new System.Drawing.Size(121, 21);
            this.refCB.TabIndex = 12;
            this.refCB.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item Index";
            // 
            // itemIndex
            // 
            this.itemIndex.Location = new System.Drawing.Point(274, 39);
            this.itemIndex.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.itemIndex.Name = "itemIndex";
            this.itemIndex.Size = new System.Drawing.Size(41, 20);
            this.itemIndex.TabIndex = 14;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Brown;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(12, 322);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(61, 38);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 367);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.itemIndex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refCB);
            this.Controls.Add(this.ItemHTMLTxt);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.LoopCount);
            this.Controls.Add(this.loopCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.FunctionComB);
            this.Name = "EventEditor";
            this.Text = "Event Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoopCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FunctionComB;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox loopCB;
        private System.Windows.Forms.NumericUpDown LoopCount;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.RichTextBox ItemHTMLTxt;
        private System.Windows.Forms.ComboBox refCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown itemIndex;
        private System.Windows.Forms.Button deleteButton;
    }
}