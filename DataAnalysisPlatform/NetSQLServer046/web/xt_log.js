/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:5.49
*/
gx.evt.autoSkip = false;
gx.define('xt_log', false, function () {
   this.ServerClass =  "xt_log" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7XT_LogID=gx.fn.getIntegerValue("vXT_LOGID",',') ;
      this.AV13Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Xt_logid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("XT_LOGID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Xt_logtime=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("XT_LOGTIME");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A220XT_LogTime)==0) || new gx.date.gxdate( this.A220XT_LogTime ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
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
   this.Valid_Xt_logtargetoperate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("XT_LOGTARGETOPERATE");
         this.AnyError  = 0;
         if ( ! ( ( this.A218XT_LogTargetOperate == "Create" ) || ( this.A218XT_LogTargetOperate == "Update" ) || ( this.A218XT_LogTargetOperate == "Delete" ) || ( this.A218XT_LogTargetOperate == "Create" ) || ( this.A218XT_LogTargetOperate == "Submit" ) || ( this.A218XT_LogTargetOperate == "Batchcheck" ) || ( this.A218XT_LogTargetOperate == "Batchapprove" ) || ( this.A218XT_LogTargetOperate == "Randomcheckpass" ) || ( this.A218XT_LogTargetOperate == "Randomcheckrefuse" ) || ( this.A218XT_LogTargetOperate == "Randomapprovepass" ) || ( this.A218XT_LogTargetOperate == "Randomapproverefuse" ) || ( this.A218XT_LogTargetOperate == "Check" ) || ( this.A218XT_LogTargetOperate == "Approve" ) || ( this.A218XT_LogTargetOperate == "Reupdate" ) || ( this.A218XT_LogTargetOperate == "Login" ) || ((''==this.A218XT_LogTargetOperate)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
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
   this.e120o2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130o25_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140o25_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72];
   this.GXLastCtrlId =72;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鏃ュ織淇℃伅", "str");
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
   GXValidFnc[9]={ id: 9, fld:"TABLECONTENT",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[15]={ id: 15, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id:22 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGSECUSERNAME",gxz:"Z174XT_LogSecUserName",gxold:"O174XT_LogSecUserName",gxvar:"A174XT_LogSecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A174XT_LogSecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z174XT_LogSecUserName=Value},v2c:function(){gx.fn.setControlValue("XT_LOGSECUSERNAME",gx.O.A174XT_LogSecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A174XT_LogSecUserName=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Xt_logtime,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTIME",gxz:"Z220XT_LogTime",gxold:"O220XT_LogTime",gxvar:"A220XT_LogTime",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[26],ip:[26],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A220XT_LogTime=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z220XT_LogTime=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("XT_LOGTIME",gx.O.A220XT_LogTime,0)},c2v:function(){if(this.val()!==undefined)gx.O.A220XT_LogTime=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("XT_LOGTIME")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPROVIDERNAME",gxz:"Z219XT_LogProviderName",gxold:"O219XT_LogProviderName",gxvar:"A219XT_LogProviderName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A219XT_LogProviderName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z219XT_LogProviderName=Value},v2c:function(){gx.fn.setControlValue("XT_LOGPROVIDERNAME",gx.O.A219XT_LogProviderName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A219XT_LogProviderName=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGPROVIDERNAME")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETMODULE",gxz:"Z217XT_LogTargetModule",gxold:"O217XT_LogTargetModule",gxvar:"A217XT_LogTargetModule",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A217XT_LogTargetModule=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z217XT_LogTargetModule=Value},v2c:function(){gx.fn.setControlValue("XT_LOGTARGETMODULE",gx.O.A217XT_LogTargetModule,0)},c2v:function(){if(this.val()!==undefined)gx.O.A217XT_LogTargetModule=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGTARGETMODULE")},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"UNNAMEDTABLEXT_LOGTARGET",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"TEXTBLOCKXT_LOGTARGET", format:0,grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:5000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGET",gxz:"Z216XT_LogTarget",gxold:"O216XT_LogTarget",gxvar:"A216XT_LogTarget",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A216XT_LogTarget=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z216XT_LogTarget=Value},v2c:function(){gx.fn.setControlValue("XT_LOGTARGET",gx.O.A216XT_LogTarget,0)},c2v:function(){if(this.val()!==undefined)gx.O.A216XT_LogTarget=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGTARGET")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"UNNAMEDTABLEXT_LOGDESCRIPTION",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"TEXTBLOCKXT_LOGDESCRIPTION", format:0,grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:5000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGDESCRIPTION",gxz:"Z221XT_LogDescription",gxold:"O221XT_LogDescription",gxvar:"A221XT_LogDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A221XT_LogDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z221XT_LogDescription=Value},v2c:function(){gx.fn.setControlValue("XT_LOGDESCRIPTION",gx.O.A221XT_LogDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A221XT_LogDescription=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Xt_logid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGID",gxz:"Z173XT_LogID",gxold:"O173XT_LogID",gxvar:"A173XT_LogID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A173XT_LogID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z173XT_LogID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("XT_LOGID",gx.O.A173XT_LogID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A173XT_LogID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("XT_LOGID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 64 , function() {
   });
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGUSERID",gxz:"Z214XT_LogUserID",gxold:"O214XT_LogUserID",gxvar:"A214XT_LogUserID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A214XT_LogUserID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z214XT_LogUserID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("XT_LOGUSERID",gx.O.A214XT_LogUserID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A214XT_LogUserID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("XT_LOGUSERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 65 , function() {
   });
   GXValidFnc[66]={ id:66 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPAGE",gxz:"Z176XT_LogPage",gxold:"O176XT_LogPage",gxvar:"A176XT_LogPage",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A176XT_LogPage=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z176XT_LogPage=Value},v2c:function(){gx.fn.setControlValue("XT_LOGPAGE",gx.O.A176XT_LogPage,0)},c2v:function(){if(this.val()!==undefined)gx.O.A176XT_LogPage=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGPAGE")},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGBUTTONNAME",gxz:"Z177XT_LogButtonName",gxold:"O177XT_LogButtonName",gxvar:"A177XT_LogButtonName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A177XT_LogButtonName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z177XT_LogButtonName=Value},v2c:function(){gx.fn.setControlValue("XT_LOGBUTTONNAME",gx.O.A177XT_LogButtonName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A177XT_LogButtonName=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGBUTTONNAME")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTYPE",gxz:"Z213XT_LogType",gxold:"O213XT_LogType",gxvar:"A213XT_LogType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A213XT_LogType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z213XT_LogType=Value},v2c:function(){gx.fn.setControlValue("XT_LOGTYPE",gx.O.A213XT_LogType,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A213XT_LogType=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGTYPE")},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
   });
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGPROVIDERID",gxz:"Z215XT_LogProviderID",gxold:"O215XT_LogProviderID",gxvar:"A215XT_LogProviderID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A215XT_LogProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z215XT_LogProviderID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("XT_LOGPROVIDERID",gx.O.A215XT_LogProviderID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A215XT_LogProviderID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("XT_LOGPROVIDERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 69 , function() {
   });
   GXValidFnc[70]={ id:70 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGSONTARGET",gxz:"Z223XT_LogSonTarget",gxold:"O223XT_LogSonTarget",gxvar:"A223XT_LogSonTarget",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A223XT_LogSonTarget=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z223XT_LogSonTarget=Value},v2c:function(){gx.fn.setControlValue("XT_LOGSONTARGET",gx.O.A223XT_LogSonTarget,0)},c2v:function(){if(this.val()!==undefined)gx.O.A223XT_LogSonTarget=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGSONTARGET")},nac:gx.falseFn};
   GXValidFnc[71]={ id:71 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETSONMODULE",gxz:"Z222XT_LogTargetSonModule",gxold:"O222XT_LogTargetSonModule",gxvar:"A222XT_LogTargetSonModule",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A222XT_LogTargetSonModule=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z222XT_LogTargetSonModule=Value},v2c:function(){gx.fn.setControlValue("XT_LOGTARGETSONMODULE",gx.O.A222XT_LogTargetSonModule,0)},c2v:function(){if(this.val()!==undefined)gx.O.A222XT_LogTargetSonModule=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGTARGETSONMODULE")},nac:gx.falseFn};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Xt_logtargetoperate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_LOGTARGETOPERATE",gxz:"Z218XT_LogTargetOperate",gxold:"O218XT_LogTargetOperate",gxvar:"A218XT_LogTargetOperate",ucs:[],op:[72],ip:[72],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A218XT_LogTargetOperate=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z218XT_LogTargetOperate=Value},v2c:function(){gx.fn.setComboBoxValue("XT_LOGTARGETOPERATE",gx.O.A218XT_LogTargetOperate);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A218XT_LogTargetOperate=this.val()},val:function(){return gx.fn.getControlValue("XT_LOGTARGETOPERATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 72 , function() {
   });
   this.A174XT_LogSecUserName = "" ;
   this.Z174XT_LogSecUserName = "" ;
   this.O174XT_LogSecUserName = "" ;
   this.A220XT_LogTime = gx.date.nullDate() ;
   this.Z220XT_LogTime = gx.date.nullDate() ;
   this.O220XT_LogTime = gx.date.nullDate() ;
   this.A219XT_LogProviderName = "" ;
   this.Z219XT_LogProviderName = "" ;
   this.O219XT_LogProviderName = "" ;
   this.A217XT_LogTargetModule = "" ;
   this.Z217XT_LogTargetModule = "" ;
   this.O217XT_LogTargetModule = "" ;
   this.A216XT_LogTarget = "" ;
   this.Z216XT_LogTarget = "" ;
   this.O216XT_LogTarget = "" ;
   this.A221XT_LogDescription = "" ;
   this.Z221XT_LogDescription = "" ;
   this.O221XT_LogDescription = "" ;
   this.A173XT_LogID = 0 ;
   this.Z173XT_LogID = 0 ;
   this.O173XT_LogID = 0 ;
   this.A214XT_LogUserID = 0 ;
   this.Z214XT_LogUserID = 0 ;
   this.O214XT_LogUserID = 0 ;
   this.A176XT_LogPage = "" ;
   this.Z176XT_LogPage = "" ;
   this.O176XT_LogPage = "" ;
   this.A177XT_LogButtonName = "" ;
   this.Z177XT_LogButtonName = "" ;
   this.O177XT_LogButtonName = "" ;
   this.A213XT_LogType = "" ;
   this.Z213XT_LogType = "" ;
   this.O213XT_LogType = "" ;
   this.A215XT_LogProviderID = 0 ;
   this.Z215XT_LogProviderID = 0 ;
   this.O215XT_LogProviderID = 0 ;
   this.A223XT_LogSonTarget = "" ;
   this.Z223XT_LogSonTarget = "" ;
   this.O223XT_LogSonTarget = "" ;
   this.A222XT_LogTargetSonModule = "" ;
   this.Z222XT_LogTargetSonModule = "" ;
   this.O222XT_LogTargetSonModule = "" ;
   this.A218XT_LogTargetOperate = "" ;
   this.Z218XT_LogTargetOperate = "" ;
   this.O218XT_LogTargetOperate = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV13Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV7XT_LogID = 0 ;
   this.AV12WebSession = {} ;
   this.A173XT_LogID = 0 ;
   this.A214XT_LogUserID = 0 ;
   this.A174XT_LogSecUserName = "" ;
   this.A220XT_LogTime = gx.date.nullDate() ;
   this.A176XT_LogPage = "" ;
   this.A177XT_LogButtonName = "" ;
   this.A213XT_LogType = "" ;
   this.A215XT_LogProviderID = 0 ;
   this.A219XT_LogProviderName = "" ;
   this.A216XT_LogTarget = "" ;
   this.A223XT_LogSonTarget = "" ;
   this.A217XT_LogTargetModule = "" ;
   this.A222XT_LogTargetSonModule = "" ;
   this.A218XT_LogTargetOperate = "" ;
   this.A221XT_LogDescription = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120o2_client": ["AFTER TRN", true] ,"e130o25_client": ["ENTER", true] ,"e140o25_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_LogID',fld:'vXT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_LogID',fld:'vXT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV13Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'gx.fn.getCtrlProperty("XT_LOGID","Visible")',ctrl:'XT_LOGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGUSERID","Visible")',ctrl:'XT_LOGUSERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGPAGE","Visible")',ctrl:'XT_LOGPAGE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGBUTTONNAME","Visible")',ctrl:'XT_LOGBUTTONNAME',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGTYPE","Visible")',ctrl:'XT_LOGTYPE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGPROVIDERID","Visible")',ctrl:'XT_LOGPROVIDERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGSONTARGET","Visible")',ctrl:'XT_LOGSONTARGET',prop:'Visible'},{av:'gx.fn.getCtrlProperty("XT_LOGTARGETSONMODULE","Visible")',ctrl:'XT_LOGTARGETSONMODULE',prop:'Visible'},{ctrl:'XT_LOGTARGETOPERATE'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7XT_LogID", "vXT_LOGID", 0, "int", 18, 0);
   this.setVCMap("AV13Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(xt_log);
