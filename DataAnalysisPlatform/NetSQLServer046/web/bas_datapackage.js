/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:58:11.75
*/
gx.evt.autoSkip=!1;gx.define("bas_datapackage",!1,function(){this.ServerClass="bas_datapackage";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Datapackage=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Datapackage",["gx.O.A366DataPackage"],["Gx_mode","Z366DataPackage",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e111i55_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e121i55_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37];this.GXLastCtrlId=37;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"TABLEMAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TITLE",format:0,grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"BTN_FIRST",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"BTN_PREVIOUS",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"BTN_NEXT",grid:0};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"BTN_LAST",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"BTN_SELECT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"",grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Datapackage,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"DATAPACKAGE",gxz:"Z366DataPackage",gxold:"O366DataPackage",gxvar:"A366DataPackage",ucs:[],op:[],ip:[28],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A366DataPackage=n)},v2z:function(n){n!==undefined&&(gx.O.Z366DataPackage=n)},v2c:function(){gx.fn.setControlValue("DATAPACKAGE",gx.O.A366DataPackage,0)},c2v:function(){this.val()!==undefined&&(gx.O.A366DataPackage=this.val())},val:function(){return gx.fn.getControlValue("DATAPACKAGE")},nac:gx.falseFn};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"BTN_ENTER",grid:0};n[34]={id:34,fld:"",grid:0};n[35]={id:35,fld:"BTN_CANCEL",grid:0};n[36]={id:36,fld:"",grid:0};n[37]={id:37,fld:"BTN_DELETE",grid:0};this.A366DataPackage="";this.Z366DataPackage="";this.O366DataPackage="";this.A366DataPackage="";this.Events={e111i55_client:["ENTER",!0],e121i55_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char",3,0);this.Initialize()});gx.createParentObj(bas_datapackage)