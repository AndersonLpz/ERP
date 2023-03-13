using AutoMapper;

namespace XRM.Application._3_AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void RegisterMappings()
        {
            var _mapper = new MapperConfiguration((mapper) =>
            {
                mapper.AddProfile<DomainToViewModelMappingProfile>();
                mapper.AddProfile<ViewModelToDomainMappingProfile>();
            });

            Mapper = _mapper.CreateMapper();
        }
    }
}
