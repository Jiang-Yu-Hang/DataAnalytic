/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:16.91
*/
gx.evt.autoSkip = false;
gx.define('br_medicalimaging_diag', false, function () {
   this.ServerClass =  "br_medicalimaging_diag" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_MedicalImaging_DiagID=gx.fn.getIntegerValue("vBR_MEDICALIMAGING_DIAGID",',') ;
      this.AV13Insert_BR_MedicalImagingID=gx.fn.getIntegerValue("vINSERT_BR_MEDICALIMAGINGID",',') ;
      this.AV15Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_medicalimaging_diagid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_DIAGID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medicalimaging_diag_no=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_DIAG_NO");
         this.AnyError  = 0;
         if ( ((0==this.A517BR_MedicalImaging_Diag_No)) )
         {
            try {
               gxballoon.setError("搴忓彿鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medicalimaging_diag_loc=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICALIMAGING_DIAG_LOC");
         this.AnyError  = 0;
         if ( ((''==this.A271BR_MedicalImaging_Diag_Loc)) )
         {
            try {
               gxballoon.setError("璇婃柇鎰忚(閮ㄤ綅)鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medicalimagingid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_medicalimagingid",["gx.num.urlDecimal(gx.O.A225BR_MedicalImagingID,\',\',\'.\')"],[]);
      return true;
   }
   this.e120s2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130s29_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140s29_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69];
   this.GXLastCtrlId =69;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "褰卞儚瀛﹁瘖鏂剰瑙?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_NO",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_MEDICALIMAGING_DIAG_NO", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_diag_no,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_NO",gxz:"Z517BR_MedicalImaging_Diag_No",gxold:"O517BR_MedicalImaging_Diag_No",gxvar:"A517BR_MedicalImaging_Diag_No",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A517BR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z517BR_MedicalImaging_Diag_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_NO",gx.O.A517BR_MedicalImaging_Diag_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A517BR_MedicalImaging_Diag_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_DIAG_NO",',')},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_LOC",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"TEXTBLOCKBR_MEDICALIMAGING_DIAG_LOC", format:0,grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_diag_loc,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_LOC",gxz:"Z271BR_MedicalImaging_Diag_Loc",gxold:"O271BR_MedicalImaging_Diag_Loc",gxvar:"A271BR_MedicalImaging_Diag_Loc",ucs:[],op:[38],ip:[38],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A271BR_MedicalImaging_Diag_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z271BR_MedicalImaging_Diag_Loc=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_LOC",gx.O.A271BR_MedicalImaging_Diag_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A271BR_MedicalImaging_Diag_Loc=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_ORGAN",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_MEDICALIMAGING_DIAG_ORGAN", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_ORGAN",gxz:"Z272BR_MedicalImaging_Diag_Organ",gxold:"O272BR_MedicalImaging_Diag_Organ",gxvar:"A272BR_MedicalImaging_Diag_Organ",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A272BR_MedicalImaging_Diag_Organ=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z272BR_MedicalImaging_Diag_Organ=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_ORGAN",gx.O.A272BR_MedicalImaging_Diag_Organ,0)},c2v:function(){if(this.val()!==undefined)gx.O.A272BR_MedicalImaging_Diag_Organ=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_DIS",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"TEXTBLOCKBR_MEDICALIMAGING_DIAG_DIS", format:0,grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_DIS",gxz:"Z273BR_MedicalImaging_Diag_Dis",gxold:"O273BR_MedicalImaging_Diag_Dis",gxvar:"A273BR_MedicalImaging_Diag_Dis",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A273BR_MedicalImaging_Diag_Dis=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z273BR_MedicalImaging_Diag_Dis=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_DIS",gx.O.A273BR_MedicalImaging_Diag_Dis,0)},c2v:function(){if(this.val()!==undefined)gx.O.A273BR_MedicalImaging_Diag_Dis=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_DIS")},nac:gx.falseFn};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimaging_diagid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAGID",gxz:"Z270BR_MedicalImaging_DiagID",gxold:"O270BR_MedicalImaging_DiagID",gxvar:"A270BR_MedicalImaging_DiagID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A270BR_MedicalImaging_DiagID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z270BR_MedicalImaging_DiagID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAGID",gx.O.A270BR_MedicalImaging_DiagID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A270BR_MedicalImaging_DiagID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_DIAGID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 68 , function() {
   });
   GXValidFnc[69]={ id:69 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medicalimagingid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGINGID",gxz:"Z225BR_MedicalImagingID",gxold:"O225BR_MedicalImagingID",gxvar:"A225BR_MedicalImagingID",ucs:[],op:[],ip:[69],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z225BR_MedicalImagingID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGINGID",gx.O.A225BR_MedicalImagingID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGINGID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_MedicalImagingID))}};
   this.declareDomainHdlr( 69 , function() {
   });
   this.A517BR_MedicalImaging_Diag_No = 0 ;
   this.Z517BR_MedicalImaging_Diag_No = 0 ;
   this.O517BR_MedicalImaging_Diag_No = 0 ;
   this.A271BR_MedicalImaging_Diag_Loc = "" ;
   this.Z271BR_MedicalImaging_Diag_Loc = "" ;
   this.O271BR_MedicalImaging_Diag_Loc = "" ;
   this.A272BR_MedicalImaging_Diag_Organ = "" ;
   this.Z272BR_MedicalImaging_Diag_Organ = "" ;
   this.O272BR_MedicalImaging_Diag_Organ = "" ;
   this.A273BR_MedicalImaging_Diag_Dis = "" ;
   this.Z273BR_MedicalImaging_Diag_Dis = "" ;
   this.O273BR_MedicalImaging_Diag_Dis = "" ;
   this.A270BR_MedicalImaging_DiagID = 0 ;
   this.Z270BR_MedicalImaging_DiagID = 0 ;
   this.O270BR_MedicalImaging_DiagID = 0 ;
   this.A225BR_MedicalImagingID = 0 ;
   this.Z225BR_MedicalImagingID = 0 ;
   this.O225BR_MedicalImagingID = 0 ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV15Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV16GXV1 = 0 ;
   this.AV13Insert_BR_MedicalImagingID = 0 ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_MedicalImaging_DiagID = 0 ;
   this.AV12WebSession = {} ;
   this.A270BR_MedicalImaging_DiagID = 0 ;
   this.A225BR_MedicalImagingID = 0 ;
   this.A271BR_MedicalImaging_Diag_Loc = "" ;
   this.A272BR_MedicalImaging_Diag_Organ = "" ;
   this.A273BR_MedicalImaging_Diag_Dis = "" ;
   this.A517BR_MedicalImaging_Diag_No = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e120s2_client": ["AFTER TRN", true] ,"e130s29_client": ["ENTER", true] ,"e140s29_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImaging_DiagID',fld:'vBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImaging_DiagID',fld:'vBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_MedicalImagingID',fld:'vINSERT_BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV16GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_MedicalImagingID',fld:'vINSERT_BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_DIAGID","Visible")',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGINGID","Visible")',ctrl:'BR_MEDICALIMAGINGID',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_MedicalImaging_DiagID", "vBR_MEDICALIMAGING_DIAGID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_MedicalImagingID", "vINSERT_BR_MEDICALIMAGINGID", 0, "int", 18, 0);
   this.setVCMap("AV15Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_medicalimaging_diag);
