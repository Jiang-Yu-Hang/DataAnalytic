/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:42.4
*/
gx.evt.autoSkip = false;
gx.define('br_behavior', false, function () {
   this.ServerClass =  "br_behavior" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.A460BR_Behavior_Smoking_Code=gx.fn.getControlValue("BR_BEHAVIOR_SMOKING_CODE") ;
      this.A462BR_Behavior_Achohol_Code=gx.fn.getControlValue("BR_BEHAVIOR_ACHOHOL_CODE") ;
      this.A464BR_Behavior_FamilyCaHistory_Code=gx.fn.getControlValue("BR_BEHAVIOR_FAMILYCAHISTORY_CODE") ;
      this.A465BR_Behavior_Menopause_Code=gx.fn.getControlValue("BR_BEHAVIOR_MENOPAUSE_CODE") ;
      this.AV12tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A461BR_Behavior_RawSmokingAmount_Code=gx.fn.getControlValue("BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE") ;
      this.A463BR_Behavior_RawAchoholAmount_Code=gx.fn.getControlValue("BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.A36BR_Information_PatientNo=gx.fn.getControlValue("BR_INFORMATION_PATIENTNO") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Br_behaviorid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_behaviorid",["gx.O.AV12tCurrentCode", "gx.num.urlDecimal(gx.O.A20BR_BehaviorID,\',\',\'.\')", "gx.O.A460BR_Behavior_Smoking_Code", "gx.O.A462BR_Behavior_Achohol_Code", "gx.O.A464BR_Behavior_FamilyCaHistory_Code", "gx.O.A465BR_Behavior_Menopause_Code", "gx.O.A21BR_Behavior_Smoking", "gx.O.A22BR_Behavior_SmokingTime", "gx.O.A23BR_Behavior_SmokingAmount", "gx.O.A24BR_Behavior_RawSmokingAmount", "gx.O.A461BR_Behavior_RawSmokingAmount_Code", "gx.O.A25BR_Behavior_Achohol", "gx.O.A26BR_Behavior_AchoholTime", "gx.O.A27BR_Behavior_AchoholAmount", "gx.O.A28BR_Behavior_RawAchoholAmount", "gx.O.A463BR_Behavior_RawAchoholAmount_Code", "gx.O.A29BR_Behavior_FamilyCaHistory", "gx.O.A30BR_Behavior_FamilyCancer", "gx.O.A31BR_Behavior_Menopause", "gx.O.A32BR_Behavior_MenopauseAge", "gx.O.A33BR_Behavior_RawMenopauseAge", "gx.O.A34BR_Behavior_ChildNum", "gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')"],["A460BR_Behavior_Smoking_Code", "A462BR_Behavior_Achohol_Code", "A464BR_Behavior_FamilyCaHistory_Code", "A465BR_Behavior_Menopause_Code", "A19BR_EncounterID", "A21BR_Behavior_Smoking", "A22BR_Behavior_SmokingTime", "A23BR_Behavior_SmokingAmount", "A24BR_Behavior_RawSmokingAmount", "A461BR_Behavior_RawSmokingAmount_Code", "A25BR_Behavior_Achohol", "A26BR_Behavior_AchoholTime", "A27BR_Behavior_AchoholAmount", "A28BR_Behavior_RawAchoholAmount", "A463BR_Behavior_RawAchoholAmount_Code", "A29BR_Behavior_FamilyCaHistory", "A30BR_Behavior_FamilyCancer", "A31BR_Behavior_Menopause", "A32BR_Behavior_MenopauseAge", "A33BR_Behavior_RawMenopauseAge", "A34BR_Behavior_ChildNum", "A85BR_Information_ID", "A36BR_Information_PatientNo", "Gx_mode", "Z20BR_BehaviorID", "Z460BR_Behavior_Smoking_Code", "Z462BR_Behavior_Achohol_Code", "Z464BR_Behavior_FamilyCaHistory_Code", "Z465BR_Behavior_Menopause_Code", "Z19BR_EncounterID", "Z21BR_Behavior_Smoking", "Z22BR_Behavior_SmokingTime", "Z23BR_Behavior_SmokingAmount", "Z24BR_Behavior_RawSmokingAmount", "Z461BR_Behavior_RawSmokingAmount_Code", "Z25BR_Behavior_Achohol", "Z26BR_Behavior_AchoholTime", "Z27BR_Behavior_AchoholAmount", "Z28BR_Behavior_RawAchoholAmount", "Z463BR_Behavior_RawAchoholAmount_Code", "Z29BR_Behavior_FamilyCaHistory", "Z30BR_Behavior_FamilyCancer", "Z31BR_Behavior_Menopause", "Z32BR_Behavior_MenopauseAge", "Z33BR_Behavior_RawMenopauseAge", "Z34BR_Behavior_ChildNum", "Z85BR_Information_ID", "Z36BR_Information_PatientNo", ["BTNTRN_DELETE","Enabled"], ["BTNTRN_ENTER","Enabled"]]);
      return true;
   }
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.Valid_Br_behavior_smoking=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_BEHAVIOR_SMOKING");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_behavior_achohol=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_BEHAVIOR_ACHOHOL");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_behavior_familycahistory=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_BEHAVIOR_FAMILYCAHISTORY");
         this.AnyError  = 0;
         if ( ! ( ( this.A29BR_Behavior_FamilyCaHistory == "鍚? ) || ( this.A29BR_Behavior_FamilyCaHistory == "鏄? ) || ( this.A29BR_Behavior_FamilyCaHistory == "涓嶈" ) || ((''==this.A29BR_Behavior_FamilyCaHistory)) ) )
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
   this.Valid_Br_behavior_menopause=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_BEHAVIOR_MENOPAUSE");
         this.AnyError  = 0;
         if ( ! ( ( this.A31BR_Behavior_Menopause == "鍚? ) || ( this.A31BR_Behavior_Menopause == "鏄? ) || ( this.A31BR_Behavior_Menopause == "涓嶈" ) || ((''==this.A31BR_Behavior_Menopause)) ) )
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
   this.e12082_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e13089_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14089_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104];
   this.GXLastCtrlId =104;
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
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_behavior_smoking,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_SMOKING",gxz:"Z21BR_Behavior_Smoking",gxold:"O21BR_Behavior_Smoking",gxvar:"A21BR_Behavior_Smoking",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A21BR_Behavior_Smoking=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z21BR_Behavior_Smoking=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_SMOKING",gx.O.A21BR_Behavior_Smoking)},c2v:function(){if(this.val()!==undefined)gx.O.A21BR_Behavior_Smoking=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_SMOKING")},nac:gx.falseFn};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_SMOKINGTIME",gxz:"Z22BR_Behavior_SmokingTime",gxold:"O22BR_Behavior_SmokingTime",gxvar:"A22BR_Behavior_SmokingTime",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A22BR_Behavior_SmokingTime=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z22BR_Behavior_SmokingTime=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_SMOKINGTIME",gx.O.A22BR_Behavior_SmokingTime,0)},c2v:function(){if(this.val()!==undefined)gx.O.A22BR_Behavior_SmokingTime=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_SMOKINGTIME")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_SMOKINGAMOUNT",gxz:"Z23BR_Behavior_SmokingAmount",gxold:"O23BR_Behavior_SmokingAmount",gxvar:"A23BR_Behavior_SmokingAmount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A23BR_Behavior_SmokingAmount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z23BR_Behavior_SmokingAmount=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_SMOKINGAMOUNT",gx.O.A23BR_Behavior_SmokingAmount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A23BR_Behavior_SmokingAmount=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_SMOKINGAMOUNT")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_RAWSMOKINGAMOUNT",gxz:"Z24BR_Behavior_RawSmokingAmount",gxold:"O24BR_Behavior_RawSmokingAmount",gxvar:"A24BR_Behavior_RawSmokingAmount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A24BR_Behavior_RawSmokingAmount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z24BR_Behavior_RawSmokingAmount=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_RAWSMOKINGAMOUNT",gx.O.A24BR_Behavior_RawSmokingAmount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A24BR_Behavior_RawSmokingAmount=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_RAWSMOKINGAMOUNT")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_behavior_achohol,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_ACHOHOL",gxz:"Z25BR_Behavior_Achohol",gxold:"O25BR_Behavior_Achohol",gxvar:"A25BR_Behavior_Achohol",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A25BR_Behavior_Achohol=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z25BR_Behavior_Achohol=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_ACHOHOL",gx.O.A25BR_Behavior_Achohol)},c2v:function(){if(this.val()!==undefined)gx.O.A25BR_Behavior_Achohol=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_ACHOHOL")},nac:gx.falseFn};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_ACHOHOLTIME",gxz:"Z26BR_Behavior_AchoholTime",gxold:"O26BR_Behavior_AchoholTime",gxvar:"A26BR_Behavior_AchoholTime",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A26BR_Behavior_AchoholTime=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z26BR_Behavior_AchoholTime=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_ACHOHOLTIME",gx.O.A26BR_Behavior_AchoholTime,0)},c2v:function(){if(this.val()!==undefined)gx.O.A26BR_Behavior_AchoholTime=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_ACHOHOLTIME")},nac:gx.falseFn};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_ACHOHOLAMOUNT",gxz:"Z27BR_Behavior_AchoholAmount",gxold:"O27BR_Behavior_AchoholAmount",gxvar:"A27BR_Behavior_AchoholAmount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A27BR_Behavior_AchoholAmount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z27BR_Behavior_AchoholAmount=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_ACHOHOLAMOUNT",gx.O.A27BR_Behavior_AchoholAmount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A27BR_Behavior_AchoholAmount=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_ACHOHOLAMOUNT")},nac:gx.falseFn};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id:64 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_RAWACHOHOLAMOUNT",gxz:"Z28BR_Behavior_RawAchoholAmount",gxold:"O28BR_Behavior_RawAchoholAmount",gxvar:"A28BR_Behavior_RawAchoholAmount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A28BR_Behavior_RawAchoholAmount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z28BR_Behavior_RawAchoholAmount=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_RAWACHOHOLAMOUNT",gx.O.A28BR_Behavior_RawAchoholAmount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A28BR_Behavior_RawAchoholAmount=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_RAWACHOHOLAMOUNT")},nac:gx.falseFn};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_behavior_familycahistory,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_FAMILYCAHISTORY",gxz:"Z29BR_Behavior_FamilyCaHistory",gxold:"O29BR_Behavior_FamilyCaHistory",gxvar:"A29BR_Behavior_FamilyCaHistory",ucs:[],op:[68],ip:[68],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A29BR_Behavior_FamilyCaHistory=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z29BR_Behavior_FamilyCaHistory=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_FAMILYCAHISTORY",gx.O.A29BR_Behavior_FamilyCaHistory);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A29BR_Behavior_FamilyCaHistory=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_FAMILYCAHISTORY")},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
   });
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_FAMILYCANCER",gxz:"Z30BR_Behavior_FamilyCancer",gxold:"O30BR_Behavior_FamilyCancer",gxvar:"A30BR_Behavior_FamilyCancer",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A30BR_Behavior_FamilyCancer=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z30BR_Behavior_FamilyCancer=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_FAMILYCANCER",gx.O.A30BR_Behavior_FamilyCancer,0)},c2v:function(){if(this.val()!==undefined)gx.O.A30BR_Behavior_FamilyCancer=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_FAMILYCANCER")},nac:gx.falseFn};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_behavior_menopause,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_MENOPAUSE",gxz:"Z31BR_Behavior_Menopause",gxold:"O31BR_Behavior_Menopause",gxvar:"A31BR_Behavior_Menopause",ucs:[],op:[77],ip:[77],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A31BR_Behavior_Menopause=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z31BR_Behavior_Menopause=Value},v2c:function(){gx.fn.setComboBoxValue("BR_BEHAVIOR_MENOPAUSE",gx.O.A31BR_Behavior_Menopause);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A31BR_Behavior_Menopause=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_MENOPAUSE")},nac:gx.falseFn};
   this.declareDomainHdlr( 77 , function() {
   });
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id:82 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_MENOPAUSEAGE",gxz:"Z32BR_Behavior_MenopauseAge",gxold:"O32BR_Behavior_MenopauseAge",gxvar:"A32BR_Behavior_MenopauseAge",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A32BR_Behavior_MenopauseAge=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z32BR_Behavior_MenopauseAge=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_MENOPAUSEAGE",gx.O.A32BR_Behavior_MenopauseAge,0)},c2v:function(){if(this.val()!==undefined)gx.O.A32BR_Behavior_MenopauseAge=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIOR_MENOPAUSEAGE",',')},nac:gx.falseFn};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id:86 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_RAWMENOPAUSEAGE",gxz:"Z33BR_Behavior_RawMenopauseAge",gxold:"O33BR_Behavior_RawMenopauseAge",gxvar:"A33BR_Behavior_RawMenopauseAge",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A33BR_Behavior_RawMenopauseAge=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z33BR_Behavior_RawMenopauseAge=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_RAWMENOPAUSEAGE",gx.O.A33BR_Behavior_RawMenopauseAge,0)},c2v:function(){if(this.val()!==undefined)gx.O.A33BR_Behavior_RawMenopauseAge=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_RAWMENOPAUSEAGE")},nac:gx.falseFn};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id:91 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIOR_CHILDNUM",gxz:"Z34BR_Behavior_ChildNum",gxold:"O34BR_Behavior_ChildNum",gxvar:"A34BR_Behavior_ChildNum",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A34BR_Behavior_ChildNum=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z34BR_Behavior_ChildNum=Value},v2c:function(){gx.fn.setControlValue("BR_BEHAVIOR_CHILDNUM",gx.O.A34BR_Behavior_ChildNum,0)},c2v:function(){if(this.val()!==undefined)gx.O.A34BR_Behavior_ChildNum=this.val()},val:function(){return gx.fn.getControlValue("BR_BEHAVIOR_CHILDNUM")},nac:gx.falseFn};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[98]={ id: 98, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[104]={ id:104 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_behaviorid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_BEHAVIORID",gxz:"Z20BR_BehaviorID",gxold:"O20BR_BehaviorID",gxvar:"A20BR_BehaviorID",ucs:[],op:[25,91,86,82,77,73,68,64,59,55,50,46,41,37,32],ip:[25,91,86,82,77,73,68,64,59,55,50,46,41,37,32,104],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A20BR_BehaviorID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z20BR_BehaviorID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_BEHAVIORID",gx.O.A20BR_BehaviorID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A20BR_BehaviorID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_BEHAVIORID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 104 , function() {
   });
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A21BR_Behavior_Smoking = "" ;
   this.Z21BR_Behavior_Smoking = "" ;
   this.O21BR_Behavior_Smoking = "" ;
   this.A22BR_Behavior_SmokingTime = "" ;
   this.Z22BR_Behavior_SmokingTime = "" ;
   this.O22BR_Behavior_SmokingTime = "" ;
   this.A23BR_Behavior_SmokingAmount = "" ;
   this.Z23BR_Behavior_SmokingAmount = "" ;
   this.O23BR_Behavior_SmokingAmount = "" ;
   this.A24BR_Behavior_RawSmokingAmount = "" ;
   this.Z24BR_Behavior_RawSmokingAmount = "" ;
   this.O24BR_Behavior_RawSmokingAmount = "" ;
   this.A25BR_Behavior_Achohol = "" ;
   this.Z25BR_Behavior_Achohol = "" ;
   this.O25BR_Behavior_Achohol = "" ;
   this.A26BR_Behavior_AchoholTime = "" ;
   this.Z26BR_Behavior_AchoholTime = "" ;
   this.O26BR_Behavior_AchoholTime = "" ;
   this.A27BR_Behavior_AchoholAmount = "" ;
   this.Z27BR_Behavior_AchoholAmount = "" ;
   this.O27BR_Behavior_AchoholAmount = "" ;
   this.A28BR_Behavior_RawAchoholAmount = "" ;
   this.Z28BR_Behavior_RawAchoholAmount = "" ;
   this.O28BR_Behavior_RawAchoholAmount = "" ;
   this.A29BR_Behavior_FamilyCaHistory = "" ;
   this.Z29BR_Behavior_FamilyCaHistory = "" ;
   this.O29BR_Behavior_FamilyCaHistory = "" ;
   this.A30BR_Behavior_FamilyCancer = "" ;
   this.Z30BR_Behavior_FamilyCancer = "" ;
   this.O30BR_Behavior_FamilyCancer = "" ;
   this.A31BR_Behavior_Menopause = "" ;
   this.Z31BR_Behavior_Menopause = "" ;
   this.O31BR_Behavior_Menopause = "" ;
   this.A32BR_Behavior_MenopauseAge = 0 ;
   this.Z32BR_Behavior_MenopauseAge = 0 ;
   this.O32BR_Behavior_MenopauseAge = 0 ;
   this.A33BR_Behavior_RawMenopauseAge = "" ;
   this.Z33BR_Behavior_RawMenopauseAge = "" ;
   this.O33BR_Behavior_RawMenopauseAge = "" ;
   this.A34BR_Behavior_ChildNum = "" ;
   this.Z34BR_Behavior_ChildNum = "" ;
   this.O34BR_Behavior_ChildNum = "" ;
   this.A20BR_BehaviorID = 0 ;
   this.Z20BR_BehaviorID = 0 ;
   this.O20BR_BehaviorID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV12tCurrentCode = "" ;
   this.AV9WebSession = {} ;
   this.A20BR_BehaviorID = 0 ;
   this.A460BR_Behavior_Smoking_Code = "" ;
   this.A462BR_Behavior_Achohol_Code = "" ;
   this.A464BR_Behavior_FamilyCaHistory_Code = "" ;
   this.A465BR_Behavior_Menopause_Code = "" ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A21BR_Behavior_Smoking = "" ;
   this.A22BR_Behavior_SmokingTime = "" ;
   this.A23BR_Behavior_SmokingAmount = "" ;
   this.A24BR_Behavior_RawSmokingAmount = "" ;
   this.A461BR_Behavior_RawSmokingAmount_Code = "" ;
   this.A25BR_Behavior_Achohol = "" ;
   this.A26BR_Behavior_AchoholTime = "" ;
   this.A27BR_Behavior_AchoholAmount = "" ;
   this.A28BR_Behavior_RawAchoholAmount = "" ;
   this.A463BR_Behavior_RawAchoholAmount_Code = "" ;
   this.A29BR_Behavior_FamilyCaHistory = "" ;
   this.A30BR_Behavior_FamilyCancer = "" ;
   this.A31BR_Behavior_Menopause = "" ;
   this.A32BR_Behavior_MenopauseAge = 0 ;
   this.A33BR_Behavior_RawMenopauseAge = "" ;
   this.A34BR_Behavior_ChildNum = "" ;
   this.Events = {"e12082_client": ["AFTER TRN", true] ,"e13089_client": ["ENTER", true] ,"e14089_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'A461BR_Behavior_RawSmokingAmount_Code',fld:'BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE',pic:''},{av:'A463BR_Behavior_RawAchoholAmount_Code',fld:'BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE',pic:''}],[]];
   this.EvtParms["START"] = [[],[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''}]];
   this.EvtParms["AFTER TRN"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("A460BR_Behavior_Smoking_Code", "BR_BEHAVIOR_SMOKING_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A462BR_Behavior_Achohol_Code", "BR_BEHAVIOR_ACHOHOL_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A464BR_Behavior_FamilyCaHistory_Code", "BR_BEHAVIOR_FAMILYCAHISTORY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A465BR_Behavior_Menopause_Code", "BR_BEHAVIOR_MENOPAUSE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV12tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A461BR_Behavior_RawSmokingAmount_Code", "BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A463BR_Behavior_RawAchoholAmount_Code", "BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("A36BR_Information_PatientNo", "BR_INFORMATION_PATIENTNO", 0, "svchar", 2000, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.Initialize( );
});
gx.createParentObj(br_behavior);
