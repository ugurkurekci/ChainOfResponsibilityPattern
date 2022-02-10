namespace Models
{
    public class Message
    {

        public string MessageType { get; set; }

        public Message(string messageType)
        {

            MessageType=messageType;

        }
    }
}