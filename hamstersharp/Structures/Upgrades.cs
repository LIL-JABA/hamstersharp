#pragma warning disable CS8618

namespace hamstersharp.Structures.Upgrades
{

    public class Upgrades
    {
        public Upgrade[] upgradesForBuy { get; set; }
    }

    public class Upgrade
    {
        public string id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public float profitPerHour { get; set; }
        public object condition { get; set; }
        public string section { get; set; }
        public int level { get; set; }
        public float currentProfitPerHour { get; set; }
        public float profitPerHourDelta { get; set; }
        public bool isAvailable { get; set; }
        public bool isExpired { get; set; }
        public int cooldownSeconds { get; set; }
        public int maxLevel { get; set; }
        public int totalCooldownSeconds { get; set; }
        public Toggle toggle { get; set; }
        public DateTime expiresAt { get; set; }
    }

    public class Toggle
    {
        public DateTime enableAt { get; set; }
    }

}
