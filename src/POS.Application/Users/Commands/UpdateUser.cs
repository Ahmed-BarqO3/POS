using POS.Domain.Entities;

namespace POS.Application.Users.Commands;

public record UpdateUser :IRequest<bool>
{
    string Username { get; set; }
    string Password { get; set; }
    byte RoleId { get; set; }
    bool IsActive { get; set; }
}

public class UpdateUserHandler : IRequestHandler<UpdateUser, bool>
{
    readonly IUnitOfWork _unitOfWork;

    public UpdateUserHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public ValueTask<bool> Handle(UpdateUser request, CancellationToken cancellationToken)
    {
        var user = request.Adapt<User>();

        _unitOfWork.User.Update(user);
        return ValueTask.FromResult(_unitOfWork.Commite() > 0);
    }
}
