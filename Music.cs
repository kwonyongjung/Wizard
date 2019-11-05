using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Music
{
    MediaPlayer.MediaPlayerClass Start;
    MediaPlayer.MediaPlayerClass Ending;
    MediaPlayer.MediaPlayerClass Die;
    public void Start_Music()
    {
        Start = new MediaPlayer.MediaPlayerClass();
        Start.FileName = @"Undertale.mp3";
        Start.Play();
    }
    public void Ending_Music()
    {
        Ending = new MediaPlayer.MediaPlayerClass();
        Ending.FileName = @"end.mp3";
        Ending.Play();
    }
    public void Die_Music()
    {
        Die = new MediaPlayer.MediaPlayerClass();
        Die.FileName = @"die.mp3";
        Die.Play();
    }
}
