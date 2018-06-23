using puskaric.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class ImageWarrior : Warrior
    {

        private CharacterImage image;

        public ImageWarrior(string name, int health, CharacterImage image)
        {
            this.CharacterClass = "Warrior";
            this.attackBehavior = new ImageSwordAttack(image);
            this.Name = name;
            this.Health = health;
            this.image = image;
            image.State = CharacterImage.CharacterState.Idle;
        }

        public override void ReceiveAttack(int damage)
        {
            image.State = CharacterImage.CharacterState.TakeDamage;

            Thread.Sleep(200);

            base.ReceiveAttack(damage);

            if (Health == 0)
                image.State = CharacterImage.CharacterState.Dead;
            else
                image.State = CharacterImage.CharacterState.Idle;
        }

    }
}
