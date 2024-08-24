using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem
{
    public class Ticket
    {
        public int TicketNumber { get; set; }
        public string Description { get; set; }
        public bool IsProcessed { get; set; }

        public Ticket(int ticketNumber, string description)
        {
            TicketNumber = ticketNumber;
            Description = description;
            IsProcessed = false;
        }

        public void Process()
        {
            IsProcessed = true;
        }

        public void UndoProcess()
        {
            IsProcessed = false;
        }
    }

}


