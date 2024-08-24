using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TicketManagementSystem
{

    namespace TicketManagementSystem
    {
        public class TicketManager
        {
            private Stack<UndoTicketAction> undoStack;
            private Queue<int> ticketQueue;
            private List<Ticket> ticketList;
            private Dictionary<int, Ticket> ticketDictionary;

            public TicketManager()
            {
                undoStack = new Stack<UndoTicketAction>();
                ticketQueue = new Queue<int>();
                ticketList = new List<Ticket>();
                ticketDictionary = new Dictionary<int, Ticket>();
            }

            public void CreateTicket(string description)
            {
                int ticketNumber = ticketList.Count + 1; // Generating ticket number
                Ticket newTicket = new Ticket(ticketNumber, description);
                ticketQueue.Enqueue(ticketNumber);
                ticketList.Add(newTicket);
                ticketDictionary.Add(ticketNumber, newTicket);
                undoStack.Push(new UndoTicketAction(UndoTicketAction.ActionType.UndoProcess, ticketNumber));
            }

            public void ProcessTicket()
            {
                if (ticketQueue.Count > 0)
                {
                    int ticketNumber = ticketQueue.Dequeue();
                    ticketDictionary[ticketNumber].Process();
                    undoStack.Push(new UndoTicketAction(UndoTicketAction.ActionType.Process, ticketNumber));
                }
            }

            public void UndoAction()
            {
                if (undoStack.Count > 0)
                {
                    UndoTicketAction action = undoStack.Pop();
                    action.Undo(ticketList);
                }
            }

            public void SortTickets()
            {
                // Sort tickets by some criteria (e.g., ticket number, description, etc.)
                ticketList.Sort((t1, t2) => t1.TicketNumber.CompareTo(t2.TicketNumber));
            }

            public List<Ticket> GetTickets()
            {
                return ticketList;
            }

            public Ticket SearchTicket(int ticketNumber)
            {
                return ticketList.FirstOrDefault(t => t.TicketNumber == ticketNumber);
            }

            public void ModifyTicket(int ticketNumber, string newDescription)
            {
                Ticket ticket = ticketList.FirstOrDefault(t => t.TicketNumber == ticketNumber);
                if (ticket != null)
                {
                    ticket.Description = newDescription;
                }
            }
        }




    }
}
