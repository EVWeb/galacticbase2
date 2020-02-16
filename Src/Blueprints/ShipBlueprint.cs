using Galactic_Base_2.Src.Stats;
using System.Collections;

namespace Galactic_Base_2.Src.Blueprints
{
    public class ShipBlueprint : Hashtable
    {
        public string name { get; }
        public string desciption { get; }
        public AttackDefense defense { get; }
        public AttackDefense attack { get; }
        public Distance speed { get; }
        public Distance range { get; }
        public Distance vision { get; }

    }
}
