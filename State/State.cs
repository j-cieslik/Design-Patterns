using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace State
{
    public abstract class State
    {
        protected Context _context;

        public State(Context context)
        {
            _context = context;
        }

        public abstract void InsertCard();
        public abstract void EjectCard();
        public abstract void InserPin(int pin);
        public abstract void WithdrawCash(int amount);
    }
}