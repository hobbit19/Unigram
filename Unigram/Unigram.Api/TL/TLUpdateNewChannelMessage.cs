// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateNewChannelMessage : TLUpdateBase 
	{
		public TLMessageBase Message { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLUpdateNewChannelMessage() { }
		public TLUpdateNewChannelMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateNewChannelMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Message = TLFactory.Read<TLMessageBase>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x62BA04D9);
			to.WriteObject(Message);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}