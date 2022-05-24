using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace State
{
    public class PinInserted : State
    {

        protected Context _context;
        public PinInserted(Context context) : base(context)
        {
            _context = context;
        }


        public override void EjectCard()
        {
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }

        public override void InserPin(int pin)
        {
            Console.WriteLine("You have already inserted correct PIN");
        }

        public override void InsertCard()
        {
            Console.WriteLine("You have already inserted a card");
        }

        public override void WithdrawCash(int amount)
        {
            if (amount > _context.AvailableCash)
            {
                Console.WriteLine("That amount of cash is not available");
            }
            else
            {
                Console.WriteLine($"You have withdraw {amount } from the machine");

                _context.AvailableCash -= amount;

                if (_context.AvailableCash == 0)
                {
                    _context.ChangeState(new NoCash(_context));
                }
                else
                {
                    Console.WriteLine("Card ejected");

                    _context.ChangeState(new NoCard(_context));
                }
            }
        }
    }
}