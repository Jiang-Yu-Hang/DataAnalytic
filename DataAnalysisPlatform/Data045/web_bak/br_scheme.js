/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:38:40.55
*/
gx.evt.autoSkip = false;
gx.define('br_scheme', false, function () {
   this.ServerClass =  "br_scheme" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_SchemeID=gx.fn.getIntegerValue("vBR_SCHEMEID",',') ;
      this.AV13Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.A500BR_Scheme_Therapy_Line_Code=gx.fn.getControlValue("BR_SCHEME_THERAPY_LINE_CODE") ;
      this.AV18tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_schemeid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEMEID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_scheme_chem_regimens=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEME_CHEM_REGIMENS");
         this.AnyError  = 0;
         if ( ((''==this.A328BR_Scheme_Chem_Regimens)) )
         {
            try {
               gxballoon.setError("鍖栫枟鏂规鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_scheme_therapy_line=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEME_THERAPY_LINE");
         this.AnyError  = 0;
         try {
            gx.fn.setCtrlProperty("vVLINE","Visible", (this.A329BR_Scheme_Therapy_Line=="鍏跺畠") );
         }
         catch(e){}
         try {
            if ( ! ( ( this.A329BR_Scheme_Therapy_Line == "鍏跺畠" ) ) )
            {
               gx.fn.setCtrlProperty("VLINE_CELL","Class", "Invisible" );
            }
            else
            {
               if ( this.A329BR_Scheme_Therapy_Line == "鍏跺畠" )
               {
                  gx.fn.setCtrlProperty("VLINE_CELL","Class", "RequiredDataContentCell" );
               }
            }
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
   this.Validv_Vline=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVLINE");
         this.AnyError  = 0;
         if ( ( ( this.A329BR_Scheme_Therapy_Line == "鍏跺畠" ) ) && ((''==this.AV16vline)) )
         {
            try {
               gxballoon.setError("鍏跺畠绾跨骇鏄繀濉殑");
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
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')"],[]);
      return true;
   }
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("vVLINE","Visible", false );
      gx.fn.setCtrlProperty("VLINE_CELL","Class", "Invisible" );
   };
   this.e12122_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e131239_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e141239_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,39,40,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74];
   this.GXLastCtrlId =74;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鍖栫枟鏂规", "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_SCHEME_CHEM_REGIMENS",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_SCHEME_CHEM_REGIMENS", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_scheme_chem_regimens,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(){gx.fn.setControlValue("BR_SCHEME_CHEM_REGIMENS",gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(){return gx.fn.getControlValue("BR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"TABLESPLITTEDBR_SCHEME_THERAPY_LINE",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_SCHEME_THERAPY_LINE", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"TABLEMERGEDBR_SCHEME_THERAPY_LINE",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_scheme_therapy_line,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_THERAPY_LINE",gxz:"Z329BR_Scheme_Therapy_Line",gxold:"O329BR_Scheme_Therapy_Line",gxvar:"A329BR_Scheme_Therapy_Line",ucs:[],op:[],ip:[40],
						nacdep:[],ctrltype:"dyncombo",v2v:function(Value){if(Value!==undefined)gx.O.A329BR_Scheme_Therapy_Line=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z329BR_Scheme_Therapy_Line=Value},v2c:function(){gx.fn.setComboBoxValue("BR_SCHEME_THERAPY_LINE",gx.O.A329BR_Scheme_Therapy_Line)},c2v:function(){if(this.val()!==undefined)gx.O.A329BR_Scheme_Therapy_Line=this.val()},val:function(){return gx.fn.getControlValue("BR_SCHEME_THERAPY_LINE")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Vline,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVLINE",gxz:"ZV16vline",gxold:"OV16vline",gxvar:"AV16vline",ucs:[],op:[43,40],ip:[43,40],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16vline=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16vline=Value},v2c:function(){gx.fn.setControlValue("vVLINE",gx.O.AV16vline,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16vline=this.val()},val:function(){return gx.fn.getControlValue("vVLINE")},nac:gx.falseFn};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"UNNAMEDTABLEBR_SCHEME_CHEM_CYCLE",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"TEXTBLOCKBR_SCHEME_CHEM_CYCLE", format:0,grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_CYCLE",gxz:"Z330BR_Scheme_Chem_Cycle",gxold:"O330BR_Scheme_Chem_Cycle",gxvar:"A330BR_Scheme_Chem_Cycle",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z330BR_Scheme_Chem_Cycle=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_SCHEME_CHEM_CYCLE",gx.O.A330BR_Scheme_Chem_Cycle,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A330BR_Scheme_Chem_Cycle=this.val()},val:function(){return gx.fn.getDecimalValue("BR_SCHEME_CHEM_CYCLE",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 52 , function() {
   });
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"UNNAMEDTABLEBR_SCHEME_CHEM_DETAIL",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"TEXTBLOCKBR_SCHEME_CHEM_DETAIL", format:0,grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id:60 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_DETAIL",gxz:"Z331BR_Scheme_Chem_Detail",gxold:"O331BR_Scheme_Chem_Detail",gxvar:"A331BR_Scheme_Chem_Detail",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A331BR_Scheme_Chem_Detail=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z331BR_Scheme_Chem_Detail=Value},v2c:function(){gx.fn.setControlValue("BR_SCHEME_CHEM_DETAIL",gx.O.A331BR_Scheme_Chem_Detail,0)},c2v:function(){if(this.val()!==undefined)gx.O.A331BR_Scheme_Chem_Detail=this.val()},val:function(){return gx.fn.getControlValue("BR_SCHEME_CHEM_DETAIL")},nac:gx.falseFn};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[70]={ id: 70, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[73]={ id:73 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_SCHEMEID",gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_SCHEMEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 73 , function() {
   });
   GXValidFnc[74]={ id:74 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[74],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 74 , function() {
   });
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.A329BR_Scheme_Therapy_Line = "" ;
   this.Z329BR_Scheme_Therapy_Line = "" ;
   this.O329BR_Scheme_Therapy_Line = "" ;
   this.AV16vline = "" ;
   this.ZV16vline = "" ;
   this.OV16vline = "" ;
   this.A330BR_Scheme_Chem_Cycle = 0 ;
   this.Z330BR_Scheme_Chem_Cycle = 0 ;
   this.O330BR_Scheme_Chem_Cycle = 0 ;
   this.A331BR_Scheme_Chem_Detail = "" ;
   this.Z331BR_Scheme_Chem_Detail = "" ;
   this.O331BR_Scheme_Chem_Detail = "" ;
   this.A327BR_SchemeID = 0 ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.AV18tCurrentCode = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV19Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV20GXV1 = 0 ;
   this.AV13Insert_BR_EncounterID = 0 ;
   this.AV17TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_SchemeID = 0 ;
   this.AV12WebSession = {} ;
   this.A327BR_SchemeID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.AV16vline = "" ;
   this.A500BR_Scheme_Therapy_Line_Code = "" ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A329BR_Scheme_Therapy_Line = "" ;
   this.A330BR_Scheme_Chem_Cycle = 0 ;
   this.A331BR_Scheme_Chem_Detail = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e12122_client": ["AFTER TRN", true] ,"e131239_client": ["ENTER", true] ,"e141239_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV19Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV20GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Visible")',ctrl:'BR_SCHEMEID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'AV17TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vVLINE","Visible")',ctrl:'vVLINE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("VLINE_CELL","Class")',ctrl:'VLINE_CELL',prop:'Class'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_SchemeID", "vBR_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("A500BR_Scheme_Therapy_Line_Code", "BR_SCHEME_THERAPY_LINE_CODE", 0, "svchar", 40, 0);
   this.setVCMap("AV18tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_scheme);
