﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Cliente.Commands.CreateClienteCommand
{
    public class CreateClienteCommand: IRequest<Response<int>> 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
    public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Response<int>>
    {
        public Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

 