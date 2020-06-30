/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:36:2.78
*/
gx.evt.autoSkip = false;
gx.define('br_death', false, function () {
   this.ServerClass =  "br_death" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.A501BR_Death_CauseCode_Code=gx.fn.getControlValue("BR_DEATH_CAUSECODE_CODE") ;
      this.A469BR_Death_Sourse_Code=gx.fn.getControlValue("BR_DEATH_SOURSE_CODE") ;
      this.AV12tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.A36BR_Information_PatientNo=gx.fn.getControlValue("BR_INFORMATION_PATIENTNO") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Br_deathid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_deathid",["gx.O.AV12tCurrentCode", "gx.num.urlDecimal(gx.O.A48BR_DeathID,\',\',\'.\')", "gx.O.A501BR_Death_CauseCode_Code", "gx.O.A469BR_Death_Sourse_Code", 'gx.date.urlDate(gx.O.A49BR_Death_Date,"ANSI")', "gx.O.A50BR_Death_Cause", "gx.O.A51BR_Death_CauseCode", "gx.O.A52BR_Death_Sourse", "gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')"],["A501BR_Death_CauseCode_Code", "A469BR_Death_Sourse_Code", "A19BR_EncounterID", "A49BR_Death_Date", "A50BR_Death_Cause", "A51BR_Death_CauseCode", "A52BR_Death_Sourse", "A85BR_Information_ID", "A36BR_Information_PatientNo", "Gx_mode", "Z48BR_DeathID", "Z501BR_Death_CauseCode_Code", "Z469BR_Death_Sourse_Code", "Z19BR_EncounterID", "Z49BR_Death_Date", "Z50BR_Death_Cause", "Z51BR_Death_CauseCode", "Z52BR_Death_Sourse", "Z85BR_Information_ID", "Z36BR_Information_PatientNo", ["BTNTRN_DELETE","Enabled"], ["BTNTRN_ENTER","Enabled"]]);
      return true;
   }
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.Valid_Br_death_date=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEATH_DATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A49BR_Death_Date)==0) || new gx.date.gxdate( this.A49BR_Death_Date ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_death_causecode=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEATH_CAUSECODE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_death_sourse=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_DEATH_SOURSE");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e120a2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130a11_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140a11_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59];
   this.GXLastCtrlId =59;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鍩虹淇℃伅", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_death_date,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEATH_DATE",gxz:"Z49BR_Death_Date",gxold:"O49BR_Death_Date",gxvar:"A49BR_Death_Date",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[32],ip:[32],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A49BR_Death_Date=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z49BR_Death_Date=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_DEATH_DATE",gx.O.A49BR_Death_Date,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A49BR_Death_Date=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_DEATH_DATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 32 , function() {
   });
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEATH_CAUSE",gxz:"Z50BR_Death_Cause",gxold:"O50BR_Death_Cause",gxvar:"A50BR_Death_Cause",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A50BR_Death_Cause=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z50BR_Death_Cause=Value},v2c:function(){gx.fn.setControlValue("BR_DEATH_CAUSE",gx.O.A50BR_Death_Cause,0)},c2v:function(){if(this.val()!==undefined)gx.O.A50BR_Death_Cause=this.val()},val:function(){return gx.fn.getControlValue("BR_DEATH_CAUSE")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_death_causecode,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEATH_CAUSECODE",gxz:"Z51BR_Death_CauseCode",gxold:"O51BR_Death_CauseCode",gxvar:"A51BR_Death_CauseCode",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A51BR_Death_CauseCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z51BR_Death_CauseCode=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEATH_CAUSECODE",gx.O.A51BR_Death_CauseCode)},c2v:function(){if(this.val()!==undefined)gx.O.A51BR_Death_CauseCode=this.val()},val:function(){return gx.fn.getControlValue("BR_DEATH_CAUSECODE")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_death_sourse,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEATH_SOURSE",gxz:"Z52BR_Death_Sourse",gxold:"O52BR_Death_Sourse",gxvar:"A52BR_Death_Sourse",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A52BR_Death_Sourse=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z52BR_Death_Sourse=Value},v2c:function(){gx.fn.setComboBoxValue("BR_DEATH_SOURSE",gx.O.A52BR_Death_Sourse)},c2v:function(){if(this.val()!==undefined)gx.O.A52BR_Death_Sourse=this.val()},val:function(){return gx.fn.getControlValue("BR_DEATH_SOURSE")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_deathid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_DEATHID",gxz:"Z48BR_DeathID",gxold:"O48BR_DeathID",gxvar:"A48BR_DeathID",ucs:[],op:[25,46,41,37,32],ip:[25,46,41,37,32,59],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A48BR_DeathID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z48BR_DeathID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_DEATHID",gx.O.A48BR_DeathID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A48BR_DeathID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_DEATHID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 59 , function() {
   });
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A49BR_Death_Date = gx.date.nullDate() ;
   this.Z49BR_Death_Date = gx.date.nullDate() ;
   this.O49BR_Death_Date = gx.date.nullDate() ;
   this.A50BR_Death_Cause = "" ;
   this.Z50BR_Death_Cause = "" ;
   this.O50BR_Death_Cause = "" ;
   this.A51BR_Death_CauseCode = "" ;
   this.Z51BR_Death_CauseCode = "" ;
   this.O51BR_Death_CauseCode = "" ;
   this.A52BR_Death_Sourse = "" ;
   this.Z52BR_Death_Sourse = "" ;
   this.O52BR_Death_Sourse = "" ;
   this.A48BR_DeathID = 0 ;
   this.Z48BR_DeathID = 0 ;
   this.O48BR_DeathID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV12tCurrentCode = "" ;
   this.AV9WebSession = {} ;
   this.A48BR_DeathID = 0 ;
   this.A501BR_Death_CauseCode_Code = "" ;
   this.A469BR_Death_Sourse_Code = "" ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A49BR_Death_Date = gx.date.nullDate() ;
   this.A50BR_Death_Cause = "" ;
   this.A51BR_Death_CauseCode = "" ;
   this.A52BR_Death_Sourse = "" ;
   this.Events = {"e120a2_client": ["AFTER TRN", true] ,"e130a11_client": ["ENTER", true] ,"e140a11_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''}],[]];
   this.EvtParms["START"] = [[],[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''}]];
   this.EvtParms["AFTER TRN"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("A501BR_Death_CauseCode_Code", "BR_DEATH_CAUSECODE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A469BR_Death_Sourse_Code", "BR_DEATH_SOURSE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV12tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("A36BR_Information_PatientNo", "BR_INFORMATION_PATIENTNO", 0, "svchar", 2000, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.Initialize( );
});
gx.createParentObj(br_death);
