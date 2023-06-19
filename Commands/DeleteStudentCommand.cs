using MediatR;

namespace Pro.CQRSAndMediatRExample.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

