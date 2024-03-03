using Sandbox;

public sealed class BoxTriggerHp : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		Log.Info("Trigger Hp !!");
		var player = other.Components.Get<UnitInfo>();
		player.Health = player.Health - 5;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}