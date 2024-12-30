using POS.Domain.Entities;
namespace POS.Application.Users.Query;
public class GetAllUsers: IRequest<List<UserResponse>>
{
    
}
public class GetAllUsersHandler: IRequestHandler<GetAllUsers, List<UserResponse>>
{
    readonly IUnitOfWork _unitOfWork;

    public GetAllUsersHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public ValueTask<List<UserResponse>> Handle(GetAllUsers request, CancellationToken cancellationToken)
    {
        var users = _unitOfWork.User.GetAllAsync(ct:cancellationToken);
        return ValueTask.FromResult(users.Adapt<List<UserResponse>>());
    }
}
