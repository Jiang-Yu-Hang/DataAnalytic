/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:24.5
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secchangepassword', false, function () {
   this.ServerClass =  "wwpbaseobjects.secchangepassword" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV10WWPContext=gx.fn.getControlValue("vWWPCONTEXT") ;
      this.A14SecUserName=gx.fn.getControlValue("SECUSERNAME") ;
      this.A15SecUserPassword=gx.fn.getControlValue("SECUSERPASSWORD") ;
      this.A6SecUserId=gx.fn.getIntegerValue("SECUSERID",',') ;
      this.AV20BCSecUser=gx.fn.getControlValue("vBCSECUSER") ;
   };
   this.e13112_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e15111_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47];
   this.GXLastCtrlId =47;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "瀵嗙爜淇敼", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERNAME",gxz:"ZV6UserName",gxold:"OV6UserName",gxvar:"AV6UserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV6UserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV6UserName=Value},v2c:function(){gx.fn.setControlValue("vUSERNAME",gx.O.AV6UserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV6UserName=this.val()},val:function(){return gx.fn.getControlValue("vUSERNAME")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORD",gxz:"ZV7UserPassword",gxold:"OV7UserPassword",gxvar:"AV7UserPassword",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV7UserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV7UserPassword=Value},v2c:function(){gx.fn.setControlValue("vUSERPASSWORD",gx.O.AV7UserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV7UserPassword=this.val()},val:function(){return gx.fn.getControlValue("vUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORDNEW",gxz:"ZV8UserPasswordNew",gxold:"OV8UserPasswordNew",gxvar:"AV8UserPasswordNew",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV8UserPasswordNew=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV8UserPasswordNew=Value},v2c:function(){gx.fn.setControlValue("vUSERPASSWORDNEW",gx.O.AV8UserPasswordNew,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV8UserPasswordNew=this.val()},val:function(){return gx.fn.getControlValue("vUSERPASSWORDNEW")},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUSERPASSWORDNEWCONF",gxz:"ZV9UserPasswordNewConf",gxold:"OV9UserPasswordNewConf",gxvar:"AV9UserPasswordNewConf",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV9UserPasswordNewConf=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV9UserPasswordNewConf=Value},v2c:function(){gx.fn.setControlValue("vUSERPASSWORDNEWCONF",gx.O.AV9UserPasswordNewConf,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV9UserPasswordNewConf=this.val()},val:function(){return gx.fn.getControlValue("vUSERPASSWORDNEWCONF")},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTNENTER",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"BTNCANCEL",grid:0};
   this.AV6UserName = "" ;
   this.ZV6UserName = "" ;
   this.OV6UserName = "" ;
   this.AV7UserPassword = "" ;
   this.ZV7UserPassword = "" ;
   this.OV7UserPassword = "" ;
   this.AV8UserPasswordNew = "" ;
   this.ZV8UserPasswordNew = "" ;
   this.OV8UserPasswordNew = "" ;
   this.AV9UserPasswordNewConf = "" ;
   this.ZV9UserPasswordNewConf = "" ;
   this.OV9UserPasswordNewConf = "" ;
   this.AV6UserName = "" ;
   this.AV7UserPassword = "" ;
   this.AV8UserPasswordNew = "" ;
   this.AV9UserPasswordNewConf = "" ;
   this.A14SecUserName = "" ;
   this.A15SecUserPassword = "" ;
   this.A6SecUserId = 0 ;
   this.AV10WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV20BCSecUser = {SecUserId:0,SecUserName:"",SecUserPassword:"",SecUserCrtUser:"",SecUserUpdUser:"",SecUserCrtDate:gx.date.nullDate(),SecUserUpdDate:gx.date.nullDate(),SecUserWorkload:0,Mode:"",Initialized:0,SecUserId_Z:0,SecUserName_Z:"",SecUserPassword_Z:"",SecUserCrtUser_Z:"",SecUserUpdUser_Z:"",SecUserCrtDate_Z:gx.date.nullDate(),SecUserUpdDate_Z:gx.date.nullDate(),SecUserWorkload_Z:0} ;
   this.Events = {"e13112_client": ["ENTER", true] ,"e15111_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV10WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV6UserName',fld:'vUSERNAME',pic:'',hsh:true}],[{av:'AV6UserName',fld:'vUSERNAME',pic:'',hsh:true}]];
   this.EvtParms["START"] = [[{av:'AV24Pgmname',fld:'vPGMNAME',pic:''}],[{ctrl:'FORM',prop:'Backcolor'},{av:'AV10WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV20BCSecUser',fld:'vBCSECUSER',pic:''},{av:'AV6UserName',fld:'vUSERNAME',pic:'',hsh:true},{av:'AV7UserPassword',fld:'vUSERPASSWORD',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'A14SecUserName',fld:'SECUSERNAME',pic:''},{av:'AV6UserName',fld:'vUSERNAME',pic:'',hsh:true},{av:'A15SecUserPassword',fld:'SECUSERPASSWORD',pic:''},{av:'AV7UserPassword',fld:'vUSERPASSWORD',pic:''},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'AV8UserPasswordNew',fld:'vUSERPASSWORDNEW',pic:''},{av:'AV9UserPasswordNewConf',fld:'vUSERPASSWORDNEWCONF',pic:''},{av:'AV20BCSecUser',fld:'vBCSECUSER',pic:''}],[{av:'AV20BCSecUser',fld:'vBCSECUSER',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10WWPContext", "vWWPCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("A14SecUserName", "SECUSERNAME", 0, "svchar", 100, 0);
   this.setVCMap("A15SecUserPassword", "SECUSERPASSWORD", 0, "svchar", 100, 0);
   this.setVCMap("A6SecUserId", "SECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV20BCSecUser", "vBCSECUSER", 0, "WWPBaseObjects\SecUser", 0, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secchangepassword);
