using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace State
{
    public class Context
    {
        public int AvailableCash { get; set; } = 2000;

        private State _currentState;

        public Context()
        {
            _currentState = new NoCard(this);
        }

        public void ChangeState(State newState)
        {
            _currentState = newState;
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void InsertPin(int pin)
        {
            _currentState.InserPin(pin);
        }

        public void WithdrawCash(int amount)
        {
            _currentState.WithdrawCash(amount);
        }

    }
}