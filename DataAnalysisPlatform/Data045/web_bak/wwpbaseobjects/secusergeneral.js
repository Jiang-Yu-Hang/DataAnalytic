/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:9.87
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secusergeneral', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secusergeneral" ;
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
   this.Valid_Secuserid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECUSERID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e130z2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140z2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27];
   this.GXLastCtrlId =27;
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
   GXValidFnc[12]={ id: 12, fld:"UNNAMEDTABLESECUSERNAME",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"TEXTBLOCKSECUSERNAME", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(){gx.fn.setControlValue("SECUSERNAME",gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(){return gx.fn.getControlValue("SECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[22]={ id:22 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECUSERID",gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECUSERID",',')},nac:gx.falseFn};
   GXValidFnc[23]={ id:23 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERPASSWORD",gxz:"Z15SecUserPassword",gxold:"O15SecUserPassword",gxvar:"A15SecUserPassword",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A15SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15SecUserPassword=Value},v2c:function(){gx.fn.setControlValue("SECUSERPASSWORD",gx.O.A15SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.A15SecUserPassword=this.val()},val:function(){return gx.fn.getControlValue("SECUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[24]={ id:24 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTUSER",gxz:"Z178SecUserCrtUser",gxold:"O178SecUserCrtUser",gxvar:"A178SecUserCrtUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A178SecUserCrtUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z178SecUserCrtUser=Value},v2c:function(){gx.fn.setControlValue("SECUSERCRTUSER",gx.O.A178SecUserCrtUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A178SecUserCrtUser=this.val()},val:function(){return gx.fn.getControlValue("SECUSERCRTUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 24 , function() {
   });
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDUSER",gxz:"Z179SecUserUpdUser",gxold:"O179SecUserUpdUser",gxvar:"A179SecUserUpdUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A179SecUserUpdUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z179SecUserUpdUser=Value},v2c:function(){gx.fn.setControlValue("SECUSERUPDUSER",gx.O.A179SecUserUpdUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A179SecUserUpdUser=this.val()},val:function(){return gx.fn.getControlValue("SECUSERUPDUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 25 , function() {
   });
   GXValidFnc[26]={ id:26 ,lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTDATE",gxz:"Z180SecUserCrtDate",gxold:"O180SecUserCrtDate",gxvar:"A180SecUserCrtDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("SECUSERCRTDATE",gx.O.A180SecUserCrtDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("SECUSERCRTDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 26 , function() {
   });
   GXValidFnc[27]={ id:27 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDDATE",gxz:"Z181SecUserUpdDate",gxold:"O181SecUserUpdDate",gxvar:"A181SecUserUpdDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("SECUSERUPDDATE",gx.O.A181SecUserUpdDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("SECUSERUPDDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 27 , function() {
   });
   this.A14SecUserName = "" ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.A6SecUserId = 0 ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.A15SecUserPassword = "" ;
   this.Z15SecUserPassword = "" ;
   this.O15SecUserPassword = "" ;
   this.A178SecUserCrtUser = "" ;
   this.Z178SecUserCrtUser = "" ;
   this.O178SecUserCrtUser = "" ;
   this.A179SecUserUpdUser = "" ;
   this.Z179SecUserUpdUser = "" ;
   this.O179SecUserUpdUser = "" ;
   this.A180SecUserCrtDate = gx.date.nullDate() ;
   this.Z180SecUserCrtDate = gx.date.nullDate() ;
   this.O180SecUserCrtDate = gx.date.nullDate() ;
   this.A181SecUserUpdDate = gx.date.nullDate() ;
   this.Z181SecUserUpdDate = gx.date.nullDate() ;
   this.O181SecUserUpdDate = gx.date.nullDate() ;
   this.A14SecUserName = "" ;
   this.A6SecUserId = 0 ;
   this.A15SecUserPassword = "" ;
   this.A178SecUserCrtUser = "" ;
   this.A179SecUserUpdUser = "" ;
   this.A180SecUserCrtDate = gx.date.nullDate() ;
   this.A181SecUserUpdDate = gx.date.nullDate() ;
   this.Events = {"e130z2_client": ["ENTER", true] ,"e140z2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'AV19Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'}],[]];
   this.EvtParms["LOAD"] = [[],[{av:'gx.fn.getCtrlProperty("SECUSERID","Visible")',ctrl:'SECUSERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERPASSWORD","Visible")',ctrl:'SECUSERPASSWORD',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERCRTUSER","Visible")',ctrl:'SECUSERCRTUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERUPDUSER","Visible")',ctrl:'SECUSERUPDUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERCRTDATE","Visible")',ctrl:'SECUSERCRTDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERUPDDATE","Visible")',ctrl:'SECUSERUPDDATE',prop:'Visible'}]];
   this.Initialize( );
});
