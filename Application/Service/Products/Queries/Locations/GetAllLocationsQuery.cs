using Application.DTO.Response.Products;
using MediatR;

namespace Application.Service.Products.Queries.Locations;

public class GetAllLocationsQuery : IRequest<IEnumerable<GetLocationResponseDTO>> { }
