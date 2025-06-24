using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Kuznetsov_pr_23
{
    public class Playlist
    {
        public struct Song
        {
            public string Author;
            public string Title;
            public string Filename;
        }

        private List<Song> list;
        private int currentIndex = 0;

        public int CurrentIndex { get => currentIndex; set => currentIndex = value; }
        public List<Song> List { get => list;}

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        // Метод для получения текущей песни
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Add(Song song) 
        {
            list.Add(song);
        }

        // Метод для получения песни по индексу
        public Song GetSongByIndex(int index)
        {
            if (list.Count > 0)
                return list[index];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");

        }

        // Метод удаления из плейлиста
        public void Delete(int i)
        {
            list.RemoveAt(i);
        }

        // Метод удаления из плейлиста с перегрузкой
        public void Delete(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(name == List[i].Title)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        // Метод для очистки плейлиста
        public void ClearPl()
        {
            List.Clear();
        }
    }
}
