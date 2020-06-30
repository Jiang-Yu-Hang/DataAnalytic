function sgQRCode($)
{
	this.Width;
	this.Height;

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
	var medical_ima_url = $.query.get("url");
	var img_id = $.query.get("imageid");
	var medical_ima_url=medical_ima_url+"?"+img_id
	jQuery('#qrcodeCanvas').qrcode({
		text	: medical_ima_url
	});	

		
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)


	
	
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
