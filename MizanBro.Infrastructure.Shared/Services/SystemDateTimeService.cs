using MizanBro.Application.Interfaces.Shared;
using System;

namespace MizanBro.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}