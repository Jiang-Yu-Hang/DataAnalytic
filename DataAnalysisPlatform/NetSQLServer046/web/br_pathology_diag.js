/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:34.65
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_diag', false, function () {
   this.ServerClass =  "br_pathology_diag" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_Pathology_DiagID=gx.fn.getIntegerValue("vBR_PATHOLOGY_DIAGID",',') ;
      this.AV13Insert_BR_PathologyID=gx.fn.getIntegerValue("vINSERT_BR_PATHOLOGYID",',') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_pathology_diagid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_DIAGID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathology_diag_loc=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_DIAG_LOC");
         this.AnyError  = 0;
         if ( ((''==this.A277BR_Pathology_Diag_Loc)) )
         {
            try {
               gxballoon.setError("鐥呯悊璇婃柇(閮ㄤ綅)鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_pathology_diag_organ=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_DIAG_ORGAN");
         this.AnyError  = 0;
         if ( ((''==this.A278BR_Pathology_Diag_Organ)) )
         {
            try {
               gxballoon.setError("鐥呯悊璇婃柇(鍣ㄥ畼)鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_pathologyid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_pathologyid",["gx.num.urlDecimal(gx.O.A226BR_PathologyID,\',\',\'.\')"],[]);
      return true;
   }
   this.e120x2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130x34_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140x34_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77];
   this.GXLastCtrlId =77;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛﹁瘖鏂?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_LOC",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_LOC", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_diag_loc,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_LOC",gxz:"Z277BR_Pathology_Diag_Loc",gxold:"O277BR_Pathology_Diag_Loc",gxvar:"A277BR_Pathology_Diag_Loc",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A277BR_Pathology_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z277BR_Pathology_Diag_Loc=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_LOC",gx.O.A277BR_Pathology_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A277BR_Pathology_Diag_Loc=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_ORGAN",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_ORGAN", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_diag_organ,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_ORGAN",gxz:"Z278BR_Pathology_Diag_Organ",gxold:"O278BR_Pathology_Diag_Organ",gxvar:"A278BR_Pathology_Diag_Organ",ucs:[],op:[37],ip:[37],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A278BR_Pathology_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z278BR_Pathology_Diag_Organ=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_ORGAN",gx.O.A278BR_Pathology_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.A278BR_Pathology_Diag_Organ=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORTYPE",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORTYPE", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORTYPE",gxz:"Z279BR_Pathology_Diag_TumorType",gxold:"O279BR_Pathology_Diag_TumorType",gxvar:"A279BR_Pathology_Diag_TumorType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A279BR_Pathology_Diag_TumorType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z279BR_Pathology_Diag_TumorType=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE",gx.O.A279BR_Pathology_Diag_TumorType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A279BR_Pathology_Diag_TumorType=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORTYPE")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORSTAGE",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORSTAGE", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORSTAGE",gxz:"Z280BR_Pathology_Diag_TumorStage",gxold:"O280BR_Pathology_Diag_TumorStage",gxvar:"A280BR_Pathology_Diag_TumorStage",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A280BR_Pathology_Diag_TumorStage=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z280BR_Pathology_Diag_TumorStage=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE",gx.O.A280BR_Pathology_Diag_TumorStage,0)},c2v:function(){if(this.val()!==undefined)gx.O.A280BR_Pathology_Diag_TumorStage=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORSTAGE")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORGRADE",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORGRADE", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_TUMORGRADE",gxz:"Z281BR_Pathology_Diag_TumorGrade",gxold:"O281BR_Pathology_Diag_TumorGrade",gxvar:"A281BR_Pathology_Diag_TumorGrade",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A281BR_Pathology_Diag_TumorGrade=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z281BR_Pathology_Diag_TumorGrade=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE",gx.O.A281BR_Pathology_Diag_TumorGrade,0)},c2v:function(){if(this.val()!==undefined)gx.O.A281BR_Pathology_Diag_TumorGrade=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_TUMORGRADE")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[76]={ id:76 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_diagid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAGID",gxz:"Z276BR_Pathology_DiagID",gxold:"O276BR_Pathology_DiagID",gxvar:"A276BR_Pathology_DiagID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A276BR_Pathology_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z276BR_Pathology_DiagID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAGID",gx.O.A276BR_Pathology_DiagID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A276BR_Pathology_DiagID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_DIAGID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 76 , function() {
   });
   GXValidFnc[77]={ id:77 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[77],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID",gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_PathologyID))}};
   this.declareDomainHdlr( 77 , function() {
   });
   this.A277BR_Pathology_Diag_Loc = "" ;
   this.Z277BR_Pathology_Diag_Loc = "" ;
   this.O277BR_Pathology_Diag_Loc = "" ;
   this.A278BR_Pathology_Diag_Organ = "" ;
   this.Z278BR_Pathology_Diag_Organ = "" ;
   this.O278BR_Pathology_Diag_Organ = "" ;
   this.A279BR_Pathology_Diag_TumorType = "" ;
   this.Z279BR_Pathology_Diag_TumorType = "" ;
   this.O279BR_Pathology_Diag_TumorType = "" ;
   this.A280BR_Pathology_Diag_TumorStage = "" ;
   this.Z280BR_Pathology_Diag_TumorStage = "" ;
   this.O280BR_Pathology_Diag_TumorStage = "" ;
   this.A281BR_Pathology_Diag_TumorGrade = "" ;
   this.Z281BR_Pathology_Diag_TumorGrade = "" ;
   this.O281BR_Pathology_Diag_TumorGrade = "" ;
   this.A276BR_Pathology_DiagID = 0 ;
   this.Z276BR_Pathology_DiagID = 0 ;
   this.O276BR_Pathology_DiagID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV16Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV17GXV1 = 0 ;
   this.AV13Insert_BR_PathologyID = 0 ;
   this.AV15TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_Pathology_DiagID = 0 ;
   this.AV12WebSession = {} ;
   this.A276BR_Pathology_DiagID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.A277BR_Pathology_Diag_Loc = "" ;
   this.A278BR_Pathology_Diag_Organ = "" ;
   this.A279BR_Pathology_Diag_TumorType = "" ;
   this.A280BR_Pathology_Diag_TumorStage = "" ;
   this.A281BR_Pathology_Diag_TumorGrade = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120x2_client": ["AFTER TRN", true] ,"e130x34_client": ["ENTER", true] ,"e140x34_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV17GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_DIAGID","Visible")',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Visible")',ctrl:'BR_PATHOLOGYID',prop:'Visible'},{av:'AV15TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_Pathology_DiagID", "vBR_PATHOLOGY_DIAGID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_PathologyID", "vINSERT_BR_PATHOLOGYID", 0, "int", 18, 0);
   this.setVCMap("AV16Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_pathology_diag);
