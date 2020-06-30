/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:6:25.84
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secuser', false, function () {
   this.ServerClass =  "wwpbaseobjects.secuser" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.A194SecUserWorkload=gx.fn.getIntegerValue("SECUSERWORKLOAD",',') ;
      this.AV17Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
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
   this.Valid_Secusername=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECUSERNAME");
         this.AnyError  = 0;
         if ( ((''==this.A14SecUserName)) )
         {
            try {
               gxballoon.setError("姓名是必须填写的。");
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
   this.Validv_Secuserpassword=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vSECUSERPASSWORD");
         this.AnyError  = 0;
         if ( ((''==this.AV16SecUserPassword)) )
         {
            try {
               gxballoon.setError("密码是必须填写的。");
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
   this.Valid_Secusercrtdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECUSERCRTDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A180SecUserCrtDate)==0) || new gx.date.gxdate( this.A180SecUserCrtDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("域创建时间超界");
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
   this.Valid_Secuserupddate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("SECUSERUPDDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A181SecUserUpdDate)==0) || new gx.date.gxdate( this.A181SecUserUpdDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("域更新时间超界");
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
   this.e12052_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e13056_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14056_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53];
   this.GXLastCtrlId =53;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "用户信息", "str");
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
   GXValidFnc[20]={ id: 20, fld:"UNNAMEDTABLESECUSERNAME",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TEXTBLOCKSECUSERNAME", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secusername,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[26],ip:[26],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(){gx.fn.setControlValue("SECUSERNAME",gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(){return gx.fn.getControlValue("SECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"UNNAMEDTABLEVSECUSERPASSWORD",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"TEXTBLOCKVSECUSERPASSWORD", format:0,grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Secuserpassword,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERPASSWORD",gxz:"ZV16SecUserPassword",gxold:"OV16SecUserPassword",gxvar:"AV16SecUserPassword",ucs:[],op:[35],ip:[35],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16SecUserPassword=Value},v2c:function(){gx.fn.setControlValue("vSECUSERPASSWORD",gx.O.AV16SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16SecUserPassword=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECUSERID",gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECUSERID",',')},nac:gx.falseFn};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERPASSWORD",gxz:"Z15SecUserPassword",gxold:"O15SecUserPassword",gxvar:"A15SecUserPassword",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A15SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z15SecUserPassword=Value},v2c:function(){gx.fn.setControlValue("SECUSERPASSWORD",gx.O.A15SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.A15SecUserPassword=this.val()},val:function(){return gx.fn.getControlValue("SECUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTUSER",gxz:"Z178SecUserCrtUser",gxold:"O178SecUserCrtUser",gxvar:"A178SecUserCrtUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A178SecUserCrtUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z178SecUserCrtUser=Value},v2c:function(){gx.fn.setControlValue("SECUSERCRTUSER",gx.O.A178SecUserCrtUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A178SecUserCrtUser=this.val()},val:function(){return gx.fn.getControlValue("SECUSERCRTUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDUSER",gxz:"Z179SecUserUpdUser",gxold:"O179SecUserUpdUser",gxvar:"A179SecUserUpdUser",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A179SecUserUpdUser=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z179SecUserUpdUser=Value},v2c:function(){gx.fn.setControlValue("SECUSERUPDUSER",gx.O.A179SecUserUpdUser,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A179SecUserUpdUser=this.val()},val:function(){return gx.fn.getControlValue("SECUSERUPDUSER")},nac:gx.falseFn};
   this.declareDomainHdlr( 51 , function() {
   });
   GXValidFnc[52]={ id:52 ,lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secusercrtdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERCRTDATE",gxz:"Z180SecUserCrtDate",gxold:"O180SecUserCrtDate",gxvar:"A180SecUserCrtDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[52],ip:[52],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z180SecUserCrtDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("SECUSERCRTDATE",gx.O.A180SecUserCrtDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A180SecUserCrtDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("SECUSERCRTDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 52 , function() {
   });
   GXValidFnc[53]={ id:53 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Secuserupddate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERUPDDATE",gxz:"Z181SecUserUpdDate",gxold:"O181SecUserUpdDate",gxvar:"A181SecUserUpdDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[53],ip:[53],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z181SecUserUpdDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("SECUSERUPDDATE",gx.O.A181SecUserUpdDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A181SecUserUpdDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("SECUSERUPDDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 53 , function() {
   });
   this.A14SecUserName = "" ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.AV16SecUserPassword = "" ;
   this.ZV16SecUserPassword = "" ;
   this.OV16SecUserPassword = "" ;
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
   this.AV15WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV17Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV7SecUserId = 0 ;
   this.AV12WebSession = {} ;
   this.A6SecUserId = 0 ;
   this.AV16SecUserPassword = "" ;
   this.A178SecUserCrtUser = "" ;
   this.A180SecUserCrtDate = gx.date.nullDate() ;
   this.A14SecUserName = "" ;
   this.A15SecUserPassword = "" ;
   this.A179SecUserUpdUser = "" ;
   this.A181SecUserUpdDate = gx.date.nullDate() ;
   this.A194SecUserWorkload = 0 ;
   this.Gx_mode = "" ;
   this.Events = {"e12052_client": ["AFTER TRN", true] ,"e13056_client": ["ENTER", true] ,"e14056_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'A194SecUserWorkload',fld:'SECUSERWORKLOAD',pic:'ZZZZZZZZZ9'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV15WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'gx.fn.getCtrlProperty("SECUSERID","Visible")',ctrl:'SECUSERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERPASSWORD","Visible")',ctrl:'SECUSERPASSWORD',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERCRTUSER","Visible")',ctrl:'SECUSERCRTUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERUPDUSER","Visible")',ctrl:'SECUSERUPDUSER',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERCRTDATE","Visible")',ctrl:'SECUSERCRTDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERUPDDATE","Visible")',ctrl:'SECUSERUPDDATE',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("A194SecUserWorkload", "SECUSERWORKLOAD", 0, "int", 10, 0);
   this.setVCMap("AV17Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secuser);
