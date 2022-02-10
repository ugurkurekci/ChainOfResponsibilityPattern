using Business.Handler;
using Models;

namespace Business.Concrete
{
    public class XTypeMessage : CompareHandler
    {
        public override void ProcessRequest(Message req)
        {
            if (req.MessageType =="X")
            {
                Console.WriteLine("{0}  CONTENT SUCCESSFULLY ADDED.",
                    this.GetType().Name, req.MessageType);
            }
            else if (_NextApprover != null)
            {
                Console.WriteLine($"The message type is not of type (X). I am sending it to the other queue.");

                _NextApprover.ProcessRequest(req);
            }
        }
    }
}
