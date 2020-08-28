using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace $projectname$.Application.Domain.Queries.SampleQuery.V1
{
    public class SampleQueryV1Handler : IRequestHandler<SampleQueryV1, SampleDtoV1>
    {
        public SampleQueryV1Handler()
        {}

        public Task<SampleDtoV1> Handle(SampleQueryV1 request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}