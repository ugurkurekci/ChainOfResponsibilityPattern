using Models;

namespace Business.Handler
{
    public abstract class CompareHandler
    {

        protected CompareHandler _NextApprover;

        public void SetNextApprover(CompareHandler compareHandler)
        {

            _NextApprover = compareHandler;

        }

        public abstract void ProcessRequest(Message message);
    }
}