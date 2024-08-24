using TicketManagementSystem.TicketManagementSystem;
using System;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    public partial class Form1 : Form
    {
        private TicketManager ticketManager;

        public Form1()
        {
            InitializeComponent();
            ticketManager = new TicketManager();

            // Subscribe to the form's Load event
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Placeholder for any code to be executed when the form loads
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            string description = txtTicketDescription.Text;
            ticketManager.CreateTicket(description);
            // Optionally, update UI to reflect the created ticket
        }

        private void btnProcessTicket_Click(object sender, EventArgs e)
        {
            ticketManager.ProcessTicket();
            // Optionally, update UI to reflect the processed ticket
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ticketManager.UndoAction();
            // Optionally, update UI to reflect the undone action
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            DisplayTickets();
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            string ticketNumberInput = Microsoft.VisualBasic.Interaction.InputBox("Enter ticket number to search:", "Search Ticket", "");
            int ticketNumber;
            if (int.TryParse(ticketNumberInput, out ticketNumber))
            {
                SearchTicket(ticketNumber);
            }
            else
            {
                MessageBox.Show("Invalid ticket number.");
            }
        }

        private void btnModifyTicket_Click(object sender, EventArgs e)
        {
            string ticketNumberInput = Microsoft.VisualBasic.Interaction.InputBox("Enter ticket number to modify:", "Modify Ticket", "");
            int ticketNumber;
            if (int.TryParse(ticketNumberInput, out ticketNumber))
            {
                ModifyTicket(ticketNumber);
            }
            else
            {
                MessageBox.Show("Invalid ticket number.");
            }
        }

        private void btnSortTickets_Click(object sender, EventArgs e)
        {
            ticketManager.SortTickets();
            // Optionally, update UI to reflect the sorted tickets
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayTickets()
        {
            string ticketInfo = "";
            foreach (Ticket ticket in ticketManager.GetTickets())
            {
                ticketInfo += $"Ticket Number: {ticket.TicketNumber}, Description: {ticket.Description}, Processed: {(ticket.IsProcessed ? "Yes" : "No")}\n";
            }
            MessageBox.Show(ticketInfo, "Tickets");
        }

        private void SearchTicket(int ticketNumber)
        {
            Ticket ticket = ticketManager.SearchTicket(ticketNumber);
            if (ticket != null)
            {
                MessageBox.Show($"Ticket found:\nTicket Number: {ticket.TicketNumber}, Description: {ticket.Description}, Processed: {(ticket.IsProcessed ? "Yes" : "No")}", "Search Result");
            }
            else
            {
                MessageBox.Show("Ticket not found.", "Search Result");
            }
        }

        private void ModifyTicket(int ticketNumber)
        {
            string newDescription = Microsoft.VisualBasic.Interaction.InputBox("Enter new description for the ticket:", "Modify Ticket", "");
            ticketManager.ModifyTicket(ticketNumber, newDescription);
            // Optionally, update UI to reflect the modified ticket
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
