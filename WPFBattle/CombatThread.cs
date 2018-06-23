using puskaric.RoleplayingGameInterfaces;
using puskaric.RPGTester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{
    class CombatThread
    {

        private ICombat encounter; 
        private Thread thread;

        public CombatThread(ICombat encounter)
        {
            this.encounter = encounter; 
        }

        public void Start()
        {
            thread = new Thread(() =>
            {
                encounter.AutoBattle();
            });
            thread.Name = "GameThread";

            thread.Start();
        }

        public void Deactivate()
        {
            thread.Abort();
        }

    }
}
