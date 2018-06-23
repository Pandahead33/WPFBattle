using System;
using System.Windows.Media;
using System.Windows.Controls;

namespace WPFBattle
{
    public class CharacterImage : Image
    {

        public enum CharacterState { Attacking, TakeDamage, Dead, Idle};
        private CharacterState state; 

        public ImageSource IdleImageSource { get; set; }
        public ImageSource AttackingImageSource { get; set; }
        public ImageSource TakeDamageImageSource { get; set; }
        public ImageSource DeadImageSource { get; set; }

        protected void UpdateImageSource()
        {
            switch (State)
            {
                case CharacterState.Attacking:
                    this.Source = AttackingImageSource;
                    break;
                case CharacterState.TakeDamage:
                    this.Source = TakeDamageImageSource;
                    break;
                case CharacterState.Dead:
                    this.Source = DeadImageSource;
                    break;
                case CharacterState.Idle:
                default:
                    this.Source = IdleImageSource;
                    break;
            }
        }

        protected override void OnRender(DrawingContext dc)
        {
            UpdateImageSource();
            base.OnRender(dc);
        }

        public CharacterState State
        {
            get { return state; }
            set
            {
                state = value;
                this.Dispatcher.Invoke((Action)(() =>
                {
                    UpdateImageSource();
                })); 
            }
        }


    }
}
