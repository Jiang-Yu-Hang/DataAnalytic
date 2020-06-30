/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:6:11.37
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secfunctionalitygeneral', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secfunctionalitygeneral" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
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
   this.Valid_Secparentfunctionalityid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECPARENTFUNCTIONALITYID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e110r1_client=function()
   {
      this.clearMessages();
      this.call("wwpbaseobjects.secfunctionality.aspx", ["UPD", this.A1SecFunctionalityId]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e120r1_client=function()
   {
      this.clearMessages();
      this.call("wwpbaseobjects.secfunctionality.aspx", ["DLT", this.A1SecFunctionalityId]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e150r2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e160r2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33];
   this.GXLastCtrlId =33;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLE",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id:14 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYKEY",gxz:"Z3SecFunctionalityKey",gxold:"O3SecFunctionalityKey",gxvar:"A3SecFunctionalityKey",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A3SecFunctionalityKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z3SecFunctionalityKey=Value},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYKEY",gx.O.A3SecFunctionalityKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A3SecFunctionalityKey=this.val()},val:function(){return gx.fn.getControlValue("SECFUNCTIONALITYKEY")},nac:gx.falseFn};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYDESCRIPTION",gxz:"Z8SecFunctionalityDescription",gxold:"O8SecFunctionalityDescription",gxvar:"A8SecFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A8SecFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z8SecFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYDESCRIPTION",gx.O.A8SecFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A8SecFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("SECFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"BTNUPDATE",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"BTNDELETE",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Secfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYID",gxz:"Z1SecFunctionalityId",gxold:"O1SecFunctionalityId",gxvar:"A1SecFunctionalityId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z1SecFunctionalityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECFUNCTIONALITYID",gx.O.A1SecFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A1SecFunctionalityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECFUNCTIONALITYID",',')},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"int",len:2,dec:0,sign:false,pic:"Z9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYTYPE",gxz:"Z9SecFunctionalityType",gxold:"O9SecFunctionalityType",gxvar:"A9SecFunctionalityType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z9SecFunctionalityType=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("SECFUNCTIONALITYTYPE",gx.O.A9SecFunctionalityType);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A9SecFunctionalityType=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECFUNCTIONALITYTYPE",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 30 , function() {
   });
   GXValidFnc[31]={ id:31 ,lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Secparentfunctionalityid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYID",gxz:"Z2SecParentFunctionalityId",gxold:"O2SecParentFunctionalityId",gxvar:"A2SecParentFunctionalityId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z2SecParentFunctionalityId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECPARENTFUNCTIONALITYID",gx.O.A2SecParentFunctionalityId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A2SecParentFunctionalityId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECPARENTFUNCTIONALITYID",',')},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECPARENTFUNCTIONALITYDESCRIPTION",gxz:"Z11SecParentFunctionalityDescription",gxold:"O11SecParentFunctionalityDescription",gxvar:"A11SecParentFunctionalityDescription",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A11SecParentFunctionalityDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z11SecParentFunctionalityDescription=Value},v2c:function(){gx.fn.setControlValue("SECPARENTFUNCTIONALITYDESCRIPTION",gx.O.A11SecParentFunctionalityDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A11SecParentFunctionalityDescription=this.val()},val:function(){return gx.fn.getControlValue("SECPARENTFUNCTIONALITYDESCRIPTION")},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECFUNCTIONALITYACTIVE",gxz:"Z7SecFunctionalityActive",gxold:"O7SecFunctionalityActive",gxvar:"A7SecFunctionalityActive",ucs:[],op:[],ip:[],
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
   this.A3SecFunctionalityKey = "" ;
   this.A8SecFunctionalityDescription = "" ;
   this.A1SecFunctionalityId = 0 ;
   this.A9SecFunctionalityType = 0 ;
   this.A2SecParentFunctionalityId = 0 ;
   this.A11SecParentFunctionalityDescription = "" ;
   this.A7SecFunctionalityActive = false ;
   this.Events = {"e150r2_client": ["ENTER", true] ,"e160r2_client": ["CANCEL", true] ,"e110r1_client": ["'DOUPDATE'", false] ,"e120r1_client": ["'DODELETE'", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'AV19Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[]];
   this.EvtParms["LOAD"] = [[],[{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYID","Visible")',ctrl:'SECFUNCTIONALITYID',prop:'Visible'},{ctrl:'SECFUNCTIONALITYTYPE'},{av:'gx.fn.getCtrlProperty("SECPARENTFUNCTIONALITYID","Visible")',ctrl:'SECPARENTFUNCTIONALITYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECPARENTFUNCTIONALITYDESCRIPTION","Visible")',ctrl:'SECPARENTFUNCTIONALITYDESCRIPTION',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECFUNCTIONALITYACTIVE","Visible")',ctrl:'SECFUNCTIONALITYACTIVE',prop:'Visible'},{ctrl:'BTNUPDATE',prop:'Visible'},{ctrl:'BTNDELETE',prop:'Visible'}]];
   this.EvtParms["'DOUPDATE'"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[]];
   this.EvtParms["'DODELETE'"] = [[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}],[]];
   this.Initialize( );
});
