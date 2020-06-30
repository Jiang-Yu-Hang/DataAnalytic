/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:56.76
*/
gx.evt.autoSkip = false;
gx.define('br_medicalimaginginsert', false, function () {
   this.ServerClass =  "br_medicalimaginginsert" ;
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
      this.AV17tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV10BR_MedicalImaging=gx.fn.getControlValue("vBR_MEDICALIMAGING") ;
      this.AV18BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
   };
   this.Validv_Vmetastasesdx=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVMETASTASESDX");
         this.AnyError  = 0;
         if ( ! ( ( this.AV23vMetastasesDX == "鍚? ) || ( this.AV23vMetastasesDX == "鏄? ) || ( this.AV23vMetastasesDX == "涓嶈" ) || ((''==this.AV23vMetastasesDX)) ) )
         {
            try {
               gxballoon.setError("鍩焩 Metastases DX瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Vmetadate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVMETADATE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s112_client=function()
   {
      if ( this.AV11vName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class", "RequiredDataContentCell" );
      }
      else
      {
         gx.fn.setCtrlProperty("VOTHERNAME_CELL","Class", "DataContentCell" );
      }
      if ( this.AV14wzName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("WXNAME_CELL","Class", "RequiredDataContentCell" );
      }
      else
      {
         gx.fn.setCtrlProperty("WXNAME_CELL","Class", "DataContentCell" );
      }
   };
   this.e15971_client=function()
   {
      this.clearMessages();
      if ( this.AV23vMetastasesDX == "鏄? )
      {
         gx.fn.setCtrlProperty("vVMETADATE","Visible", true );
         gx.fn.setCtrlProperty("vVMETALOC","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vVMETADATE","Visible", false );
         gx.fn.setCtrlProperty("vVMETALOC","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:'vVMETADATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e16971_client=function()
   {
      this.clearMessages();
      if ( this.AV11vName == "鍏跺畠" )
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
   this.e17971_client=function()
   {
      this.clearMessages();
      if ( this.AV14wzName == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("vWXNAME","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vWXNAME","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:'vWXNAME',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e13972_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e18971_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,90,91,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125];
   this.GXLastCtrlId =125;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "褰卞儚瀛?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",gxz:"ZV29GXV1",gxold:"OV29GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV1=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO",',')},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"TABLESPLITTEDVNAME",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"TEXTBLOCKVNAME", format:0,grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"TABLEMERGEDVNAME",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id:36 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e16971_client',evt_cvcing:null,rgrid:[],fld:"vVNAME",gxz:"ZV11vName",gxold:"OV11vName",gxvar:"AV11vName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV11vName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11vName=Value},v2c:function(){gx.fn.setComboBoxValue("vVNAME",gx.O.AV11vName)},c2v:function(){if(this.val()!==undefined)gx.O.AV11vName=this.val()},val:function(){return gx.fn.getControlValue("vVNAME")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERNAME",gxz:"ZV12vOtherName",gxold:"OV12vOtherName",gxvar:"AV12vOtherName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12vOtherName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12vOtherName=Value},v2c:function(){gx.fn.setControlValue("vVOTHERNAME",gx.O.AV12vOtherName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12vOtherName=this.val()},val:function(){return gx.fn.getControlValue("vVOTHERNAME")},nac:gx.falseFn};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE",gxz:"ZV30GXV2",gxold:"OV30GXV2",gxvar:"GXV2",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=gx.fn.toDatetimeValue(Value,"Y4MD")},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV2=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP",gxz:"ZV31GXV3",gxold:"OV31GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV3=Value},v2c:function(){gx.fn.setComboBoxValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP",gx.O.GXV3)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP")},nac:gx.falseFn};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",gxz:"ZV32GXV4",gxold:"OV32GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV32GXV4=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE",',')},nac:gx.falseFn};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE",gxz:"ZV33GXV5",gxold:"OV33GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33GXV5=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE")},nac:gx.falseFn};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmetastasesdx,isvalid:null,evt_cvc:'e15971_client',evt_cvcing:null,rgrid:[],fld:"vVMETASTASESDX",gxz:"ZV23vMetastasesDX",gxold:"OV23vMetastasesDX",gxvar:"AV23vMetastasesDX",ucs:[],op:[62],ip:[62],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV23vMetastasesDX=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23vMetastasesDX=Value},v2c:function(){gx.fn.setComboBoxValue("vVMETASTASESDX",gx.O.AV23vMetastasesDX)},c2v:function(){if(this.val()!==undefined)gx.O.AV23vMetastasesDX=this.val()},val:function(){return gx.fn.getControlValue("vVMETASTASESDX")},nac:gx.falseFn};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMETALOC",gxz:"ZV24vMetaLoc",gxold:"OV24vMetaLoc",gxvar:"AV24vMetaLoc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24vMetaLoc=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24vMetaLoc=Value},v2c:function(){gx.fn.setControlValue("vVMETALOC",gx.O.AV24vMetaLoc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24vMetaLoc=this.val()},val:function(){return gx.fn.getControlValue("vVMETALOC")},nac:gx.falseFn};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vmetadate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVMETADATE",gxz:"ZV25vMetaDate",gxold:"OV25vMetaDate",gxvar:"AV25vMetaDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25vMetaDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25vMetaDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVMETADATE",gx.O.AV25vMetaDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25vMetaDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVMETADATE")},nac:gx.falseFn};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",gxz:"ZV34GXV6",gxold:"OV34GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34GXV6=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG")},nac:gx.falseFn};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"TABLESPLITTEDWZNAME",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"TEXTBLOCKWZNAME", format:0,grid:0};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"TABLEMERGEDWZNAME",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id:91 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e17971_client',evt_cvcing:null,rgrid:[],fld:"vWZNAME",gxz:"ZV14wzName",gxold:"OV14wzName",gxvar:"AV14wzName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV14wzName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14wzName=Value},v2c:function(){gx.fn.setComboBoxValue("vWZNAME",gx.O.AV14wzName)},c2v:function(){if(this.val()!==undefined)gx.O.AV14wzName=this.val()},val:function(){return gx.fn.getControlValue("vWZNAME")},nac:gx.falseFn};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id:94 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vWXNAME",gxz:"ZV15wxName",gxold:"OV15wxName",gxvar:"AV15wxName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15wxName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15wxName=Value},v2c:function(){gx.fn.setControlValue("vWXNAME",gx.O.AV15wxName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15wxName=this.val()},val:function(){return gx.fn.getControlValue("vWXNAME")},nac:gx.falseFn};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN", format:0,grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"svchar",len:5000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",gxz:"ZV35GXV7",gxold:"OV35GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35GXV7=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN",gx.O.GXV7,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN")},nac:gx.falseFn};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",grid:0};
   GXValidFnc[106]={ id: 106, fld:"",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES", format:0,grid:0};
   GXValidFnc[109]={ id: 109, fld:"",grid:0};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id:111 ,lvl:0,type:"svchar",len:9999,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",gxz:"ZV36GXV8",gxold:"OV36GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36GXV8=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES",gx.O.GXV8,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES")},nac:gx.falseFn};
   GXValidFnc[112]={ id: 112, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"",grid:0};
   GXValidFnc[115]={ id: 115, fld:"",grid:0};
   GXValidFnc[116]={ id: 116, fld:"BTNENTER",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[118]={ id: 118, fld:"BTNCANCEL",grid:0};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"",grid:0};
   GXValidFnc[121]={ id: 121, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[122]={ id:122 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",gxz:"ZV37GXV9",gxold:"OV37GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV37GXV9=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",gx.O.GXV9,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGINGID",',')},nac:gx.falseFn};
   GXValidFnc[123]={ id:123 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_ENCOUNTERID",gxz:"ZV38GXV10",gxold:"OV38GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV10=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV38GXV10=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_ENCOUNTERID",gx.O.GXV10,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV10=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[124]={ id:124 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO",gxz:"ZV39GXV11",gxold:"OV39GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV11=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV39GXV11=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO",gx.O.GXV11,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV11=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[125]={ id:125 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",gxz:"ZV40GXV12",gxold:"OV40GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV12=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV40GXV12=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",gx.O.GXV12,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV12=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID",',')},nac:gx.falseFn};
   this.GXV1 = 0 ;
   this.ZV29GXV1 = 0 ;
   this.OV29GXV1 = 0 ;
   this.AV11vName = "" ;
   this.ZV11vName = "" ;
   this.OV11vName = "" ;
   this.AV12vOtherName = "" ;
   this.ZV12vOtherName = "" ;
   this.OV12vOtherName = "" ;
   this.GXV2 = gx.date.nullDate() ;
   this.ZV30GXV2 = gx.date.nullDate() ;
   this.OV30GXV2 = gx.date.nullDate() ;
   this.GXV3 = "" ;
   this.ZV31GXV3 = "" ;
   this.OV31GXV3 = "" ;
   this.GXV4 = 0 ;
   this.ZV32GXV4 = 0 ;
   this.OV32GXV4 = 0 ;
   this.GXV5 = "" ;
   this.ZV33GXV5 = "" ;
   this.OV33GXV5 = "" ;
   this.AV23vMetastasesDX = "" ;
   this.ZV23vMetastasesDX = "" ;
   this.OV23vMetastasesDX = "" ;
   this.AV24vMetaLoc = "" ;
   this.ZV24vMetaLoc = "" ;
   this.OV24vMetaLoc = "" ;
   this.AV25vMetaDate = gx.date.nullDate() ;
   this.ZV25vMetaDate = gx.date.nullDate() ;
   this.OV25vMetaDate = gx.date.nullDate() ;
   this.GXV6 = "" ;
   this.ZV34GXV6 = "" ;
   this.OV34GXV6 = "" ;
   this.AV14wzName = "" ;
   this.ZV14wzName = "" ;
   this.OV14wzName = "" ;
   this.AV15wxName = "" ;
   this.ZV15wxName = "" ;
   this.OV15wxName = "" ;
   this.GXV7 = "" ;
   this.ZV35GXV7 = "" ;
   this.OV35GXV7 = "" ;
   this.GXV8 = "" ;
   this.ZV36GXV8 = "" ;
   this.OV36GXV8 = "" ;
   this.GXV9 = 0 ;
   this.ZV37GXV9 = 0 ;
   this.OV37GXV9 = 0 ;
   this.GXV10 = 0 ;
   this.ZV38GXV10 = 0 ;
   this.OV38GXV10 = 0 ;
   this.GXV11 = "" ;
   this.ZV39GXV11 = "" ;
   this.OV39GXV11 = "" ;
   this.GXV12 = 0 ;
   this.ZV40GXV12 = 0 ;
   this.OV40GXV12 = 0 ;
   this.GXV1 = 0 ;
   this.AV11vName = "" ;
   this.AV12vOtherName = "" ;
   this.GXV2 = gx.date.nullDate() ;
   this.GXV3 = "" ;
   this.GXV4 = 0 ;
   this.GXV5 = "" ;
   this.AV23vMetastasesDX = "" ;
   this.AV24vMetaLoc = "" ;
   this.AV25vMetaDate = gx.date.nullDate() ;
   this.GXV6 = "" ;
   this.AV14wzName = "" ;
   this.AV15wxName = "" ;
   this.GXV7 = "" ;
   this.GXV8 = "" ;
   this.GXV9 = 0 ;
   this.GXV10 = 0 ;
   this.GXV11 = "" ;
   this.GXV12 = 0 ;
   this.AV18BR_EncounterID = 0 ;
   this.AV10BR_MedicalImaging = {BR_MedicalImagingID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_MedicalImaging_ID:0,BR_MedicalImaging_No:0,BR_MedicalImaging_ImageName:"",BR_MedicalImaging_ImageName_Code:"",BR_MedicalImaging_ImageDate:gx.date.nullDate(),BR_MedicalImaging_ImageHosp:"",BR_MedicalImaging_ImageHosp_Code:"",BR_MedicalImaging_ImageAge:0,BR_MedicalImaging_ImageLoc:"",BR_MedicalImaging_ImageLoc_Code:"",BR_MedicalImaging_ImageOrgan:"",BR_MedicalImaging_PreImageDiag:"",BR_MedicalImaging_ImageDes:"",BR_MedicalImaging_TumorSize:"",BR_MedicalImaging_ImageHtml:"",BR_MedicalImaging_MetastasesDX:"",BR_MedicalImaging_MetaLoc:"",BR_MedicalImaging_MetaDate:gx.date.nullDate(),Mode:"",Initialized:0,BR_MedicalImagingID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_MedicalImaging_ID_Z:0,BR_MedicalImaging_No_Z:0,BR_MedicalImaging_ImageName_Z:"",BR_MedicalImaging_ImageName_Code_Z:"",BR_MedicalImaging_ImageDate_Z:gx.date.nullDate(),BR_MedicalImaging_ImageHosp_Z:"",BR_MedicalImaging_ImageHosp_Code_Z:"",BR_MedicalImaging_ImageAge_Z:0,BR_MedicalImaging_ImageLoc_Z:"",BR_MedicalImaging_ImageLoc_Code_Z:"",BR_MedicalImaging_ImageOrgan_Z:"",BR_MedicalImaging_PreImageDiag_Z:"",BR_MedicalImaging_ImageDes_Z:"",BR_MedicalImaging_TumorSize_Z:"",BR_MedicalImaging_ImageHtml_Z:"",BR_MedicalImaging_MetastasesDX_Z:"",BR_MedicalImaging_MetaLoc_Z:"",BR_MedicalImaging_MetaDate_Z:gx.date.nullDate()} ;
   this.Events = {"e13972_client": ["ENTER", true] ,"e18971_client": ["CANCEL", true] ,"e15971_client": ["VVMETASTASESDX.CONTROLVALUECHANGED", false] ,"e16971_client": ["VVNAME.CONTROLVALUECHANGED", false] ,"e17971_client": ["VWZNAME.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV18BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''},{ctrl:'vVNAME'},{av:'AV11vName',fld:'vVNAME',pic:''},{ctrl:'vWZNAME'},{av:'AV14wzName',fld:'vWZNAME',pic:''}],[{ctrl:'BR_MEDICALIMAGING_BR_MEDICALIMAGINGID',prop:'Visible'},{ctrl:'BR_MEDICALIMAGING_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO',prop:'Visible'},{ctrl:'BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:'vVOTHERNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:'vWXNAME',prop:'Visible'},{av:'AV24vMetaLoc',fld:'vVMETALOC',pic:''},{av:'AV25vMetaDate',fld:'vVMETADATE',pic:''},{av:'gx.fn.getCtrlProperty("VOTHERNAME_CELL","Class")',ctrl:'VOTHERNAME_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("WXNAME_CELL","Class")',ctrl:'WXNAME_CELL',prop:'Class'}]];
   this.EvtParms["VVMETASTASESDX.CONTROLVALUECHANGED"] = [[{ctrl:'vVMETASTASESDX'},{av:'AV23vMetastasesDX',fld:'vVMETASTASESDX',pic:''}],[{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:'vVMETADATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''},{ctrl:'vVNAME'},{av:'AV11vName',fld:'vVNAME',pic:''},{av:'AV12vOtherName',fld:'vVOTHERNAME',pic:''},{ctrl:'vWZNAME'},{av:'AV14wzName',fld:'vWZNAME',pic:''},{av:'AV15wxName',fld:'vWXNAME',pic:''},{av:'AV18BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV24vMetaLoc',fld:'vVMETALOC',pic:''},{av:'AV25vMetaDate',fld:'vVMETADATE',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV23vMetastasesDX',fld:'vVMETASTASESDX',pic:''}],[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''}]];
   this.EvtParms["VVNAME.CONTROLVALUECHANGED"] = [[{ctrl:'vVNAME'},{av:'AV11vName',fld:'vVNAME',pic:''}],[{av:'gx.fn.getCtrlProperty("vVOTHERNAME","Visible")',ctrl:'vVOTHERNAME',prop:'Visible'}]];
   this.EvtParms["VWZNAME.CONTROLVALUECHANGED"] = [[{ctrl:'vWZNAME'},{av:'AV14wzName',fld:'vWZNAME',pic:''}],[{av:'gx.fn.getCtrlProperty("vWXNAME","Visible")',ctrl:'vWXNAME',prop:'Visible'}]];
   this.EvtParms["LOAD"] = [[{av:'AV20BR_MedicalImagingID',fld:'vBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vVNAME'},{av:'AV11vName',fld:'vVNAME',pic:''},{ctrl:'vWZNAME'},{av:'AV14wzName',fld:'vWZNAME',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV23vMetastasesDX',fld:'vVMETASTASESDX',pic:''}],[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''},{av:'gx.fn.getCtrlProperty("vVMETADATE","Visible")',ctrl:'vVMETADATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVMETALOC","Visible")',ctrl:'vVMETALOC',prop:'Visible'},{ctrl:'vVNAME'},{av:'AV11vName',fld:'vVNAME',pic:''},{ctrl:'vWZNAME'},{av:'AV14wzName',fld:'vWZNAME',pic:''},{ctrl:'vVMETASTASESDX'},{av:'AV23vMetastasesDX',fld:'vVMETASTASESDX',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV17tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV10BR_MedicalImaging", "vBR_MEDICALIMAGING", 0, "BR_MedicalImaging", 0, 0);
   this.setVCMap("AV18BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_No"], this.GXValidFnc[25], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ImageDate"], this.GXValidFnc[44], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ImageHosp"], this.GXValidFnc[48], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ImageAge"], this.GXValidFnc[53], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_TumorSize"], this.GXValidFnc[57], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_PreImageDiag"], this.GXValidFnc[80], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ImageOrgan"], this.GXValidFnc[103], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ImageDes"], this.GXValidFnc[111], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImagingID"], this.GXValidFnc[122], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_EncounterID"], this.GXValidFnc[123], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_Information_PatientNo"], this.GXValidFnc[124], "AV10BR_MedicalImaging");
   this.addBCProperty("Br_medicalimaging", ["BR_MedicalImaging_ID"], this.GXValidFnc[125], "AV10BR_MedicalImaging");
   this.Initialize( );
});
gx.createParentObj(br_medicalimaginginsert);
