using System;

namespace MCDawn
{
    public class CmdOpChat : Command
    {
        public override string name { get { return "opchat"; } }
        public override string[] aliases { get { return new string[] { "" }; } }
        public override string type { get { return "other"; } }
        public override bool museumUsable { get { return true; } }
        public override LevelPermission defaultRank { get { return LevelPermission.AdvBuilder; } }
        public CmdOpChat() { }

        public override void Use(Player p, string message)
        {
            p.opchat = !p.opchat;
            if (p.opchat) Player.SendMessage(p, "All messages will now be sent to OPs only");
            else Player.SendMessage(p, "OP chat turned off");
        }
        public override void Help(Player p)
        {
            Player.SendMessage(p, "/opchat - Makes all messages sent go to OPs by default");
        }
    }
}