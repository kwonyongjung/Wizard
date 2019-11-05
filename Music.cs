using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Music
{
    //참조추가탭 -> COM탭 -> Windows.MediaPlayer 참조 추가
    //참조추가된 MediaPlayer의 속성에 들어가서 InterOP를 true에서 false로 변경
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
