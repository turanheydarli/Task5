namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Test";

            PlayerController playerController = new PlayerController(player);

            playerController.EquipWeapon(new Weapon { Name = "Kalashnikovadajjefi"});

            playerController.Attack();

        }
    }


}