using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul6_1302213121
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;
        //method
        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length <= 200 & title != null,"Judul Video lebih dari 200");
            this.title = title;
            Random random = new Random();
            id = random.Next(10000,99999);
            playCount = 0;
        }

        public void increasePlayCount(int playCount) {
            Debug.Assert(playCount <= 25000000 && playCount >= 0,"PlayCount Melebihi jumlah maksimal");
            this.playCount+= playCount;
        }

        public void PrintVideoDetails() {
            Console.WriteLine("id: "+this.id);
            Console.WriteLine("title: " + this.title);
            Console.WriteLine("PlayCount: " + this.playCount);
        }
    }
}
