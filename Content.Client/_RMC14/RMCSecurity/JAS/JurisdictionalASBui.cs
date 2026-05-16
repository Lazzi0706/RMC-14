using Content.Shared._RMC14.RMCSecurity.JAS;
using Content.Shared._RMC14.UserInterface;
using JetBrains.Annotations;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;

namespace Content.Client._RMC14.RMCSecurity.JAS;

[UsedImplicitly]
public sealed class JurisdictionalASBui : BoundUserInterface, IRefreshableBui
{
    private JurisdictionalASWindow? _window;
    private readonly ContainerSystem _container;
    public JurisdictionalASBui(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
        _container = EntMan.System<ContainerSystem>();
    }

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<JurisdictionalASWindow>();

        _window.JASSuspectID.OnPressed += _ =>
        {
            SendPredictedMessage(new JurisdictionalASInsertedSuspectIdBuiMsg());
        };

    }

    public void Refresh()
    {
        if (_window is not {IsOpen: true})
            return;

        if (!EntMan.TryGetComponent(Owner, out JurisdictionalASComponent? jas))
            return;
    }
}
