namespace TicketManagementSystem
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
            btnCreateTicket = new Button();
            btnProcessTicket = new Button();
            btnUndo = new Button();
            btnViewTickets = new Button();
            btnSearchTicket = new Button();
            btnModifyTicket = new Button();
            btnSortTickets = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Location = new Point(53, 86);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(150, 34);
            btnCreateTicket.TabIndex = 1;
            btnCreateTicket.Text = "Create Ticket";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // btnProcessTicket
            // 
            btnProcessTicket.Location = new Point(53, 139);
            btnProcessTicket.Name = "btnProcessTicket";
            btnProcessTicket.Size = new Size(150, 34);
            btnProcessTicket.TabIndex = 2;
            btnProcessTicket.Text = "Process Ticket";
            btnProcessTicket.UseVisualStyleBackColor = true;
            btnProcessTicket.Click += btnProcessTicket_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(53, 194);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(150, 34);
            btnUndo.TabIndex = 3;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnViewTickets
            // 
            btnViewTickets.Location = new Point(53, 248);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(150, 34);
            btnViewTickets.TabIndex = 4;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = true;
            btnViewTickets.Click += btnViewTickets_Click;
            // 
            // btnSearchTicket
            // 
            btnSearchTicket.Location = new Point(53, 303);
            btnSearchTicket.Name = "btnSearchTicket";
            btnSearchTicket.Size = new Size(150, 34);
            btnSearchTicket.TabIndex = 5;
            btnSearchTicket.Text = "Search Ticket";
            btnSearchTicket.UseVisualStyleBackColor = true;
            btnSearchTicket.Click += btnSearchTicket_Click;
            // 
            // btnModifyTicket
            // 
            btnModifyTicket.Location = new Point(53, 357);
            btnModifyTicket.Name = "btnModifyTicket";
            btnModifyTicket.Size = new Size(150, 34);
            btnModifyTicket.TabIndex = 6;
            btnModifyTicket.Text = "Modify Ticket";
            btnModifyTicket.UseVisualStyleBackColor = true;
            btnModifyTicket.Click += btnModifyTicket_Click;
            // 
            // btnSortTickets
            // 
            btnSortTickets.Location = new Point(53, 411);
            btnSortTickets.Name = "btnSortTickets";
            btnSortTickets.Size = new Size(150, 34);
            btnSortTickets.TabIndex = 7;
            btnSortTickets.Text = "Sort Tickets";
            btnSortTickets.UseVisualStyleBackColor = true;
            btnSortTickets.Click += btnSortTickets_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(53, 465);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 34);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 36);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 9;
            label1.Text = "Ticket Creator";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 568);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnSortTickets);
            Controls.Add(btnModifyTicket);
            Controls.Add(btnSearchTicket);
            Controls.Add(btnViewTickets);
            Controls.Add(btnUndo);
            Controls.Add(btnProcessTicket);
            Controls.Add(btnCreateTicket);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnProcessTicket;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnViewTickets;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Button btnModifyTicket;
        private System.Windows.Forms.Button btnSortTickets;
        private System.Windows.Forms.Button btnExit;
        private Label label1;
    }
}
