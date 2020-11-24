using MediatR;

namespace DevFreela.Application.Querys.GetUser
{
    public class GetUserQuery : IRequest<GetUserViewModel>
    {
        public GetUserQuery(int idUser)
        {
            IdUser = idUser;
        }

        public int IdUser { get; private set; }
    }
}
