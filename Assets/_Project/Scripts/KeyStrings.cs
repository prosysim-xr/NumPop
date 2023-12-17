using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyStrings
{
    #region player prefs keys
    public static string AutoLoadScene => "AutoLoadScene";
    public static string Name => "Name";
    public static string ServerMode => "ServerMode";
    #endregion

    #region Mutiplayer Player Keys
    public static string Slot => "Slot";
    #endregion;

    #region Multiplayer Room Keys
    public static string RoomName => "RoomName";
    public static string RoomPassword => "RoomPassword";
    public static string RoomMaxPlayers => "RoomMaxPlayers";
    public static string RoomIsOpen => "RoomIsOpen";
    public static string RoomIsVisible => "RoomIsVisible";
    public static string GameJson => "GameJson";
    #endregion
}
