using Business.Concrete;
using Business.Handler;
using Models;


CompareHandler xtypemessage = new XTypeMessage();
CompareHandler ytypemessage = new YTypeMessage();
CompareHandler manueltypemessage = new ManuelTypeMessage();

xtypemessage.SetNextApprover(ytypemessage);
ytypemessage.SetNextApprover(manueltypemessage);

var message = new Message("TEST");
xtypemessage.ProcessRequest(message);
Console.ReadKey();