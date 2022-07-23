using ChatRoomWithMediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomWithMediator.Concrete
{
    public class ChatRoom : IChatRoom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ChatRoom = this;
        }
        public void Send(string sender, string receiver, string message)
        {
            Participant participant = _participants[receiver];

            if (participant != null)
            {
                participant.Receive(sender, message);
            }
        }
    }

}