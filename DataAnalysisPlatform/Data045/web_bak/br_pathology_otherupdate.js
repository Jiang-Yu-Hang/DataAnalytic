/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:55.42
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_otherupdate', false, function () {
   this.ServerClass =  "br_pathology_otherupdate" ;
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
      this.AV16tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV10BR_Pathology_Other=gx.fn.getControlValue("vBR_PATHOLOGY_OTHER") ;
      this.AV17BR_Pathology_OtherID=gx.fn.getIntegerValue("vBR_PATHOLOGY_OTHERID",',') ;
   };
   this.s112_client=function()
   {
      if ( this.AV11zlName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("BZNAME_CELL","Class", "RequiredDataContentCell" );
      }
      else
      {
         gx.fn.setCtrlProperty("BZNAME_CELL","Class", "DataContentCell" );
      }
      if ( this.AV13vName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class", "RequiredDataContentCell" );
      }
      else
      {
         gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class", "DataContentCell" );
      }
   };
   this.e15961_client=function()
   {
      this.clearMessages();
      this.popupOpenUrl(gx.http.formatLink("beizhu.aspx",[]), []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e16961_client=function()
   {
      this.clearMessages();
      if ( this.AV13vName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("vVOTHERNAME","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vVOTHERNAME","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:'vVOTHERNAME',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e17961_client=function()
   {
      this.clearMessages();
      if ( this.AV11zlName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("vBZNAME","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vBZNAME","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vBZNAME","Visible")',ctrl:'vBZNAME',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e13962_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e18961_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,15,16,17,18,19,20,21,22,23,24,25,28,29,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,85,86,88,89,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105];
   this.GXLastCtrlId =105;
   this.DVPANEL_TABLEATTRIBUTESContainer = gx.uc.getNew(this, 13, 0, "BootstrapPanel", "DVPANEL_TABLEATTRIBUTESContainer", "Dvpanel_tableattributes", "DVPANEL_TABLEATTRIBUTES");
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
   GXValidFnc[12]={ id: 12, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[15]={ id: 15, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLESPLITTEDZLNAME",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TEXTBLOCKZLNAME", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"TABLEMERGEDZLNAME",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e17961_client',evt_cvcing:null,rgrid:[],fld:"vZLNAME",gxz:"ZV11zlName",gxold:"OV11zlName",gxvar:"AV11zlName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV11zlName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11zlName=Value},v2c:function(){gx.fn.setComboBoxValue("vZLNAME",gx.O.AV11zlName)},c2v:function(){if(this.val()!==undefined)gx.O.AV11zlName=this.val()},val:function(){return gx.fn.getControlValue("vZLNAME")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vBZNAME",gxz:"ZV12bzName",gxold:"OV12bzName",gxvar:"AV12bzName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12bzName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12bzName=Value},v2c:function(){gx.fn.setControlValue("vBZNAME",gx.O.AV12bzName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12bzName=this.val()},val:function(){return gx.fn.getControlValue("vBZNAME")},nac:gx.falseFn};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM", format:0,grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",gxz:"ZV23GXV1",gxold:"OV23GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV23GXV1=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",gx.O.GXV1,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM",',','.')},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT", format:0,grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT",gxz:"ZV24GXV2",gxold:"OV24GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24GXV2=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT",gx.O.GXV2)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT")},nac:gx.falseFn};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW", format:0,grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",gxz:"ZV25GXV3",gxold:"OV25GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV3=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",gx.O.GXV3,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW",',','.')},nac:gx.falseFn};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH", format:0,grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",gxz:"ZV26GXV4",gxold:"OV26GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV4=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",gx.O.GXV4,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH",',','.')},nac:gx.falseFn};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND", format:0,grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",gxz:"ZV27GXV5",gxold:"OV27GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV5=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND")},nac:gx.falseFn};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TABLESPLITTEDVNAME",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"TEXTBLOCKVNAME", format:0,grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"TABLEMERGEDVNAME",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e16961_client',evt_cvcing:null,rgrid:[],fld:"vVNAME",gxz:"ZV13vName",gxold:"OV13vName",gxvar:"AV13vName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV13vName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13vName=Value},v2c:function(){gx.fn.setComboBoxValue("vVNAME",gx.O.AV13vName)},c2v:function(){if(this.val()!==undefined)gx.O.AV13vName=this.val()},val:function(){return gx.fn.getControlValue("vVNAME")},nac:gx.falseFn};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id:89 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERNAME",gxz:"ZV14vOtherName",gxold:"OV14vOtherName",gxvar:"AV14vOtherName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14vOtherName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14vOtherName=Value},v2c:function(){gx.fn.setControlValue("vVOTHERNAME",gx.O.AV14vOtherName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14vOtherName=this.val()},val:function(){return gx.fn.getControlValue("vVOTHERNAME")},nac:gx.falseFn};
   GXValidFnc[91]={ id: 91, fld:"BTNBEIZHU",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"BTNENTER",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"BTNCANCEL",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[102]={ id:102 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",gxz:"ZV28GXV6",gxold:"OV28GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV28GXV6=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID",',')},nac:gx.falseFn};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",gxz:"ZV29GXV7",gxold:"OV29GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV7=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",gx.O.GXV7,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGYID",',')},nac:gx.falseFn};
   GXValidFnc[104]={ id:104 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO",gxz:"ZV30GXV8",gxold:"OV30GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV8=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO",gx.O.GXV8)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO")},nac:gx.falseFn};
   GXValidFnc[105]={ id:105 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL",gxz:"ZV31GXV9",gxold:"OV31GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV9=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL",gx.O.GXV9)},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL")},nac:gx.falseFn};
   this.AV11zlName = "" ;
   this.ZV11zlName = "" ;
   this.OV11zlName = "" ;
   this.AV12bzName = "" ;
   this.ZV12bzName = "" ;
   this.OV12bzName = "" ;
   this.GXV1 = 0 ;
   this.ZV23GXV1 = 0 ;
   this.OV23GXV1 = 0 ;
   this.GXV2 = "" ;
   this.ZV24GXV2 = "" ;
   this.OV24GXV2 = "" ;
   this.GXV3 = 0 ;
   this.ZV25GXV3 = 0 ;
   this.OV25GXV3 = 0 ;
   this.GXV4 = 0 ;
   this.ZV26GXV4 = 0 ;
   this.OV26GXV4 = 0 ;
   this.GXV5 = "" ;
   this.ZV27GXV5 = "" ;
   this.OV27GXV5 = "" ;
   this.AV13vName = "" ;
   this.ZV13vName = "" ;
   this.OV13vName = "" ;
   this.AV14vOtherName = "" ;
   this.ZV14vOtherName = "" ;
   this.OV14vOtherName = "" ;
   this.GXV6 = 0 ;
   this.ZV28GXV6 = 0 ;
   this.OV28GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.ZV29GXV7 = 0 ;
   this.OV29GXV7 = 0 ;
   this.GXV8 = "" ;
   this.ZV30GXV8 = "" ;
   this.OV30GXV8 = "" ;
   this.GXV9 = "" ;
   this.ZV31GXV9 = "" ;
   this.OV31GXV9 = "" ;
   this.AV11zlName = "" ;
   this.AV12bzName = "" ;
   this.GXV1 = 0 ;
   this.GXV2 = "" ;
   this.GXV3 = 0 ;
   this.GXV4 = 0 ;
   this.GXV5 = "" ;
   this.AV13vName = "" ;
   this.AV14vOtherName = "" ;
   this.GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.GXV8 = "" ;
   this.GXV9 = "" ;
   this.AV17BR_Pathology_OtherID = 0 ;
   this.AV10BR_Pathology_Other = {BR_Pathology_OtherID:0,BR_PathologyID:0,BR_Pathology_Other_Bio:"",BR_Pathology_Other_Bio_Code:"",BR_Pathology_Other_BioNum:0,BR_Pathology_Other_BioNum_Code:"",BR_Pathology_Other_BioNumUnit:"",BR_Pathology_Other_BioQual:"",BR_Pathology_Other_BioQual_Code:"",BR_Pathology_Other_Low:0,BR_Pathology_Other_High:0,BR_Pathology_Other_AbnInd:"",BR_Pathology_Other_AbnInd_Code:"",Mode:"",Initialized:0,BR_Pathology_OtherID_Z:0,BR_PathologyID_Z:0,BR_Pathology_Other_Bio_Z:"",BR_Pathology_Other_Bio_Code_Z:"",BR_Pathology_Other_BioNum_Z:0,BR_Pathology_Other_BioNum_Code_Z:"",BR_Pathology_Other_BioNumUnit_Z:"",BR_Pathology_Other_BioQual_Z:"",BR_Pathology_Other_BioQual_Code_Z:"",BR_Pathology_Other_Low_Z:0,BR_Pathology_Other_High_Z:0,BR_Pathology_Other_AbnInd_Z:"",BR_Pathology_Other_AbnInd_Code_Z:""} ;
   this.Events = {"e13962_client": ["ENTER", true] ,"e18961_client": ["CANCEL", true] ,"e15961_client": ["'DOBEIZHU'", false] ,"e16961_client": ["VVNAME.CONTROLVALUECHANGED", false] ,"e17961_client": ["VZLNAME.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV17BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV17BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{ctrl:'vZLNAME'},{av:'AV11zlName',fld:'vZLNAME',pic:''},{ctrl:'vVNAME'},{av:'AV13vName',fld:'vVNAME',pic:''}],[{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGYID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Visible'},{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''},{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:'vVOTHERNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vBZNAME","Visible")',ctrl:'vBZNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BZNAME_CELL","Class")',ctrl:'BZNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("VOTHERNAME_CELL","Class")',ctrl:'VOTHERNAME_CELL',prop:'Class'}]];
   this.EvtParms["'DOBEIZHU'"] = [[],[]];
   this.EvtParms["VVNAME.CONTROLVALUECHANGED"] = [[{ctrl:'vVNAME'},{av:'AV13vName',fld:'vVNAME',pic:''}],[{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:'vVOTHERNAME',prop:'Visible'}]];
   this.EvtParms["VZLNAME.CONTROLVALUECHANGED"] = [[{ctrl:'vZLNAME'},{av:'AV11zlName',fld:'vZLNAME',pic:''}],[{av:'gx.fn.getCtrlProperty("vBZNAME","Visible")',ctrl:'vBZNAME',prop:'Visible'}]];
   this.EvtParms["ENTER"] = [[{ctrl:'vVNAME'},{av:'AV13vName',fld:'vVNAME',pic:''},{av:'AV14vOtherName',fld:'vVOTHERNAME',pic:''},{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''},{ctrl:'vZLNAME'},{av:'AV11zlName',fld:'vZLNAME',pic:''},{av:'AV12bzName',fld:'vBZNAME',pic:''}],[{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''}]];
   this.EvtParms["LOAD"] = [[{av:'AV17BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{ctrl:'vZLNAME'},{av:'AV11zlName',fld:'vZLNAME',pic:''},{ctrl:'vVNAME'},{av:'AV13vName',fld:'vVNAME',pic:''}],[{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''},{ctrl:'vZLNAME'},{av:'AV11zlName',fld:'vZLNAME',pic:''},{ctrl:'vVNAME'},{av:'AV13vName',fld:'vVNAME',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV16tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV10BR_Pathology_Other", "vBR_PATHOLOGY_OTHER", 0, "BR_Pathology_Other", 0, 0);
   this.setVCMap("AV17BR_Pathology_OtherID", "vBR_PATHOLOGY_OTHERID", 0, "int", 18, 0);
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_BioNum"], this.GXValidFnc[40], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_BioNumUnit"], this.GXValidFnc[49], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_Low"], this.GXValidFnc[57], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_High"], this.GXValidFnc[66], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_AbnInd"], this.GXValidFnc[74], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_OtherID"], this.GXValidFnc[102], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_PathologyID"], this.GXValidFnc[103], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_Bio"], this.GXValidFnc[104], "AV10BR_Pathology_Other");
   this.addBCProperty("Br_pathology_other", ["BR_Pathology_Other_BioQual"], this.GXValidFnc[105], "AV10BR_Pathology_Other");
   this.Initialize( );
});
gx.createParentObj(br_pathology_otherupdate);
