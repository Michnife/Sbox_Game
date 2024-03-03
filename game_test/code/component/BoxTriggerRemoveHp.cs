using Sandbox;
	
public sealed class BoxTriggerRemoveHp : Component, Component.ITriggerListener
{

	[Property]
	[Range( 1f, 100f, 1f )]
	public float damage { get; set; } = 0f;

	public void OnTriggerEnter( Collider other)
	{
		var player = other.Components.Get<UnitInfo>();
		float copy = damage;
		if( damage - player.Armor < 0) {
			copy = copy - player.Armor;
			Log.Info("copy :");
			Log.Info(copy);
			player.Armor = 0;
			player.Health = player.Health - copy;
			Log.Info("player.Health :");
			Log.Info(player.Health);
		}
		if( damage - player.Armor > 0) {
			Log.Info("no");
			player.Armor = player.Armor - damage;
		}
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}