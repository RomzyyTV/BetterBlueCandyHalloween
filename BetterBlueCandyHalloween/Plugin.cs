using System;
using Exiled.API.Features;

namespace BetterBlueCandyHalloween;

public class Plugin : Plugin<Config>
{
    public override string Author => "Bankokwak";
    public override string Name => "Better Blue Candy Halloween";
    public override Version Version => new Version(1, 0, 0);
    public override Version RequiredExiledVersion => new Version(8,13,1);
    
    public static Plugin Singleton { get; private set; }
    public static EventHandlers Handlers { get; private set; }

    public override void OnEnabled()
    {
        Singleton = this;
        Handlers = new EventHandlers();
        
        Exiled.Events.Handlers.Scp330.EatingScp330 += Handlers.OnPlayerEatScp330;
        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Singleton = null;
        Handlers = null;
        
        Exiled.Events.Handlers.Scp330.EatingScp330 -= Handlers.OnPlayerEatScp330;
        base.OnDisabled();
    }
}