using System;

namespace ConsoleRPG
{
    /// <summary>
    /// playerとenemyの親となるクラス。
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// MaxHP
        /// </summary>
        public int MaxHp { get; }

        /// <summary>
        /// 現在HP
        /// </summary>
        public int CurrentHp { get; private set; }

        /// <summary>
        /// 攻撃力
        /// </summary>
        public int Attack { get; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defence { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected Character(string name, int maxhp, int attack, int defence)
        {
            Name = name;
            MaxHp = maxhp;
            CurrentHp = maxhp;
            Attack = attack;
            Defence = defence;
        }

        /// <summary>
        /// ダメージ計算式
        /// </summary>
        /// <param name="vDamage">ダメージ</param>
        public void TakeDamage(int vDamage)
        {
            if (vDamage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(vDamage));
            }

            CurrentHp = Math.Max(0, CurrentHp - vDamage);
        }

        /// <summary>
        /// 生存判定
        /// </summary>
        /// <returns>生死</returns>
        public bool IsAlive()
        {
            return CurrentHp > 0;
        }
    }
}
