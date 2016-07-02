// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.reportSpam
	/// </summary>
	public partial class TLChannelsReportSpam : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public TLInputUserBase UserId { get; set; }
		public TLVector<Int32> Id { get; set; }

		public TLChannelsReportSpam() { }
		public TLChannelsReportSpam(TLBinaryReader from, TLType type = TLType.ChannelsReportSpam)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelsReportSpam; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelsReportSpam)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			UserId = TLFactory.Read<TLInputUserBase>(from);
			Id = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFE087810);
			to.WriteObject(Channel);
			to.WriteObject(UserId);
			to.WriteObject(Id);
		}
	}
}