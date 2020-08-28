using System.Collections.Generic;
using System.Threading;

namespace $projectname$.Application.Interfaces.Services
{
	public interface IService
	{
		List<bool> Get(CancellationToken cancellationToken);
	}
}