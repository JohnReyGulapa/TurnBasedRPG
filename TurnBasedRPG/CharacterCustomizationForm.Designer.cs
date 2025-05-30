namespace TurnBasedRPG
{
    partial class CharacterCustomizationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelCurrentPlayer;

        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;

        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonPrevColor;
        private System.Windows.Forms.Button buttonNextColor;

        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Button buttonPrevHead;
        private System.Windows.Forms.Button buttonNextHead;

        private System.Windows.Forms.Label labelShirt;
        private System.Windows.Forms.Button buttonPrevShirt;
        private System.Windows.Forms.Button buttonNextShirt;

        private System.Windows.Forms.Label labelPants;
        private System.Windows.Forms.Button buttonPrevPants;
        private System.Windows.Forms.Button buttonNextPants;

        private System.Windows.Forms.Label labelShoes;
        private System.Windows.Forms.Button buttonPrevShoes;
        private System.Windows.Forms.Button buttonNextShoes;

        private System.Windows.Forms.Button buttonNextPlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelPlayer1Name = new Label();
            labelPlayer2Name = new Label();
            labelCurrentPlayer = new Label();
            pictureBoxPlayer1 = new PictureBox();
            pictureBoxPlayer2 = new PictureBox();
            labelColor = new Label();
            buttonPrevColor = new Button();
            buttonNextColor = new Button();
            labelHead = new Label();
            buttonPrevHead = new Button();
            buttonNextHead = new Button();
            labelShirt = new Label();
            buttonPrevShirt = new Button();
            buttonNextShirt = new Button();
            labelPants = new Label();
            buttonPrevPants = new Button();
            buttonNextPants = new Button();
            labelShoes = new Label();
            buttonPrevShoes = new Button();
            buttonNextShoes = new Button();
            buttonNextPlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(250, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Customize Your Character";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayer1Name
            // 
            labelPlayer1Name.Location = new Point(150, 70);
            labelPlayer1Name.Name = "labelPlayer1Name";
            labelPlayer1Name.Size = new Size(120, 20);
            labelPlayer1Name.TabIndex = 1;
            labelPlayer1Name.Text = "Player 1";
            // 
            // labelPlayer2Name
            // 
            labelPlayer2Name.Location = new Point(530, 70);
            labelPlayer2Name.Name = "labelPlayer2Name";
            labelPlayer2Name.Size = new Size(120, 20);
            labelPlayer2Name.TabIndex = 2;
            labelPlayer2Name.Text = "Player 2";
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCurrentPlayer.Location = new Point(297, 50);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(200, 25);
            labelCurrentPlayer.TabIndex = 3;
            labelCurrentPlayer.Text = "Current: Player 1";
            labelCurrentPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.BackColor = Color.White;
            pictureBoxPlayer1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer1.Location = new Point(96, 100);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(160, 220);
            pictureBoxPlayer1.TabIndex = 4;
            pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.BackColor = Color.White;
            pictureBoxPlayer2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPlayer2.Location = new Point(581, 100);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(160, 220);
            pictureBoxPlayer2.TabIndex = 5;
            pictureBoxPlayer2.TabStop = false;
            // 
            // labelColor
            // 
            labelColor.Location = new Point(320, 114);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(200, 20);
            labelColor.TabIndex = 6;
            labelColor.Text = "Color: Black";
            // 
            // buttonPrevColor
            // 
            buttonPrevColor.Location = new Point(290, 114);
            buttonPrevColor.Name = "buttonPrevColor";
            buttonPrevColor.Size = new Size(25, 23);
            buttonPrevColor.TabIndex = 7;
            buttonPrevColor.Text = "<";
            buttonPrevColor.Click += buttonPrevColor_Click;
            // 
            // buttonNextColor
            // 
            buttonNextColor.Location = new Point(520, 114);
            buttonNextColor.Name = "buttonNextColor";
            buttonNextColor.Size = new Size(25, 23);
            buttonNextColor.TabIndex = 8;
            buttonNextColor.Text = ">";
            buttonNextColor.Click += buttonNextColor_Click;
            // 
            // labelHead
            // 
            labelHead.Location = new Point(320, 154);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(200, 20);
            labelHead.TabIndex = 9;
            labelHead.Text = "Head: None";
            // 
            // buttonPrevHead
            // 
            buttonPrevHead.Location = new Point(290, 154);
            buttonPrevHead.Name = "buttonPrevHead";
            buttonPrevHead.Size = new Size(25, 23);
            buttonPrevHead.TabIndex = 10;
            buttonPrevHead.Text = "<";
            buttonPrevHead.Click += buttonPrevHead_Click;
            // 
            // buttonNextHead
            // 
            buttonNextHead.Location = new Point(520, 154);
            buttonNextHead.Name = "buttonNextHead";
            buttonNextHead.Size = new Size(25, 23);
            buttonNextHead.TabIndex = 11;
            buttonNextHead.Text = ">";
            buttonNextHead.Click += buttonNextHead_Click;
            // 
            // labelShirt
            // 
            labelShirt.Location = new Point(320, 194);
            labelShirt.Name = "labelShirt";
            labelShirt.Size = new Size(200, 20);
            labelShirt.TabIndex = 12;
            labelShirt.Text = "Shirt: T-Shirt";
            // 
            // buttonPrevShirt
            // 
            buttonPrevShirt.Location = new Point(290, 194);
            buttonPrevShirt.Name = "buttonPrevShirt";
            buttonPrevShirt.Size = new Size(25, 23);
            buttonPrevShirt.TabIndex = 13;
            buttonPrevShirt.Text = "<";
            buttonPrevShirt.Click += buttonPrevShirt_Click;
            // 
            // buttonNextShirt
            // 
            buttonNextShirt.Location = new Point(520, 194);
            buttonNextShirt.Name = "buttonNextShirt";
            buttonNextShirt.Size = new Size(25, 23);
            buttonNextShirt.TabIndex = 14;
            buttonNextShirt.Text = ">";
            buttonNextShirt.Click += buttonNextShirt_Click;
            // 
            // labelPants
            // 
            labelPants.Location = new Point(320, 234);
            labelPants.Name = "labelPants";
            labelPants.Size = new Size(200, 20);
            labelPants.TabIndex = 15;
            labelPants.Text = "Pants: Jeans";
            // 
            // buttonPrevPants
            // 
            buttonPrevPants.Location = new Point(290, 234);
            buttonPrevPants.Name = "buttonPrevPants";
            buttonPrevPants.Size = new Size(25, 23);
            buttonPrevPants.TabIndex = 16;
            buttonPrevPants.Text = "<";
            buttonPrevPants.Click += buttonPrevPants_Click;
            // 
            // buttonNextPants
            // 
            buttonNextPants.Location = new Point(520, 234);
            buttonNextPants.Name = "buttonNextPants";
            buttonNextPants.Size = new Size(25, 23);
            buttonNextPants.TabIndex = 17;
            buttonNextPants.Text = ">";
            buttonNextPants.Click += buttonNextPants_Click;
            // 
            // labelShoes
            // 
            labelShoes.Location = new Point(320, 274);
            labelShoes.Name = "labelShoes";
            labelShoes.Size = new Size(200, 20);
            labelShoes.TabIndex = 18;
            labelShoes.Text = "Shoes: Sneakers";
            // 
            // buttonPrevShoes
            // 
            buttonPrevShoes.Location = new Point(290, 274);
            buttonPrevShoes.Name = "buttonPrevShoes";
            buttonPrevShoes.Size = new Size(25, 23);
            buttonPrevShoes.TabIndex = 19;
            buttonPrevShoes.Text = "<";
            buttonPrevShoes.Click += buttonPrevShoes_Click;
            // 
            // buttonNextShoes
            // 
            buttonNextShoes.Location = new Point(520, 274);
            buttonNextShoes.Name = "buttonNextShoes";
            buttonNextShoes.Size = new Size(25, 23);
            buttonNextShoes.TabIndex = 20;
            buttonNextShoes.Text = ">";
            buttonNextShoes.Click += buttonNextShoes_Click;
            // 
            // buttonNextPlayer
            // 
            buttonNextPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonNextPlayer.Location = new Point(320, 326);
            buttonNextPlayer.Name = "buttonNextPlayer";
            buttonNextPlayer.Size = new Size(200, 40);
            buttonNextPlayer.TabIndex = 21;
            buttonNextPlayer.Text = "Next";
            buttonNextPlayer.Click += buttonNextPlayer_Click;
            // 
            // CharacterCustomizationForm
            // 
            ClientSize = new Size(800, 380);
            Controls.Add(labelTitle);
            Controls.Add(labelPlayer1Name);
            Controls.Add(labelPlayer2Name);
            Controls.Add(labelCurrentPlayer);
            Controls.Add(pictureBoxPlayer1);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(labelColor);
            Controls.Add(buttonPrevColor);
            Controls.Add(buttonNextColor);
            Controls.Add(labelHead);
            Controls.Add(buttonPrevHead);
            Controls.Add(buttonNextHead);
            Controls.Add(labelShirt);
            Controls.Add(buttonPrevShirt);
            Controls.Add(buttonNextShirt);
            Controls.Add(labelPants);
            Controls.Add(buttonPrevPants);
            Controls.Add(buttonNextPants);
            Controls.Add(labelShoes);
            Controls.Add(buttonPrevShoes);
            Controls.Add(buttonNextShoes);
            Controls.Add(buttonNextPlayer);
            Name = "CharacterCustomizationForm";
            Text = "Character Customization";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
            ResumeLayout(false);
        }
    }
}
