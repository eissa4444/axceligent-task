using System;
using System.Collections.Generic;
using System.Text;

namespace JohnTheRobot
{
    public class Humanoid : IStrategy
    {
        private IStrategy _behavior;

        public Humanoid()
        {

        }
        public Humanoid(IStrategy behavior)
        {
            _behavior = behavior;
        }

        public string ShowSkill()
        {
            if (_behavior == null)
                return "no skill is defined";
            
            return _behavior.ShowSkill();
        }
    }
}
