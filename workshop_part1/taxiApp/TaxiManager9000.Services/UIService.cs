using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Services.Enums;
using TaxiManager9000.Services.Interfaces;
using TaxiManager9000.Services.Utilities;

namespace TaxiManager9000.Services
{
    public class UIService : IUIService
    {
        private List<MenuChoice> _menuItems;
        public List<MenuChoice> MenuItems 
        { 
            get => _menuItems;
            set 
               if()
                }

        public int ChooseEntitesMenu<T>(List<T> enttites) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public int ChooseMenu<T>(List<T> items)
        {
            throw new NotImplementedException();
        }

        public User LogInMenu()
        {
            Console.WriteLine("Taxi Manager 9000");
            ExtendedConsole.Separator();
            Console.WriteLine("Log in:");
            string username = ExtendedConsole.GetInput("Username:");
            string password = ExtendedConsole.GetInput("Password:");

            return new User { UserName = username, Password = password };
        }

        public int MainMenu(Role role)
        {
            var menuItems = new List<MenuChoice>() {MenuChoice.ChangePassword, MenuChoice.Exit};
            switch(role)
            {
                case Role.Admin:
                    menuItems = menuItems.Prepend(MenuChoice.AddNewUser).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.RemoveExistingUser).ToList();
                    break;
                case Role.Manager:



            }
        }

        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome {user.Role} user");
        }
    }
}
}
