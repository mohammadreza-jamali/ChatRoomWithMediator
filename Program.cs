using ChatRoomWithMediator.Concrete;

ChatRoom chatroom = new ChatRoom();

Participant mohammad = new Participant("Mohammad");
Participant sara = new Participant("Sara");
Participant ali = new Participant("Ali");

chatroom.Register(mohammad);
chatroom.Register(sara);
chatroom.Register(ali);

mohammad.Send("Sara", "Hi, How are you?");
sara.Send("Mohammad", "Hi,I'm great.What about you?");
ali.Send("Sara", "Did you compelete your work yesterday?");
sara.Send("Ali", "Of course.");
