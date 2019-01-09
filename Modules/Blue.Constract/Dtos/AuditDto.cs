﻿using System;
using Framework.Constract.Constant;
using Framework.Constract.Interfaces;
using Framework.Constract.SeedWork;

namespace Blue.Constract.Dtos
{
    public class AuditDto : BaseDto, IAuditableDto
    {
        public string SessionId { get; set; }

        public string ExternalIpAddress { get; set; }

        public string UserName { get; set; }

        public string UrlAccessed { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public int AudittingLevel { get; set; }

        public int EventType { get; set; } /* Success = 1; Failure = 2; Information = 3; Error = 4 */

        public string Data { get; set; }

        public UserAction UserAction { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
