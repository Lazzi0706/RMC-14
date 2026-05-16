using Robust.Shared.Serialization;

namespace Content.Shared._RMC14.RMCSecurity.JAS;

[Serializable, NetSerializable]
public enum JurisdictionalASUiKey
{
    Key,
}

[Serializable, NetSerializable]
public sealed class JurisdictionalASInsertedSuspectIdBuiMsg : BoundUserInterfaceMessage;

[Serializable, NetSerializable]
public sealed class JurisdictionalASInsertedPrivilegedIdBuiMsg : BoundUserInterfaceMessage;

[Serializable, NetSerializable]
public sealed class JurisdictionalASInsertedWitnessIdBuiMsg : BoundUserInterfaceMessage;
