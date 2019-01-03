namespace EvidencijaPolja
{
    partial class GodineForm
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
            this.godinaListBox = new System.Windows.Forms.ListBox();
            this.odjavaLabel = new System.Windows.Forms.Label();
            this.dodajGodinuLabel = new System.Windows.Forms.Label();
            this.dodajGodinuTextBox = new System.Windows.Forms.TextBox();
            this.dodajGodinuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // godinaListBox
            // 
            this.godinaListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.godinaListBox.FormattingEnabled = true;
            this.godinaListBox.ItemHeight = 16;
            this.godinaListBox.Location = new System.Drawing.Point(186, 56);
            this.godinaListBox.Name = "godinaListBox";
            this.godinaListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.godinaListBox.Size = new System.Drawing.Size(120, 84);
            this.godinaListBox.TabIndex = 0;
            this.godinaListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.godinaListBox_MouseDoubleClick);
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
            this.odjavaLabel.TabIndex = 2;
            this.odjavaLabel.Text = "(odjava)";
            this.odjavaLabel.Click += new System.EventHandler(this.odjavaLabel_Click);
            // 
            // dodajGodinuLabel
            // 
            this.dodajGodinuLabel.AutoSize = true;
            this.dodajGodinuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajGodinuLabel.Location = new System.Drawing.Point(134, 221);
            this.dodajGodinuLabel.Name = "dodajGodinuLabel";
            this.dodajGodinuLabel.Size = new System.Drawing.Size(55, 16);
            this.dodajGodinuLabel.TabIndex = 3;
            this.dodajGodinuLabel.Text = "Godina:";
            // 
            // dodajGodinuTextBox
            // 
            this.dodajGodinuTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dodajGodinuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajGodinuTextBox.Location = new System.Drawing.Point(195, 218);
            this.dodajGodinuTextBox.Name = "dodajGodinuTextBox";
            this.dodajGodinuTextBox.Size = new System.Drawing.Size(100, 22);
            this.dodajGodinuTextBox.TabIndex = 4;
            // 
            // dodajGodinuButton
            // 
            this.dodajGodinuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajGodinuButton.Location = new System.Drawing.Point(301, 218);
            this.dodajGodinuButton.Name = "dodajGodinuButton";
            this.dodajGodinuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajGodinuButton.TabIndex = 5;
            this.dodajGodinuButton.Text = "Dodaj";
            this.dodajGodinuButton.UseVisualStyleBackColor = true;
            this.dodajGodinuButton.Click += new System.EventHandler(this.dodajGodinuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "IZBOR GODINA";
            // 
            // GodineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvidencijaPolja.Properties.Resources.farm_hi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajGodinuButton);
            this.Controls.Add(this.dodajGodinuTextBox);
            this.Controls.Add(this.dodajGodinuLabel);
            this.Controls.Add(this.odjavaLabel);
            this.Controls.Add(this.godinaListBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GodineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Godine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox godinaListBox;
        private System.Windows.Forms.Label odjavaLabel;
        private System.Windows.Forms.Label dodajGodinuLabel;
        private System.Windows.Forms.TextBox dodajGodinuTextBox;
        private System.Windows.Forms.Button dodajGodinuButton;
        private System.Windows.Forms.Label label1;
    }
}