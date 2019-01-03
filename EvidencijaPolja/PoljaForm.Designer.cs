namespace EvidencijaPolja
{
    partial class PoljaForm
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
            this.natragButton = new System.Windows.Forms.Button();
            this.poljaListBox = new System.Windows.Forms.ListBox();
            this.odjavaLabel = new System.Windows.Forms.Label();
            this.godinaLabel = new System.Windows.Forms.Label();
            this.obrisiGodinuButton = new System.Windows.Forms.Button();
            this.dodajPoljeButton = new System.Windows.Forms.Button();
            this.imePoljaTextBox = new System.Windows.Forms.TextBox();
            this.imePoljaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // natragButton
            // 
            this.natragButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.natragButton.Location = new System.Drawing.Point(11, 261);
            this.natragButton.Name = "natragButton";
            this.natragButton.Size = new System.Drawing.Size(92, 36);
            this.natragButton.TabIndex = 0;
            this.natragButton.Text = "Natrag";
            this.natragButton.UseVisualStyleBackColor = true;
            this.natragButton.Click += new System.EventHandler(this.natragButton_Click);
            // 
            // poljaListBox
            // 
            this.poljaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poljaListBox.FormattingEnabled = true;
            this.poljaListBox.ItemHeight = 16;
            this.poljaListBox.Location = new System.Drawing.Point(175, 64);
            this.poljaListBox.Name = "poljaListBox";
            this.poljaListBox.Size = new System.Drawing.Size(150, 132);
            this.poljaListBox.TabIndex = 1;
            this.poljaListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.poljaListBox_MouseDoubleClick);
            // 
            // odjavaLabel
            // 
            this.odjavaLabel.AutoEllipsis = true;
            this.odjavaLabel.AutoSize = true;
            this.odjavaLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.odjavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjavaLabel.Location = new System.Drawing.Point(459, 0);
            this.odjavaLabel.Name = "odjavaLabel";
            this.odjavaLabel.Size = new System.Drawing.Size(58, 16);
            this.odjavaLabel.TabIndex = 3;
            this.odjavaLabel.Text = "(odjava)";
            this.odjavaLabel.Click += new System.EventHandler(this.odjavaLabel_Click);
            // 
            // godinaLabel
            // 
            this.godinaLabel.AutoEllipsis = true;
            this.godinaLabel.AutoSize = true;
            this.godinaLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.godinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godinaLabel.Location = new System.Drawing.Point(0, 0);
            this.godinaLabel.Name = "godinaLabel";
            this.godinaLabel.Size = new System.Drawing.Size(50, 16);
            this.godinaLabel.TabIndex = 4;
            this.godinaLabel.Text = "godina";
            // 
            // obrisiGodinuButton
            // 
            this.obrisiGodinuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisiGodinuButton.Location = new System.Drawing.Point(410, 261);
            this.obrisiGodinuButton.Name = "obrisiGodinuButton";
            this.obrisiGodinuButton.Size = new System.Drawing.Size(95, 40);
            this.obrisiGodinuButton.TabIndex = 5;
            this.obrisiGodinuButton.Text = "Obriši godinu";
            this.obrisiGodinuButton.UseVisualStyleBackColor = true;
            this.obrisiGodinuButton.Click += new System.EventHandler(this.obrisiGodinuButton_Click);
            // 
            // dodajPoljeButton
            // 
            this.dodajPoljeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajPoljeButton.Location = new System.Drawing.Point(294, 210);
            this.dodajPoljeButton.Name = "dodajPoljeButton";
            this.dodajPoljeButton.Size = new System.Drawing.Size(93, 26);
            this.dodajPoljeButton.TabIndex = 6;
            this.dodajPoljeButton.Text = "Dodaj polje";
            this.dodajPoljeButton.UseVisualStyleBackColor = true;
            this.dodajPoljeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // imePoljaTextBox
            // 
            this.imePoljaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imePoljaTextBox.Location = new System.Drawing.Point(190, 212);
            this.imePoljaTextBox.Name = "imePoljaTextBox";
            this.imePoljaTextBox.Size = new System.Drawing.Size(100, 22);
            this.imePoljaTextBox.TabIndex = 7;
            // 
            // imePoljaLabel
            // 
            this.imePoljaLabel.AutoSize = true;
            this.imePoljaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imePoljaLabel.Location = new System.Drawing.Point(119, 215);
            this.imePoljaLabel.Name = "imePoljaLabel";
            this.imePoljaLabel.Size = new System.Drawing.Size(67, 16);
            this.imePoljaLabel.TabIndex = 8;
            this.imePoljaLabel.Text = "Ime Polja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "IZBOR POLJA";
            // 
            // PoljaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvidencijaPolja.Properties.Resources.farm_hi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imePoljaLabel);
            this.Controls.Add(this.imePoljaTextBox);
            this.Controls.Add(this.dodajPoljeButton);
            this.Controls.Add(this.obrisiGodinuButton);
            this.Controls.Add(this.godinaLabel);
            this.Controls.Add(this.odjavaLabel);
            this.Controls.Add(this.poljaListBox);
            this.Controls.Add(this.natragButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "PoljaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoljaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button natragButton;
        private System.Windows.Forms.ListBox poljaListBox;
        private System.Windows.Forms.Label odjavaLabel;
        private System.Windows.Forms.Label godinaLabel;
        private System.Windows.Forms.Button obrisiGodinuButton;
        private System.Windows.Forms.Button dodajPoljeButton;
        private System.Windows.Forms.TextBox imePoljaTextBox;
        private System.Windows.Forms.Label imePoljaLabel;
        private System.Windows.Forms.Label label1;
    }
}