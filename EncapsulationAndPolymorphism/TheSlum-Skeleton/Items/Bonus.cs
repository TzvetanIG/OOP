using TheSlum.Interfaces;

namespace TheSlum.Items
{
    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect, int timeout)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = timeout;
        }

        public int Timeout { get; set; }
        public int Countdown { get; set; }
        public bool HasTimedOut { get; set; }
    }
}
