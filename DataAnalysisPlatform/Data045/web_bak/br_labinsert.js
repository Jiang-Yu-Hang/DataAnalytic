/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:43.36
*/
gx.evt.autoSkip = false;
gx.define('br_labinsert', false, function () {
   this.ServerClass =  "br_labinsert" ;
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
      this.AV20tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV10BR_Lab=gx.fn.getControlValue("vBR_LAB") ;
      this.AV21BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
   };
   this.Validv_Vspecimendate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVSPECIMENDATE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Vreceivingtime=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVRECEIVINGTIME");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Vreporttime=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVREPORTTIME");
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
      if ( this.AV11vSource == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("VOTHERSOURCE_CELL","Class", "RequiredDataContentCell" );
      }
      else
      {
         gx.fn.setCtrlProperty("VOTHERSOURCE_CELL","Class", "DataContentCell" );
      }
   };
   this.e158q1_client=function()
   {
      this.clearMessages();
      if ( this.AV11vSource == "鍏跺畠" )
      {
         gx.fn.setCtrlProperty("vVOTHERSOURCE","Visible", true );
      }
      else
      {
         gx.fn.setCtrlProperty("vVOTHERSOURCE","Visible", false );
      }
      this.refreshOutputs([{av:'gx.fn.getCtrlProperty("vVOTHERSOURCE","Visible")',ctrl:'vVOTHERSOURCE',prop:'Visible'}]);
      return gx.$.Deferred().resolve();
   };
   this.e138q2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e168q1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,49,50,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119];
   this.GXLastCtrlId =119;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "瀹為獙瀹ゆ鏌?, "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_TESTNAME",gxz:"ZV25GXV1",gxold:"OV25GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25GXV1=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_TESTNAME",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_TESTNAME")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_TESTENGNAME",gxz:"ZV26GXV2",gxold:"OV26GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26GXV2=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_TESTENGNAME",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_TESTENGNAME")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_AGE",gxz:"ZV27GXV3",gxold:"OV27GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV27GXV3=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_AGE",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_BR_LAB_AGE",',')},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_DIAG",gxz:"ZV28GXV4",gxold:"OV28GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_DIAG",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_DIAG")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"TABLESPLITTEDVSOURCE",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"TEXTBLOCKVSOURCE", format:0,grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"TABLEMERGEDVSOURCE",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:'e158q1_client',evt_cvcing:null,rgrid:[],fld:"vVSOURCE",gxz:"ZV11vSource",gxold:"OV11vSource",gxvar:"AV11vSource",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.AV11vSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV11vSource=Value},v2c:function(){gx.fn.setComboBoxValue("vVSOURCE",gx.O.AV11vSource)},c2v:function(){if(this.val()!==undefined)gx.O.AV11vSource=this.val()},val:function(){return gx.fn.getControlValue("vVSOURCE")},nac:gx.falseFn};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVOTHERSOURCE",gxz:"ZV12vOtherSource",gxold:"OV12vOtherSource",gxvar:"AV12vOtherSource",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12vOtherSource=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12vOtherSource=Value},v2c:function(){gx.fn.setControlValue("vVOTHERSOURCE",gx.O.AV12vOtherSource,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12vOtherSource=this.val()},val:function(){return gx.fn.getControlValue("vVOTHERSOURCE")},nac:gx.falseFn};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vspecimendate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVSPECIMENDATE",gxz:"ZV13vSpecimenDate",gxold:"OV13vSpecimenDate",gxvar:"AV13vSpecimenDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13vSpecimenDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13vSpecimenDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVSPECIMENDATE",gx.O.AV13vSpecimenDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.AV13vSpecimenDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vVSPECIMENDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 57 , function() {
   });
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vreceivingtime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVRECEIVINGTIME",gxz:"ZV14vReceivingTime",gxold:"OV14vReceivingTime",gxvar:"AV14vReceivingTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14vReceivingTime=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14vReceivingTime=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVRECEIVINGTIME",gx.O.AV14vReceivingTime,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.AV14vReceivingTime=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vVRECEIVINGTIME")},nac:gx.falseFn};
   this.declareDomainHdlr( 62 , function() {
   });
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vreporttime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVREPORTTIME",gxz:"ZV15vReportTime",gxold:"OV15vReportTime",gxvar:"AV15vReportTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15vReportTime=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15vReportTime=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVREPORTTIME",gx.O.AV15vReportTime,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.AV15vReportTime=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("vVREPORTTIME")},nac:gx.falseFn};
   this.declareDomainHdlr( 66 , function() {
   });
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:500,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_RESULTQUAL",gxz:"ZV29GXV5",gxold:"OV29GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29GXV5=Value},v2c:function(){gx.fn.setComboBoxValue("BR_LAB_BR_LAB_RESULTQUAL",gx.O.GXV5)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_RESULTQUAL")},nac:gx.falseFn};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_RESULTUNIT",gxz:"ZV30GXV6",gxold:"OV30GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30GXV6=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_RESULTUNIT",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_RESULTUNIT")},nac:gx.falseFn};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_ABNIND",gxz:"ZV31GXV7",gxold:"OV31GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31GXV7=Value},v2c:function(){gx.fn.setComboBoxValue("BR_LAB_BR_LAB_ABNIND",gx.O.GXV7)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_ABNIND")},nac:gx.falseFn};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id:85 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_NORMRANGELOW",gxz:"ZV32GXV8",gxold:"OV32GXV8",gxvar:"GXV8",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV8=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV32GXV8=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_NORMRANGELOW",gx.O.GXV8,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV8=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_NORMRANGELOW")},nac:gx.falseFn};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id:90 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_TESTMETHOD",gxz:"ZV33GXV9",gxold:"OV33GXV9",gxvar:"GXV9",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV9=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33GXV9=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_TESTMETHOD",gx.O.GXV9,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV9=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_TESTMETHOD")},nac:gx.falseFn};
   GXValidFnc[91]={ id: 91, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id:94 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_INSTRUMENTCODE",gxz:"ZV34GXV10",gxold:"OV34GXV10",gxvar:"GXV10",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV10=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34GXV10=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_INSTRUMENTCODE",gx.O.GXV10,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV10=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_INSTRUMENTCODE")},nac:gx.falseFn};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id:99 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_INSTRUMENTNAME",gxz:"ZV35GXV11",gxold:"OV35GXV11",gxvar:"GXV11",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV11=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35GXV11=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_INSTRUMENTNAME",gx.O.GXV11,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV11=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_INSTRUMENTNAME")},nac:gx.falseFn};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"svchar",len:500,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_RESULTNUM",gxz:"ZV36GXV12",gxold:"OV36GXV12",gxvar:"GXV12",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV12=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV36GXV12=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_RESULTNUM",gx.O.GXV12,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV12=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_RESULTNUM")},nac:gx.falseFn};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"",grid:0};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"BTNENTER",grid:0};
   GXValidFnc[109]={ id: 109, fld:"",grid:0};
   GXValidFnc[110]={ id: 110, fld:"BTNCANCEL",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[112]={ id: 112, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[114]={ id:114 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_ENCOUNTERID",gxz:"ZV37GXV13",gxold:"OV37GXV13",gxvar:"GXV13",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV13=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV37GXV13=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_ENCOUNTERID",gx.O.GXV13,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV13=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_BR_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[115]={ id:115 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_INFORMATION_PATIENTNO",gxz:"ZV38GXV14",gxold:"OV38GXV14",gxvar:"GXV14",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV14=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV38GXV14=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_INFORMATION_PATIENTNO",gx.O.GXV14,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV14=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[116]={ id:116 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LABID",gxz:"ZV39GXV15",gxold:"OV39GXV15",gxvar:"GXV15",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV15=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV39GXV15=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LABID",gx.O.GXV15,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV15=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_BR_LABID",',')},nac:gx.falseFn};
   GXValidFnc[117]={ id:117 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_SAMPLEID",gxz:"ZV40GXV16",gxold:"OV40GXV16",gxvar:"GXV16",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV16=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40GXV16=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_SAMPLEID",gx.O.GXV16,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV16=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_SAMPLEID")},nac:gx.falseFn};
   GXValidFnc[118]={ id:118 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_TESTID",gxz:"ZV41GXV17",gxold:"OV41GXV17",gxvar:"GXV17",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV17=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV41GXV17=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_TESTID",gx.O.GXV17,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV17=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_LAB_BR_LAB_TESTID",',')},nac:gx.falseFn};
   GXValidFnc[119]={ id:119 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_BR_LAB_NORMRANGEHIGH",gxz:"ZV42GXV18",gxold:"OV42GXV18",gxvar:"GXV18",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV18=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV42GXV18=Value},v2c:function(){gx.fn.setControlValue("BR_LAB_BR_LAB_NORMRANGEHIGH",gx.O.GXV18,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV18=this.val()},val:function(){return gx.fn.getControlValue("BR_LAB_BR_LAB_NORMRANGEHIGH")},nac:gx.falseFn};
   this.GXV1 = "" ;
   this.ZV25GXV1 = "" ;
   this.OV25GXV1 = "" ;
   this.GXV2 = "" ;
   this.ZV26GXV2 = "" ;
   this.OV26GXV2 = "" ;
   this.GXV3 = 0 ;
   this.ZV27GXV3 = 0 ;
   this.OV27GXV3 = 0 ;
   this.GXV4 = "" ;
   this.ZV28GXV4 = "" ;
   this.OV28GXV4 = "" ;
   this.AV11vSource = "" ;
   this.ZV11vSource = "" ;
   this.OV11vSource = "" ;
   this.AV12vOtherSource = "" ;
   this.ZV12vOtherSource = "" ;
   this.OV12vOtherSource = "" ;
   this.AV13vSpecimenDate = gx.date.nullDate() ;
   this.ZV13vSpecimenDate = gx.date.nullDate() ;
   this.OV13vSpecimenDate = gx.date.nullDate() ;
   this.AV14vReceivingTime = gx.date.nullDate() ;
   this.ZV14vReceivingTime = gx.date.nullDate() ;
   this.OV14vReceivingTime = gx.date.nullDate() ;
   this.AV15vReportTime = gx.date.nullDate() ;
   this.ZV15vReportTime = gx.date.nullDate() ;
   this.OV15vReportTime = gx.date.nullDate() ;
   this.GXV5 = "" ;
   this.ZV29GXV5 = "" ;
   this.OV29GXV5 = "" ;
   this.GXV6 = "" ;
   this.ZV30GXV6 = "" ;
   this.OV30GXV6 = "" ;
   this.GXV7 = "" ;
   this.ZV31GXV7 = "" ;
   this.OV31GXV7 = "" ;
   this.GXV8 = "" ;
   this.ZV32GXV8 = "" ;
   this.OV32GXV8 = "" ;
   this.GXV9 = "" ;
   this.ZV33GXV9 = "" ;
   this.OV33GXV9 = "" ;
   this.GXV10 = "" ;
   this.ZV34GXV10 = "" ;
   this.OV34GXV10 = "" ;
   this.GXV11 = "" ;
   this.ZV35GXV11 = "" ;
   this.OV35GXV11 = "" ;
   this.GXV12 = "" ;
   this.ZV36GXV12 = "" ;
   this.OV36GXV12 = "" ;
   this.GXV13 = 0 ;
   this.ZV37GXV13 = 0 ;
   this.OV37GXV13 = 0 ;
   this.GXV14 = "" ;
   this.ZV38GXV14 = "" ;
   this.OV38GXV14 = "" ;
   this.GXV15 = 0 ;
   this.ZV39GXV15 = 0 ;
   this.OV39GXV15 = 0 ;
   this.GXV16 = "" ;
   this.ZV40GXV16 = "" ;
   this.OV40GXV16 = "" ;
   this.GXV17 = 0 ;
   this.ZV41GXV17 = 0 ;
   this.OV41GXV17 = 0 ;
   this.GXV18 = "" ;
   this.ZV42GXV18 = "" ;
   this.OV42GXV18 = "" ;
   this.GXV1 = "" ;
   this.GXV2 = "" ;
   this.GXV3 = 0 ;
   this.GXV4 = "" ;
   this.AV11vSource = "" ;
   this.AV12vOtherSource = "" ;
   this.AV13vSpecimenDate = gx.date.nullDate() ;
   this.AV14vReceivingTime = gx.date.nullDate() ;
   this.AV15vReportTime = gx.date.nullDate() ;
   this.GXV5 = "" ;
   this.GXV6 = "" ;
   this.GXV7 = "" ;
   this.GXV8 = "" ;
   this.GXV9 = "" ;
   this.GXV10 = "" ;
   this.GXV11 = "" ;
   this.GXV12 = "" ;
   this.GXV13 = 0 ;
   this.GXV14 = "" ;
   this.GXV15 = 0 ;
   this.GXV16 = "" ;
   this.GXV17 = 0 ;
   this.GXV18 = "" ;
   this.AV21BR_EncounterID = 0 ;
   this.AV10BR_Lab = {BR_LabID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_Lab_SampleID:"",BR_Lab_TestID:0,BR_Lab_TestCode:"",BR_Lab_TestName:"",BR_Lab_TestEngName:"",BR_Lab_Age:0,BR_Lab_Diag:"",BR_Lab_SpecimenDate:gx.date.nullDate(),BR_Lab_ReceivingTime:gx.date.nullDate(),BR_Lab_ReportTime:gx.date.nullDate(),BR_Lab_SpecimenSource:"",BR_Lab_SpecimenSource_Code:"",BR_Lab_ResultQual:"",BR_Lab_ResultQual_Code:"",BR_Lab_ResultNum:"",BR_Lab_ResultUnit:"",BR_Lab_AbnInd:"",BR_Lab_AbnInd_Code:"",BR_Lab_NormRangeLow:"",BR_Lab_NormRangeHigh:"",BR_Lab_TestMethod:"",BR_Lab_InstrumentName:"",BR_Lab_InstrumentCode:"",BR_SampleId:0,Mode:"",Initialized:0,BR_LabID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_Lab_SampleID_Z:"",BR_Lab_TestID_Z:0,BR_Lab_TestCode_Z:"",BR_Lab_TestName_Z:"",BR_Lab_TestEngName_Z:"",BR_Lab_Age_Z:0,BR_Lab_Diag_Z:"",BR_Lab_SpecimenDate_Z:gx.date.nullDate(),BR_Lab_ReceivingTime_Z:gx.date.nullDate(),BR_Lab_ReportTime_Z:gx.date.nullDate(),BR_Lab_SpecimenSource_Z:"",BR_Lab_SpecimenSource_Code_Z:"",BR_Lab_ResultQual_Z:"",BR_Lab_ResultQual_Code_Z:"",BR_Lab_ResultNum_Z:"",BR_Lab_ResultUnit_Z:"",BR_Lab_AbnInd_Z:"",BR_Lab_AbnInd_Code_Z:"",BR_Lab_NormRangeLow_Z:"",BR_Lab_NormRangeHigh_Z:"",BR_Lab_TestMethod_Z:"",BR_Lab_InstrumentName_Z:"",BR_Lab_InstrumentCode_Z:"",BR_SampleId_Z:0} ;
   this.Events = {"e138q2_client": ["ENTER", true] ,"e168q1_client": ["CANCEL", true] ,"e158q1_client": ["VVSOURCE.CONTROLVALUECHANGED", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV21BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''},{ctrl:'vVSOURCE'},{av:'AV11vSource',fld:'vVSOURCE',pic:''}],[{ctrl:'BR_LAB_BR_ENCOUNTERID',prop:'Visible'},{ctrl:'BR_LAB_BR_INFORMATION_PATIENTNO',prop:'Visible'},{ctrl:'BR_LAB_BR_LABID',prop:'Visible'},{ctrl:'BR_LAB_BR_LAB_SAMPLEID',prop:'Visible'},{ctrl:'BR_LAB_BR_LAB_TESTID',prop:'Visible'},{ctrl:'BR_LAB_BR_LAB_NORMRANGEHIGH',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVOTHERSOURCE","Visible")',ctrl:'vVOTHERSOURCE',prop:'Visible'},{av:'AV13vSpecimenDate',fld:'vVSPECIMENDATE',pic:'9999/99/99 99:99:99'},{av:'AV14vReceivingTime',fld:'vVRECEIVINGTIME',pic:'9999/99/99 99:99:99'},{av:'AV15vReportTime',fld:'vVREPORTTIME',pic:'9999/99/99 99:99:99'},{av:'gx.fn.getCtrlProperty("VOTHERSOURCE_CELL","Class")',ctrl:'VOTHERSOURCE_CELL',prop:'Class'}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''},{av:'AV13vSpecimenDate',fld:'vVSPECIMENDATE',pic:'9999/99/99 99:99:99'},{ctrl:'vVSOURCE'},{av:'AV11vSource',fld:'vVSOURCE',pic:''},{av:'AV12vOtherSource',fld:'vVOTHERSOURCE',pic:''},{av:'AV14vReceivingTime',fld:'vVRECEIVINGTIME',pic:'9999/99/99 99:99:99'},{av:'AV15vReportTime',fld:'vVREPORTTIME',pic:'9999/99/99 99:99:99'},{av:'AV21BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''}]];
   this.EvtParms["LOAD"] = [[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''},{ctrl:'vVSOURCE'},{av:'AV11vSource',fld:'vVSOURCE',pic:''}],[{ctrl:'vVSOURCE'},{av:'AV11vSource',fld:'vVSOURCE',pic:''}]];
   this.EvtParms["VVSOURCE.CONTROLVALUECHANGED"] = [[{ctrl:'vVSOURCE'},{av:'AV11vSource',fld:'vVSOURCE',pic:''}],[{av:'gx.fn.getCtrlProperty("vVOTHERSOURCE","Visible")',ctrl:'vVOTHERSOURCE',prop:'Visible'}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV20tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV10BR_Lab", "vBR_LAB", 0, "BR_Lab", 0, 0);
   this.setVCMap("AV21BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.addBCProperty("Br_lab", ["BR_Lab_TestName"], this.GXValidFnc[25], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_TestEngName"], this.GXValidFnc[29], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_Age"], this.GXValidFnc[34], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_Diag"], this.GXValidFnc[38], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_ResultQual"], this.GXValidFnc[71], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_ResultUnit"], this.GXValidFnc[76], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_AbnInd"], this.GXValidFnc[80], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_NormRangeLow"], this.GXValidFnc[85], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_TestMethod"], this.GXValidFnc[90], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_InstrumentCode"], this.GXValidFnc[94], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_InstrumentName"], this.GXValidFnc[99], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_ResultNum"], this.GXValidFnc[103], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_EncounterID"], this.GXValidFnc[114], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Information_PatientNo"], this.GXValidFnc[115], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_LabID"], this.GXValidFnc[116], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_SampleID"], this.GXValidFnc[117], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_TestID"], this.GXValidFnc[118], "AV10BR_Lab");
   this.addBCProperty("Br_lab", ["BR_Lab_NormRangeHigh"], this.GXValidFnc[119], "AV10BR_Lab");
   this.Initialize( );
});
gx.createParentObj(br_labinsert);
