using System;
using Sev1.Congratulations.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sev1.Congratulations.DataAccess.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        // Группа 1 - "Личные праздники"
        private static Category category1 = new Category
        {
            Id = 1,
            Name = "Личные праздники",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategory = null
        };

        private static Category category1_1 = new Category
        {
            Id = 2,
            Name = "Дни рождения",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 1
        };
        private static Category category1_2 = new Category
        {
            Id = 3,
            Name = "Дни свадьбы",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 1
        };
        // Группа 2 - "Гражданские праздники"
        private static Category category2 = new Category
        {
            Id = 5,
            Name = "Гражданские праздники",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategory = null
        };

        private static Category category2_1 = new Category
        {
            Id = 6,
            Name = "День шахматиста",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 5
        };

        private static Category category2_2 = new Category
        {
            Id = 7,
            Name = "День пожарника",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 5
        };

        private static Category category2_3 = new Category
        {
            Id = 8,
            Name = "День рыбака",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 5
        };

        // Группа 3 - "Политические праздники"
        private static Category category3 = new Category
        {
            Id = 9,
            Name = "Политические праздники",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategory = null
        };

        private static Category category3_1 = new Category
        {
            Id = 10,
            Name = "День России",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 9
        };
        private static Category category3_2 = new Category
        {
            Id = 11,
            Name = "День Конституции",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 9
        };
        private static Category category3_3 = new Category
        {
            Id = 12,
            Name = "День флота",
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            ParentCategoryId = 9
        };


        private readonly Category[] categories = new Category[]
        {
            category1,
            category1_1,
            category1_2,
            category2,
            category2_1,
            category2_2,
            category2_3,
            category3,
            category3_1,
            category3_2,
            category3_3,
        };
        
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(cat => cat.Id);
            builder.Property(cat => cat.Name).IsRequired();
            builder.Property(cat => cat.ParentCategoryId).IsRequired(false);
            builder.Property(cat => cat.CreatedAt).IsRequired();
            builder.Property(cat => cat.UpdatedAt).IsRequired(false);
            builder.HasData(categories);
        }
    }
}