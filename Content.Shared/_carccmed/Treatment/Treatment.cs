using Content.Shared._carccmed.Injuries;
using Robust.Shared.Prototypes;

namespace Content.Shared._carccmed.Treatment;

[Prototype("carccmedTreatment")]
public sealed partial class TreatmentType : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = string.Empty;

    [DataField]
    public string Name = string.Empty;

    [DataField]
    public Dictionary<ProtoId<InjuryProperty>, TreatmentProperty> Properties = [];
}

[DataDefinition]
public sealed partial class TreatmentProperty
{
    /// <summary>
    /// Multiplies the property value.
    /// </summary>
    [DataField("scale")]
    public float? Scale;

    /// <summary>
    /// Adds to the property value.
    /// </summary>
    [DataField("add")]
    public float? Add;
}
