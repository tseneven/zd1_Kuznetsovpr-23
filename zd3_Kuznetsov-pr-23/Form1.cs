using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_Kuznetsov_pr_23
{
    public partial class Form1 : Form
    {
        Playlist pl;
        Playlist.Song song;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pl = new Playlist();
            song = new Playlist.Song();
            song.Author = "AutorX";
            song.Title = "TitleX";
            song.Filename = "FileX";
            pl.Add(song);

            song = new Playlist.Song();
            song.Author = "AutorY";
            song.Title = "TitleY";
            song.Filename = "FileY";
            pl.Add(song);

            song = new Playlist.Song();
            song.Author = "AutorZ";
            song.Title = "TitleZ";
            song.Filename = "FileZ";
            pl.Add(song);

            Playlist.Song curSong = new Playlist.Song();
            curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);

            UpdateButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pl.CurrentIndex++;
            Playlist.Song curSong = new Playlist.Song();
            curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);
            UpdateButton();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pl.CurrentIndex--;
            Playlist.Song curSong = new Playlist.Song();
            curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);
            UpdateButton();

        }

        private void Go_to_Button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Playlist.Song curSong = new Playlist.Song();
            try
            {
                if (Convert.ToInt32(textBox4.Text) >= 0 && Convert.ToInt32(textBox4.Text) < pl.List.Count)
                {
                    curSong = pl.GetSongByIndex(Convert.ToInt32(textBox4.Text));

                    listBox1.Items.Add(curSong.Author);
                    listBox1.Items.Add(curSong.Title);
                    listBox1.Items.Add(curSong.Filename);
                } 
                else
                {
                    MessageBox.Show("Такой песни нету");
                }
            }
            catch (Exception ex) 
            {
                throw (new Exception($"Ошибка: {ex}"));
            }
            pl.CurrentIndex = Convert.ToInt32(textBox4.Text);
            UpdateButton();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playlist.Song song = new Playlist.Song();
            song.Author = textBox1.Text;
            song.Title = textBox2.Text;
            song.Filename = textBox3.Text;

            pl.Add(song);

            pl.CurrentIndex = pl.List.Count - 1;
            Playlist.Song curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Clear();
            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);
            UpdateButton();
        }

        private void UpdateButton()
        {
            button2.Enabled = pl.CurrentIndex > 0;
            button3.Enabled = pl.CurrentIndex < pl.List.Count - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pl.CurrentIndex = 0;
            Playlist.Song curSong = new Playlist.Song();
            curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);
            UpdateButton();
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox5.Text == "")
                {
                    pl.Delete(pl.CurrentIndex);
                }
                else
                {
                    pl.Delete(textBox5.Text);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception ($"Ошибка: {ex}");
            }

            listBox1.Items.Clear();
            Playlist.Song curSong = new Playlist.Song();
            curSong = pl.GetSongByIndex(pl.CurrentIndex);

            listBox1.Items.Add(curSong.Author);
            listBox1.Items.Add(curSong.Title);
            listBox1.Items.Add(curSong.Filename);
            UpdateButton();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pl.ClearPl();
            UpdateButton();
            pl.CurrentIndex = 0;
            listBox1.Items.Clear();
        }
    }
}
