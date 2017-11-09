using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Card_Game_2000
{
    class Character
    {
        public string name;
        public int health;
        public int damage;

        public void Damage(Character pTarget, int pDamage)
        {
            pTarget.health -= pDamage;
        }
    }

    class NonPlayerCharacter : Character
    {
        public NonPlayerCharacter(string pName, int pHealth, int pDamage)
        {
            name = pName;
            health = pHealth;
            damage = pDamage;
        }
    }

    class PlayerCharacter : Character
    {
        PlayerCharacterType type;

        public PlayerCharacter(string pName, int pHealth, int pDamage, string pType)
        {
            name = pName;
            health = pHealth;
            damage = pDamage;

            switch (pType)
            {
                case "warrior":
                    type = new Warrior(this);
                    break;
                case "thief":
                    type = new Thief(this);
                    break;
                case "mage":
                    type = new Mage(this);
                    break;
            }
        }

        public void AttackSpecial(NonPlayerCharacter pTarget)
        {
            type.AttackSpecial(pTarget);
        }
    }

    class PlayerCharacterType
    {
        public PlayerCharacter pc;
        public Random random = new Random();

        public virtual void AttackSpecial(NonPlayerCharacter pTarget)
        {
            throw new NotImplementedException();
        }
    }

    class Warrior : PlayerCharacterType
    {
        public Warrior(PlayerCharacter pPlayerCharacter)
        {
            pc = pPlayerCharacter;
        }

        public override void AttackSpecial(NonPlayerCharacter pTarget)
        {
            if (random.Next(1, 4) == 1)
            {
                pc.Damage(pTarget, pc.damage * 3);
            }
        }
    }

    class Thief : PlayerCharacterType
    {
        public Thief(PlayerCharacter pPlayerCharacter)
        {
            pc = pPlayerCharacter;
        }

        public override void AttackSpecial(NonPlayerCharacter pTarget)
        {
            if (random.Next(1, 4) == 1)
            {
                pc.Damage(pTarget, pc.damage * 2);
            }
            else
            {
                pc.Damage(pTarget, pc.damage / 2);
            }
        }
    }

    class Mage : PlayerCharacterType
    {
        public Mage(PlayerCharacter pPlayerCharacter)
        {
            pc = pPlayerCharacter;
        }

        public override void AttackSpecial(NonPlayerCharacter pTarget)
        {
            if (random.Next(1, 3) == 1)
            {
                pc.Damage(pTarget, pc.damage * 4);
            }
            else
            {
                pc.Damage(pc, pc.damage);
            }
        }
    }
}

