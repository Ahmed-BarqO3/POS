namespace POS.Application.Users.Query;

public class IsExist : IRequest<bool>
{
    public string Username { get; set; }
}

public class IsExistHandler : IRequestHandler<IsExist, bool>
{
    private readonly IUserRepository _userRepository;

    public IsExistHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async ValueTask<bool> Handle(IsExist request, CancellationToken cancellationToken)
    {
        return  _userRepository.IsUserExist(request.Username);
    }
}

