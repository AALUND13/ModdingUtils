﻿using UnboundLib;
using UnityEngine;

namespace ModdingUtils.Extensions
{
    public class GetPlayerColor
    {
        public static Color GetColorMax(Player player)
        {
            // I "borrowed" this code from Willis
            Color colorMax = Color.clear;
            Color colorMin = Color.clear;


            PlayerSkinParticle[] componentsInChildren = player.gameObject.GetComponentsInChildren<PlayerSkinParticle>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                ParticleSystem particleSystem = (ParticleSystem)componentsInChildren[i].GetFieldValue("part");
                ParticleSystem.MinMaxGradient startColor = particleSystem.main.startColor;
                colorMax = startColor.colorMax;
                colorMin = startColor.colorMin;
            }

            return colorMax;
        }
        public static Color GetColorMin(Player player)
        {
            // I "borrowed" this code from Willis
            Color colorMax = Color.clear;
            Color colorMin = Color.clear;


            PlayerSkinParticle[] componentsInChildren = player.gameObject.GetComponentsInChildren<PlayerSkinParticle>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                ParticleSystem particleSystem = (ParticleSystem)componentsInChildren[i].GetFieldValue("part");
                ParticleSystem.MinMaxGradient startColor = particleSystem.main.startColor;
                colorMax = startColor.colorMax;
                colorMin = startColor.colorMin;
            }

            return colorMin;
        }
    }
}