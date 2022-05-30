using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Resource;

namespace LearningCenter.API.Learning.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResource, Category>();
    }
}
