using System;
using System.Collections.Generic;

namespace wizard_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard newWiz = new Wizard("Bubbles");
            Wizard quavoWiz = new Wizard("Quavo");
            
            // quavoWiz.fireball(newWiz);
            // newWiz.heal();
            // quavoWiz.heal();
            // quavoWiz.getinfo();
            Ninja newNin = new Ninja("Sam");
            newNin.getinfo();
            Wizard takeoffWiz = new Wizard("Takeoff");
            // takeoffWiz.getinfo();
            // newNin.steal(newWiz);
            // newNin.getinfo();
            // newWiz.getinfo();
            // newNin.get_away();
            // newNin.getinfo();
            Samurai newSamurai = new Samurai("Offset");
            newSamurai.getinfo();
            quavoWiz.getinfo();
            newSamurai.death_blow(quavoWiz);
            quavoWiz.getinfo();
            takeoffWiz.fireball(newSamurai);
            newSamurai.getinfo();
            newSamurai.meditate();
            newSamurai.getinfo();
            newSamurai.how_many();
            Samurai savageSamurai = new Samurai("Savage");
            savageSamurai.how_many();
            Samurai thotSamural = new Samurai("Thot");
            thotSamural.how_many();
            



            
        }
    }
}
