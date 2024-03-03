using Sandbox;

public sealed class BoxTriggerHpAdd : Component, Component.ITriggerListener
{
	public void OnTriggerEnter( Collider other)
	{
		var player = other.Components.Get<UnitInfo>();
		player.Health = player.MaxHealth;
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}