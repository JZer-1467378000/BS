using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public class CharacterAttributes
    {
        public ExploreAttributes ExplorAttrs;
        public List<string> Items;
        public NormalAttributes NormalAttrs;
    }

    public class ExploreAttributes
    {
        public float BeginEnergy;
        public float EnergyConsumeRate;
        public float MaxEnergy;
        public float MaxGainResources;
        public float ResourcesGainRate;
    }

    public class NormalAttributes
    {
        public float Knowledge;
        public float Resources;
    }
}