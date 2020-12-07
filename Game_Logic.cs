namespace Game_project
{
    public class Game_Logic
    {
        public int Hammer_Position;
        public int Bullet_Position;
        public int Fire_on_Head;


        public int shoot()
        {
            if (Hammer_Position == Bullet_Position)
            {
                return 1;
            }
            else if (Bullet_Position == 6)
            {
                Bullet_Position = 1;
                return 0;
            }
            else
            {
                Bullet_Position++;
                return 0;
            }
        }


    }
}
