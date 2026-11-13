using System;
using System.Data; 

namespace ConsoleRPG
{
    /// <summary>
    /// playerとenemyの親となるクラス。
    /// </summary>
    public abstract class Character
    {
        public string Name { get; }
        public int MaxHp { get; }
        public int CurrentHp { get; private set; }
        public int Attack { get; }
        public int Defence { get; }

        /// <summary>
        /// characterが持つ値の初期化を行うコンストラクタ
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
