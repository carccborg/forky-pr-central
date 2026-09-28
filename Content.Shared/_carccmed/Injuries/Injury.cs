using Content.Shared._carccmed.Anatomy;
using Content.Shared._carccmed.Treatment;
using Robust.Shared.Prototypes;

namespace Content.Shared._carccmed.Injuries;

/// <summary>
/// Runtime injury.
/// </summary>
public sealed class Injury
{
    /// <summary>
    /// The type of injury.
    /// </summary>
    public ProtoId<InjuryType> Type = default!;

    /// <summary>
    /// The body part affected by the injury.
    /// </summary>
    public BodyPart Location = default!;

    /// <summary>
    /// The property:value dict for this injury.
    /// </summary>
    public Dictionary<ProtoId<InjuryProperty>, float> Properties = new();

    /// <summary>
    /// Treatments that have been applied to this injury.
    /// </summary>
    public HashSet<ProtoId<TreatmentType>> AppliedTreatments = new();
}

/// <summary>
/// Injury prototype.
/// </summary>
[Prototype("carccmedInjury")]
public sealed partial class InjuryType : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = string.Empty;

    [DataField]
    public string Name = string.Empty;

    /// <summary>
    /// Properties this injury inflicts on the entity upon receiving it.
    /// </summary>
    [DataField]
    public HashSet<ProtoId<InjuryProperty>> Properties = new();

    /// <summary>
    /// All of the treatments that can be used.
    /// </summary>
    [DataField]
    public HashSet<ProtoId<TreatmentType>> PossibleTreatments = new();
}

/// <summary>
/// Defines a property that can exist on an injury.
/// </summary>
[Prototype("carccmedInjuryProperty")]
public sealed partial class InjuryProperty : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = string.Empty;

    [DataField]
    public string Name = string.Empty;
}
