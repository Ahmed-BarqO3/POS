using Mediator;
using POS.Domain.Entities;namespace POS.Application.Responses;

public record UserResponse(byte Id,string ussername,string password,byte roleId,bool isActive,RoleResponse role);
