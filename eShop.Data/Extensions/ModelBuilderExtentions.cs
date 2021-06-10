using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
            new AppConfig() { Key = "HomeTitle", Value = "This is homepage of eShop" },
            new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShop" },
            new AppConfig() { Key = "HomeDesciption", Value = "This is description of eShop" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID=1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                  
                },
                    new Category()
                    {
                        ID = 2,
                        IsShowOnHome = true,
                        ParentId = null,
                        SortOrder = 2,
                        Status = Status.Active,
                  
                    }
                ) ;
            modelBuilder.Entity<CategoryTranslation>().HasData(

                        new CategoryTranslation() { Id=1, CategoryId = 1, Name = "Blazer", LanguageId = "vi-VN", SeoAlias = "blazer", SeoDescription = "Blazer nữ", SeoTitle = "Blazer nữ" },
                        new CategoryTranslation() {Id=2, CategoryId = 1, Name = "Blazer", LanguageId = "en-US", SeoAlias = "blazer", SeoDescription = "Woman Blazer", SeoTitle = "Woman Blazer" },

                        new CategoryTranslation() {Id=3, CategoryId = 2, Name = "Hoodie Nữ", LanguageId = "vi-VN", SeoAlias = "hoodie-nu", SeoDescription = "Hoodie Nữ", SeoTitle = "Hoodie Nữ" },
                        new CategoryTranslation() {Id=4, CategoryId = 2, Name = "Hoodie", LanguageId = "en-US", SeoAlias = "Hoodie", SeoDescription = "Woman Hoodie", SeoTitle = "Woman Hoodie" }
                    ) ;
            

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID=1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 815000,
                    Price = 1350000,
                    Stock = 0,
                    ViewCount = 0,
                  
                

                }
            )  ;
            modelBuilder.Entity<ProductTranslation>().HasData(
                   new ProductTranslation()
                   {
                       Id=1,
                       ProductId=1,
                       Name = "Blazer",
                       LanguageId = "vi-VN",
                       SeoAlias = "blazer-nu",
                       SeoDescription = "Blazer nữ",
                       SeoTitle = "Blazer nữ",
                       Details = "Blazer Nhà ChemiseBikini",
                       Description = "Blazer Nhà ChemiseBikini"
                   },
                   new ProductTranslation()
                        {
                            Id=2,
                            ProductId=1,
                            Name = "Blazer",
                            LanguageId = "en-US",
                            SeoAlias = "woman-blazer",
                            SeoDescription = "Woman Blazer",
                            SeoTitle = "Woman Blazer",
                            Details = "Blazer by ChemiseBikini",
                            Description = "Blazer by ChemiseBikini"
                        });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    CategoryId = 1,
                    ProductId = 1
                }
                );
            // any guid
            var roleId = new Guid("E2D0051A-439A-46FF-93C9-C5129D99878C");
            var adminId = new Guid("E2D0051A-439A-46FF-93C9-C5129D99878C");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "chauongchan@gmail.com",
                NormalizedEmail = "chauongchan@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "dgmaila2612"),
                SecurityStamp = string.Empty,
                FirstName = "Duc",
                LastName = "Anh",
                Dob = new DateTime(2000, 12, 26)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
       
    }
}

