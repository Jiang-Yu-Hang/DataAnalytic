/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:56:44.50
*/
gx.evt.autoSkip = false;
gx.define('br_vital', false, function () {
   this.ServerClass =  "br_vital" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_VitalID=gx.fn.getIntegerValue("vBR_VITALID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV17Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV16Pgmdesc=gx.fn.getControlValue("vPGMDESC") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_vitalid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_VITALID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_vital_measuredate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_VITAL_MEASUREDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A152BR_Vital_MeasureDate)==0) || new gx.date.gxdate( this.A152BR_Vital_MeasureDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate('').compare(this.A152BR_Vital_MeasureDate)==0) )
         {
            try {
               gxballoon.setError("娴嬮噺鏃ユ湡鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.e120j2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130j20_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140j20_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102];
   this.GXLastCtrlId =102;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐢熷懡浣撳緛", "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_VITAL_MEASUREDATE",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_VITAL_MEASUREDATE", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_vital_measuredate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_MEASUREDATE",gxz:"Z152BR_Vital_MeasureDate",gxold:"O152BR_Vital_MeasureDate",gxvar:"A152BR_Vital_MeasureDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_VITAL_MEASUREDATE",gx.O.A152BR_Vital_MeasureDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_VITAL_MEASUREDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 29 , function() {
   });
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_VITAL_TEMPERATURE",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_VITAL_TEMPERATURE", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_TEMPERATURE",gxz:"Z153BR_Vital_Temperature",gxold:"O153BR_Vital_Temperature",gxvar:"A153BR_Vital_Temperature",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_TEMPERATURE",gx.O.A153BR_Vital_Temperature,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A153BR_Vital_Temperature=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_TEMPERATURE",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 37 , function() {
   });
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_VITAL_PULSE",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_VITAL_PULSE", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_PULSE",gxz:"Z154BR_Vital_Pulse",gxold:"O154BR_Vital_Pulse",gxvar:"A154BR_Vital_Pulse",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A154BR_Vital_Pulse=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z154BR_Vital_Pulse=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_PULSE",gx.O.A154BR_Vital_Pulse,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A154BR_Vital_Pulse=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_PULSE",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 46 , function() {
   });
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_VITAL_RESPIRATION",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_VITAL_RESPIRATION", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_RESPIRATION",gxz:"Z155BR_Vital_Respiration",gxold:"O155BR_Vital_Respiration",gxvar:"A155BR_Vital_Respiration",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A155BR_Vital_Respiration=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z155BR_Vital_Respiration=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_RESPIRATION",gx.O.A155BR_Vital_Respiration,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A155BR_Vital_Respiration=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_RESPIRATION",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 54 , function() {
   });
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_VITAL_SYSTOLIC",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_VITAL_SYSTOLIC", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_SYSTOLIC",gxz:"Z156BR_Vital_Systolic",gxold:"O156BR_Vital_Systolic",gxvar:"A156BR_Vital_Systolic",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A156BR_Vital_Systolic=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z156BR_Vital_Systolic=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_SYSTOLIC",gx.O.A156BR_Vital_Systolic,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A156BR_Vital_Systolic=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_SYSTOLIC",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 63 , function() {
   });
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"UNNAMEDTABLEBR_VITAL_DIASTOLIC",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"TEXTBLOCKBR_VITAL_DIASTOLIC", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_DIASTOLIC",gxz:"Z157BR_Vital_Diastolic",gxold:"O157BR_Vital_Diastolic",gxvar:"A157BR_Vital_Diastolic",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A157BR_Vital_Diastolic=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z157BR_Vital_Diastolic=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_DIASTOLIC",gx.O.A157BR_Vital_Diastolic,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A157BR_Vital_Diastolic=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_DIASTOLIC",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 71 , function() {
   });
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEBR_VITAL_HEIGHT",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKBR_VITAL_HEIGHT", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_HEIGHT",gxz:"Z158BR_Vital_Height",gxold:"O158BR_Vital_Height",gxvar:"A158BR_Vital_Height",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A158BR_Vital_Height=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z158BR_Vital_Height=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_HEIGHT",gx.O.A158BR_Vital_Height,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A158BR_Vital_Height=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_HEIGHT",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 80 , function() {
   });
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"UNNAMEDTABLEBR_VITAL_WEIGHT",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"TEXTBLOCKBR_VITAL_WEIGHT", format:0,grid:0};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id:88 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_WEIGHT",gxz:"Z159BR_Vital_Weight",gxold:"O159BR_Vital_Weight",gxvar:"A159BR_Vital_Weight",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_VITAL_WEIGHT",gx.O.A159BR_Vital_Weight,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A159BR_Vital_Weight=this.val()},val:function(){return gx.fn.getDecimalValue("BR_VITAL_WEIGHT",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 88 , function() {
   });
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[99]={ id:99 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_vitalid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITALID",gxz:"Z150BR_VitalID",gxold:"O150BR_VitalID",gxvar:"A150BR_VitalID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A150BR_VitalID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z150BR_VitalID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_VITALID",gx.O.A150BR_VitalID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A150BR_VitalID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_VITALID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 99 , function() {
   });
   GXValidFnc[100]={ id:100 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[101],ip:[101,100],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 100 , function() {
   });
   GXValidFnc[101]={ id:101 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[102]={ id:102 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_VITALID",gxz:"Z151BR_Vital_VitalID",gxold:"O151BR_Vital_VitalID",gxvar:"A151BR_Vital_VitalID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A151BR_Vital_VitalID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z151BR_Vital_VitalID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_VITAL_VITALID",gx.O.A151BR_Vital_VitalID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A151BR_Vital_VitalID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_VITAL_VITALID",',')},nac:gx.falseFn};
   this.A152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.Z152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.O152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.A153BR_Vital_Temperature = 0 ;
   this.Z153BR_Vital_Temperature = 0 ;
   this.O153BR_Vital_Temperature = 0 ;
   this.A154BR_Vital_Pulse = 0 ;
   this.Z154BR_Vital_Pulse = 0 ;
   this.O154BR_Vital_Pulse = 0 ;
   this.A155BR_Vital_Respiration = 0 ;
   this.Z155BR_Vital_Respiration = 0 ;
   this.O155BR_Vital_Respiration = 0 ;
   this.A156BR_Vital_Systolic = 0 ;
   this.Z156BR_Vital_Systolic = 0 ;
   this.O156BR_Vital_Systolic = 0 ;
   this.A157BR_Vital_Diastolic = 0 ;
   this.Z157BR_Vital_Diastolic = 0 ;
   this.O157BR_Vital_Diastolic = 0 ;
   this.A158BR_Vital_Height = 0 ;
   this.Z158BR_Vital_Height = 0 ;
   this.O158BR_Vital_Height = 0 ;
   this.A159BR_Vital_Weight = 0 ;
   this.Z159BR_Vital_Weight = 0 ;
   this.O159BR_Vital_Weight = 0 ;
   this.A150BR_VitalID = 0 ;
   this.Z150BR_VitalID = 0 ;
   this.O150BR_VitalID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A151BR_Vital_VitalID = 0 ;
   this.Z151BR_Vital_VitalID = 0 ;
   this.O151BR_Vital_VitalID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV16Pgmdesc = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV17Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV18GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_VitalID = 0 ;
   this.AV9WebSession = {} ;
   this.A150BR_VitalID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A151BR_Vital_VitalID = 0 ;
   this.A152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.A153BR_Vital_Temperature = 0 ;
   this.A154BR_Vital_Pulse = 0 ;
   this.A155BR_Vital_Respiration = 0 ;
   this.A156BR_Vital_Systolic = 0 ;
   this.A157BR_Vital_Diastolic = 0 ;
   this.A158BR_Vital_Height = 0 ;
   this.A159BR_Vital_Weight = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e120j2_client": ["AFTER TRN", true] ,"e130j20_client": ["ENTER", true] ,"e140j20_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_VitalID',fld:'vBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_VitalID',fld:'vBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV16Pgmdesc',fld:'vPGMDESC',pic:''},{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV18GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Visible")',ctrl:'BR_VITALID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_VITAL_VITALID","Visible")',ctrl:'BR_VITAL_VITALID',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_VitalID", "vBR_VITALID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV17Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV16Pgmdesc", "vPGMDESC", 0, "char", 30, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_vital);
