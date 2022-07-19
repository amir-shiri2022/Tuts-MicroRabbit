using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from, int to,decimal amount)
        {
            To = to;
            Amount = amount;
            From = from;
        }
    }
}
