using POS.Application.Common;

namespace POS.Application.Users.Query;
public class GetUserByUsername : IRequest<UserResponse>
{
    public GetUserByUsername(string usernam,string password)
    {
        Username = usernam;
        Password = Utility.Hash(password);
    }
    public readonly string Username;
    public readonly string Password;
}
public class GetUserByUsernameHandler : IRequestHandler<GetUserByUsername, UserResponse?>
{
    readonly IUnitOfWork _unitOfWork;

    public GetUserByUsernameHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async ValueTask<UserResponse?> Handle(GetUserByUsername request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.User.FindAsync(x => x.Username == request.Username && x.Password == request.Password);
        return user.Adapt<UserResponse?>();
    }
}
