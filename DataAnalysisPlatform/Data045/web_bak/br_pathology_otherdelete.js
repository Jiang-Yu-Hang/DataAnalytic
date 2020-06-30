/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:46:30.76
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_otherdelete', false, function () {
   this.ServerClass =  "br_pathology_otherdelete" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV10BR_Pathology_Other=gx.fn.getControlValue("vBR_PATHOLOGY_OTHER") ;
      this.AV11iBR_Pathology_OtherID=gx.fn.getIntegerValue("vIBR_PATHOLOGY_OTHERID",',') ;
   };
   this.e13742_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e15741_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92];
   this.GXLastCtrlId =92;
   this.DVPANEL_TABLEATTRIBUTESContainer = gx.uc.getNew(this, 16, 0, "BootstrapPanel", "DVPANEL_TABLEATTRIBUTESContainer", "Dvpanel_tableattributes", "DVPANEL_TABLEATTRIBUTES");
   var DVPANEL_TABLEATTRIBUTESContainer = this.DVPANEL_TABLEATTRIBUTESContainer;
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛﹀叾瀹冧俊鎭?, "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsible", "Collapsible", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEATTRIBUTESContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLECONTENT",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEVTUMORNAME",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKVTUMORNAME", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVTUMORNAME",gxz:"ZV12vTumorName",gxold:"OV12vTumorName",gxvar:"AV12vTumorName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12vTumorName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12vTumorName=Value},v2c:function(){gx.fn.setControlValue("vVTUMORNAME",gx.O.AV12vTumorName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12vTumorName=this.val()},val:function(){return gx.fn.getControlValue("vVTUMORNAME")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",gxz:"ZV18GXV1",gxold:"OV18GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV18GXV1=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",gx.O.GXV1,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",',','.')},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEVBR_PATHOLOGY_OTHER_BIONUMUNIT",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKVBR_PATHOLOGY_OTHER_BIONUMUNIT", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVBR_PATHOLOGY_OTHER_BIONUMUNIT",gxz:"ZV14vBR_Pathology_Other_BioNumUnit",gxold:"OV14vBR_Pathology_Other_BioNumUnit",gxvar:"AV14vBR_Pathology_Other_BioNumUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14vBR_Pathology_Other_BioNumUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14vBR_Pathology_Other_BioNumUnit=Value},v2c:function(){gx.fn.setControlValue("vVBR_PATHOLOGY_OTHER_BIONUMUNIT",gx.O.AV14vBR_Pathology_Other_BioNumUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14vBR_Pathology_Other_BioNumUnit=this.val()},val:function(){return gx.fn.getControlValue("vVBR_PATHOLOGY_OTHER_BIONUMUNIT")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",gxz:"ZV19GXV2",gxold:"OV19GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV19GXV2=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",gx.O.GXV2,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",',','.')},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",gxz:"ZV20GXV3",gxold:"OV20GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV20GXV3=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",gx.O.GXV3,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",',','.')},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",gxz:"ZV21GXV4",gxold:"OV21GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND")},nac:gx.falseFn};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEVBR_PATHOLOGY_OTHER_BIOQUAL",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKVBR_PATHOLOGY_OTHER_BIOQUAL", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVBR_PATHOLOGY_OTHER_BIOQUAL",gxz:"ZV13vBR_Pathology_Other_BioQual",gxold:"OV13vBR_Pathology_Other_BioQual",gxvar:"AV13vBR_Pathology_Other_BioQual",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13vBR_Pathology_Other_BioQual=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13vBR_Pathology_Other_BioQual=Value},v2c:function(){gx.fn.setControlValue("vVBR_PATHOLOGY_OTHER_BIOQUAL",gx.O.AV13vBR_Pathology_Other_BioQual,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13vBR_Pathology_Other_BioQual=this.val()},val:function(){return gx.fn.getControlValue("vVBR_PATHOLOGY_OTHER_BIOQUAL")},nac:gx.falseFn};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"BTNENTER",grid:0};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"BTNCANCEL",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[91]={ id:91 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",gxz:"ZV22GXV5",gxold:"OV22GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22GXV5=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",',')},nac:gx.falseFn};
   GXValidFnc[92]={ id:92 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",gxz:"ZV23GXV6",gxold:"OV23GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23GXV6=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",',')},nac:gx.falseFn};
   this.AV12vTumorName = "" ;
   this.ZV12vTumorName = "" ;
   this.OV12vTumorName = "" ;
   this.GXV1 = 0 ;
   this.ZV18GXV1 = 0 ;
   this.OV18GXV1 = 0 ;
   this.AV14vBR_Pathology_Other_BioNumUnit = "" ;
   this.ZV14vBR_Pathology_Other_BioNumUnit = "" ;
   this.OV14vBR_Pathology_Other_BioNumUnit = "" ;
   this.GXV2 = 0 ;
   this.ZV19GXV2 = 0 ;
   this.OV19GXV2 = 0 ;
   this.GXV3 = 0 ;
   this.ZV20GXV3 = 0 ;
   this.OV20GXV3 = 0 ;
   this.GXV4 = "" ;
   this.ZV21GXV4 = "" ;
   this.OV21GXV4 = "" ;
   this.AV13vBR_Pathology_Other_BioQual = "" ;
   this.ZV13vBR_Pathology_Other_BioQual = "" ;
   this.OV13vBR_Pathology_Other_BioQual = "" ;
   this.GXV5 = 0 ;
   this.ZV22GXV5 = 0 ;
   this.OV22GXV5 = 0 ;
   this.GXV6 = 0 ;
   this.ZV23GXV6 = 0 ;
   this.OV23GXV6 = 0 ;
   this.AV12vTumorName = "" ;
   this.GXV1 = 0 ;
   this.AV14vBR_Pathology_Other_BioNumUnit = "" ;
   this.GXV2 = 0 ;
   this.GXV3 = 0 ;
   this.GXV4 = "" ;
   this.AV13vBR_Pathology_Other_BioQual = "" ;
   this.GXV5 = 0 ;
   this.GXV6 = 0 ;
   this.AV11iBR_Pathology_OtherID = 0 ;
   this.AV10BR_Pathology_Other = {BR_Pathology_OtherID:0,BR_PathologyID:0,BR_Pathology_Other_Bio:"",BR_Pathology_Other_Bio_Code:"",BR_Pathology_Other_BioNum:0,BR_Pathology_Other_BioNum_Code:"",BR_Pathology_Other_BioNumUnit:"",BR_Pathology_Other_BioQual:"",BR_Pathology_Other_BioQual_Code:"",BR_Pathology_Other_Low:0,BR_Pathology_Other_High:0,BR_Pathology_Other_AbnInd:"",BR_Pathology_Other_AbnInd_Code:"",Mode:"",Initialized:0,BR_Pathology_OtherID_Z:0,BR_PathologyID_Z:0,BR_Pathology_Other_Bio_Z:"",BR_Pathology_Other_Bio_Code_Z:"",BR_Pathology_Other_BioNum_Z:0,BR_Pathology_Other_BioNum_Code_Z:"",BR_Pathology_Other_BioNumUnit_Z:"",BR_Pathology_Other_BioQual_Z:"",BR_Pathology_Other_BioQual_Code_Z:"",BR_Pathology_Other_Low_Z:0,BR_Pathology_Other_High_Z:0,BR_Pathology_Other_AbnInd_Z:"",BR_Pathology_Other_AbnInd_Code_Z:""} ;
   this.Events = {"e13742_client": ["ENTER", true] ,"e15741_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV11iBR_Pathology_OtherID',fld:'vIBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'AV11iBR_Pathology_OtherID',fld:'vIBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGYID',prop:'Visible'},{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''},{av:'AV12vTumorName',fld:'vVTUMORNAME',pic:''},{av:'AV13vBR_Pathology_Other_BioQual',fld:'vVBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV14vBR_Pathology_Other_BioNumUnit',fld:'vVBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''}],[]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10BR_Pathology_Other", "vBR_PATHOLOGY_OTHER", 0, "BR_Pathology_Other", 0, 0);
   this.setVCMap("AV11iBR_Pathology_OtherID", "vIBR_PATHOLOGY_OTHERID", 0, "int", 18, 0);
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_BioNum"], this.GXValidFnc[37], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_Low"], this.GXValidFnc[54], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_High"], this.GXValidFnc[63], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_AbnInd"], this.GXValidFnc[71], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_OtherID"], this.GXValidFnc[91], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_PathologyID"], this.GXValidFnc[92], "AV10BR_Pathology_Other");
   this.Initialize( );
});
gx.createParentObj(br_pathology_otherdelete);
