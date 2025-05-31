namespace TurnBasedRPG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelP1Stats = new Label();
            labelP2Stats = new Label();
            labelTurnInfo = new Label();
            buttonAttack = new Button();
            buttonTaunt = new Button();
            buttonDefend = new Button();
            panelP1HPBar = new Panel();
            panelP2HPBar = new Panel();
            SuspendLayout();
            // 
            // labelP1Stats
            // 
            labelP1Stats.AutoSize = true;
            labelP1Stats.Font = new Font("Segoe UI", 10F);
            labelP1Stats.Location = new Point(30, 30);
            labelP1Stats.Name = "labelP1Stats";
            labelP1Stats.Size = new Size(101, 19);
            labelP1Stats.TabIndex = 0;
            labelP1Stats.Text = "Player 1 Stats...";
            // 
            // labelP2Stats
            // 
            labelP2Stats.AutoSize = true;
            labelP2Stats.Font = new Font("Segoe UI", 10F);
            labelP2Stats.Location = new Point(601, 30);
            labelP2Stats.Name = "labelP2Stats";
            labelP2Stats.Size = new Size(101, 19);
            labelP2Stats.TabIndex = 1;
            labelP2Stats.Text = "Player 2 Stats...";
            // 
            // labelTurnInfo
            // 
            labelTurnInfo.AutoSize = true;
            labelTurnInfo.Font = new Font("Segoe UI", 10F);
            labelTurnInfo.Location = new Point(30, 248);
            labelTurnInfo.MaximumSize = new Size(500, 0);
            labelTurnInfo.Name = "labelTurnInfo";
            labelTurnInfo.Size = new Size(121, 19);
            labelTurnInfo.TabIndex = 2;
            labelTurnInfo.Text = "Turn information...";
            // 
            // buttonAttack
            // 
            buttonAttack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAttack.Font = new Font("Segoe UI", 10F);
            buttonAttack.Location = new Point(130, 336);
            buttonAttack.Name = "buttonAttack";
            buttonAttack.Size = new Size(100, 40);
            buttonAttack.TabIndex = 3;
            buttonAttack.Text = "Attack";
            buttonAttack.UseVisualStyleBackColor = true;
            buttonAttack.Click += buttonAttack_Click;
            // 
            // buttonTaunt
            // 
            buttonTaunt.Font = new Font("Segoe UI", 10F);
            buttonTaunt.Location = new Point(398, 336);
            buttonTaunt.Name = "buttonTaunt";
            buttonTaunt.Size = new Size(100, 40);
            buttonTaunt.TabIndex = 4;
            buttonTaunt.Text = "Taunt";
            buttonTaunt.UseVisualStyleBackColor = true;
            buttonTaunt.Click += buttonTaunt_Click;
            // 
            // buttonDefend
            // 
            buttonDefend.Font = new Font("Segoe UI", 10F);
            buttonDefend.Location = new Point(703, 336);
            buttonDefend.Name = "buttonDefend";
            buttonDefend.Size = new Size(100, 40);
            buttonDefend.TabIndex = 5;
            buttonDefend.Text = "Defend";
            buttonDefend.UseVisualStyleBackColor = true;
            buttonDefend.Click += buttonDefend_Click;
            // 
            // panelP1HPBar
            // 
            panelP1HPBar.BackColor = SystemColors.ControlDark;
            panelP1HPBar.Location = new Point(30, 52);
            panelP1HPBar.Name = "panelP1HPBar";
            panelP1HPBar.Size = new Size(200, 20);
            panelP1HPBar.TabIndex = 6;
            panelP1HPBar.Paint += panelP1HPBar_Paint;
            // 
            // panelP2HPBar
            // 
            panelP2HPBar.BackColor = SystemColors.ControlDark;
            panelP2HPBar.Location = new Point(601, 52);
            panelP2HPBar.Name = "panelP2HPBar";
            panelP2HPBar.Size = new Size(200, 20);
            panelP2HPBar.TabIndex = 7;
            panelP2HPBar.Paint += panelP2HPBar_Paint;
            // 
            // Form1
            // 
            ClientSize = new Size(856, 422);
            Controls.Add(panelP2HPBar);
            Controls.Add(panelP1HPBar);
            Controls.Add(buttonDefend);
            Controls.Add(buttonTaunt);
            Controls.Add(buttonAttack);
            Controls.Add(labelTurnInfo);
            Controls.Add(labelP2Stats);
            Controls.Add(labelP1Stats);
            Name = "Form1";
            Text = "Turn-Based RPG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelP1Stats;
        private System.Windows.Forms.Label labelP2Stats;
        private System.Windows.Forms.Label labelTurnInfo;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonTaunt;
        private System.Windows.Forms.Button buttonDefend;
        private Panel panelP1HPBar;
        private Panel panelP2HPBar;
    }
}
