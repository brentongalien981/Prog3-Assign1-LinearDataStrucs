namespace Assign1_Question3_Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addAthleteLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.silverTextBox = new System.Windows.Forms.TextBox();
            this.bronzeTextBox = new System.Windows.Forms.TextBox();
            this.athletesListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.yearColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.goldColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.silverColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.bronzeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.allAthletesLabel = new System.Windows.Forms.Label();
            this.deleteAthleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.myDebugLabel1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(628, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Athlete";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Athlete Name";
            this.nameTextBox.Size = new System.Drawing.Size(238, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // addAthleteLabel
            // 
            this.addAthleteLabel.AutoSize = true;
            this.addAthleteLabel.Location = new System.Drawing.Point(12, 9);
            this.addAthleteLabel.Name = "addAthleteLabel";
            this.addAthleteLabel.Size = new System.Drawing.Size(70, 15);
            this.addAthleteLabel.TabIndex = 2;
            this.addAthleteLabel.Text = "Add Athlete";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(256, 27);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PlaceholderText = "Year";
            this.yearTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearTextBox.TabIndex = 3;
            // 
            // goldTextBox
            // 
            this.goldTextBox.Location = new System.Drawing.Point(362, 27);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.PlaceholderText = "Gold";
            this.goldTextBox.Size = new System.Drawing.Size(75, 23);
            this.goldTextBox.TabIndex = 4;
            // 
            // silverTextBox
            // 
            this.silverTextBox.Location = new System.Drawing.Point(443, 27);
            this.silverTextBox.Name = "silverTextBox";
            this.silverTextBox.PlaceholderText = "Silver";
            this.silverTextBox.Size = new System.Drawing.Size(73, 23);
            this.silverTextBox.TabIndex = 5;
            // 
            // bronzeTextBox
            // 
            this.bronzeTextBox.Location = new System.Drawing.Point(522, 27);
            this.bronzeTextBox.Name = "bronzeTextBox";
            this.bronzeTextBox.PlaceholderText = "Bronze";
            this.bronzeTextBox.Size = new System.Drawing.Size(100, 23);
            this.bronzeTextBox.TabIndex = 6;
            // 
            // athletesListView
            // 
            this.athletesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.yearColumnHeader,
            this.goldColumnHeader,
            this.silverColumnHeader,
            this.bronzeColumnHeader});
            this.athletesListView.Location = new System.Drawing.Point(12, 186);
            this.athletesListView.Name = "athletesListView";
            this.athletesListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.athletesListView.Size = new System.Drawing.Size(916, 297);
            this.athletesListView.TabIndex = 7;
            this.athletesListView.UseCompatibleStateImageBehavior = false;
            this.athletesListView.View = System.Windows.Forms.View.Details;
            this.athletesListView.Click += new System.EventHandler(this.athletesListView_Click);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 240;
            // 
            // yearColumnHeader
            // 
            this.yearColumnHeader.Text = "Year";
            this.yearColumnHeader.Width = 100;
            // 
            // goldColumnHeader
            // 
            this.goldColumnHeader.Text = "Gold";
            // 
            // silverColumnHeader
            // 
            this.silverColumnHeader.Text = "Silver";
            // 
            // bronzeColumnHeader
            // 
            this.bronzeColumnHeader.Text = "Bronze";
            // 
            // allAthletesLabel
            // 
            this.allAthletesLabel.AutoSize = true;
            this.allAthletesLabel.Location = new System.Drawing.Point(12, 168);
            this.allAthletesLabel.Name = "allAthletesLabel";
            this.allAthletesLabel.Size = new System.Drawing.Size(67, 15);
            this.allAthletesLabel.TabIndex = 8;
            this.allAthletesLabel.Text = "All Athletes";
            // 
            // deleteAthleteButton
            // 
            this.deleteAthleteButton.Location = new System.Drawing.Point(12, 489);
            this.deleteAthleteButton.Name = "deleteAthleteButton";
            this.deleteAthleteButton.Size = new System.Drawing.Size(113, 23);
            this.deleteAthleteButton.TabIndex = 9;
            this.deleteAthleteButton.Text = "Delete Athlete";
            this.deleteAthleteButton.UseVisualStyleBackColor = true;
            this.deleteAthleteButton.Click += new System.EventHandler(this.deleteAthleteButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(501, 156);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Type Anything";
            this.searchTextBox.Size = new System.Drawing.Size(265, 23);
            this.searchTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(772, 156);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // myDebugLabel1
            // 
            this.myDebugLabel1.AutoSize = true;
            this.myDebugLabel1.Location = new System.Drawing.Point(12, 611);
            this.myDebugLabel1.Name = "myDebugLabel1";
            this.myDebugLabel1.Size = new System.Drawing.Size(0, 15);
            this.myDebugLabel1.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(853, 156);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 635);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.myDebugLabel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteAthleteButton);
            this.Controls.Add(this.allAthletesLabel);
            this.Controls.Add(this.athletesListView);
            this.Controls.Add(this.bronzeTextBox);
            this.Controls.Add(this.silverTextBox);
            this.Controls.Add(this.goldTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.addAthleteLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Olympic Athletes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private TextBox nameTextBox;
        private Label addAthleteLabel;
        private TextBox yearTextBox;
        private TextBox goldTextBox;
        private TextBox silverTextBox;
        private TextBox bronzeTextBox;
        private ListView athletesListView;
        private Label allAthletesLabel;
        private Button deleteAthleteButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private ColumnHeader nameColumnHeader;
        private ColumnHeader yearColumnHeader;
        private ColumnHeader goldColumnHeader;
        private ColumnHeader silverColumnHeader;
        private ColumnHeader bronzeColumnHeader;
        private Label myDebugLabel1;
        private Button clearButton;
    }
}