using $projectname$.Application.Domain.Queries.SampleQuery.V1;
using System;
using System.Collections.Generic;

namespace $projectname$.Application.Interfaces.Databases
{
	public interface IRepository
	{
		List<SampleDtoV1> Get();
	}
}