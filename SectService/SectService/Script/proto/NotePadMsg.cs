﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Game.Script.Net;
public class MsgGetText : MsgBase
{
    public MsgGetText()
    {
        protoName = "MsgGetText";
    }
    public string text = "";

}
public class MsgSaveText : MsgBase
{ 
    public MsgSaveText()
    {
        protoName = "MsgSaveText";
    }
    public string text = "";
    public int result = 0;

}
public partial class MsgHandler
{
    public static void MsgGetText(ClientState c,MsgBase msgBase)
    {
        MsgGetText msg = (MsgGetText)msgBase;
        Player player = c.player;
        if(player == null)
        {
            return;
        }
        msg.text = player.data.text;
        player.Send(msg);
    }
    public static void MsgSaveText(ClientState c,MsgBase msgBase)
    {
        MsgSaveText msg = (MsgSaveText)msgBase;
        Player player = c.player;
        if (player == null)
        {
            return;
        }
        player.data.text = msg.text;
        player.Send(msg);
    }

}


