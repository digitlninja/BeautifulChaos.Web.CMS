using System;
using System.Linq;
using CMS.Models;
using Data.Entities;
using Data.Entities.Identity;

namespace CMS.Extensions
{
    public static class FactoryExtensions
    {
        public static UserModel ToModel(this ApplicationUser user)
        {
            if (user == null)
                return null;

            return new UserModel()
            {
                Email = user.Email,
                Username = user.UserName,
                Bio = user.Bio,
                Role = user.Role
            };
        }


        public static AboutModel ToModel(this About entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            return new AboutModel()
            {
                UUId = entity.UUId,
                PageId = entity.PageId,
                HeaderTitle = entity.HeaderTitle,
                HeaderParagraph = entity.HeaderParagraph,
                Content1Header = entity.Content1Header,
                Content1Paragraph = entity.Content1Paragraph,
                TeamTitle = entity.TeamTitle,
                TeamParagraph = entity.TeamParagraph,
                DescriptionBlock1Header = entity.DescriptionBlock1Header,
                DescriptionBlock1Paragraph = entity.DescriptionBlock1Paragraph,
                DescriptionBlock1Image = entity.DescriptionBlock1Image,
                DescriptionBlock2Header = entity.DescriptionBlock2Header,
                DescriptionBlock2Paragraph = entity.DescriptionBlock2Paragraph,
                AboutImage1 = entity.AboutImage1,
                AboutImage2 = entity.AboutImage2,
                AboutImage3 = entity.AboutImage3
            };
        }

        public static ServicesPageModel ToModel(this ServicesPage entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            return new ServicesPageModel()
            {
                UUId = entity.UUId,
                PageId = entity.PageId,
                HeaderTitle = entity.HeaderTitle,
                HeaderParagraph = entity.HeaderParagraph,
                ServiceSection1Title = entity.ServiceSection1Title,
                ServiceSection2Title = entity.ServiceSection2Title,
                ServiceSection3Title = entity.ServiceSection3Title,
                Content1Header = entity.Content1Header,
                Content1Paragraph = entity.Content1Paragraph,
                Page = entity.Page,
                Services = entity.Services?.ToList()
            };
        }


    }
}
