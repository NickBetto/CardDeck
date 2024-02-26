
namespace CardDeck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shuffleButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.dealerCardsLabel = new System.Windows.Forms.Label();
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.collectButton = new System.Windows.Forms.Button();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.availableBox = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.availableBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.White;
            this.shuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.ForeColor = System.Drawing.Color.Black;
            this.shuffleButton.Location = new System.Drawing.Point(24, 12);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(89, 47);
            this.shuffleButton.TabIndex = 0;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.Gray;
            this.dealButton.Enabled = false;
            this.dealButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.ForeColor = System.Drawing.Color.Black;
            this.dealButton.Location = new System.Drawing.Point(24, 65);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(89, 47);
            this.dealButton.TabIndex = 1;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // dealerCardsLabel
            // 
            this.dealerCardsLabel.AutoSize = true;
            this.dealerCardsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCardsLabel.ForeColor = System.Drawing.Color.White;
            this.dealerCardsLabel.Location = new System.Drawing.Point(260, 52);
            this.dealerCardsLabel.Name = "dealerCardsLabel";
            this.dealerCardsLabel.Size = new System.Drawing.Size(18, 18);
            this.dealerCardsLabel.TabIndex = 2;
            this.dealerCardsLabel.Text = "--";
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.AutoSize = true;
            this.playerCardsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCardsLabel.ForeColor = System.Drawing.Color.White;
            this.playerCardsLabel.Location = new System.Drawing.Point(260, 102);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(18, 18);
            this.playerCardsLabel.TabIndex = 3;
            this.playerCardsLabel.Text = "--";
            // 
            // collectButton
            // 
            this.collectButton.BackColor = System.Drawing.Color.Gray;
            this.collectButton.Enabled = false;
            this.collectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.collectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collectButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectButton.ForeColor = System.Drawing.Color.Black;
            this.collectButton.Location = new System.Drawing.Point(24, 118);
            this.collectButton.Name = "collectButton";
            this.collectButton.Size = new System.Drawing.Size(89, 47);
            this.collectButton.TabIndex = 4;
            this.collectButton.Text = "Collect";
            this.collectButton.UseVisualStyleBackColor = false;
            this.collectButton.Click += new System.EventHandler(this.collectButton_Click);
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.ForeColor = System.Drawing.Color.White;
            this.dealerLabel.Location = new System.Drawing.Point(140, 52);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(114, 19);
            this.dealerLabel.TabIndex = 9;
            this.dealerLabel.Text = "Dealer Cards:";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.White;
            this.playerLabel.Location = new System.Drawing.Point(140, 102);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(113, 19);
            this.playerLabel.TabIndex = 10;
            this.playerLabel.Text = "Player Cards:";
            // 
            // availableBox
            // 
            this.availableBox.Controls.Add(this.outputLabel);
            this.availableBox.ForeColor = System.Drawing.Color.White;
            this.availableBox.Location = new System.Drawing.Point(12, 185);
            this.availableBox.Name = "availableBox";
            this.availableBox.Size = new System.Drawing.Size(457, 118);
            this.availableBox.TabIndex = 12;
            this.availableBox.TabStop = false;
            this.availableBox.Text = "Cards available in Main Deck";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 24);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(425, 78);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(481, 317);
            this.Controls.Add(this.availableBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.collectButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.dealerCardsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deck of Cards";
            this.availableBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label dealerCardsLabel;
        private System.Windows.Forms.Label playerCardsLabel;
        private System.Windows.Forms.Button collectButton;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.GroupBox availableBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

