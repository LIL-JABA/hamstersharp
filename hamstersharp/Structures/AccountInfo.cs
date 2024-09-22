#pragma warning disable CS8618

namespace hamstersharp.Structures.AccountInfo
{

    public class AccountInfo
    {
        public Interludeuser interludeUser { get; set; }
    }

    public class Interludeuser
    {
        public string id { get; set; }
        public float totalDiamonds { get; set; }
        public float balanceDiamonds { get; set; }
        public float earnPassivePerSec { get; set; }
        public float earnPassivePerHour { get; set; }
        public float lastPassiveEarn { get; set; }
        public int lastSyncUpdate { get; set; }
        public string exchangeId { get; set; }
        public Upgrades upgrades { get; set; }
        public Tasks tasks { get; set; }
        public int referralsCount { get; set; }
        public Skin skin { get; set; }
        public Achievement[] achievements { get; set; }
        public Withdraw withdraw { get; set; }
        public Memories memories { get; set; }
        public Minigame miniGame { get; set; }
        public Promo[] promos { get; set; }
        public Airdroptasks airdropTasks { get; set; }
        public Tokenbalance tokenBalance { get; set; }
    }

    public class Upgrades
    {
        public Int_Year_Strategy int_year_strategy { get; set; }
    }

    public class Int_Year_Strategy
    {
        public string id { get; set; }
        public int level { get; set; }
        public int lastUpgradeAt { get; set; }
    }

    public class Tasks
    {
        public Select_Exchange select_exchange { get; set; }
        public Subscribe_Telegram_Channel subscribe_telegram_channel { get; set; }
    }

    public class Select_Exchange
    {
        public string id { get; set; }
        public DateTime completedAt { get; set; }
    }

    public class Subscribe_Telegram_Channel
    {
        public string id { get; set; }
        public DateTime completedAt { get; set; }
    }

    public class Skin
    {
        public string selectedSkinId { get; set; }
        public Available[] available { get; set; }
    }

    public class Available
    {
        public string skinId { get; set; }
        public DateTime buyAt { get; set; }
    }

    public class Withdraw
    {
        public int state { get; set; }
        public object[] unavailable { get; set; }
        public Info info { get; set; }
        public string selected { get; set; }
    }

    public class Info
    {
        public Telegramwallet TelegramWallet { get; set; }
    }

    public class Telegramwallet
    {
        public string uid { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Memories
    {
        public float totalCoins { get; set; }
        public int diffDays { get; set; }
        public int upgradesTotal { get; set; }
    }

    public class Minigame
    {
        public Candles Candles { get; set; }
    }

    public class Candles
    {
        public DateTime lastStartAt { get; set; }
        public DateTime lastClaimAt { get; set; }
    }

    public class Airdroptasks
    {
        public Airdrop_Connect_Ton_Wallet airdrop_connect_ton_wallet { get; set; }
        public Subscribe_Telegram_Channel1 subscribe_telegram_channel { get; set; }
    }

    public class Airdrop_Connect_Ton_Wallet
    {
        public string id { get; set; }
        public string walletAddress { get; set; }
        public DateTime completedAt { get; set; }
    }

    public class Subscribe_Telegram_Channel1
    {
        public string id { get; set; }
        public DateTime completedAt { get; set; }
    }

    public class Tokenbalance
    {
        public long tokens_passive { get; set; }
        public long tokens_keys { get; set; }
        public long tokens_friends { get; set; }
        public long tokens_achivements { get; set; }
        public int tokens_tasks { get; set; }
        public long total { get; set; }
        public int claimed { get; set; }
        public long unclaimed { get; set; }
        public long nextUnlocked { get; set; }
    }

    public class Achievement
    {
        public string id { get; set; }
        public DateTime unlockedAt { get; set; }
        public bool isNew { get; set; }
        public bool isClaimed { get; set; }
    }

    public class Promo
    {
        public string promoId { get; set; }
        public int rewardsTotal { get; set; }
        public int rewardsToday { get; set; }
        public DateTime rewardsLastTime { get; set; }
        public int lastPromoCodeLevel { get; set; }
        public long[] hashes { get; set; }
    }

}
