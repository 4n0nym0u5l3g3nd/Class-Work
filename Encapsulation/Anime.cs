using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Anime
    {
        private string anime_name;

        public string Getname()
        {
            return anime_name;
        }
        public void Setname(String anime_name)
        {
            this.anime_name = anime_name;
        }
    }
}
