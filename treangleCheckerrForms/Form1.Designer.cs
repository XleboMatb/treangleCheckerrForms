namespace treangleCheckerrForms
{
    partial class MyForm
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
            this.buttonCheckTreangle = new System.Windows.Forms.Button();
            this.tbSideOne = new System.Windows.Forms.TextBox();
            this.tbSideTwo = new System.Windows.Forms.TextBox();
            this.tbSideThree = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treanglePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.treanglePB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckTreangle
            // 
            this.buttonCheckTreangle.Location = new System.Drawing.Point(304, 342);
            this.buttonCheckTreangle.Name = "buttonCheckTreangle";
            this.buttonCheckTreangle.Size = new System.Drawing.Size(218, 52);
            this.buttonCheckTreangle.TabIndex = 0;
            this.buttonCheckTreangle.Text = "проверить";
            this.buttonCheckTreangle.UseVisualStyleBackColor = true;
            this.buttonCheckTreangle.Click += new System.EventHandler(this.buttonCheckTreangle_Click);
            // 
            // tbSideOne
            // 
            this.tbSideOne.Location = new System.Drawing.Point(12, 97);
            this.tbSideOne.Name = "tbSideOne";
            this.tbSideOne.Size = new System.Drawing.Size(137, 20);
            this.tbSideOne.TabIndex = 1;
            // 
            // tbSideTwo
            // 
            this.tbSideTwo.Location = new System.Drawing.Point(184, 97);
            this.tbSideTwo.Name = "tbSideTwo";
            this.tbSideTwo.Size = new System.Drawing.Size(137, 20);
            this.tbSideTwo.TabIndex = 2;
            // 
            // tbSideThree
            // 
            this.tbSideThree.Location = new System.Drawing.Point(358, 97);
            this.tbSideThree.Name = "tbSideThree";
            this.tbSideThree.Size = new System.Drawing.Size(137, 20);
            this.tbSideThree.TabIndex = 3;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(584, 93);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(167, 23);
            this.answerLabel.TabIndex = 4;
            this.answerLabel.Text = "Ответ будет здесь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сторона 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сторона 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сторона 3";
            // 
            // treanglePB
            // 
            this.treanglePB.Location = new System.Drawing.Point(304, 174);
            this.treanglePB.Name = "treanglePB";
            this.treanglePB.Size = new System.Drawing.Size(218, 162);
            this.treanglePB.TabIndex = 8;
            this.treanglePB.TabStop = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treanglePB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.tbSideThree);
            this.Controls.Add(this.tbSideTwo);
            this.Controls.Add(this.tbSideOne);
            this.Controls.Add(this.buttonCheckTreangle);
            this.Name = "MyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treanglePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckTreangle;
        private System.Windows.Forms.TextBox tbSideOne;
        private System.Windows.Forms.TextBox tbSideTwo;
        private System.Windows.Forms.TextBox tbSideThree;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox treanglePB;
    }
}

