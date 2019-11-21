﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using za.co.grindrodbank.a3s.Models;

namespace za.co.grindrodbank.a3s.Repositories
{
    public class TermsOfServiceRepository : ITermsOfServiceRepository
    {
        private readonly A3SContext a3SContext;

        public void InitSharedTransaction()
        {
            if (a3SContext.Database.CurrentTransaction == null)
                a3SContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (a3SContext.Database.CurrentTransaction != null)
                a3SContext.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            if (a3SContext.Database.CurrentTransaction != null)
                a3SContext.Database.CurrentTransaction.Rollback();
        }

        public TermsOfServiceRepository(A3SContext a3SContext)
        {
            this.a3SContext = a3SContext;
        }

        public async Task<TermsOfServiceModel> CreateAsync(TermsOfServiceModel termsOfService)
        {
            a3SContext.TermsOfService.Add(termsOfService);
            await a3SContext.SaveChangesAsync();

            return termsOfService;
        }

        public async Task DeleteAsync(TermsOfServiceModel termsOfService)
        {
            a3SContext.TermsOfService.Remove(termsOfService);
            await a3SContext.SaveChangesAsync();
        }

        public async Task<TermsOfServiceModel> GetByIdAsync(Guid termsOfServiceId, bool includeRelations)
        {
            if (includeRelations)
            {
                return await a3SContext.TermsOfService.Where(t => t.Id == termsOfServiceId)
                                      .Include(t => t.Teams)
                                      .FirstOrDefaultAsync();
            }

            return await a3SContext.TermsOfService.Where(t => t.Id == termsOfServiceId).FirstOrDefaultAsync();
        }

        public async Task<TermsOfServiceModel> GetByNameAsync(string name, bool includeRelations)
        {
            if (includeRelations)
            {
                return await a3SContext.TermsOfService.Where(t => t.AgreementName == name)
                                      .Include(t => t.Teams)
                                      .FirstOrDefaultAsync();
            }

            return await a3SContext.TermsOfService.Where(t => t.AgreementName == name).FirstOrDefaultAsync();
        }

        public async Task<List<TermsOfServiceModel>> GetListAsync()
        {
            return await a3SContext.TermsOfService.Include(t => t.Teams)
                                        .ToListAsync();
        }

        public async Task<TermsOfServiceModel> UpdateAsync(TermsOfServiceModel termsOfService)
        {
            a3SContext.Entry(termsOfService).State = EntityState.Modified;
            await a3SContext.SaveChangesAsync();

            return termsOfService;
        }
    }
}
