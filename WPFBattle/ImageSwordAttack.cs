using puskaric.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static WPFBattle.CharacterImage;

namespace WPFBattle
{
    class ImageSwordAttack : SwordAttack
    {
        private CharacterImage image;

        public ImageSwordAttack(CharacterImage image)
        {
            this.image = image;
        }

        public override void Attack(ICharacter attacker, ICharacter defender)
        {
            image.State = CharacterImage.CharacterState.Attacking;
            Thread.Sleep(200);
            base.Attack(attacker, defender);
            image.State = CharacterImage.CharacterState.Idle;
        }
    }
}
