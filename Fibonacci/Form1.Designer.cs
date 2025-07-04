﻿namespace Fibonacci
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
            startAsyncButton = new Button();
            cancelAsyncButton = new Button();
            resultLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            loadImageButton = new Button();
            loadSoundButton = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(20, 118);
            startAsyncButton.Margin = new Padding(2);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(90, 27);
            startAsyncButton.TabIndex = 0;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(238, 118);
            cancelAsyncButton.Margin = new Padding(2);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(90, 27);
            cancelAsyncButton.TabIndex = 1;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(20, 24);
            resultLabel.Margin = new Padding(2, 0, 2, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(128, 25);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "label1";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(152, 22);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 70);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(308, 27);
            progressBar1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 220);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 236);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // loadImageButton
            // 
            loadImageButton.Location = new Point(238, 471);
            loadImageButton.Margin = new Padding(2);
            loadImageButton.Name = "loadImageButton";
            loadImageButton.Size = new Size(90, 27);
            loadImageButton.TabIndex = 6;
            loadImageButton.Text = "cargar";
            loadImageButton.UseVisualStyleBackColor = true;
            loadImageButton.Click += loadImageButton_Click;
            // 
            // loadSoundButton
            // 
            loadSoundButton.Location = new Point(238, 173);
            loadSoundButton.Margin = new Padding(2);
            loadSoundButton.Name = "loadSoundButton";
            loadSoundButton.Size = new Size(90, 27);
            loadSoundButton.TabIndex = 7;
            loadSoundButton.Text = "sonido";
            loadSoundButton.UseVisualStyleBackColor = true;
            loadSoundButton.Click += loadSoundButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 173);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 547);
            Controls.Add(textBox1);
            Controls.Add(loadSoundButton);
            Controls.Add(loadImageButton);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(numericUpDown1);
            Controls.Add(resultLabel);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startAsyncButton;
        private Button cancelAsyncButton;
        private Label resultLabel;
        private NumericUpDown numericUpDown1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Button loadImageButton;
        private Button loadSoundButton;
        private TextBox textBox1;
    }
}
