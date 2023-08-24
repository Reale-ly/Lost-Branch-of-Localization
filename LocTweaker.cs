using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Character.Cirno;
using LBoL.EntityLib.Cards.Character.Marisa;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoL.EntityLib.Cards.Neutral.Red;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static LBoL_Sideloader_Template1.BepinexPlugin;

namespace LBoL_Sideloader_Template1
{
    [OverwriteVanilla]
    public sealed class RedLaserLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(RedLaser);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource, true);
            globalLoc.LocalizationFiles.AddLocaleFile(Locale.En, "Cards");

            return globalLoc;
        }

        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }
    [OverwriteVanilla]
    public sealed class NightMana1Loc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(NightMana1);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }

        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }

    }

    [OverwriteVanilla]
    public sealed class NightMana2Loc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(NightMana2);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }

        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }

    }

    [OverwriteVanilla]
    public sealed class NightMana3Loc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(NightMana3);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class NightMana4Loc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(NightMana4);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class RunAwayLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(RunAway);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class DarkSatelliteLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(DarkSatellite);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class StarSkyLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(StarSky);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class MarisaEatLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(MarisaEat);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class DoubleManaLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(DoubleMana);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }

    [OverwriteVanilla]
    public sealed class ShannvAbilityLoc : CardTemplate
    {
        public override IdContainer GetId()
        {
            return nameof(ShannvAbility);
        }

        [DontOverwrite]
        public override CardImages LoadCardImages()
        {
            return null;
        }

        public override LocalizationOption LoadLocalization()
        {
            var globalLoc = new GlobalLocalization(embeddedSource);
            return globalLoc;
        }


        [DontOverwrite]
        public override CardConfig MakeConfig()
        {
            return null;
        }
    }
}
