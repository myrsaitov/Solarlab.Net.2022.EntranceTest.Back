using Mapster;
using Sev1.Congratulations.AppServices.Contracts.Congratulation;
using Sev1.Congratulations.Contracts.Contracts.Congratulation.Responses;
using System.Linq;

namespace Sev1.Congratulations.MapsterMapper.MapProfiles
{
    public class CongratulationMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<Domain.Congratulation, CongratulationGetResponse>()
                .Map(dest => dest.CreatedAt, src => src.CreatedAt.ToLocalTime().ToString("dd/MM/yy H:mm:ss"))
                .Map(dest => dest.Tags, src => src.Tags.Select(a => a.Body).ToArray())
                .Map(dest => dest.UserFiles, src => src.UserFiles.Select(a => a.FileId).ToArray());

            config.NewConfig<Domain.Congratulation, CongratulationGetPagedDto>()
                .Map(dest => dest.CreatedAt, src => src.CreatedAt.ToLocalTime().ToString("dd/MM/yy H:mm:ss"))
                .Map(dest => dest.CategoryName, src => src.Category.Name)
                .Map(dest => dest.RegionName, src => src.Region.Name)
                .Map(dest => dest.Tags, src => src.Tags.Select(a => a.Body).ToArray())
                .Map(dest => dest.UserFiles, src => src.UserFiles.Select(a => a.FileId).ToArray());
            return config;
        }
    }
}