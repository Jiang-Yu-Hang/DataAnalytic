function sgHighChartsBasic($)
{
	this.Width;
	this.Height;
	this.OptionJson;
	this.SwitchType;

	// Databinding for property OptionJson
	this.SetOptionJson = function(data)
	{
		///UserCodeRegionStart:[SetOptionJson] (do not remove this comment.)

		this.OptionJson = data;
		
		
		
		
		
		
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property OptionJson
	this.GetOptionJson = function()
	{
		///UserCodeRegionStart:[GetOptionJson] (do not remove this comment.)

		return this.OptionJson;
		
		
		
		
		
		
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)

		var buffer = '<div id="' + this.ControlName + '" '
			buffer += 'style="width:' + this.Width + '; height:' + this.Height + '; line-height:' + this.Height + '; text-align:center">'
			buffer += 'The chart will appear within this DIV. This text will be replaced by the chart.'
			buffer += '</div>'
		this.setHtml(buffer);
		
		var containerDom = document.getElementById(this.ControlName);
		
		if (!this.OptionJson == ''){
			var option = JSON.parse(this.OptionJson);
			if (this.SwitchType == 'formatter')
			{
				option.tooltip.formatter = '';
			}
			else if (this.SwitchType == 'formatterX')
			{
				option.tooltip.formatter = function () {return '<b>' + this.series.name + ' ( ' + this.x + ' , ' + this.key + ' )</b>';};
			}
			else
			{
				//none
			}
			var chart = new Highcharts.Chart(containerDom,option);
		}
		
		
		
		
		
		
		
		
		
		
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	
	
	
	
	
	
	
	
	
	
	
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
