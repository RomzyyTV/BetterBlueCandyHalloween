using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups;
using Exiled.API.Extensions;
using Exiled.Events.EventArgs;
using GameCore;
using MEC;
using Exiled.Events.EventArgs.Scp330;
using InventorySystem.Items.Usables.Scp330;
using PlayerRoles;
using UnityEngine;
using Player = Exiled.Events.Handlers.Player;
using Version = System.Version;

namespace BetterBlueCandyHalloween;
    public class EventHandlers
    {
        private void OnEat(EatingScp330EventArgs ev)
        {
            if (ev.Candy.Kind == CandyKindID.Blue)
            {
                ev.IsAllowed = false;
                var RolePlayer = ev.Player.Role.Type;
                var posPlayer = ev.Player.Position;
                var healthPlayer = ev.Player.Health;
                ev.Player.CurrentItem.Destroy();
                ev.Player.DropItems();
                ev.Player.Role.Set(RoleTypeId.Tutorial);
                ev.Player.IsGodModeEnabled = false;
                ev.Player.Position = posPlayer;
                ev.Player.Health = healthPlayer;
                ev.Player.EnableEffect(EffectType.Marshmallow);
                ev.Player.AddAhp(base.Config.ShieldBlueCandy, base.Config.ShieldBlueCandy, 0f);
                Timing.CallDelayed(base.Config.TimeBlueCandy, () =>
                {
                    ev.Player.DisableEffect(EffectType.Marshmallow);
                    ev.Player.ArtificialHealth = 0f;
                    var posPlayer = ev.Player.Position;
                    var healthPlayer = ev.Player.Health;
                    ev.Player.Role.Set(RolePlayer);
                    ev.Player.Position = posPlayer;
                    ev.Player.Health = healthPlayer;
                    ev.Player.EnableEffect(EffectType.Blinded, 1, 5f);
                });
            }
        }
    }
