using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public static PlayerStatsController Shared;


    private void Awake()
    {
        Shared = this;
    }

    PlayerItemsController ItemsPlayer() 
    {
        return PlayerItemsController.Shared;
    }

    public float DarForceTotal()
    {
        float t = 0;

        t = ItemsPlayer().Casco()._force + ItemsPlayer().Pechera()._force
                + ItemsPlayer().Guantes()._force + ItemsPlayer().Botas()._force 
                    + ItemsPlayer().Habilidad()._force + ItemsPlayer().Poder2()._force;

        t = reformatearValorStat(t);

        return t;
    }
    public float DarAilityTotal() 
    {
        float t = 0;

        t = ItemsPlayer().Casco()._agility + ItemsPlayer().Pechera()._agility
            + ItemsPlayer().Guantes()._agility + ItemsPlayer().Botas()._agility
                + ItemsPlayer().Habilidad()._agility + ItemsPlayer().Poder2()._agility;

        t = reformatearValorStat(t);

        return t;
    }
    public float DarManaTotal() 
    {
        float t = 0;

        t = ItemsPlayer().Casco()._mana + ItemsPlayer().Pechera()._mana
             + ItemsPlayer().Guantes()._mana + ItemsPlayer().Botas()._mana
                + ItemsPlayer().Habilidad()._mana + ItemsPlayer().Poder2()._mana;

        t = reformatearValorStat(t);

        return t;
    }

    float reformatearValorStat(float t)
    {
        if (t > 100)
        {
            t = 100;
        }
        else
        if (t < 0)
        {
            t = 0;
        }

        return t;
    }
}
