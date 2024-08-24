using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem
{
    using System.Collections.Generic;

    public class UndoTicketAction
    {
        public enum ActionType { Process, UndoProcess }

        public ActionType Action { get; set; }
        public int TicketNumber { get; set; }

        public UndoTicketAction(ActionType action, int ticketNumber)
        {
            Action = action;
            TicketNumber = ticketNumber;
        }

        public void Undo(List<Ticket> tickets)
        {
            var ticket = tickets.Find(t => t.TicketNumber == TicketNumber);
            if (ticket != null)
            {
                switch (Action)
                {
                    case ActionType.Process:
                        ticket.UndoProcess();
                        break;
                    case ActionType.UndoProcess:
                        ticket.Process();
                        break;
                    default:
                        break;
                }
            }
        }
    }


}
