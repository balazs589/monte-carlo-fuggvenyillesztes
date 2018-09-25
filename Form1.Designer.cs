namespace monte_carlo_03
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
            this.components = new System.ComponentModel.Container();
            this.illesztett_grafikon_zedGraphControl = new ZedGraph.ZedGraphControl();
            this.energia_grafikon_zedGraphControl = new ZedGraph.ZedGraphControl();
            this.A_kezdo_textBox = new System.Windows.Forms.TextBox();
            this.tau_kezdo_textBox = new System.Windows.Forms.TextBox();
            this.T_kezdo_textBox = new System.Windows.Forms.TextBox();
            this.T_lepes_textBox = new System.Windows.Forms.TextBox();
            this.tau_lepes_textBox = new System.Windows.Forms.TextBox();
            this.A_lepes_textBox = new System.Windows.Forms.TextBox();
            this.T_aktualis_textBox = new System.Windows.Forms.TextBox();
            this.tau_aktualis_textBox = new System.Windows.Forms.TextBox();
            this.A_aktualis_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.beta_textBox = new System.Windows.Forms.TextBox();
            this.iteraciok_szama_textBox = new System.Windows.Forms.TextBox();
            this.beolvas_button = new System.Windows.Forms.Button();
            this.indit_button = new System.Windows.Forms.Button();
            this.megtett_lepesek_textBox = new System.Windows.Forms.TextBox();
            this.energia_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iteracio_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.megszakitas_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // illesztett_grafikon_zedGraphControl
            // 
            this.illesztett_grafikon_zedGraphControl.Location = new System.Drawing.Point(13, 13);
            this.illesztett_grafikon_zedGraphControl.Name = "illesztett_grafikon_zedGraphControl";
            this.illesztett_grafikon_zedGraphControl.ScrollGrace = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMaxX = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMaxY = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMaxY2 = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMinX = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMinY = 0;
            this.illesztett_grafikon_zedGraphControl.ScrollMinY2 = 0;
            this.illesztett_grafikon_zedGraphControl.Size = new System.Drawing.Size(520, 300);
            this.illesztett_grafikon_zedGraphControl.TabIndex = 0;
            // 
            // energia_grafikon_zedGraphControl
            // 
            this.energia_grafikon_zedGraphControl.Location = new System.Drawing.Point(12, 361);
            this.energia_grafikon_zedGraphControl.Name = "energia_grafikon_zedGraphControl";
            this.energia_grafikon_zedGraphControl.ScrollGrace = 0;
            this.energia_grafikon_zedGraphControl.ScrollMaxX = 0;
            this.energia_grafikon_zedGraphControl.ScrollMaxY = 0;
            this.energia_grafikon_zedGraphControl.ScrollMaxY2 = 0;
            this.energia_grafikon_zedGraphControl.ScrollMinX = 0;
            this.energia_grafikon_zedGraphControl.ScrollMinY = 0;
            this.energia_grafikon_zedGraphControl.ScrollMinY2 = 0;
            this.energia_grafikon_zedGraphControl.Size = new System.Drawing.Size(520, 300);
            this.energia_grafikon_zedGraphControl.TabIndex = 1;
            // 
            // A_kezdo_textBox
            // 
            this.A_kezdo_textBox.Location = new System.Drawing.Point(621, 110);
            this.A_kezdo_textBox.Name = "A_kezdo_textBox";
            this.A_kezdo_textBox.Size = new System.Drawing.Size(100, 20);
            this.A_kezdo_textBox.TabIndex = 2;
            this.A_kezdo_textBox.Text = "2";
            // 
            // tau_kezdo_textBox
            // 
            this.tau_kezdo_textBox.Location = new System.Drawing.Point(620, 136);
            this.tau_kezdo_textBox.Name = "tau_kezdo_textBox";
            this.tau_kezdo_textBox.Size = new System.Drawing.Size(100, 20);
            this.tau_kezdo_textBox.TabIndex = 3;
            this.tau_kezdo_textBox.Text = "100";
            // 
            // T_kezdo_textBox
            // 
            this.T_kezdo_textBox.Location = new System.Drawing.Point(620, 162);
            this.T_kezdo_textBox.Name = "T_kezdo_textBox";
            this.T_kezdo_textBox.Size = new System.Drawing.Size(100, 20);
            this.T_kezdo_textBox.TabIndex = 4;
            this.T_kezdo_textBox.Text = "100";
            // 
            // T_lepes_textBox
            // 
            this.T_lepes_textBox.Location = new System.Drawing.Point(735, 362);
            this.T_lepes_textBox.Name = "T_lepes_textBox";
            this.T_lepes_textBox.Size = new System.Drawing.Size(100, 20);
            this.T_lepes_textBox.TabIndex = 7;
            this.T_lepes_textBox.Text = "5";
            // 
            // tau_lepes_textBox
            // 
            this.tau_lepes_textBox.Location = new System.Drawing.Point(735, 336);
            this.tau_lepes_textBox.Name = "tau_lepes_textBox";
            this.tau_lepes_textBox.Size = new System.Drawing.Size(100, 20);
            this.tau_lepes_textBox.TabIndex = 6;
            this.tau_lepes_textBox.Text = "5";
            // 
            // A_lepes_textBox
            // 
            this.A_lepes_textBox.Location = new System.Drawing.Point(736, 310);
            this.A_lepes_textBox.Name = "A_lepes_textBox";
            this.A_lepes_textBox.Size = new System.Drawing.Size(100, 20);
            this.A_lepes_textBox.TabIndex = 5;
            this.A_lepes_textBox.Text = "0.5";
            // 
            // T_aktualis_textBox
            // 
            this.T_aktualis_textBox.Location = new System.Drawing.Point(619, 362);
            this.T_aktualis_textBox.Name = "T_aktualis_textBox";
            this.T_aktualis_textBox.Size = new System.Drawing.Size(100, 20);
            this.T_aktualis_textBox.TabIndex = 10;
            // 
            // tau_aktualis_textBox
            // 
            this.tau_aktualis_textBox.Location = new System.Drawing.Point(619, 336);
            this.tau_aktualis_textBox.Name = "tau_aktualis_textBox";
            this.tau_aktualis_textBox.Size = new System.Drawing.Size(100, 20);
            this.tau_aktualis_textBox.TabIndex = 9;
            // 
            // A_aktualis_textBox
            // 
            this.A_aktualis_textBox.Location = new System.Drawing.Point(620, 310);
            this.A_aktualis_textBox.Name = "A_aktualis_textBox";
            this.A_aktualis_textBox.Size = new System.Drawing.Size(100, 20);
            this.A_aktualis_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "tau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "kezdõérték";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "lépésköz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "aktuális";
            // 
            // beta_textBox
            // 
            this.beta_textBox.Location = new System.Drawing.Point(619, 448);
            this.beta_textBox.Name = "beta_textBox";
            this.beta_textBox.Size = new System.Drawing.Size(100, 20);
            this.beta_textBox.TabIndex = 17;
            this.beta_textBox.Text = "1000";
            // 
            // iteraciok_szama_textBox
            // 
            this.iteraciok_szama_textBox.Location = new System.Drawing.Point(619, 487);
            this.iteraciok_szama_textBox.Name = "iteraciok_szama_textBox";
            this.iteraciok_szama_textBox.Size = new System.Drawing.Size(100, 20);
            this.iteraciok_szama_textBox.TabIndex = 18;
            this.iteraciok_szama_textBox.Text = "1";
            // 
            // beolvas_button
            // 
            this.beolvas_button.Location = new System.Drawing.Point(620, 13);
            this.beolvas_button.Name = "beolvas_button";
            this.beolvas_button.Size = new System.Drawing.Size(75, 23);
            this.beolvas_button.TabIndex = 19;
            this.beolvas_button.Text = "beolvas";
            this.beolvas_button.UseVisualStyleBackColor = true;
            this.beolvas_button.Click += new System.EventHandler(this.beolvas_button_Click);
            // 
            // indit_button
            // 
            this.indit_button.Location = new System.Drawing.Point(620, 188);
            this.indit_button.Name = "indit_button";
            this.indit_button.Size = new System.Drawing.Size(75, 23);
            this.indit_button.TabIndex = 20;
            this.indit_button.Text = "indít";
            this.indit_button.UseVisualStyleBackColor = true;
            this.indit_button.Click += new System.EventHandler(this.indit_button_Click);
            // 
            // megtett_lepesek_textBox
            // 
            this.megtett_lepesek_textBox.Location = new System.Drawing.Point(619, 615);
            this.megtett_lepesek_textBox.Name = "megtett_lepesek_textBox";
            this.megtett_lepesek_textBox.Size = new System.Drawing.Size(100, 20);
            this.megtett_lepesek_textBox.TabIndex = 21;
            // 
            // energia_textBox
            // 
            this.energia_textBox.Location = new System.Drawing.Point(770, 615);
            this.energia_textBox.Name = "energia_textBox";
            this.energia_textBox.Size = new System.Drawing.Size(100, 20);
            this.energia_textBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "béta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "iterációk száma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "megtett lépések száma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(767, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "energia értéke";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iteracio_button
            // 
            this.iteracio_button.Location = new System.Drawing.Point(707, 524);
            this.iteracio_button.Name = "iteracio_button";
            this.iteracio_button.Size = new System.Drawing.Size(75, 23);
            this.iteracio_button.TabIndex = 27;
            this.iteracio_button.Text = "iteráció";
            this.iteracio_button.UseVisualStyleBackColor = true;
            this.iteracio_button.Click += new System.EventHandler(this.iteracio_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(579, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "T";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(579, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "tau";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(579, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "A";
            // 
            // megszakitas_textBox
            // 
            this.megszakitas_textBox.Location = new System.Drawing.Point(770, 487);
            this.megszakitas_textBox.Name = "megszakitas_textBox";
            this.megszakitas_textBox.Size = new System.Drawing.Size(100, 20);
            this.megszakitas_textBox.TabIndex = 31;
            this.megszakitas_textBox.Text = "24.37";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(770, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "megszakít, ha az energia kisebb mint";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.megszakitas_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.iteracio_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.energia_textBox);
            this.Controls.Add(this.megtett_lepesek_textBox);
            this.Controls.Add(this.indit_button);
            this.Controls.Add(this.beolvas_button);
            this.Controls.Add(this.iteraciok_szama_textBox);
            this.Controls.Add(this.beta_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_aktualis_textBox);
            this.Controls.Add(this.tau_aktualis_textBox);
            this.Controls.Add(this.A_aktualis_textBox);
            this.Controls.Add(this.T_lepes_textBox);
            this.Controls.Add(this.tau_lepes_textBox);
            this.Controls.Add(this.A_lepes_textBox);
            this.Controls.Add(this.T_kezdo_textBox);
            this.Controls.Add(this.tau_kezdo_textBox);
            this.Controls.Add(this.A_kezdo_textBox);
            this.Controls.Add(this.energia_grafikon_zedGraphControl);
            this.Controls.Add(this.illesztett_grafikon_zedGraphControl);
            this.Name = "Form1";
            this.Text = "Monte Carlo fit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl illesztett_grafikon_zedGraphControl;
        private ZedGraph.ZedGraphControl energia_grafikon_zedGraphControl;
        private System.Windows.Forms.TextBox A_kezdo_textBox;
        private System.Windows.Forms.TextBox tau_kezdo_textBox;
        private System.Windows.Forms.TextBox T_kezdo_textBox;
        private System.Windows.Forms.TextBox T_lepes_textBox;
        private System.Windows.Forms.TextBox tau_lepes_textBox;
        private System.Windows.Forms.TextBox A_lepes_textBox;
        private System.Windows.Forms.TextBox T_aktualis_textBox;
        private System.Windows.Forms.TextBox tau_aktualis_textBox;
        private System.Windows.Forms.TextBox A_aktualis_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox beta_textBox;
        private System.Windows.Forms.TextBox iteraciok_szama_textBox;
        private System.Windows.Forms.Button beolvas_button;
        private System.Windows.Forms.Button indit_button;
        private System.Windows.Forms.TextBox megtett_lepesek_textBox;
        private System.Windows.Forms.TextBox energia_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button iteracio_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox megszakitas_textBox;
        private System.Windows.Forms.Label label14;
    }
}

