using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Modul6_1302213121
{
    internal class SayaTubeUser
    {
        //field
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String Username;
        //Method
        public SayaTubeUser(String username)
        {
            this.Username = username;
            Random random = new Random();
            id = random.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User:" +this.Username);
            for (int i = 0; i <= uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video "+(i+1)+" judul:" + uploadedVideos[i].title);
            }
        }

    }
}
