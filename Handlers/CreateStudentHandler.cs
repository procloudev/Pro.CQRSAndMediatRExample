using Pro.CQRSAndMediatRExample.Commands;
using Pro.CQRSAndMediatRExample.Models;
using Pro.CQRSAndMediatRExample.Repositories;
using MediatR;
using System.Numerics;

namespace Pro.CQRSAndMediatRExample.Handlers
{
    public class CreateStudentHandler: IRequestHandler<CreateStudentCommand, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<StudentDetails> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = new StudentDetails()
            {
                StudentName = command.StudentName,
                StudentEmail = command.StudentEmail,
                StudentAddress = command.StudentAddress,
                StudentAge = command.StudentAge
            };

            return await _studentRepository.AddStudentAsync(studentDetails);
        }
    }
}
