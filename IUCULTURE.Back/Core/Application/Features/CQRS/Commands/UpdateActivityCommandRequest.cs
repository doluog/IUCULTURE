﻿using MediatR;

namespace IUCULTURE.Back.Core.Application.Features.CQRS.Commands
{
    public class UpdateActivityCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string? ClubName { get; set; }
        public string? ActivityName { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string? ActivityType { get; set; }
        public string? ActivityDefinition { get; set; }
        public string? ActivityDefinitionBold { get; set; }
        public string? ActivityImage { get; set; }
    }
}
