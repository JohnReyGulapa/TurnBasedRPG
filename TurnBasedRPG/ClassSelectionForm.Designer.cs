namespace TurnBasedRPG
{
    partial class ClassSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private FlowLayoutPanel panelClassButtons;
        private Label labelClassDescription;
        private Label labelClassStats;
        private Label labelPlayer1Choice;
        private Label labelPlayer2Choice;
        private Button buttonNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelClassButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.labelClassDescription = new System.Windows.Forms.Label();
            this.labelClassStats = new System.Windows.Forms.Label();
            this.labelPlayer1Choice = new System.Windows.Forms.Label();
            this.labelPlayer2Choice = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Size = new System.Drawing.Size(760, 30);
            this.labelTitle.Text = "Player 1, choose your class";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelClassButtons
            this.panelClassButtons.Location = new System.Drawing.Point(20, 50);
            this.panelClassButtons.Size = new System.Drawing.Size(500, 300);

            // labelClassDescription
            this.labelClassDescription.Location = new System.Drawing.Point(530, 50);
            this.labelClassDescription.Size = new System.Drawing.Size(250, 100);
            this.labelClassDescription.Text = "Class Description Here";

            // labelClassStats
            this.labelClassStats.Location = new System.Drawing.Point(530, 160);
            this.labelClassStats.Size = new System.Drawing.Size(250, 120);
            this.labelClassStats.Text = "Stats";

            // labelPlayer1Choice
            this.labelPlayer1Choice.Location = new System.Drawing.Point(20, 360);
            this.labelPlayer1Choice.Size = new System.Drawing.Size(360, 30);
            this.labelPlayer1Choice.Text = "Player 1: Not selected";

            // labelPlayer2Choice
            this.labelPlayer2Choice.Location = new System.Drawing.Point(400, 360);
            this.labelPlayer2Choice.Size = new System.Drawing.Size(360, 30);
            this.labelPlayer2Choice.Text = "Player 2: Not selected";

            // buttonNext
            this.buttonNext.Location = new System.Drawing.Point(330, 400);
            this.buttonNext.Size = new System.Drawing.Size(120, 40);
            this.buttonNext.Text = "Next";
            this.buttonNext.Enabled = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);

            // ClassSelectionForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelClassButtons);
            this.Controls.Add(this.labelClassDescription);
            this.Controls.Add(this.labelClassStats);
            this.Controls.Add(this.labelPlayer1Choice);
            this.Controls.Add(this.labelPlayer2Choice);
            this.Controls.Add(this.buttonNext);
            this.Text = "Class Selection";
            this.ResumeLayout(false);
        }
    }
}
