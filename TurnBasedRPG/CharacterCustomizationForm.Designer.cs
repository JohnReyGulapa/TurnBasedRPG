namespace TurnBasedRPG
{
    partial class CharacterCustomizationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Button buttonPrevVariant;
        private System.Windows.Forms.Button buttonNextVariant;
        private System.Windows.Forms.Button buttonNextPlayer;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.buttonPrevVariant = new System.Windows.Forms.Button();
            this.buttonNextVariant = new System.Windows.Forms.Button();
            this.buttonNextPlayer = new System.Windows.Forms.Button();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(0, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 40);
            this.labelTitle.Text = "Customize Your Character";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelCurrentPlayer
            this.labelCurrentPlayer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelCurrentPlayer.Location = new System.Drawing.Point(0, 50);
            this.labelCurrentPlayer.Size = new System.Drawing.Size(800, 30);
            this.labelCurrentPlayer.Text = "Current: Player1";
            this.labelCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelPlayer1Name
            this.labelPlayer1Name.Location = new System.Drawing.Point(150, 80);
            this.labelPlayer1Name.Size = new System.Drawing.Size(100, 20);
            this.labelPlayer1Name.Text = "Player 1";
            this.labelPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelPlayer2Name
            this.labelPlayer2Name.Location = new System.Drawing.Point(550, 80);
            this.labelPlayer2Name.Size = new System.Drawing.Size(100, 20);
            this.labelPlayer2Name.Text = "Player 2";
            this.labelPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pictureBoxPlayer1
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(100, 110);
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer1.BorderStyle = BorderStyle.FixedSingle;

            // pictureBoxPlayer2
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(500, 110);
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer2.BorderStyle = BorderStyle.FixedSingle;

            // buttonPrevVariant
            this.buttonPrevVariant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrevVariant.Location = new System.Drawing.Point(250, 430);
            this.buttonPrevVariant.Size = new System.Drawing.Size(75, 40);
            this.buttonPrevVariant.Text = "◀";
            this.buttonPrevVariant.Click += new System.EventHandler(this.buttonPrevVariant_Click);

            // buttonNextVariant
            this.buttonNextVariant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNextVariant.Location = new System.Drawing.Point(475, 430);
            this.buttonNextVariant.Size = new System.Drawing.Size(75, 40);
            this.buttonNextVariant.Text = "▶";
            this.buttonNextVariant.Click += new System.EventHandler(this.buttonNextVariant_Click);

            // buttonNextPlayer
            this.buttonNextPlayer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonNextPlayer.Location = new System.Drawing.Point(325, 490);
            this.buttonNextPlayer.Size = new System.Drawing.Size(150, 45);
            this.buttonNextPlayer.Text = "Next Player";
            this.buttonNextPlayer.Click += new System.EventHandler(this.buttonNextPlayer_Click);

            // CharacterCustomizationForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCurrentPlayer);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.buttonPrevVariant);
            this.Controls.Add(this.buttonNextVariant);
            this.Controls.Add(this.buttonNextPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CharacterCustomizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Customization";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.ResumeLayout(false);
        }
    }
}