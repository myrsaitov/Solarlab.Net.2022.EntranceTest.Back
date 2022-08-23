using Mapster;
using Sev1.Congratulations.Contracts.Enums;
using Sev1.Congratulations.Contracts.Contracts.Tag.Requests;
using Sev1.Congratulations.Contracts.Contracts.Tag.Responses;
using System.Linq;

namespace Sev1.Congratulations.MapsterMapper.MapProfiles
{
    public class TagMapProfile
    {
        public static TypeAdapterConfig GetConfiguredMappingConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.NewConfig<TagCreateRequest, Domain.Tag>()
                .Map(dest => dest.Body, src => src.Body);

            config.NewConfig<Domain.Tag, TagCreateRequest>()
                .Map(dest => dest.Body, src => src.Body);

            config.NewConfig<Domain.Tag, TagGetResponse>()
                .Map(dest => dest.Body, src => src.Body)
                
                // Считает количество активных объявлений,
                // связанных с данным тагом
                .Map(dest => dest.Count, src => src.Congratulations
                    .Where(a => a.Status == CongratulationStatus.Active)
                    .Count());

            return config;
        }
    }
}