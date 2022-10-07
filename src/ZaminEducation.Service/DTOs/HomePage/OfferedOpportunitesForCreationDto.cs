using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ZaminEducation.Domain.Entities.MainPages.Commons;
using ZaminEducation.Service.Extensions.Attributes;

namespace ZaminEducation.Service.DTOs.HomePage;

public class OfferedOpportunitesForCreationDto
{
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }

    [IsNoMoreThenMaxSize(3), FormFileAttributes]
    public IFormFile File { get; set; }
}