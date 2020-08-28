using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace $projectname$.Application.Domain.Commands.SampleCommand.V1
{
    public class SampleCommandV1Handler : IRequestHandler<SampleCommandV1, bool>
    {
        public SampleCommandV1Handler()
        {}

        public Task<bool> Handle(SampleCommandV1 request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}