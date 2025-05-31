namespace TurnBasedRPG
{
    partial class NameInputForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBoxPlayer1;
        private Label label2;
        private TextBox textBoxPlayer2;
        private Button buttonSelectCharacter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxPlayer1 = new TextBox();
            label2 = new Label();
            textBoxPlayer2 = new TextBox();
            buttonSelectCharacter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 89);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Player 1 Name:";
            // 
            // textBoxPlayer1
            // 
            textBoxPlayer1.Location = new Point(101, 122);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.Size = new Size(150, 23);
            textBoxPlayer1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Player 2 Name:";
            // 
            // textBoxPlayer2
            // 
            textBoxPlayer2.Location = new Point(472, 122);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.Size = new Size(150, 23);
            textBoxPlayer2.TabIndex = 3;
            textBoxPlayer2.TextChanged += textBoxPlayer2_TextChanged;
            // 
            // buttonSelectCharacter
            // 
            buttonSelectCharacter.Location = new Point(286, 160);
            buttonSelectCharacter.Name = "buttonSelectCharacter";
            buttonSelectCharacter.Size = new Size(139, 53);
            buttonSelectCharacter.TabIndex = 4;
            buttonSelectCharacter.Text = "Select Character";
            buttonSelectCharacter.Click += buttonSelectCharacter_Click;
            // 
            // NameInputForm
            // 
            ClientSize = new Size(721, 275);
            Controls.Add(label1);
            Controls.Add(textBoxPlayer1);
            Controls.Add(label2);
            Controls.Add(textBoxPlayer2);
            Controls.Add(buttonSelectCharacter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NameInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Player Names";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
