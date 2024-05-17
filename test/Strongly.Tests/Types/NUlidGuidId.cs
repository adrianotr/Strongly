namespace Strongly.IntegrationTests.Types;

[Strongly(backingType: StronglyType.NUlidGuid)]
public partial struct NUlidGuidId1
{
}

[Strongly(backingType: StronglyType.NUlidGuid)]
public partial record struct RecordNUlidGuidId1
{
}

[Strongly(backingType: StronglyType.NUlidGuid)]
public partial struct NUlidGuidId2
{
}

[Strongly(backingType: StronglyType.NUlidGuid, converters: StronglyConverter.None)]
public partial struct NoConverterNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.TypeConverter)]
public partial struct NoJsonNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.NewtonsoftJson)]
public partial struct NewtonsoftJsonNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.TypeConverter | StronglyConverter.SystemTextJson)]
public partial struct SystemTextJsonNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.NewtonsoftJson | StronglyConverter.SystemTextJson)]
public partial struct BothJsonNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.EfValueConverter)]
public partial struct EfCoreNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.DapperTypeHandler)]
public partial struct DapperNUlidGuidId
{
}

#if NET5_0_OR_GREATER
[Strongly(backingType: StronglyType.NUlidGuid,
    converters: StronglyConverter.SwaggerSchemaFilter)]
public partial struct SwaggerNUlidGuidId
{
}
#endif

[Strongly(backingType: StronglyType.NUlidGuid,
    implementations: StronglyImplementations.IEquatable |
                     StronglyImplementations.IComparable)]
public partial struct BothNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    implementations: StronglyImplementations.IEquatable)]
public partial struct EquatableNUlidGuidId
{
}

[Strongly(backingType: StronglyType.NUlidGuid,
    implementations: StronglyImplementations.IComparable)]
public partial struct ComparableNUlidGuidId
{
}
