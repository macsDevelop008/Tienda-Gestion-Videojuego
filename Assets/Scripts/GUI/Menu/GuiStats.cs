using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuiStats : MonoBehaviour
{
    public static GuiStats Shared;

    //Force
    [SerializeField] Text _forceNum; 
    [SerializeField] Slider _forceSlider;

    //Agility
    [SerializeField] Text _agilityNum;
    [SerializeField] Slider _agilitySlider;

    //Agility
    [SerializeField] Text _manaNum;
    [SerializeField] Slider _manaSlider;


    private void Awake()
    {
        Shared = this;
    }

    private void Start()
    {
        InicializarStatsGUI();
    }

    PlayerStatsController PlayerStats() 
    {
        return PlayerStatsController.Shared;
    }

    void InicializarStatsGUI() 
    {
        ModificarFuerzaGUI(PlayerStats().DarForceTotal());
        ModificarAgilidadGUI(PlayerStats().DarAilityTotal());
        ModificarManaGUI(PlayerStats().DarManaTotal());
    }

    public void ModificarFuerzaGUI(float num)
    {
        _forceNum.text = num.ToString();
        _forceSlider.value = num;
    }

    public void ModificarAgilidadGUI(float num)
    {
        _agilityNum.text = num.ToString();
        _agilitySlider.value = num;
    }

    public void ModificarManaGUI(float num)
    {
        _manaNum.text = num.ToString();
        _manaSlider.value = num;
    }
}
