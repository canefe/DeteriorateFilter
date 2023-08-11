using RimWorld;
using Verse;
using System;
using System.Collections.Generic;

namespace Deteriorated
{
    public class SpecialThingFilterWorker_AllowNotDetThings : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            List<StatModifier> statBases = t.def.statBases;
            StatDef deteriorationRate = StatDefOf.DeteriorationRate;
            if (!statBases.StatListContains(deteriorationRate))
            {
                return true;
            }
            float rate = statBases.GetStatValueFromList(deteriorationRate, 0f);
            return (rate == 0f);
        }

        public override bool CanEverMatch(ThingDef def)
        {
            List<StatModifier> statBases = def.statBases;
            StatDef deteriorationRate = StatDefOf.DeteriorationRate;
            if (!statBases.StatListContains(deteriorationRate))
            {
                return true;
            }
            float rate = statBases.GetStatValueFromList(deteriorationRate, 0f);
            return (rate == 0f);
        }
    }

    public class SpecialThingFilterWorker_AllowDetThings : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            List<StatModifier> statBases = t.def.statBases;
            StatDef deteriorationRate = StatDefOf.DeteriorationRate;
            if (!statBases.StatListContains(deteriorationRate))
            {
                return false;
            }
            float rate = statBases.GetStatValueFromList(deteriorationRate, 0f);
            return (rate > 0f);
        }

        public override bool CanEverMatch(ThingDef def)
        {
            List<StatModifier> statBases = def.statBases;
            StatDef deteriorationRate = StatDefOf.DeteriorationRate;
            if (!statBases.StatListContains(deteriorationRate))
            {
                return false;
            }
            float rate = statBases.GetStatValueFromList(deteriorationRate, 0f);
            return (rate > 0f);
        }
    }

}


