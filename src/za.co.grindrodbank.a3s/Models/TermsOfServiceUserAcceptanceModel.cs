/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using NpgsqlTypes;

namespace za.co.grindrodbank.a3s.Models
{
    public class TermsOfServiceUserAcceptanceModel : AuditableModel
    {
        public Guid TermsOfServiceId { get; set; }
        public TermsOfServiceModel TermsOfService { get; set; }

        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        public NpgsqlRange<DateTime> AcceptanceTime { get; set; }
    }
}
