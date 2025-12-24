using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand:IRequest<CreatedBarndResponse>
{
    public string Name { get; set; }

    public class CreatedBarndCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBarndResponse>
    {
        public Task<CreatedBarndResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            CreatedBarndResponse response = new CreatedBarndResponse();
            response.Name = request.Name;
            response.Id = new Guid();
            return null;
        }
    }
}

