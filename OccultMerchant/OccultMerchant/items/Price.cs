using System;

namespace OccultMerchant.items
{
    public enum CoinType
    {
        CopperCoin,
        SilverCoin,
        GoldCoin,
        PlatinumCoin
    }

    public struct Price
    {
        public int value { get; set; }
        public CoinType coin { get; set; }

        public Price(int _value, CoinType _coin)
        {
            this.value = _value;
            this.coin = _coin;
        }

        public Price(string str)
        {
            string[] tmp = str.Split('[', ']', ':');
            this.value = Int32.Parse(tmp[1]);
            this.coin =(CoinType) Int32.Parse(tmp[2]);
        }

        public override string ToString()
        {
            return $"[{value.ToString()}:{((int)this.coin).ToString()}]";
        }

        
    }
}