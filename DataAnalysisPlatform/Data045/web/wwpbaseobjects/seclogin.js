/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:9:22.40
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.seclogin', false, function () {
   this.ServerClass =  "wwpbaseobjects.seclogin" ;
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
      this.A417UserType=gx.fn.getIntegerValue("USERTYPE",',') ;
      this.A418PasswordHash=gx.fn.getControlValue("PASSWORDHASH") ;
      this.A359UserID=gx.fn.getControlValue("USERID") ;
      this.A416DisplayName=gx.fn.getControlValue("DISPLAYNAME") ;
      this.AV12WWPContext=gx.fn.getControlValue("vWWPCONTEXT") ;
      this.AV42tDisplayName=gx.fn.getControlValue("vTDISPLAYNAME") ;
      this.AV29tUserID=gx.fn.getControlValue("vTUSERID") ;
      this.AV38tUserType=gx.fn.getControlValue("vTUSERTYPE") ;
      this.AV18tClientAddress=gx.fn.getControlValue("vTCLIENTADDRESS") ;
      this.AV21returnurl=gx.fn.getControlValue("vRETURNURL") ;
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
   this.e120t2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140t2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,28,29,30,31,34,37,39,40,41,42,43,44,45,46,49,52,54,55,56,57,58,59,60,61,64,65,66,67,68,69];
   this.GXLastCtrlId =69;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"DESC", format:0,grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"DESCSON", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLELOGINCONTENT",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLELOGIN",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTCNLOGIN", format:0,grid:0};
   GXValidFnc[28]={ id: 28, fld:"LOGIN_TITLE", format:0,grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLE3",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TABLEMERGEDDAS_LOGINUSER",grid:0};
   GXValidFnc[37]={ id: 37, fld:"DAS_LOGINUSER",grid:0};
   GXValidFnc[39]={ id: 39, fld:"UNNAMEDTABLESECUSERNAME",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"TEXTBLOCKSECUSERNAME", format:0,grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Secusername,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERNAME",gxz:"ZV7SecUserName",gxold:"OV7SecUserName",gxvar:"AV7SecUserName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV7SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV7SecUserName=Value},v2c:function(){gx.fn.setControlValue("vSECUSERNAME",gx.O.AV7SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV7SecUserName=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERNAME")},nac:gx.falseFn};
   GXValidFnc[49]={ id: 49, fld:"TABLEMERGEDDAS_LOGINPASSWORD",grid:0};
   GXValidFnc[52]={ id: 52, fld:"DAS_LOGINPASSWORD",grid:0};
   GXValidFnc[54]={ id: 54, fld:"UNNAMEDTABLESECUSERPASSWORD",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"TEXTBLOCKSECUSERPASSWORD", format:0,grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSECUSERPASSWORD",gxz:"ZV8SecUserPassword",gxold:"OV8SecUserPassword",gxvar:"AV8SecUserPassword",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV8SecUserPassword=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV8SecUserPassword=Value},v2c:function(){gx.fn.setControlValue("vSECUSERPASSWORD",gx.O.AV8SecUserPassword,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV8SecUserPassword=this.val()},val:function(){return gx.fn.getControlValue("vSECUSERPASSWORD")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"BTNENTER",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"TABLELOGINERROR",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   this.AV7SecUserName = "" ;
   this.ZV7SecUserName = "" ;
   this.OV7SecUserName = "" ;
   this.AV8SecUserPassword = "" ;
   this.ZV8SecUserPassword = "" ;
   this.OV8SecUserPassword = "" ;
   this.AV7SecUserName = "" ;
   this.AV8SecUserPassword = "" ;
   this.AV21returnurl = "" ;
   this.A417UserType = 0 ;
   this.A364Account = "" ;
   this.A418PasswordHash = "" ;
   this.A359UserID = '00000000-0000-0000-0000-000000000000' ;
   this.A416DisplayName = "" ;
   this.AV12WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV42tDisplayName = "" ;
   this.AV29tUserID = '00000000-0000-0000-0000-000000000000' ;
   this.AV38tUserType = "" ;
   this.AV18tClientAddress = "" ;
   this.Events = {"e120t2_client": ["ENTER", true] ,"e140t2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV21returnurl',fld:'vRETURNURL',pic:'',hsh:true},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[],[{ctrl:'FORM',prop:'Headerrawhtml'},{av:'gx.fn.getCtrlProperty("TABLELOGINERROR","Visible")',ctrl:'TABLELOGINERROR',prop:'Visible'},{av:'gx.fn.getCtrlProperty("LAYOUTMAINTABLE","Class")',ctrl:'LAYOUTMAINTABLE',prop:'Class'},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}]];
   this.EvtParms["ENTER"] = [[{av:'A364Account',fld:'ACCOUNT',pic:''},{av:'AV7SecUserName',fld:'vSECUSERNAME',pic:''},{av:'A417UserType',fld:'USERTYPE',pic:'ZZZZZZZZ9'},{av:'AV8SecUserPassword',fld:'vSECUSERPASSWORD',pic:''},{av:'A418PasswordHash',fld:'PASSWORDHASH',pic:''},{av:'A359UserID',fld:'USERID',pic:''},{av:'A416DisplayName',fld:'DISPLAYNAME',pic:''},{av:'AV12WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV42tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV38tUserType',fld:'vTUSERTYPE',pic:''},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true},{av:'AV21returnurl',fld:'vRETURNURL',pic:'',hsh:true}],[{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV42tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV38tUserType',fld:'vTUSERTYPE',pic:''},{av:'AV12WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'gx.fn.getCtrlProperty("TABLELOGINERROR","Visible")',ctrl:'TABLELOGINERROR',prop:'Visible'}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("A364Account", "ACCOUNT", 0, "svchar", 50, 0);
   this.setVCMap("A417UserType", "USERTYPE", 0, "int", 9, 0);
   this.setVCMap("A418PasswordHash", "PASSWORDHASH", 0, "svchar", 50, 0);
   this.setVCMap("A359UserID", "USERID", 0, "guid", 16, 0);
   this.setVCMap("A416DisplayName", "DISPLAYNAME", 0, "svchar", 50, 0);
   this.setVCMap("AV12WWPContext", "vWWPCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("AV42tDisplayName", "vTDISPLAYNAME", 0, "svchar", 50, 0);
   this.setVCMap("AV29tUserID", "vTUSERID", 0, "guid", 16, 0);
   this.setVCMap("AV38tUserType", "vTUSERTYPE", 0, "svchar", 40, 0);
   this.setVCMap("AV18tClientAddress", "vTCLIENTADDRESS", 0, "svchar", 1024, 0);
   this.setVCMap("AV21returnurl", "vRETURNURL", 0, "svchar", 500, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.seclogin);
