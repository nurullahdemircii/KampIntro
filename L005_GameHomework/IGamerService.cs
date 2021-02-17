using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update();
        public void Delete();
    }
}
