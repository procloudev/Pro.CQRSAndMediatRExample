using Pro.CQRSAndMediatRExample.Models;
using MediatR;

namespace Pro.CQRSAndMediatRExample.Queries
{
    public class GetStudentListQuery :  IRequest<List<StudentDetails>>
    {
    }
}
