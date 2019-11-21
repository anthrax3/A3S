/**
 * *************************************************
 * Copyright (c) 2019, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using za.co.grindrodbank.a3s.Models;

namespace za.co.grindrodbank.a3s.Repositories
{
    public interface ITermsOfServiceRepository : ITransactableRepository
    {
        Task<TermsOfServiceModel> GetByIdAsync(Guid termsOfServiceId, bool includeRelations);
        Task<TermsOfServiceModel> GetByNameAsync(string name, bool includeRelations);
        Task<TermsOfServiceModel> CreateAsync(TermsOfServiceModel termsOfService);
        Task<TermsOfServiceModel> UpdateAsync(TermsOfServiceModel termsOfService);
        Task DeleteAsync(TermsOfServiceModel termsOfService);
        Task<List<TermsOfServiceModel>> GetListAsync();
    }
}
