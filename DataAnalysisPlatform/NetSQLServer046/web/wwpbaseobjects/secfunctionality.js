/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:24.78
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secfunctionality', false, function () {
   this.ServerClass =  "wwpbaseobjects.secfunctionality" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7SecFunctionalityId=gx.fn.getIntegerValue("vSECFUNCTIONALITYID",',') ;
      this.AV12Insert_SecParentFunctionalityId=gx.fn.getIntegerValue("vINSERT_SECPARENTFUNCTIONALITYID",',') ;
      this.AV19Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV10TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Secfunctionalityid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECFUNCTIONALITYID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Secfunctionalitykey=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Secfunctionalitykey",["gx.O.A3SecFunctionalityKey", "gx.O.A1SecFunctionalityId"],[]);
      return true;
   }
   this.Valid_Secparentfunctionalityid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Secparentfunctionalityid",["gx.O.A2SecParentFunctionalityId", "gx.O.A11SecParentFunctionalityDescription"],["A11SecParentFunctionalityDescription"]);
      return true;
   }
   this.e12012_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e13011_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14011_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];
   this.GXLastCtrlId =43;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鏉冮檺", "str");
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
   GXValidFnc[22]={ id:22 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secfunctionalitykey,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[39,22],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYKEY",gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("SECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYDESCRIPTION",gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("SECFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Secfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYID",gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECFUNCTIONALITYID",',')},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("SECFUNCTIONALITYTYPE",gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECFUNCTIONALITYTYPE",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 40 , function() {
   });
   GXValidFnc[41]={ id:41 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secparentfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYID",gxz:"Z2SecParentFunctionalityId",gxold:"O2SecParentFunctionalityId",gxvar:"A2SecParentFunctionalityId",ucs:[],op:[42],ip:[42,41],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2SecParentFunctionalityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECPARENTFUNCTIONALITYID",gx.O.A2SecParentFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECPARENTFUNCTIONALITYID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV12Insert_SecParentFunctionalityId))}};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("SECPARENTFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYACTIVE",gxz:"Z7SecFunctionalityActive",gxold:"O7SecFunctionalityActive",gxvar:"A7SecFunctionalityActive",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z7SecFunctionalityActive=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYACTIVE",gx.O.A7SecFunctionalityActive,0)},c2v:function(){if(this.val()!==undefined)gx.O.A7SecFunctionalityActive=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("SECFUNCTIONALITYACTIVE")},nac:gx.falseFn};
   this.A3SecFunctionalityKey = "" ;
   this.Z3SecFunctionalityKey = "" ;
   this.O3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.Z8SecFunctionalityDescription = "" ;
   this.O8SecFunctionalityDescription = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.Z1SecFunctionalityId = 0 ;
   this.O1SecFunctionalityId = 0 ;
   this.A9SecFunctionalityType = 0 ;
   this.Z9SecFunctionalityType = 0 ;
   this.O9SecFunctionalityType = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.Z2SecParentFunctionalityId = 0 ;
   this.O2SecParentFunctionalityId = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.Z11SecParentFunctionalityDescription = "" ;
   this.O11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.Z7SecFunctionalityActive = false ;
   this.O7SecFunctionalityActive = false ;
   this.AV18WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV10TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV20GXV1 = 0 ;
   this.AV12Insert_SecParentFunctionalityId = 0 ;
   this.AV13TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7SecFunctionalityId = 0 ;
   this.AV11WebSession = {} ;
   this.A1SecFunctionalityId = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.AV19Pgmname = "" ;
   this.A3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.A9SecFunctionalityType = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.Gx_mode = "" ;
   this.Events = {"e12012_client": ["AFTER TRN", true] ,"e13011_client": ["ENTER", true] ,"e14011_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV12Insert_SecParentFunctionalityId',fld:'vINSERT_SECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{ctrl:'SECFUNCTIONALITYTYPE'},{av:'A9SecFunctionalityType',fld:'SECFUNCTIONALITYTYPE',pic:'Z9'}],[]];
   this.EvtParms["START"] = [[{av:'AV19Pgmname',fld:'vPGMNAME',pic:''},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true}],[{av:'AV18WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV20GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV13TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV12Insert_SecParentFunctionalityId',fld:'vINSERT_SECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYID","Visible")',ctrl:'SECFUNCTIONALITYID',prop:'Visible'},{ctrl:'SECFUNCTIONALITYTYPE'},{av:'gx.fn.getCtrlProperty("SECPARENTFUNCTIONALITYID","Visible")',ctrl:'SECPARENTFUNCTIONALITYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECPARENTFUNCTIONALITYDESCRIPTION","Visible")',ctrl:'SECPARENTFUNCTIONALITYDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYACTIVE","Visible")',ctrl:'SECFUNCTIONALITYACTIVE',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7SecFunctionalityId", "vSECFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV12Insert_SecParentFunctionalityId", "vINSERT_SECPARENTFUNCTIONALITYID", 0, "int", 10, 0);
   this.setVCMap("AV19Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV10TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secfunctionality);
