using ChatRoomWithMediator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomWithMediator.Abstract
{
    public interface IChatRoom
    {
        public void Register(Participant participant);
        public void Send(string sender, string receiver, string message);
    }
}
