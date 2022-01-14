﻿using Arrowgene.Ddon.GameServer.Dump;
using Arrowgene.Ddon.Server.Logging;
using Arrowgene.Ddon.Server.Network;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class MailSystemMailGetListHeadHandler : PacketHandler<GameClient>
    {
        private static readonly DdonLogger Logger = LogProvider.Logger<DdonLogger>(typeof(MailSystemMailGetListHeadHandler));


        public MailSystemMailGetListHeadHandler(DdonGameServer server) : base(server)
        {
        }

        public override PacketId Id => PacketId.C2S_MAIL_SYSTEM_MAIL_GET_LIST_HEAD_REQ;

        public override void Handle(GameClient client, Packet packet)
        {
            client.Send(InGameDump.Dump_83);
        }
    }
}