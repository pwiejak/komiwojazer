﻿namespace Komiwojazer1
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
            this.btWczytajMiasta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textlabel7 = new System.Windows.Forms.Label();
            this.liczbaPokolen = new System.Windows.Forms.NumericUpDown();
            this.RozmiarPopulacji = new System.Windows.Forms.NumericUpDown();
            this.Mutacje = new System.Windows.Forms.NumericUpDown();
            this.minimum = new System.Windows.Forms.Label();
            this.aktualnePokolenie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Czas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaPokolen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RozmiarPopulacji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutacje)).BeginInit();
            this.SuspendLayout();
            // 
            // btWczytajMiasta
            // 
            this.btWczytajMiasta.Location = new System.Drawing.Point(60, 33);
            this.btWczytajMiasta.Name = "btWczytajMiasta";
            this.btWczytajMiasta.Size = new System.Drawing.Size(175, 23);
            this.btWczytajMiasta.TabIndex = 0;
            this.btWczytajMiasta.Text = "Wczytaj Miasta";
            this.btWczytajMiasta.UseVisualStyleBackColor = true;
            this.btWczytajMiasta.Click += new System.EventHandler(this.btWczytajMiasta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(302, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(60, 62);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(121, 21);
            this.cbMiasta.TabIndex = 3;
            this.cbMiasta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozmiar populacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mutacje [%]";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textlabel7
            // 
            this.textlabel7.AutoSize = true;
            this.textlabel7.Location = new System.Drawing.Point(57, 95);
            this.textlabel7.Name = "textlabel7";
            this.textlabel7.Size = new System.Drawing.Size(80, 13);
            this.textlabel7.TabIndex = 12;
            this.textlabel7.Text = "Liczba Pokoleń";
            // 
            // liczbaPokolen
            // 
            this.liczbaPokolen.Location = new System.Drawing.Point(60, 111);
            this.liczbaPokolen.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.liczbaPokolen.Name = "liczbaPokolen";
            this.liczbaPokolen.Size = new System.Drawing.Size(120, 20);
            this.liczbaPokolen.TabIndex = 13;
            this.liczbaPokolen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RozmiarPopulacji
            // 
            this.RozmiarPopulacji.Location = new System.Drawing.Point(60, 161);
            this.RozmiarPopulacji.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RozmiarPopulacji.Name = "RozmiarPopulacji";
            this.RozmiarPopulacji.Size = new System.Drawing.Size(120, 20);
            this.RozmiarPopulacji.TabIndex = 14;
            this.RozmiarPopulacji.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Mutacje
            // 
            this.Mutacje.DecimalPlaces = 1;
            this.Mutacje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Mutacje.Location = new System.Drawing.Point(61, 215);
            this.Mutacje.Name = "Mutacje";
            this.Mutacje.Size = new System.Drawing.Size(120, 20);
            this.Mutacje.TabIndex = 15;
            this.Mutacje.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Mutacje.Visible = false;
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Location = new System.Drawing.Point(106, 317);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(85, 13);
            this.minimum.TabIndex = 16;
            this.minimum.Text = "najkrotsza droga";
            // 
            // aktualnePokolenie
            // 
            this.aktualnePokolenie.AutoSize = true;
            this.aktualnePokolenie.Location = new System.Drawing.Point(106, 376);
            this.aktualnePokolenie.Name = "aktualnePokolenie";
            this.aktualnePokolenie.Size = new System.Drawing.Size(97, 13);
            this.aktualnePokolenie.TabIndex = 17;
            this.aktualnePokolenie.Text = "aktualne pokolenie";
            this.aktualnePokolenie.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Najkrótsza droga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Minimalna droga";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Czas :";
            // 
            // Czas
            // 
            this.Czas.Location = new System.Drawing.Point(108, 346);
            this.Czas.Name = "Czas";
            this.Czas.ReadOnly = true;
            this.Czas.Size = new System.Drawing.Size(100, 20);
            this.Czas.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 526);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aktualnePokolenie);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.Mutacje);
            this.Controls.Add(this.RozmiarPopulacji);
            this.Controls.Add(this.liczbaPokolen);
            this.Controls.Add(this.textlabel7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btWczytajMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaPokolen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RozmiarPopulacji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutacje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWczytajMiasta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textlabel7;
        private System.Windows.Forms.NumericUpDown liczbaPokolen;
        private System.Windows.Forms.NumericUpDown RozmiarPopulacji;
        private System.Windows.Forms.NumericUpDown Mutacje;
        private System.Windows.Forms.Label minimum;
        private System.Windows.Forms.Label aktualnePokolenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Czas;
    }
}

