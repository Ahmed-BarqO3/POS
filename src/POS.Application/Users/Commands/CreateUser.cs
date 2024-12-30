using POS.Domain.Entities;

namespace POS.Application.Users.Commands;

public record CreateUser: IRequest<bool>
{
    string Username { get; set; }
    string Password { get; set; }
    byte RoleId { get; set; }
    bool IsActive { get; set; }
}

public class CreateUserHandler: IRequestHandler<CreateUser,bool>
{
    readonly IUnitOfWork _unitOfWork ;

    public CreateUserHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public ValueTask<bool> Handle(CreateUser request, CancellationToken cancellationToken)
    {
        var user = request.Adapt<User>();

        _unitOfWork.User.AddAsync(user);
        return ValueTask.FromResult(_unitOfWork.Commite() > 0);
    }
}
