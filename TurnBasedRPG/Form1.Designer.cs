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
            pictureBoxPlayer1 = new PictureBox();
            pictureBoxPlayer2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).BeginInit();
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
            labelTurnInfo.Location = new Point(30, 324);
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
            buttonAttack.Location = new Point(78, 433);
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
            buttonTaunt.Location = new Point(370, 433);
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
            buttonDefend.Location = new Point(654, 433);
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
            // pictureBoxPlayer1
            // 
            pictureBoxPlayer1.AccessibleName = "pictureBoxPlayer1";
            pictureBoxPlayer1.Location = new Point(45, 119);
            pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            pictureBoxPlayer1.Size = new Size(202, 178);
            pictureBoxPlayer1.TabIndex = 8;
            pictureBoxPlayer1.TabStop = false;
            pictureBoxPlayer1.Click += pictureBox1_Click;
            // 
            // pictureBoxPlayer2
            // 
            pictureBoxPlayer2.AccessibleName = "pictureBoxPlayer2";
            pictureBoxPlayer2.Location = new Point(601, 119);
            pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            pictureBoxPlayer2.Size = new Size(200, 178);
            pictureBoxPlayer2.TabIndex = 9;
            pictureBoxPlayer2.TabStop = false;
            pictureBoxPlayer2.Click += pictureBoxPlayer2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(838, 520);
            Controls.Add(pictureBoxPlayer2);
            Controls.Add(pictureBoxPlayer1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer2).EndInit();
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
        private PictureBox pictureBoxPlayer1;
        private PictureBox pictureBoxPlayer2;
    }
}
