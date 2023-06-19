using Pro.CQRSAndMediatRExample.Models;
using MediatR;

namespace Pro.CQRSAndMediatRExample.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
