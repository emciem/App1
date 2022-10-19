using System;
namespace AudioPlayEx
{
    public interface IAudio
    {
        void PlayAudioFile(string fileName);


        void StopAudioFile(string fileName);

    }
}