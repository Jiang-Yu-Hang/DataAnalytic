/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:50.44
*/
gx.evt.autoSkip = false;
gx.define('br_pathology', false, function () {
   this.ServerClass =  "br_pathology" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_PathologyID=gx.fn.getIntegerValue("vBR_PATHOLOGYID",',') ;
      this.AV13Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A505BR_Pathology_N_Code=gx.fn.getControlValue("BR_PATHOLOGY_N_CODE") ;
      this.A506BR_Pathology_M_Code=gx.fn.getControlValue("BR_PATHOLOGY_M_CODE") ;
      this.A508BR_PathologyID_PAHosp_Code=gx.fn.getControlValue("BR_PATHOLOGYID_PAHOSP_CODE") ;
      this.AV16tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.A85BR_Information_ID=gx.fn.getIntegerValue("BR_INFORMATION_ID",',') ;
      this.AV17Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_pathologyid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGYID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathologyid_padate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGYID_PADATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A238BR_PathologyID_PADate)==0) || new gx.date.gxdate( this.A238BR_PathologyID_PADate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         if ( (new gx.date.gxdate('').compare(this.A238BR_PathologyID_PADate)==0) )
         {
            try {
               gxballoon.setError("鐥呯悊妫€鏌ユ棩鏈熸槸蹇呴』濉啓鐨勩€?);
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
   this.Valid_Br_pathologyid_paage=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGYID_PAAGE");
         this.AnyError  = 0;
         if ( ((0==this.A240BR_PathologyID_PAAge)) )
         {
            try {
               gxballoon.setError("骞撮緞鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_pathologyid_pahosp=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGYID_PAHOSP");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathology_dia_name=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_DIA_NAME");
         this.AnyError  = 0;
         if ( ((''==this.A326BR_Pathology_Dia_Name)) )
         {
            try {
               gxballoon.setError("鐥呯悊璇婃柇鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_pathology_n=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_N");
         this.AnyError  = 0;
         if ( ! ( ( this.A315BR_Pathology_N == "鍚? ) || ( this.A315BR_Pathology_N == "鏄? ) || ( this.A315BR_Pathology_N == "涓嶈" ) || ((''==this.A315BR_Pathology_N)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
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
   this.Valid_Br_pathology_m=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_M");
         this.AnyError  = 0;
         if ( ! ( ( this.A318BR_Pathology_M == "鍚? ) || ( this.A318BR_Pathology_M == "鏄? ) || ( this.A318BR_Pathology_M == "涓嶈" ) || ((''==this.A318BR_Pathology_M)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }
         try {
            gx.fn.setCtrlProperty("UNNAMEDTABLE1","Visible", ((this.A318BR_Pathology_M=="鏄?)) );
         }
         catch(e){}

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
      gx.fn.setCtrlProperty("UNNAMEDTABLE1","Visible", false );
   };
   this.e120z2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130z36_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140z36_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142];
   this.GXLastCtrlId =142;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PATHOLOGYID_PADATE",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGYID_PADATE", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid_padate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_PADATE",gxz:"Z238BR_PathologyID_PADate",gxold:"O238BR_PathologyID_PADate",gxvar:"A238BR_PathologyID_PADate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A238BR_PathologyID_PADate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z238BR_PathologyID_PADate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID_PADATE",gx.O.A238BR_PathologyID_PADate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A238BR_PathologyID_PADate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGYID_PADATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 29 , function() {
   });
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PATHOLOGYID_PAAGE",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PATHOLOGYID_PAAGE", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid_paage,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_PAAGE",gxz:"Z240BR_PathologyID_PAAge",gxold:"O240BR_PathologyID_PAAge",gxvar:"A240BR_PathologyID_PAAge",ucs:[],op:[37],ip:[37],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A240BR_PathologyID_PAAge=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z240BR_PathologyID_PAAge=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID_PAAGE",gx.O.A240BR_PathologyID_PAAge,0)},c2v:function(){if(this.val()!==undefined)gx.O.A240BR_PathologyID_PAAge=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID_PAAGE",',')},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_PATHOLOGYID_PAHOSP",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_PATHOLOGYID_PAHOSP", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid_pahosp,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_PAHOSP",gxz:"Z239BR_PathologyID_PAHosp",gxold:"O239BR_PathologyID_PAHosp",gxvar:"A239BR_PathologyID_PAHosp",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A239BR_PathologyID_PAHosp=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z239BR_PathologyID_PAHosp=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGYID_PAHOSP",gx.O.A239BR_PathologyID_PAHosp)},c2v:function(){if(this.val()!==undefined)gx.O.A239BR_PathologyID_PAHosp=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGYID_PAHOSP")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIA_NAME",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"TEXTBLOCKBR_PATHOLOGY_DIA_NAME", format:0,grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:3000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_dia_name,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIA_NAME",gxz:"Z326BR_Pathology_Dia_Name",gxold:"O326BR_Pathology_Dia_Name",gxvar:"A326BR_Pathology_Dia_Name",ucs:[],op:[55],ip:[55],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A326BR_Pathology_Dia_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z326BR_Pathology_Dia_Name=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIA_NAME",gx.O.A326BR_Pathology_Dia_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A326BR_Pathology_Dia_Name=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIA_NAME")},nac:gx.falseFn};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_PATHOLOGYID_PARESULT",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_PATHOLOGYID_PARESULT", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:9999,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_PARESULT",gxz:"Z242BR_PathologyID_PAResult",gxold:"O242BR_PathologyID_PAResult",gxvar:"A242BR_PathologyID_PAResult",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A242BR_PathologyID_PAResult=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z242BR_PathologyID_PAResult=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID_PARESULT",gx.O.A242BR_PathologyID_PAResult,0)},c2v:function(){if(this.val()!==undefined)gx.O.A242BR_PathologyID_PAResult=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGYID_PARESULT")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"UNNAMEDTABLEBR_PATHOLOGYID_PREPADIA",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"TEXTBLOCKBR_PATHOLOGYID_PREPADIA", format:0,grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id:72 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_PREPADIA",gxz:"Z241BR_PathologyID_PrePaDia",gxold:"O241BR_PathologyID_PrePaDia",gxvar:"A241BR_PathologyID_PrePaDia",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A241BR_PathologyID_PrePaDia=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z241BR_PathologyID_PrePaDia=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID_PREPADIA",gx.O.A241BR_PathologyID_PrePaDia,0)},c2v:function(){if(this.val()!==undefined)gx.O.A241BR_PathologyID_PrePaDia=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGYID_PREPADIA")},nac:gx.falseFn};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLEBR_PATHOLOGY_T",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"TEXTBLOCKBR_PATHOLOGY_T", format:0,grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"",grid:0};
   GXValidFnc[80]={ id:80 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_T",gxz:"Z314BR_Pathology_T",gxold:"O314BR_Pathology_T",gxvar:"A314BR_Pathology_T",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A314BR_Pathology_T=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z314BR_Pathology_T=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_T",gx.O.A314BR_Pathology_T,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A314BR_Pathology_T=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_T",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 80 , function() {
   });
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"UNNAMEDTABLEBR_PATHOLOGY_N",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id: 86, fld:"TEXTBLOCKBR_PATHOLOGY_N", format:0,grid:0};
   GXValidFnc[87]={ id: 87, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id:89 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_n,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_N",gxz:"Z315BR_Pathology_N",gxold:"O315BR_Pathology_N",gxvar:"A315BR_Pathology_N",ucs:[],op:[89],ip:[89],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A315BR_Pathology_N=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z315BR_Pathology_N=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_N",gx.O.A315BR_Pathology_N);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A315BR_Pathology_N=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_N")},nac:gx.falseFn};
   this.declareDomainHdlr( 89 , function() {
   });
   GXValidFnc[90]={ id: 90, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"UNNAMEDTABLEBR_PATHOLOGY_LYMPHNUM",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[94]={ id: 94, fld:"TEXTBLOCKBR_PATHOLOGY_LYMPHNUM", format:0,grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id:97 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_LYMPHNUM",gxz:"Z316BR_Pathology_LymphNum",gxold:"O316BR_Pathology_LymphNum",gxvar:"A316BR_Pathology_LymphNum",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A316BR_Pathology_LymphNum=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z316BR_Pathology_LymphNum=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_PATHOLOGY_LYMPHNUM",gx.O.A316BR_Pathology_LymphNum,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A316BR_Pathology_LymphNum=this.val()},val:function(){return gx.fn.getDecimalValue("BR_PATHOLOGY_LYMPHNUM",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 97 , function() {
   });
   GXValidFnc[98]={ id: 98, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"UNNAMEDTABLEBR_PATHOLOGY_LYMPHRATE",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"TEXTBLOCKBR_PATHOLOGY_LYMPHRATE", format:0,grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id:106 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_LYMPHRATE",gxz:"Z317BR_Pathology_LymphRate",gxold:"O317BR_Pathology_LymphRate",gxvar:"A317BR_Pathology_LymphRate",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A317BR_Pathology_LymphRate=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z317BR_Pathology_LymphRate=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_LYMPHRATE",gx.O.A317BR_Pathology_LymphRate,0)},c2v:function(){if(this.val()!==undefined)gx.O.A317BR_Pathology_LymphRate=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_LYMPHRATE")},nac:gx.falseFn};
   GXValidFnc[107]={ id: 107, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id: 109, fld:"UNNAMEDTABLEBR_PATHOLOGY_M",grid:0};
   GXValidFnc[110]={ id: 110, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"",grid:0};
   GXValidFnc[112]={ id: 112, fld:"TEXTBLOCKBR_PATHOLOGY_M", format:0,grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[114]={ id: 114, fld:"",grid:0};
   GXValidFnc[115]={ id:115 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_m,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_M",gxz:"Z318BR_Pathology_M",gxold:"O318BR_Pathology_M",gxvar:"A318BR_Pathology_M",ucs:[],op:[115],ip:[115],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A318BR_Pathology_M=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z318BR_Pathology_M=Value},v2c:function(){gx.fn.setComboBoxValue("BR_PATHOLOGY_M",gx.O.A318BR_Pathology_M);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A318BR_Pathology_M=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_M")},nac:gx.falseFn};
   this.declareDomainHdlr( 115 , function() {
   });
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[118]={ id: 118, fld:"",grid:0};
   GXValidFnc[119]={ id: 119, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"UNNAMEDTABLEBR_PATHOLOGY_METALOC",grid:0};
   GXValidFnc[121]={ id: 121, fld:"",grid:0};
   GXValidFnc[122]={ id: 122, fld:"",grid:0};
   GXValidFnc[123]={ id: 123, fld:"TEXTBLOCKBR_PATHOLOGY_METALOC", format:0,grid:0};
   GXValidFnc[124]={ id: 124, fld:"",grid:0};
   GXValidFnc[125]={ id: 125, fld:"",grid:0};
   GXValidFnc[126]={ id:126 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_METALOC",gxz:"Z319BR_Pathology_MetaLoc",gxold:"O319BR_Pathology_MetaLoc",gxvar:"A319BR_Pathology_MetaLoc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A319BR_Pathology_MetaLoc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z319BR_Pathology_MetaLoc=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_METALOC",gx.O.A319BR_Pathology_MetaLoc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A319BR_Pathology_MetaLoc=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_METALOC")},nac:gx.falseFn};
   GXValidFnc[127]={ id: 127, fld:"",grid:0};
   GXValidFnc[128]={ id: 128, fld:"",grid:0};
   GXValidFnc[129]={ id: 129, fld:"",grid:0};
   GXValidFnc[130]={ id: 130, fld:"",grid:0};
   GXValidFnc[131]={ id: 131, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[132]={ id: 132, fld:"",grid:0};
   GXValidFnc[133]={ id: 133, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[134]={ id: 134, fld:"",grid:0};
   GXValidFnc[135]={ id: 135, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[136]={ id: 136, fld:"",grid:0};
   GXValidFnc[137]={ id: 137, fld:"",grid:0};
   GXValidFnc[138]={ id: 138, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[139]={ id:139 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID",gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 139 , function() {
   });
   GXValidFnc[140]={ id:140 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[141],ip:[141,140],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 140 , function() {
   });
   GXValidFnc[141]={ id:141 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_PATIENTNO",gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[142]={ id:142 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID_TESTID",gxz:"Z237BR_PathologyID_TestID",gxold:"O237BR_PathologyID_TestID",gxvar:"A237BR_PathologyID_TestID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A237BR_PathologyID_TestID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z237BR_PathologyID_TestID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID_TESTID",gx.O.A237BR_PathologyID_TestID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A237BR_PathologyID_TestID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID_TESTID",',')},nac:gx.falseFn};
   this.A238BR_PathologyID_PADate = gx.date.nullDate() ;
   this.Z238BR_PathologyID_PADate = gx.date.nullDate() ;
   this.O238BR_PathologyID_PADate = gx.date.nullDate() ;
   this.A240BR_PathologyID_PAAge = 0 ;
   this.Z240BR_PathologyID_PAAge = 0 ;
   this.O240BR_PathologyID_PAAge = 0 ;
   this.A239BR_PathologyID_PAHosp = "" ;
   this.Z239BR_PathologyID_PAHosp = "" ;
   this.O239BR_PathologyID_PAHosp = "" ;
   this.A326BR_Pathology_Dia_Name = "" ;
   this.Z326BR_Pathology_Dia_Name = "" ;
   this.O326BR_Pathology_Dia_Name = "" ;
   this.A242BR_PathologyID_PAResult = "" ;
   this.Z242BR_PathologyID_PAResult = "" ;
   this.O242BR_PathologyID_PAResult = "" ;
   this.A241BR_PathologyID_PrePaDia = "" ;
   this.Z241BR_PathologyID_PrePaDia = "" ;
   this.O241BR_PathologyID_PrePaDia = "" ;
   this.A314BR_Pathology_T = 0 ;
   this.Z314BR_Pathology_T = 0 ;
   this.O314BR_Pathology_T = 0 ;
   this.A315BR_Pathology_N = "" ;
   this.Z315BR_Pathology_N = "" ;
   this.O315BR_Pathology_N = "" ;
   this.A316BR_Pathology_LymphNum = 0 ;
   this.Z316BR_Pathology_LymphNum = 0 ;
   this.O316BR_Pathology_LymphNum = 0 ;
   this.A317BR_Pathology_LymphRate = "" ;
   this.Z317BR_Pathology_LymphRate = "" ;
   this.O317BR_Pathology_LymphRate = "" ;
   this.A318BR_Pathology_M = "" ;
   this.Z318BR_Pathology_M = "" ;
   this.O318BR_Pathology_M = "" ;
   this.A319BR_Pathology_MetaLoc = "" ;
   this.Z319BR_Pathology_MetaLoc = "" ;
   this.O319BR_Pathology_MetaLoc = "" ;
   this.A226BR_PathologyID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.A237BR_PathologyID_TestID = 0 ;
   this.Z237BR_PathologyID_TestID = 0 ;
   this.O237BR_PathologyID_TestID = 0 ;
   this.A85BR_Information_ID = 0 ;
   this.AV16tCurrentCode = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV17Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV18GXV1 = 0 ;
   this.AV13Insert_BR_EncounterID = 0 ;
   this.AV15TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_PathologyID = 0 ;
   this.AV12WebSession = {} ;
   this.A226BR_PathologyID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A505BR_Pathology_N_Code = "" ;
   this.A506BR_Pathology_M_Code = "" ;
   this.A508BR_PathologyID_PAHosp_Code = "" ;
   this.A36BR_Information_PatientNo = "" ;
   this.A237BR_PathologyID_TestID = 0 ;
   this.A238BR_PathologyID_PADate = gx.date.nullDate() ;
   this.A239BR_PathologyID_PAHosp = "" ;
   this.A240BR_PathologyID_PAAge = 0 ;
   this.A241BR_PathologyID_PrePaDia = "" ;
   this.A242BR_PathologyID_PAResult = "" ;
   this.A326BR_Pathology_Dia_Name = "" ;
   this.A314BR_Pathology_T = 0 ;
   this.A315BR_Pathology_N = "" ;
   this.A316BR_Pathology_LymphNum = 0 ;
   this.A317BR_Pathology_LymphRate = "" ;
   this.A318BR_Pathology_M = "" ;
   this.A319BR_Pathology_MetaLoc = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120z2_client": ["AFTER TRN", true] ,"e130z36_client": ["ENTER", true] ,"e140z36_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV18GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Visible")',ctrl:'BR_PATHOLOGYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Visible")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID_TESTID","Visible")',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Visible'},{av:'AV15TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("UNNAMEDTABLE1","Visible")',ctrl:'UNNAMEDTABLE1',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_PathologyID", "vBR_PATHOLOGYID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A505BR_Pathology_N_Code", "BR_PATHOLOGY_N_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A506BR_Pathology_M_Code", "BR_PATHOLOGY_M_CODE", 0, "svchar", 40, 0);
   this.setVCMap("A508BR_PathologyID_PAHosp_Code", "BR_PATHOLOGYID_PAHOSP_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV16tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("A85BR_Information_ID", "BR_INFORMATION_ID", 0, "int", 18, 0);
   this.setVCMap("AV17Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_pathology);
