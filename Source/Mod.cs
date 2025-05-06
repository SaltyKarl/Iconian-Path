using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace IconianPsycasts
{
    public class IconianPsycasts_Mod : Mod
    {
        public static IconianPsycasts_Settings settings;
        public IconianPsycasts_Mod(ModContentPack content) : base(content)
        {
            settings = GetSettings<IconianPsycasts_Settings>();
        }
        public override string SettingsCategory()
        {
            return "Iconian Psycasts";
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.DoWindowContents(inRect);
        }
    }
}
