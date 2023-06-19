using Pro.CQRSAndMediatRExample.Models;
using Pro.CQRSAndMediatRExample.Queries;
using Pro.CQRSAndMediatRExample.Repositories;
using MediatR;
using System.Numerics;

namespace Pro.CQRSAndMediatRExample.Handlers
{
    public class GetStudentListHandler :  IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
