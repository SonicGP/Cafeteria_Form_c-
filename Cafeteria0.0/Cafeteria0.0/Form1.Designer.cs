namespace Cafeteria0._0
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
            this.lumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLumberjack = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LowMany = new System.Windows.Forms.NumericUpDown();
            this.Crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.AddFlapjack = new System.Windows.Forms.Button();
            this.NextInLine = new System.Windows.Forms.TextBox();
            this.NexLumberjack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowMany)).BeginInit();
            this.SuspendLayout();
            // 
            // lumber
            // 
            this.lumber.Location = new System.Drawing.Point(127, 12);
            this.lumber.Name = "lumber";
            this.lumber.Size = new System.Drawing.Size(145, 20);
            this.lumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Lenhador";
            // 
            // AddLumberjack
            // 
            this.AddLumberjack.Location = new System.Drawing.Point(12, 38);
            this.AddLumberjack.Name = "AddLumberjack";
            this.AddLumberjack.Size = new System.Drawing.Size(120, 23);
            this.AddLumberjack.TabIndex = 2;
            this.AddLumberjack.Text = "Adicionar Lenhador";
            this.AddLumberjack.UseVisualStyleBackColor = true;
            this.AddLumberjack.Click += new System.EventHandler(this.AddLumberjack_Click);
            // 
            // Line
            // 
            this.Line.FormattingEnabled = true;
            this.Line.Location = new System.Drawing.Point(12, 85);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(120, 225);
            this.Line.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila do Café da Manhã";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NexLumberjack);
            this.groupBox1.Controls.Add(this.NextInLine);
            this.groupBox1.Controls.Add(this.AddFlapjack);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.Crispy);
            this.groupBox1.Controls.Add(this.LowMany);
            this.groupBox1.Location = new System.Drawing.Point(138, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alimente o Lenhador";
            // 
            // LowMany
            // 
            this.LowMany.Location = new System.Drawing.Point(6, 19);
            this.LowMany.Name = "LowMany";
            this.LowMany.Size = new System.Drawing.Size(70, 20);
            this.LowMany.TabIndex = 0;
            // 
            // Crispy
            // 
            this.Crispy.AutoSize = true;
            this.Crispy.Location = new System.Drawing.Point(6, 45);
            this.Crispy.Name = "Crispy";
            this.Crispy.Size = new System.Drawing.Size(68, 17);
            this.Crispy.TabIndex = 1;
            this.Crispy.TabStop = true;
            this.Crispy.Text = "Crocante";
            this.Crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 68);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(76, 17);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Com Calda";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 91);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(64, 17);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Tostada";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(6, 114);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // AddFlapjack
            // 
            this.AddFlapjack.Location = new System.Drawing.Point(6, 137);
            this.AddFlapjack.Name = "AddFlapjack";
            this.AddFlapjack.Size = new System.Drawing.Size(122, 23);
            this.AddFlapjack.TabIndex = 5;
            this.AddFlapjack.Text = "Adicionar Panqueca";
            this.AddFlapjack.UseVisualStyleBackColor = true;
            this.AddFlapjack.Click += new System.EventHandler(this.AddFlapjack_Click);
            // 
            // NextInLine
            // 
            this.NextInLine.Location = new System.Drawing.Point(6, 166);
            this.NextInLine.Multiline = true;
            this.NextInLine.Name = "NextInLine";
            this.NextInLine.ReadOnly = true;
            this.NextInLine.Size = new System.Drawing.Size(122, 71);
            this.NextInLine.TabIndex = 6;
            // 
            // NexLumberjack
            // 
            this.NexLumberjack.Location = new System.Drawing.Point(7, 243);
            this.NexLumberjack.Name = "NexLumberjack";
            this.NexLumberjack.Size = new System.Drawing.Size(121, 23);
            this.NexLumberjack.TabIndex = 7;
            this.NexLumberjack.Text = "Proximo Lenhador";
            this.NexLumberjack.UseVisualStyleBackColor = true;
            this.NexLumberjack.Click += new System.EventHandler(this.NexLumberjack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.AddLumberjack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddLumberjack;
        private System.Windows.Forms.ListBox Line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NexLumberjack;
        private System.Windows.Forms.TextBox NextInLine;
        private System.Windows.Forms.Button AddFlapjack;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton Crispy;
        private System.Windows.Forms.NumericUpDown LowMany;
    }
}

