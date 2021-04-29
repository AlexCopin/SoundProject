using UnityEngine;
using UnityEngine.UI;
class UI : MonoBehaviour
{
    int volFactor = 100;
    public Slider masterVol, musicVol, sfxVol;
    public Button eventExplo, eventCombat;
    public void SetMasterVol()
    {
        AkSoundEngine.SetRTPCValue("User_RTPC_Master_Vol", masterVol.value * volFactor);
    }
    public void SetMusicVol()
    {
        AkSoundEngine.SetRTPCValue("User_RTPC_Music_Vol", musicVol.value * volFactor);
    }
    public void SetSFXVol()
    {
        AkSoundEngine.SetRTPCValue("User_RTPC_SFX_Vol", sfxVol.value * volFactor);
    }
    public void SetExplo()
    {
        AkSoundEngine.PostEvent("Event_Explo", gameObject);
    }
    public void SetTension()
    {
        AkSoundEngine.PostEvent("Event_Tension", gameObject);
    }
    public void PlayMusic()
    {
        AkSoundEngine.PostEvent("Play_LVL_0", gameObject);
    }
    public void StopMusic()
    {
        AkSoundEngine.PostEvent("Stop_LVL_0", gameObject);
    }
    public void PlayVictory()
    {
        AkSoundEngine.PostEvent("Play_Defeat", gameObject);
    }
    public void PlayDefeat()
    {
        AkSoundEngine.PostEvent("Play_Victory", gameObject);
    }
    public void PlayBonusSFX()
    {
        AkSoundEngine.PostEvent("Play_Bonus", gameObject);
    }
    public void PlayRadioSFX()
    {
        AkSoundEngine.PostEvent("Play_Radio", gameObject);
    }
    public void PlayCartoonSFX()
    {
        AkSoundEngine.PostEvent("Play_Cartoon", gameObject);
    }
    public void PlayMonsterSFX()
    {
        AkSoundEngine.PostEvent("Play_Monster", gameObject);
    }
}