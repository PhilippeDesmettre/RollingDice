using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            

        }
        Random rnd = new Random();

        string srcBuild(int s1)
        {
            string src = "Alea_" + s1 + ".png";
            return src;
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("dicesound.mp3");
            player.Play();
            

            int dice1 = rnd.Next(1, 6);
            int dice2= rnd.Next(1, 6);
                       
            img1.Source= srcBuild(dice1);
            img2.Source= srcBuild(dice2);

            result.Text = (dice1 + dice2).ToString()+" !";



        }


    }
}
