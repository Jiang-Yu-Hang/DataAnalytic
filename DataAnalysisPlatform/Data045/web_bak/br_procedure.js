/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:38:37.52
*/
gx.evt.autoSkip = false;
gx.define('br_procedure', false, function () {
   this.ServerClass =  "br_procedure" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12BR_ProcedureID=gx.fn.getIntegerValue("vBR_PROCEDUREID",',') ;
      this.AV10Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A497BR_Procedure_PXSurgery_Code=gx.fn.getControlValue("BR_PROCEDURE_PXSURGERY_CODE") ;
      this.A498BR_Procedure_PXRadiotherapy_Code=gx.fn.getControlValue("BR_PROCEDURE_PXRADIOTHERAPY_CODE") ;
      this.A140BR_Procedure_PXID=gx.fn.getIntegerValue("BR_PROCEDURE_PXID",',') ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV20Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV8TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_procedureid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDUREID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_procedure_pxsurgery=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_PXSURGERY");
         this.AnyError  = 0;
         if ( ! ( ( this.A141BR_Procedure_PXSurgery == "鍚? ) || ( this.A141BR_Procedure_PXSurgery == "鏄? ) || ( this.A141BR_Procedure_PXSurgery == "涓嶈" ) || ((''==this.A141BR_Procedure_PXSurgery)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         try {
            gx.fn.setCtrlProperty("BR_PROCEDURE_PXRADIOTHERAPY","Visible", (this.A141BR_Procedure_PXSurgery=="鍚?) );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A141BR_Procedure_PXSurgery == "鍚? ) ) )
            {
               gx.fn.setCtrlProperty("BR_PROCEDURE_PXRADIOTHERAPY_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A141BR_Procedure_PXSurgery == "鍚? )
               {
                  gx.fn.setCtrlProperty("BR_PROCEDURE_PXRADIOTHERAPY_CELL","Class", "col-xs-12 col-sm-6 RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         try {
            gx.fn.setCtrlProperty("UNNAMEDTABLE1","Visible", ((this.A141BR_Procedure_PXSurgery=="鏄?)) );
         }
         catch(e){}
         if ( ((''==this.A141BR_Procedure_PXSurgery)) )
         {
            try {
               gxballoon.setError("鏄惁鎵嬫湳鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_procedure_date=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_DATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A266BR_Procedure_Date)==0) || new gx.date.gxdate( this.A266BR_Procedure_Date ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_procedure_pxradiotherapy=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_PXRADIOTHERAPY");
         this.AnyError  = 0;
         if ( ! ( ( this.A143BR_Procedure_PXRadiotherapy == "鍚? ) || ( this.A143BR_Procedure_PXRadiotherapy == "鏄? ) || ( this.A143BR_Procedure_PXRadiotherapy == "涓嶈" ) || ((''==this.A143BR_Procedure_PXRadiotherapy)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         try {
            gx.fn.setCtrlProperty("BR_PROCEDURE_PXSURGERY","Visible", (this.A143BR_Procedure_PXRadiotherapy=="鍚?) );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A143BR_Procedure_PXRadiotherapy == "鍚? ) ) )
            {
               gx.fn.setCtrlProperty("BR_PROCEDURE_PXSURGERY_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A143BR_Procedure_PXRadiotherapy == "鍚? )
               {
                  gx.fn.setCtrlProperty("BR_PROCEDURE_PXSURGERY_CELL","Class", "col-xs-12 col-sm-6 RequiredDataContentCell" );
               }
            }
         }
         catch(e){}
         try {
            gx.fn.setCtrlProperty("UNNAMEDTABLE2","Visible", ((this.A143BR_Procedure_PXRadiotherapy=="鏄?)) );
         }
         catch(e){}
         if ( ((''==this.A143BR_Procedure_PXRadiotherapy)) )
         {
            try {
               gxballoon.setError("鏄惁鎺ュ彈鏀惧皠鐤楁硶鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_procedure_radiodate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_RADIODATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A268BR_Procedure_RadioDate)==0) || new gx.date.gxdate( this.A268BR_Procedure_RadioDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
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
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')", "gx.num.urlDecimal(gx.O.A85BR_Information_ID,\',\',\'.\')", "gx.O.A36BR_Information_PatientNo"],["A85BR_Information_ID", "A36BR_Information_PatientNo"]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("BR_PROCEDURE_PXSURGERY_CELL","Class", "col-xs-12 col-sm-6 RequiredDataContentCell" );
      gx.fn.setCtrlProperty("BR_PROCEDURE_PXRADIOTHERAPY_CELL","Class", "col-xs-12 col-sm-6 RequiredDataContentCell" );
      gx.fn.setCtrlProperty("UNNAMEDTABLE1","Visible", false );
      gx.fn.setCtrlProperty("UNNAMEDTABLE2","Visible", false );
   };
   this.e120i2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130i2_client=function()
   {
      return this.executeServerEvent("'DOTEST'", true, null, false, false);
   };
   this.e140i19_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e150i19_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83];
   this.GXLastCtrlId =83;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "璇婄枟澶勭悊", "str");
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
   GXValidFnc[22]={ id: 22, fld:"BR_PROCEDURE_PXSURGERY_CELL",grid:0};
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PROCEDURE_PXSURGERY",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PROCEDURE_PXSURGERY", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_pxsurgery,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_PXSURGERY",gxz:"Z141BR_Procedure_PXSurgery",gxold:"O141BR_Procedure_PXSurgery",gxvar:"A141BR_Procedure_PXSurgery",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A141BR_Procedure_PXSurgery=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z141BR_Procedure_PXSurgery=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PROCEDURE_PXSURGERY",gx.O.A141BR_Procedure_PXSurgery);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A141BR_Procedure_PXSurgery=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_PXSURGERY")},nac:gx.falseFn};
   this.declareDomainHdlr( 29 , function() {
   });
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"UNNAMEDTABLEBR_PROCEDURE_DATE",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"TEXTBLOCKBR_PROCEDURE_DATE", format:0,grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_date,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_DATE",gxz:"Z266BR_Procedure_Date",gxold:"O266BR_Procedure_Date",gxvar:"A266BR_Procedure_Date",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[40],ip:[40],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A266BR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z266BR_Procedure_Date=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_DATE",gx.O.A266BR_Procedure_Date,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A266BR_Procedure_Date=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_DATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 40 , function() {
   });
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"BR_PROCEDURE_PXRADIOTHERAPY_CELL",grid:0};
   GXValidFnc[43]={ id: 43, fld:"UNNAMEDTABLEBR_PROCEDURE_PXRADIOTHERAPY",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"TEXTBLOCKBR_PROCEDURE_PXRADIOTHERAPY", format:0,grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_pxradiotherapy,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_PXRADIOTHERAPY",gxz:"Z143BR_Procedure_PXRadiotherapy",gxold:"O143BR_Procedure_PXRadiotherapy",gxvar:"A143BR_Procedure_PXRadiotherapy",ucs:[],op:[49],ip:[49],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A143BR_Procedure_PXRadiotherapy=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z143BR_Procedure_PXRadiotherapy=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PROCEDURE_PXRADIOTHERAPY",gx.O.A143BR_Procedure_PXRadiotherapy);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A143BR_Procedure_PXRadiotherapy=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_PXRADIOTHERAPY")},nac:gx.falseFn};
   this.declareDomainHdlr( 49 , function() {
   });
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"UNNAMEDTABLEBR_PROCEDURE_RADIODATE",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"TEXTBLOCKBR_PROCEDURE_RADIODATE", format:0,grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_radiodate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIODATE",gxz:"Z268BR_Procedure_RadioDate",gxold:"O268BR_Procedure_RadioDate",gxvar:"A268BR_Procedure_RadioDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[60],ip:[60],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIODATE",gx.O.A268BR_Procedure_RadioDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A268BR_Procedure_RadioDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_RADIODATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 60 , function() {
   });
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"UNNAMEDTABLEBR_PROCEDURE_RADIOTIME",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"TEXTBLOCKBR_PROCEDURE_RADIOTIME", format:0,grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIOTIME",gxz:"Z269BR_Procedure_RadioTime",gxold:"O269BR_Procedure_RadioTime",gxvar:"A269BR_Procedure_RadioTime",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A269BR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z269BR_Procedure_RadioTime=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PROCEDURE_RADIOTIME",gx.O.A269BR_Procedure_RadioTime,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A269BR_Procedure_RadioTime=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PROCEDURE_RADIOTIME",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
   });
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[81]={ id:81 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_procedureid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDUREID",gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDUREID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 81 , function() {
   });
   GXValidFnc[82]={ id:82 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[83],ip:[83,82],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV10Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 82 , function() {
   });
   GXValidFnc[83]={ id:83 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   this.A141BR_Procedure_PXSurgery = "" ;
   this.Z141BR_Procedure_PXSurgery = "" ;
   this.O141BR_Procedure_PXSurgery = "" ;
   this.A266BR_Procedure_Date = gx.date.nullDate() ;
   this.Z266BR_Procedure_Date = gx.date.nullDate() ;
   this.O266BR_Procedure_Date = gx.date.nullDate() ;
   this.A143BR_Procedure_PXRadiotherapy = "" ;
   this.Z143BR_Procedure_PXRadiotherapy = "" ;
   this.O143BR_Procedure_PXRadiotherapy = "" ;
   this.A268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.Z268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.O268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.A269BR_Procedure_RadioTime = 0 ;
   this.Z269BR_Procedure_RadioTime = 0 ;
   this.O269BR_Procedure_RadioTime = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A85BR_Information_ID = 0 ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV13IsAuthorized = false ;
   this.AV20Pgmname = "" ;
   this.AV8TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV21GXV1 = 0 ;
   this.AV10Insert_BR_EncounterID = 0 ;
   this.AV15TempBoolean = false ;
   this.AV11TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV12BR_ProcedureID = 0 ;
   this.AV9WebSession = {} ;
   this.A139BR_ProcedureID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A497BR_Procedure_PXSurgery_Code = "" ;
   this.A498BR_Procedure_PXRadiotherapy_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A140BR_Procedure_PXID = 0 ;
   this.A141BR_Procedure_PXSurgery = "" ;
   this.A266BR_Procedure_Date = gx.date.nullDate() ;
   this.A143BR_Procedure_PXRadiotherapy = "" ;
   this.A268BR_Procedure_RadioDate = gx.date.nullDate() ;
   this.A269BR_Procedure_RadioTime = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e120i2_client": ["AFTER TRN", true] ,"e130i2_client": ["'DOTEST'", true] ,"e140i19_client": ["ENTER", true] ,"e150i19_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A140BR_Procedure_PXID',fld:'BR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV20Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV13IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV21GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV11TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Visible")',ctrl:'BR_PROCEDUREID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'AV15TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXSURGERY_CELL","Class")',ctrl:'BR_PROCEDURE_PXSURGERY_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_PXRADIOTHERAPY_CELL","Class")',ctrl:'BR_PROCEDURE_PXRADIOTHERAPY_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("UNNAMEDTABLE1","Visible")',ctrl:'UNNAMEDTABLE1',prop:'Visible'},{av:'gx.fn.getCtrlProperty("UNNAMEDTABLE2","Visible")',ctrl:'UNNAMEDTABLE2',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["'DOTEST'"] = [[],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV12BR_ProcedureID", "vBR_PROCEDUREID", 0, "int", 18, 0);
   this.setVCMap("AV10Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A497BR_Procedure_PXSurgery_Code", "BR_PROCEDURE_PXSURGERY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A498BR_Procedure_PXRadiotherapy_Code", "BR_PROCEDURE_PXRADIOTHERAPY_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A140BR_Procedure_PXID", "BR_PROCEDURE_PXID", 0, "int", 10, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV20Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV8TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_procedure);
