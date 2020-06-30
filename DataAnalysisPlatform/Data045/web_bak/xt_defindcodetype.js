/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:10.56
*/
gx.evt.autoSkip = false;
gx.define('xt_defindcodetype', false, function () {
   this.ServerClass =  "xt_defindcodetype" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7XT_DefindcodeTypeID=gx.fn.getIntegerValue("vXT_DEFINDCODETYPEID",',') ;
      this.A511XT_DefindcodeTypeIsShow=gx.fn.getIntegerValue("XT_DEFINDCODETYPEISSHOW",',') ;
      this.AV15Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV14Pgmdesc=gx.fn.getControlValue("vPGMDESC") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Xt_defindcodetypeid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("XT_DEFINDCODETYPEID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Xt_defindcodetypename=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("XT_DEFINDCODETYPENAME");
         this.AnyError  = 0;
         if ( ((''==this.A166XT_DefindcodeTypeName)) )
         {
            try {
               gxballoon.setError("鏁版嵁瀛楀吀绫诲瀷鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.e120m2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130m23_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140m23_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38];
   this.GXLastCtrlId =38;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鏁版嵁瀛楀吀绫诲瀷", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Xt_defindcodetypename,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPENAME",gxz:"Z166XT_DefindcodeTypeName",gxold:"O166XT_DefindcodeTypeName",gxvar:"A166XT_DefindcodeTypeName",ucs:[],op:[25],ip:[25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A166XT_DefindcodeTypeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z166XT_DefindcodeTypeName=Value},v2c:function(){gx.fn.setControlValue("XT_DEFINDCODETYPENAME",gx.O.A166XT_DefindcodeTypeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A166XT_DefindcodeTypeName=this.val()},val:function(){return gx.fn.getControlValue("XT_DEFINDCODETYPENAME")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Xt_defindcodetypeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPEID",gxz:"Z165XT_DefindcodeTypeID",gxold:"O165XT_DefindcodeTypeID",gxvar:"A165XT_DefindcodeTypeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z165XT_DefindcodeTypeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("XT_DEFINDCODETYPEID",gx.O.A165XT_DefindcodeTypeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("XT_DEFINDCODETYPEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 38 , function() {
   });
   this.A166XT_DefindcodeTypeName = "" ;
   this.Z166XT_DefindcodeTypeName = "" ;
   this.O166XT_DefindcodeTypeName = "" ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.Z165XT_DefindcodeTypeID = 0 ;
   this.O165XT_DefindcodeTypeID = 0 ;
   this.AV14Pgmdesc = "" ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV15Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV7XT_DefindcodeTypeID = 0 ;
   this.AV12WebSession = {} ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.A166XT_DefindcodeTypeName = "" ;
   this.A511XT_DefindcodeTypeIsShow = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e120m2_client": ["AFTER TRN", true] ,"e130m23_client": ["ENTER", true] ,"e140m23_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A165XT_DefindcodeTypeID',fld:'XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A511XT_DefindcodeTypeIsShow',fld:'XT_DEFINDCODETYPEISSHOW',pic:'ZZZ9'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV14Pgmdesc',fld:'vPGMDESC',pic:''},{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPEID","Visible")',ctrl:'XT_DEFINDCODETYPEID',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7XT_DefindcodeTypeID", "vXT_DEFINDCODETYPEID", 0, "int", 18, 0);
   this.setVCMap("A511XT_DefindcodeTypeIsShow", "XT_DEFINDCODETYPEISSHOW", 0, "int", 4, 0);
   this.setVCMap("AV15Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV14Pgmdesc", "vPGMDESC", 0, "char", 30, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(xt_defindcodetype);
