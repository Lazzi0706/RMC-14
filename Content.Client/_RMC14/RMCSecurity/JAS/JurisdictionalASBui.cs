using Content.Shared._RMC14.RMCSecurity.JAS;
using JetBrains.Annotations;
using Robust.Client.UserInterface;

namespace Content.Client._RMC14.RMCSecurity.JAS;

[UsedImplicitly]
public sealed class JurisdictionalASBui : BoundUserInterface
{
    private JurisdictionalASWindow? _window;

    public JurisdictionalASBui(EntityUid owner, Enum uiKey) : base(owner, uiKey) { }

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<JurisdictionalASWindow>();
    }
}
