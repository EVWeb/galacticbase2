namespace Galactic_Base_2.Src.Stats
{
    public class AttackDefense
    {
        private int attackDefense { get; set; }

        public AttackDefense(int attackDefense)
        {
            this.attackDefense = attackDefense;
        }

        public void TakeDamage(AttackDefense attack)
        {
            this.attackDefense -= attack.attackDefense;
        }
    }
}
