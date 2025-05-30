using System;
using System.Windows.Forms;

namespace TurnBasedRPG
{
    public partial class Form1 : Form
    {
        private Character player1;
        private Character player2;

        private bool isPlayer1Turn;
        private Random rand = new Random();

        // New constructor accepting player characters
        public Form1(Character p1, Character p2)
        {
            InitializeComponent();

            player1 = p1;
            player2 = p2;

            // Randomly decide who starts first
            isPlayer1Turn = rand.Next(2) == 0;

            UpdateUI();
        }

        // Removed the old StartGame method that creates default characters

        private void UpdateUI(string actionLog = "")
        {
            labelP1Stats.Text = $"{player1.Name} ({player1.Class})\nHP: {player1.Hp}/{player1.MaxHp}\nStress: {player1.Stress}/{player1.MaxStress}";
            labelP2Stats.Text = $"{player2.Name} ({player2.Class})\nHP: {player2.Hp}/{player2.MaxHp}\nStress: {player2.Stress}/{player2.MaxStress}";

            labelTurnInfo.Text = actionLog + "\n" + (isPlayer1Turn ? $"{player1.Name}'s turn." : $"{player2.Name}'s turn.");

            // Enable or disable buttons based on current player's stun state
            bool isStunned = GetCurrentPlayer().IsStunned;
            buttonAttack.Enabled = !isStunned;
            buttonTaunt.Enabled = !isStunned;
            buttonDefend.Enabled = !isStunned;

            if (isStunned)
            {
                labelTurnInfo.Text += "\nYou're stunned! Skipping turn...";
                EndTurn(); // Automatically skip turn if stunned
            }
        }

        private Character GetCurrentPlayer() => isPlayer1Turn ? player1 : player2;
        private Character GetOpponentPlayer() => isPlayer1Turn ? player2 : player1;

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            var attacker = GetCurrentPlayer();
            var defender = GetOpponentPlayer();

            attacker.AttackTarget(defender);
            string log = $"{attacker.Name} attacked {defender.Name}!";

            CheckPassiveTriggers(attacker, defender);
            CheckGameOver();
            EndTurn(log);
        }

        private void buttonTaunt_Click(object sender, EventArgs e)
        {
            var attacker = GetCurrentPlayer();
            var defender = GetOpponentPlayer();

            attacker.Taunt(defender);
            string log = $"{attacker.Name} taunted {defender.Name}.";

            CheckPassiveTriggers(attacker, defender);
            CheckGameOver();
            EndTurn(log);
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            var defender = GetCurrentPlayer();
            defender.Defend();
            string log = $"{defender.Name} defended!";

            EndTurn(log);
        }

        private void EndTurn(string log = "")
        {
            GetCurrentPlayer().EndTurnReset();
            isPlayer1Turn = !isPlayer1Turn;
            UpdateUI(log);
        }

        private void CheckPassiveTriggers(Character current, Character opponent)
        {
            // Trigger passive effects (some already handled internally)
            current.ApplyPassiveEffects();
            opponent.ApplyPassiveEffects();
        }

        private void CheckGameOver()
        {
            if (!player1.IsAlive)
            {
                MessageBox.Show($"{player2.Name} wins!");
                DisableButtons();
            }
            else if (!player2.IsAlive)
            {
                MessageBox.Show($"{player1.Name} wins!");
                DisableButtons();
            }
        }

        private void DisableButtons()
        {
            buttonAttack.Enabled = false;
            buttonTaunt.Enabled = false;
            buttonDefend.Enabled = false;
        }
    }
}
