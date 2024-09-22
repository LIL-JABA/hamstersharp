using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamstersharp.Data
{
    public static class Data
    {
        public static readonly Uri baseURI = new Uri("https://api.hamsterkombatgame.io/interlude");
        public static readonly Uri infoPath = new Uri("/sync");
        public static readonly Uri getUpgradesPath = new Uri("/upgrades-for-buy");
    }
}
