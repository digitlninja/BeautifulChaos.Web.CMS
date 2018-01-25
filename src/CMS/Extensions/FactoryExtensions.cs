using System;
using System.Collections.Generic;
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
                return null;

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
                return null;

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

        public static WorkModel ToModel(this Work entity)
        {
            if (entity == null)
                return null;

            var workImages = entity.Images.ToList();
            return new WorkModel()
            {
                UUId = entity.UUId,
                PageId = entity.PageId,
                HeaderTitle = entity.HeaderTitle,
                HeaderParagraph = entity.HeaderParagraph,
                Images = workImages.ToModelList()
            };
        }

        public static ImageModel ToModel(this Image entity)
        {
            if (entity == null)
                return null;

            return new ImageModel()
            {
                UUId = entity.UUId,
                PageId = entity.PageId,
                Title = entity.Title,
                AltText = entity.AltText,
                Url = entity.Url,
                Page = entity.Page
            };
        }

        public static List<ImageModel> ToModelList(this List<Image> entities)
        {
            if (entities.Count <= 0 || entities == null)
                throw new ArgumentNullException(nameof(entities));

            var models = new List<ImageModel>();
            foreach (var entity in entities)
            {
                models.Add(entity.ToModel());
            }

            if (models.Count <= 0)
                return null;

            return models;
        }

        public static TestimonialsPageModel ToModel(this TestimonialsPage entity)
        {
            if (entity == null)
                return null;    

            var testimonialsModel = entity.Testimonials.ToList().ToModelList();
            return new TestimonialsPageModel()
            {
                UUId = entity.UUId,
                PageId = entity.PageId,
                HeaderTitle = entity.HeaderTitle,
                ContentSectionHeader = entity.ContentSectionHeader,
                ContentSectionParagraph = entity.ContentSectionParagraph,
                LeftContentTitle = entity.LeftContentTitle,
                LeftContentParagraph = entity.LeftContentParagraph,
                MiddleContentTitle = entity.MiddleContentTitle,
                MiddleContentParagraph = entity.MiddleContentParagraph,
                RightContentTitle = entity.RightContentTitle,
                RightContentParagraph = entity.RightContentParagraph,
                Testimonials = testimonialsModel
            };
        }

        public static TestimonialModel ToModel(this Testimonial entity)
        {
            if (entity == null)
                return null;

            return new TestimonialModel()
            {
                UUId = entity.UUId,
                TestimonialsPage = entity.TestimonialsPage.ToModel(), // Test to see if works
                TestimonialContent = entity.TestimonialContent
            };
        }

        public static List<TestimonialModel> ToModelList(this List<Testimonial> entities)
        {
            if (entities.Count <= 0 || entities == null)
                throw new ArgumentNullException(nameof(entities));

            var models = new List<TestimonialModel>();
            foreach (var entity in entities)
            {
                models.Add(entity.ToModel());
            }

            if (models.Count <= 0)
                return null;

            return models;
        }
    }
}
