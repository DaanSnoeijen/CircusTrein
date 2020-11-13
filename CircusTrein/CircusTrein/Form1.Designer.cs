namespace CircusTrein
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
            this.AnimalBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DietBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.WagonBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalBox
            // 
            this.AnimalBox.FormattingEnabled = true;
            this.AnimalBox.ItemHeight = 16;
            this.AnimalBox.Location = new System.Drawing.Point(12, 28);
            this.AnimalBox.Name = "AnimalBox";
            this.AnimalBox.Size = new System.Drawing.Size(226, 308);
            this.AnimalBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "All animals:";
            // 
            // DietBox
            // 
            this.DietBox.FormattingEnabled = true;
            this.DietBox.Items.AddRange(new object[] {
            "Meat",
            "Plants"});
            this.DietBox.Location = new System.Drawing.Point(426, 26);
            this.DietBox.Name = "DietBox";
            this.DietBox.Size = new System.Drawing.Size(121, 24);
            this.DietBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "What does the animal eat?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "How big is the animal?";
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.SizeBox.Location = new System.Drawing.Point(426, 61);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(121, 24);
            this.SizeBox.TabIndex = 5;
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(406, 102);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(141, 63);
            this.AddAnimalButton.TabIndex = 6;
            this.AddAnimalButton.Text = "Add animal";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            this.AddAnimalButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(246, 271);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(301, 63);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // WagonBox
            // 
            this.WagonBox.FormattingEnabled = true;
            this.WagonBox.ItemHeight = 16;
            this.WagonBox.Location = new System.Drawing.Point(553, 29);
            this.WagonBox.Name = "WagonBox";
            this.WagonBox.Size = new System.Drawing.Size(238, 308);
            this.WagonBox.TabIndex = 8;
            this.WagonBox.SelectedIndexChanged += new System.EventHandler(this.WagonBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Animal distribution over wagons:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(246, 102);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(141, 63);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove animal";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 349);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WagonBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AddAnimalButton);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DietBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnimalBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculateAnimalDistribution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnimalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DietBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SizeBox;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox WagonBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveButton;
    }
}

