namespace EvidencijaPolja
{
    partial class KreirajUserForm
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
            this.noviUserButton = new System.Windows.Forms.Button();
            this.noviUserTextBox = new System.Windows.Forms.TextBox();
            this.noviPasswordTextBox = new System.Windows.Forms.TextBox();
            this.noviUserLabel = new System.Windows.Forms.Label();
            this.noviPasswordLabel = new System.Windows.Forms.Label();
            this.natragButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noviUserButton
            // 
            this.noviUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noviUserButton.Location = new System.Drawing.Point(171, 149);
            this.noviUserButton.Name = "noviUserButton";
            this.noviUserButton.Size = new System.Drawing.Size(89, 28);
            this.noviUserButton.TabIndex = 0;
            this.noviUserButton.Text = "Dodaj";
            this.noviUserButton.UseVisualStyleBackColor = true;
            this.noviUserButton.Click += new System.EventHandler(this.noviUserButton_Click);
            // 
            // noviUserTextBox
            // 
            this.noviUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noviUserTextBox.Location = new System.Drawing.Point(205, 80);
            this.noviUserTextBox.Name = "noviUserTextBox";
            this.noviUserTextBox.Size = new System.Drawing.Size(100, 22);
            this.noviUserTextBox.TabIndex = 1;
            // 
            // noviPasswordTextBox
            // 
            this.noviPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noviPasswordTextBox.Location = new System.Drawing.Point(205, 107);
            this.noviPasswordTextBox.Name = "noviPasswordTextBox";
            this.noviPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.noviPasswordTextBox.TabIndex = 2;
            // 
            // noviUserLabel
            // 
            this.noviUserLabel.AutoSize = true;
            this.noviUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noviUserLabel.Location = new System.Drawing.Point(94, 83);
            this.noviUserLabel.Name = "noviUserLabel";
            this.noviUserLabel.Size = new System.Drawing.Size(105, 16);
            this.noviUserLabel.TabIndex = 3;
            this.noviUserLabel.Text = "Novi Username:";
            // 
            // noviPasswordLabel
            // 
            this.noviPasswordLabel.AutoSize = true;
            this.noviPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noviPasswordLabel.Location = new System.Drawing.Point(95, 110);
            this.noviPasswordLabel.Name = "noviPasswordLabel";
            this.noviPasswordLabel.Size = new System.Drawing.Size(102, 16);
            this.noviPasswordLabel.TabIndex = 4;
            this.noviPasswordLabel.Text = "Novi Password:";
            // 
            // natragButton
            // 
            this.natragButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.natragButton.Location = new System.Drawing.Point(12, 226);
            this.natragButton.Name = "natragButton";
            this.natragButton.Size = new System.Drawing.Size(85, 29);
            this.natragButton.TabIndex = 5;
            this.natragButton.Text = "Natrag";
            this.natragButton.UseVisualStyleBackColor = true;
            this.natragButton.Click += new System.EventHandler(this.natragButton_Click);
            // 
            // KreirajUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvidencijaPolja.Properties.Resources.farm_hi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 267);
            this.Controls.Add(this.natragButton);
            this.Controls.Add(this.noviPasswordLabel);
            this.Controls.Add(this.noviUserLabel);
            this.Controls.Add(this.noviPasswordTextBox);
            this.Controls.Add(this.noviUserTextBox);
            this.Controls.Add(this.noviUserButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "KreirajUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KreirajUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noviUserButton;
        private System.Windows.Forms.TextBox noviUserTextBox;
        private System.Windows.Forms.TextBox noviPasswordTextBox;
        private System.Windows.Forms.Label noviUserLabel;
        private System.Windows.Forms.Label noviPasswordLabel;
        private System.Windows.Forms.Button natragButton;
    }
}