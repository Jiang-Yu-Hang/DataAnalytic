/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:13.10
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secloginback', false, function () {
   this.ServerClass =  "wwpbaseobjects.secloginback" ;
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
      this.A364Account=gx.fn.getControlValue("ACCOUNT") ;
      this.A418PasswordHash=gx.fn.getControlValue("PASSWORDHASH") ;
      this.A359UserID=gx.fn.getControlValue("USERID") ;
      this.A416DisplayName=gx.fn.getControlValue("DISPLAYNAME") ;
      this.AV32WWPContext=gx.fn.getControlValue("vWWPCONTEXT") ;
      this.AV36tDisplayName=gx.fn.getControlValue("vTDISPLAYNAME") ;
      this.AV29tUserID=gx.fn.getControlValue("vTUSERID") ;
      this.AV18tClientAddress=gx.fn.getControlValue("vTCLIENTADDRESS") ;
      this.AV12returnurl=gx.fn.getControlValue("vRETURNURL") ;
   };
   this.Validv_Secusername=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vSECUSERNAME");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e12852_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14852_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,28,29,32,33,34,35,36,37];
   this.GXLastCtrlId =37;
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
   GXValidFnc[12]={ id: 12, fld:"LOGOLOGIN",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"TABLELOGIN",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"SIGNIN", format:0,grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Secusername,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERNAME",gxz:"ZV15SecUserName",gxold:"OV15SecUserName",gxvar:"AV15SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15SecUserName=Value},v2c:function(){gx.fn.setControlValue("vSECUSERNAME",gx.O.AV15SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15SecUserName=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERPASSWORD",gxz:"ZV16SecUserPassword",gxold:"OV16SecUserPassword",gxvar:"AV16SecUserPassword",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16SecUserPassword=Value},v2c:function(){gx.fn.setControlValue("vSECUSERPASSWORD",gx.O.AV16SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16SecUserPassword=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[32]={ id: 32, fld:"BTNENTER",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"TABLELOGINERROR",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   this.AV15SecUserName = "" ;
   this.ZV15SecUserName = "" ;
   this.OV15SecUserName = "" ;
   this.AV16SecUserPassword = "" ;
   this.ZV16SecUserPassword = "" ;
   this.OV16SecUserPassword = "" ;
   this.AV15SecUserName = "" ;
   this.AV16SecUserPassword = "" ;
   this.AV12returnurl = "" ;
   this.A364Account = "" ;
   this.A418PasswordHash = "" ;
   this.A359UserID = '00000000-0000-0000-0000-000000000000' ;
   this.A416DisplayName = "" ;
   this.AV32WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV36tDisplayName = "" ;
   this.AV29tUserID = '00000000-0000-0000-0000-000000000000' ;
   this.AV18tClientAddress = "" ;
   this.Events = {"e12852_client": ["ENTER", true] ,"e14852_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV12returnurl',fld:'vRETURNURL',pic:'',hsh:true},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[],[{ctrl:'FORM',prop:'Headerrawhtml'},{av:'gx.fn.getCtrlProperty("TABLELOGINERROR","Visible")',ctrl:'TABLELOGINERROR',prop:'Visible'},{av:'gx.fn.getCtrlProperty("LAYOUTMAINTABLE","Class")',ctrl:'LAYOUTMAINTABLE',prop:'Class'},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}]];
   this.EvtParms["ENTER"] = [[{av:'A364Account',fld:'ACCOUNT',pic:''},{av:'AV15SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV16SecUserPassword',fld:'vSECUSERPASSWORD',pic:''},{av:'A418PasswordHash',fld:'PASSWORDHASH',pic:''},{av:'A359UserID',fld:'USERID',pic:''},{av:'A416DisplayName',fld:'DISPLAYNAME',pic:''},{av:'AV32WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV36tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true},{av:'AV12returnurl',fld:'vRETURNURL',pic:'',hsh:true}],[{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV36tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV32WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'gx.fn.getCtrlProperty("TABLELOGINERROR","Visible")',ctrl:'TABLELOGINERROR',prop:'Visible'}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("A364Account", "ACCOUNT", 0, "svchar", 50, 0);
   this.setVCMap("A418PasswordHash", "PASSWORDHASH", 0, "svchar", 50, 0);
   this.setVCMap("A359UserID", "USERID", 0, "guid", 16, 0);
   this.setVCMap("A416DisplayName", "DISPLAYNAME", 0, "svchar", 50, 0);
   this.setVCMap("AV32WWPContext", "vWWPCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("AV36tDisplayName", "vTDISPLAYNAME", 0, "svchar", 50, 0);
   this.setVCMap("AV29tUserID", "vTUSERID", 0, "guid", 16, 0);
   this.setVCMap("AV18tClientAddress", "vTCLIENTADDRESS", 0, "svchar", 1024, 0);
   this.setVCMap("AV12returnurl", "vRETURNURL", 0, "svchar", 500, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secloginback);
