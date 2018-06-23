using puskaric.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class ImageNormalAttack : NormalAttack
    {

        public void Attack(ICharacter attacker, ICharacter defender, CharacterImage image)
        {

            image.State = CharacterImage.CharacterState.Attacking;
            System.Console.WriteLine("Attacking");
            Thread.Sleep(200);   
            base.Attack(attacker, defender);
            image.State = CharacterImage.CharacterState.Idle;
        }

    }
}
