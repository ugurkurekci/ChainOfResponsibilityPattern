using Business.Handler;
using Models;

namespace Business.Concrete
{
    public class ManuelTypeMessage : CompareHandler
    {
        public override void ProcessRequest(Message req)
        {
            if (req.MessageType!=null)
            {
                Console.WriteLine("{0}  THE CONTENT DOEST NOT SUPPORT THIS MESSAGE. ",
                    this.GetType().Name, req.MessageType);
            }
            else
            {
                throw new Exception(
                    $"THE EMPTY TAIL DOESN'T GO ANYWHERE. !!! END !!!");
            }
        }
    }
}
