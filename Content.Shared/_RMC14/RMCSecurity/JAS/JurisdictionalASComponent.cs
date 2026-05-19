using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.RMCSecurity.JAS;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class JurisdictionalASComponent : Component
{
    [DataField] [AutoNetworkedField]
    public string PrivilegedIdSlot = "PrivilegedIdSlot";

    [DataField] [AutoNetworkedField]
    public string SuspectIdSlot = "SuspectIdSlot";

    [DataField] [AutoNetworkedField]
    public string WitnessIdSlot = "WitnessIdSlot";
}
