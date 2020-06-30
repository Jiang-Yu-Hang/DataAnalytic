/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:57:52.83
*/
gx.evt.autoSkip = false;
gx.define('br_procedure_radio', false, function () {
   this.ServerClass =  "br_procedure_radio" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_Procedure_RadioID=gx.fn.getIntegerValue("vBR_PROCEDURE_RADIOID",',') ;
      this.AV13Insert_BR_ProcedureID=gx.fn.getIntegerValue("vINSERT_BR_PROCEDUREID",',') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_procedure_radioid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_RADIOID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_procedure_radio_loc=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_RADIO_LOC");
         this.AnyError  = 0;
         if ( ((''==this.A324BR_Procedure_Radio_Loc)) )
         {
            try {
               gxballoon.setError("鏀剧枟閮ㄤ綅鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_procedureid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_procedureid",["gx.num.urlDecimal(gx.O.A139BR_ProcedureID,\',\',\'.\')"],[]);
      return true;
   }
   this.e12112_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e131138_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e141138_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51];
   this.GXLastCtrlId =51;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鏀剧枟淇℃伅", "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PROCEDURE_RADIO_LOC",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PROCEDURE_RADIO_LOC", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_radio_loc,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_LOC",gxz:"Z324BR_Procedure_Radio_Loc",gxold:"O324BR_Procedure_Radio_Loc",gxvar:"A324BR_Procedure_Radio_Loc",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A324BR_Procedure_Radio_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z324BR_Procedure_Radio_Loc=Value},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIO_LOC",gx.O.A324BR_Procedure_Radio_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A324BR_Procedure_Radio_Loc=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_RADIO_LOC")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PROCEDURE_RADIO_AMOUNT",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PROCEDURE_RADIO_AMOUNT", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIO_AMOUNT",gxz:"Z325BR_Procedure_Radio_Amount",gxold:"O325BR_Procedure_Radio_Amount",gxvar:"A325BR_Procedure_Radio_Amount",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A325BR_Procedure_Radio_Amount=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z325BR_Procedure_Radio_Amount=Value},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIO_AMOUNT",gx.O.A325BR_Procedure_Radio_Amount,0)},c2v:function(){if(this.val()!==undefined)gx.O.A325BR_Procedure_Radio_Amount=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_RADIO_AMOUNT")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_radioid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_RADIOID",gxz:"Z323BR_Procedure_RadioID",gxold:"O323BR_Procedure_RadioID",gxvar:"A323BR_Procedure_RadioID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A323BR_Procedure_RadioID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z323BR_Procedure_RadioID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_RADIOID",gx.O.A323BR_Procedure_RadioID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A323BR_Procedure_RadioID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_RADIOID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[51]={ id:51 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_procedureid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[51],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDUREID",gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDUREID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_ProcedureID))}};
   this.declareDomainHdlr( 51 , function() {
   });
   this.A324BR_Procedure_Radio_Loc = "" ;
   this.Z324BR_Procedure_Radio_Loc = "" ;
   this.O324BR_Procedure_Radio_Loc = "" ;
   this.A325BR_Procedure_Radio_Amount = "" ;
   this.Z325BR_Procedure_Radio_Amount = "" ;
   this.O325BR_Procedure_Radio_Amount = "" ;
   this.A323BR_Procedure_RadioID = 0 ;
   this.Z323BR_Procedure_RadioID = 0 ;
   this.O323BR_Procedure_RadioID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV16Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV17GXV1 = 0 ;
   this.AV13Insert_BR_ProcedureID = 0 ;
   this.AV15TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_Procedure_RadioID = 0 ;
   this.AV12WebSession = {} ;
   this.A323BR_Procedure_RadioID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.A324BR_Procedure_Radio_Loc = "" ;
   this.A325BR_Procedure_Radio_Amount = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e12112_client": ["AFTER TRN", true] ,"e131138_client": ["ENTER", true] ,"e141138_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Procedure_RadioID',fld:'vBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Procedure_RadioID',fld:'vBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_ProcedureID',fld:'vINSERT_BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV17GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_ProcedureID',fld:'vINSERT_BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_RADIOID","Visible")',ctrl:'BR_PROCEDURE_RADIOID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Visible")',ctrl:'BR_PROCEDUREID',prop:'Visible'},{av:'AV15TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_Procedure_RadioID", "vBR_PROCEDURE_RADIOID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_ProcedureID", "vINSERT_BR_PROCEDUREID", 0, "int", 18, 0);
   this.setVCMap("AV16Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_procedure_radio);
