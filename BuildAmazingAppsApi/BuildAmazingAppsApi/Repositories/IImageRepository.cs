﻿namespace BuildAmazingAppsApi.Repositories
{
    public interface IImageRepository
    {
       Task<string> Upload(IFormFile file, string fileName);
    }
}
