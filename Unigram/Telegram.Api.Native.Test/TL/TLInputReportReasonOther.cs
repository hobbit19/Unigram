// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputReportReasonOther : TLReportReasonBase 
	{
		public String Text { get; set; }

		public TLInputReportReasonOther() { }
		public TLInputReportReasonOther(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonOther; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Text ?? string.Empty);
		}
	}
}