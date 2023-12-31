namespace DragaliaAPI.MissionDesigner.Models.EventMission;

public class EventChallengeBattleClearMission : Mission
{
    protected override MissionCompleteType CompleteType =>
        MissionCompleteType.EventChallengeBattleClear;

    public int EventId { get; set; }

    public VariationTypes? VariationType { get; init; }

    public bool? FullClear { get; init; }

    protected override int? Parameter => this.EventId;

    protected override int? Parameter2 => (int?)this.VariationType;

    protected override int? Parameter3 => this.FullClear == true ? 1 : null;
}
