using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.dom;

namespace SpaceshipExampleOfApp
{
    public class Application
    {
        public HTMLDivElement NavigationBar;

        public HTMLButtonElement ButtonNewsFeed;
        public HTMLButtonElement ButtonCompanies;
        public HTMLButtonElement ButtonMyProfile;
        public HTMLButtonElement ButtonContact;

        public HTMLDivElement DisplayViewPort;

        public Application()
        {
            NavigationBar = new HTMLDivElement();
            NavigationBar.className = "nar-bar";
            // Each Button is 25% of the screen...
            SetupNavButtons(
                (ButtonNewsFeed = new HTMLButtonElement() { innerText = "Today's News" }),
                (ButtonCompanies = new HTMLButtonElement() { innerText = "Companies" }),
                (ButtonMyProfile = new HTMLButtonElement() { innerText = "My Profile" }),
                (ButtonContact = new HTMLButtonElement() { innerText = "Contact" }));

            document.body.appendChild(NavigationBar);
        }

        public void SetupNavButtons(params HTMLButtonElement[] buttons)
        {
            
            for (int i = 0; i < buttons.Length; i++)
            {
                var button = buttons[i];                
                button.className = "nav-button";
                button.style.left = (i * 25) + "%";
                button.tabIndex = -1;
                NavigationBar.appendChild(button);
            }
        }
    }
}
