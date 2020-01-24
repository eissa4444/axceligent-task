using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSettings
{
    public class Alexa
    {
        private MessageAttribute _messageAttribute;
        public Alexa()
        {
        }
        public string Talk()
        {
            if (_messageAttribute != null)
                return _messageAttribute.GreetingMessage.Interpolate(_messageAttribute);

            return "hello, i am Alexa";
        }

        internal void Configure(Action<MessageAttribute> action)
        {
            _messageAttribute = new MessageAttribute();
            action?.Invoke(_messageAttribute);
        }
    }
}
