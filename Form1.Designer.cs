namespace Sumulacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number_of_cells_text_box = new System.Windows.Forms.TextBox();
            this.number_of_steps_text_box = new System.Windows.Forms.TextBox();
            this.rule_combo_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bc_combo_box = new System.Windows.Forms.ComboBox();
            this.start_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liczba komórek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba Kroków";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reguła";
            // 
            // number_of_cells_text_box
            // 
            this.number_of_cells_text_box.Location = new System.Drawing.Point(48, 25);
            this.number_of_cells_text_box.Name = "number_of_cells_text_box";
            this.number_of_cells_text_box.Size = new System.Drawing.Size(100, 20);
            this.number_of_cells_text_box.TabIndex = 4;
            this.number_of_cells_text_box.Text = "1";
            // 
            // number_of_steps_text_box
            // 
            this.number_of_steps_text_box.Location = new System.Drawing.Point(209, 25);
            this.number_of_steps_text_box.Name = "number_of_steps_text_box";
            this.number_of_steps_text_box.Size = new System.Drawing.Size(100, 20);
            this.number_of_steps_text_box.TabIndex = 5;
            this.number_of_steps_text_box.Text = "1";
            // 
            // rule_combo_box
            // 
            this.rule_combo_box.FormattingEnabled = true;
            this.rule_combo_box.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "255"});
            this.rule_combo_box.Location = new System.Drawing.Point(359, 25);
            this.rule_combo_box.Name = "rule_combo_box";
            this.rule_combo_box.Size = new System.Drawing.Size(121, 21);
            this.rule_combo_box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Warunek Brzegowy";
            // 
            // bc_combo_box
            // 
            this.bc_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bc_combo_box.FormattingEnabled = true;
            this.bc_combo_box.Items.AddRange(new object[] {
            "periodyczne"});
            this.bc_combo_box.Location = new System.Drawing.Point(564, 25);
            this.bc_combo_box.Name = "bc_combo_box";
            this.bc_combo_box.Size = new System.Drawing.Size(121, 21);
            this.bc_combo_box.TabIndex = 8;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_button.Location = new System.Drawing.Point(736, 22);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(542, 23);
            this.start_button.TabIndex = 9;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 653);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.bc_combo_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rule_combo_box);
            this.Controls.Add(this.number_of_steps_text_box);
            this.Controls.Add(this.number_of_cells_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Symulacja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number_of_cells_text_box;
        private System.Windows.Forms.TextBox number_of_steps_text_box;
        private System.Windows.Forms.ComboBox rule_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bc_combo_box;
        private System.Windows.Forms.Button start_button;
    }
}

