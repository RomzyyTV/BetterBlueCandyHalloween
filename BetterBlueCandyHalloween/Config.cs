using Exiled.API.Interfaces;

namespace BetterBlueCandyHalloween
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; }

        public float TimeBlueCandy { get; set; } = 20f;
        public float ShieldBlueCandy { get; set; } = 450f;
    }
}