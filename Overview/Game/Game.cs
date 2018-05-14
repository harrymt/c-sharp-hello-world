using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview.Game
{
    interface IGame
    {
        bool Start(Player[] players);

        Player GetPlayer(int number);
    }
}
