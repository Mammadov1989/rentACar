using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Transaction;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse>, ITransactionalRequest
{
    public string Name { get; set; }

    public class CreatedBarndCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _repository;

        public CreatedBarndCommandHandler(IMapper mapper, IBrandRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = _mapper.Map<Brand>(request);
            brand.Id = Guid.NewGuid();
            await _repository.AddAsync(brand);
            CreatedBrandResponse createdBarndResponse = _mapper.Map<CreatedBrandResponse>(brand);
            return createdBarndResponse;
        }
    }
}

