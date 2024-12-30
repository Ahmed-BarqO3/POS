using POS.Domain.Entities;

namespace POS.Application.Roles;

public class GetAllRoles : IRequest<List<RoleResponse>>
{
    public GetAllRoles()
    {
        
    }
};

public class GetAllRolesHandler : IRequestHandler<GetAllRoles, List<RoleResponse>>
{
    private readonly IUnitOfWork unitOfWork;

    public GetAllRolesHandler(IUnitOfWork roleRepository)
    {
        unitOfWork = roleRepository;
    }

    public  ValueTask<List<RoleResponse>> Handle(GetAllRoles request, CancellationToken cancellationToken)
    {
        var roles =  unitOfWork.Role.GetAllAsync();
        return ValueTask.FromResult(roles.Adapt<List<RoleResponse>>());
    }
}
