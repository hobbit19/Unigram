// <auto-generated/>
using System;

namespace Telegram.Api.TL.Stickers.Methods
{
	/// <summary>
	/// RCP method stickers.removeStickerFromSet.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesStickerSet"/>
	/// </summary>
	public partial class TLStickersRemoveStickerFromSet : TLObject
	{
		public TLInputDocumentBase Sticker { get; set; }

		public TLStickersRemoveStickerFromSet() { }
		public TLStickersRemoveStickerFromSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StickersRemoveStickerFromSet; } }

		public override void Read(TLBinaryReader from)
		{
			Sticker = TLFactory.Read<TLInputDocumentBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF7760F51);
			to.WriteObject(Sticker);
		}
	}
}