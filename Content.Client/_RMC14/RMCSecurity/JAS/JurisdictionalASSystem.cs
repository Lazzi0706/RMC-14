using Content.Shared._RMC14.RMCSecurity.JAS;
using Robust.Shared.Containers;

namespace Content.Client._RMC14.RMCSecurity.JAS;

public sealed partial class JurisdictionalASSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<JurisdictionalASComponent, EntInsertedIntoContainerMessage>(OnInserted);
        SubscribeLocalEvent<JurisdictionalASComponent, EntRemovedFromContainerMessage>(OnEjected);
    }

    private void OnInserted(Entity<JurisdictionalASComponent> ent, ref EntInsertedIntoContainerMessage args)
    {

    }

    private void OnEjected(Entity<JurisdictionalASComponent> ent, ref EntRemovedFromContainerMessage args)
    {

    }
}
