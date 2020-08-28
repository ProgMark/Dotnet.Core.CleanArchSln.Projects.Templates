using $projectname$.Application.Interfaces.Databases;
using $projectname$.Application.Domain.Queries.SampleQuery.V1;
using System.Collections.Generic;

namespace $projectname$.Persistance.Repositories
{
	public class Repository : IRepository
	{
        public List<SampleDtoV1> Get()
        {
            throw new System.NotImplementedException();
        }
	}
}