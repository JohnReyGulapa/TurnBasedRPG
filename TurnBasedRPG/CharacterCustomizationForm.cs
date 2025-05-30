using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class CharacterCustomizationForm : Form
    {
        private Character player1;
        private Character player2;

        private int currentPlayerIndex = 1; // 1 or 2
        private Character currentPlayer;

        // Options arrays for each customizable part (colors and accessories)
        private Color[] colors = { Color.Black, Color.Blue, Color.Red, Color.Green, Color.Purple };
        private string[] headAccessories = { "None", "Hat", "Glasses", "Helmet" };
        private string[] shirts = { "T-Shirt", "Jacket", "Hoodie" };
        private string[] pants = { "Jeans", "Shorts", "Trousers" };
        private string[] shoes = { "Sneakers", "Boots", "Sandals" };

        // Current indices for customization for each player
        private int[] colorIndex = new int[3];         // [player1=0, player2=1]
        private int[] headIndex = new int[3];
        private int[] shirtIndex = new int[3];
        private int[] pantsIndex = new int[3];
        private int[] shoesIndex = new int[3];

        public CharacterCustomizationForm(string player1Name, ClassType player1Class, string player2Name, ClassType player2Class)
        {
            InitializeComponent();

            player1 = new Character(player1Name, player1Class);
            player2 = new Character(player2Name, player2Class);

            currentPlayer = player1;
            currentPlayerIndex = 1;

            UpdateUI();
        }

        private void UpdateUI()
        {
            labelTitle.Text = "Customize Your Character";

            labelPlayer1Name.Text = player1.Name;
            labelPlayer2Name.Text = player2.Name;

            labelCurrentPlayer.Text = $"Current: {currentPlayer.Name}";

            // Draw stick figures colored based on customization
            DrawStickFigure(pictureBoxPlayer1, colorIndex[1]);
            DrawStickFigure(pictureBoxPlayer2, colorIndex[2]);

            // Update customization labels
            labelColor.Text = $"Color: {colors[colorIndex[currentPlayerIndex]].Name}";
            labelHead.Text = $"Head: {headAccessories[headIndex[currentPlayerIndex]]}";
            labelShirt.Text = $"Shirt: {shirts[shirtIndex[currentPlayerIndex]]}";
            labelPants.Text = $"Pants: {pants[pantsIndex[currentPlayerIndex]]}";
            labelShoes.Text = $"Shoes: {shoes[shoesIndex[currentPlayerIndex]]}";
        }

        private void DrawStickFigure(PictureBox pb, int colorIdx)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Pen pen = new Pen(colors[colorIdx], 4);

                // Draw a simple stick figure centered in the PictureBox
                int centerX = pb.Width / 2;
                int centerY = pb.Height / 2;

                // Head
                g.DrawEllipse(pen, centerX - 15, centerY - 60, 30, 30);

                // Body
                g.DrawLine(pen, centerX, centerY - 30, centerX, centerY + 30);

                // Arms
                g.DrawLine(pen, centerX - 20, centerY - 10, centerX + 20, centerY - 10);

                // Legs
                g.DrawLine(pen, centerX, centerY + 30, centerX - 20, centerY + 60);
                g.DrawLine(pen, centerX, centerY + 30, centerX + 20, centerY + 60);
            }
            pb.Image = bmp;
        }

        private void buttonNextPart_Click(object sender, EventArgs e)
        {
            // Move to next customization part (not implemented here)
        }

        private void buttonPrevColor_Click(object sender, EventArgs e)
        {
            ChangeOption(ref colorIndex[currentPlayerIndex], colors.Length, -1);
            UpdateUI();
        }

        private void buttonNextColor_Click(object sender, EventArgs e)
        {
            ChangeOption(ref colorIndex[currentPlayerIndex], colors.Length, +1);
            UpdateUI();
        }

        private void buttonPrevHead_Click(object sender, EventArgs e)
        {
            ChangeOption(ref headIndex[currentPlayerIndex], headAccessories.Length, -1);
            UpdateUI();
        }

        private void buttonNextHead_Click(object sender, EventArgs e)
        {
            ChangeOption(ref headIndex[currentPlayerIndex], headAccessories.Length, +1);
            UpdateUI();
        }

        private void buttonPrevShirt_Click(object sender, EventArgs e)
        {
            ChangeOption(ref shirtIndex[currentPlayerIndex], shirts.Length, -1);
            UpdateUI();
        }

        private void buttonNextShirt_Click(object sender, EventArgs e)
        {
            ChangeOption(ref shirtIndex[currentPlayerIndex], shirts.Length, +1);
            UpdateUI();
        }

        private void buttonPrevPants_Click(object sender, EventArgs e)
        {
            ChangeOption(ref pantsIndex[currentPlayerIndex], pants.Length, -1);
            UpdateUI();
        }

        private void buttonNextPants_Click(object sender, EventArgs e)
        {
            ChangeOption(ref pantsIndex[currentPlayerIndex], pants.Length, +1);
            UpdateUI();
        }

        private void buttonPrevShoes_Click(object sender, EventArgs e)
        {
            ChangeOption(ref shoesIndex[currentPlayerIndex], shoes.Length, -1);
            UpdateUI();
        }

        private void buttonNextShoes_Click(object sender, EventArgs e)
        {
            ChangeOption(ref shoesIndex[currentPlayerIndex], shoes.Length, +1);
            UpdateUI();
        }

        private void ChangeOption(ref int index, int length, int delta)
        {
            index += delta;
            if (index < 0) index = length - 1;
            if (index >= length) index = 0;
        }

        private void buttonNextPlayer_Click(object sender, EventArgs e)
        {
            if (currentPlayerIndex == 1)
            {
                // Save player1 customization here if needed

                currentPlayer = player2;
                currentPlayerIndex = 2;
                UpdateUI();
            }
            else
            {
                // Save player2 customization if needed

                // Move to main game form
                Form1 mainForm = new Form1(player1, player2);
                mainForm.Show();
                this.Close();
            }
        }
    }
}
