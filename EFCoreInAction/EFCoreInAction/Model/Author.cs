﻿namespace EFCoreInAction.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? WebUrl { get; set; }
    }
}