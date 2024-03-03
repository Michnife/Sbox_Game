using Sandbox;
	
public sealed class BoxTriggerRemoveHp : Component, Component.ITriggerListener
{

	[Property]
	[Range( 1f, 100f, 1f )]
	public float damage { get; set; } = 0f;

	public void OnTriggerEnter( Collider other)
	{
		var player = other.Components.Get<UnitInfo>();
        if (damage <= player.Armor)
        {
            player.Armor -= damage;
        }
        else
        {
            float damageRestants = damage - player.Armor;
            player.Armor = 0;
            player.Health -= damageRestants;
        }

        // Limiter les valeurs à leurs maximums
        player.Health = Math.Max(player.Health, 0);
        player.Armor = Math.Max(player.Armor, 0);
	}
	public void OnTriggerExit( Collider other)
	{
		
	}
}