using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BetterBlueCandyHalloween
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; }
        [Description("The amount of time the player is a marshmallow.")]
        public float TimeBlueCandy { get; set; } = 20f;
        [Description("The amount of shield when the player spawn.")]
        public float ShieldBlueCandy { get; set; } = 450f;
    }
}