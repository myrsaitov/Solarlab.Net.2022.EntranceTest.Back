using MapsterMapper;
using Sev1.Accounts.Contracts.UserProvider;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;
using Sev1.Congratulations.AppServices.Services.Congratulation.Repositories;
using Sev1.Congratulations.AppServices.Services.Category.Repositories;
using Sev1.Congratulations.AppServices.Services.Region.Repositories;
using Sev1.Congratulations.AppServices.Services.Tag.Repositories;
using Sev1.UserFiles.Contracts.ApiClients.UserFilesUpload;

namespace Sev1.Congratulations.AppServices.Services.Congratulation.Implementations
{
    public sealed partial class CongratulationServiceV1 : ICongratulationService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICongratulationRepository _advertisementRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IUserFileRepository _userFileRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IUserProvider _userProvider;
        private readonly IUserFilesUploadApiClient _userFilesUploadApiClient;
        private readonly IMapper _mapper;
        public CongratulationServiceV1(
            ICongratulationRepository advertisementRepository,
            ICategoryRepository categoryRepository,
            ITagRepository tagRepository,
            IUserFileRepository userFileRepository,
            IRegionRepository regionRepository,
            IUserProvider userProvider,
            IUserFilesUploadApiClient userFilesUploadApiClient,
            IMapper mapper)
        {
            _advertisementRepository = advertisementRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            _userFileRepository = userFileRepository;
            _regionRepository = regionRepository;
            _userProvider = userProvider;
            _userFilesUploadApiClient = userFilesUploadApiClient;
            _mapper = mapper;
        }
    }
}