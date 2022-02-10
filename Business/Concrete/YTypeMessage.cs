using Business.Handler;
using Models;

namespace Business.Concrete
{
    public class YTypeMessage : CompareHandler
    {
        public override void ProcessRequest(Message req)
        {
            if (req.MessageType =="Y")
            {
                Console.WriteLine("{0}  CONTENT SUCCESSFULLY ADDED.",
                    this.GetType().Name, req.MessageType);
            }

            else if (_NextApprover != null)
            {
                Console.WriteLine($"The message type is not of type (Y). I am sending it to the other queue.");

                _NextApprover.ProcessRequest(req);
            }
        }
    }
}
