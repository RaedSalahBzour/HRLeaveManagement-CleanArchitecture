﻿using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class LeaveRequestDeleteCommand : IRequest
    {
        public int Id { get; set; }
    }
}
