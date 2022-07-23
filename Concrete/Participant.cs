using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomWithMediator.Concrete
{
    public class Participant
    {
        public ChatRoom ChatRoom { get; set; }
        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
        }
        public void Send(string receiver, string message)
        {
            ChatRoom.Send(Name, receiver, message);
        }
        public void Receive(string sender, string message)
        {
            Console.WriteLine($"{sender} to {Name}: '{message}'");
        }
    }

}