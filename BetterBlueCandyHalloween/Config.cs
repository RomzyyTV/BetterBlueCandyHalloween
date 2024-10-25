using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BetterBlueCandyHalloween;
public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; }
    
    [Description("Time for blue candy")]
    public float TimeBlueCandy { get; set; } = 20f;
    [Description("Custom shield to blue candy")]
    public float ShieldBlueCandy { get; set; } = 450f;
}