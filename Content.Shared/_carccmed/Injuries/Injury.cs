using Content.Shared._carccmed.Anatomy;

namespace Content.Shared._carccmed.Injuries
{
    public sealed class Injury
    {
        public InjuryType Type { get; set; }
        public BodyPart Location { get; set; }
        public float Severity { get; set; }
    }
}
