namespace H3_AIValue_Evaluator
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
            this.TrainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.LinkLabel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.attackTextbox = new System.Windows.Forms.NumericUpDown();
            this.defenseTextbox = new System.Windows.Forms.NumericUpDown();
            this.mindmgTextbox = new System.Windows.Forms.NumericUpDown();
            this.maxdmgTextbox = new System.Windows.Forms.NumericUpDown();
            this.hitpointsTextbox = new System.Windows.Forms.NumericUpDown();
            this.speedTextbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.attackTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindmgTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxdmgTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitpointsTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(376, 387);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(116, 23);
            this.TrainButton.TabIndex = 0;
            this.TrainButton.Text = "Train Neural Network";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attack Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Defense Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Damage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Damage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hit Points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Speed";
            // 
            // outputTextbox
            // 
            this.outputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputTextbox.Location = new System.Drawing.Point(159, 297);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(134, 22);
            this.outputTextbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Predicted AI Value:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(453, 452);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(93, 13);
            this.authorLabel.TabIndex = 15;
            this.authorLabel.TabStop = true;
            this.authorLabel.Text = "Created by Dydzio";
            this.authorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLabel_LinkClicked);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 257);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 23);
            this.calculateButton.TabIndex = 16;
            this.calculateButton.Text = "Calculate AI Value";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // attackTextbox
            // 
            this.attackTextbox.Location = new System.Drawing.Point(12, 25);
            this.attackTextbox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.attackTextbox.Name = "attackTextbox";
            this.attackTextbox.Size = new System.Drawing.Size(120, 20);
            this.attackTextbox.TabIndex = 17;
            // 
            // defenseTextbox
            // 
            this.defenseTextbox.Location = new System.Drawing.Point(12, 64);
            this.defenseTextbox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.defenseTextbox.Name = "defenseTextbox";
            this.defenseTextbox.Size = new System.Drawing.Size(120, 20);
            this.defenseTextbox.TabIndex = 18;
            // 
            // mindmgTextbox
            // 
            this.mindmgTextbox.Location = new System.Drawing.Point(12, 103);
            this.mindmgTextbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.mindmgTextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mindmgTextbox.Name = "mindmgTextbox";
            this.mindmgTextbox.Size = new System.Drawing.Size(120, 20);
            this.mindmgTextbox.TabIndex = 19;
            this.mindmgTextbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxdmgTextbox
            // 
            this.maxdmgTextbox.Location = new System.Drawing.Point(12, 142);
            this.maxdmgTextbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxdmgTextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxdmgTextbox.Name = "maxdmgTextbox";
            this.maxdmgTextbox.Size = new System.Drawing.Size(120, 20);
            this.maxdmgTextbox.TabIndex = 20;
            this.maxdmgTextbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hitpointsTextbox
            // 
            this.hitpointsTextbox.Location = new System.Drawing.Point(12, 181);
            this.hitpointsTextbox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.hitpointsTextbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hitpointsTextbox.Name = "hitpointsTextbox";
            this.hitpointsTextbox.Size = new System.Drawing.Size(120, 20);
            this.hitpointsTextbox.TabIndex = 21;
            this.hitpointsTextbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // speedTextbox
            // 
            this.speedTextbox.Location = new System.Drawing.Point(12, 221);
            this.speedTextbox.Name = "speedTextbox";
            this.speedTextbox.Size = new System.Drawing.Size(120, 20);
            this.speedTextbox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 474);
            this.Controls.Add(this.speedTextbox);
            this.Controls.Add(this.hitpointsTextbox);
            this.Controls.Add(this.maxdmgTextbox);
            this.Controls.Add(this.mindmgTextbox);
            this.Controls.Add(this.defenseTextbox);
            this.Controls.Add(this.attackTextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrainButton);
            this.Name = "Form1";
            this.Text = "H3 AI Value Evaluator";
            ((System.ComponentModel.ISupportInitialize)(this.attackTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindmgTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxdmgTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitpointsTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel authorLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown attackTextbox;
        private System.Windows.Forms.NumericUpDown defenseTextbox;
        private System.Windows.Forms.NumericUpDown mindmgTextbox;
        private System.Windows.Forms.NumericUpDown maxdmgTextbox;
        private System.Windows.Forms.NumericUpDown hitpointsTextbox;
        private System.Windows.Forms.NumericUpDown speedTextbox;
    }
}

