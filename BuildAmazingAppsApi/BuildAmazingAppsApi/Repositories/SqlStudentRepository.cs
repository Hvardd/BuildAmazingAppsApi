﻿using BuildAmazingAppsApi.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BuildAmazingAppsApi.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }


        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
         }
    }
}